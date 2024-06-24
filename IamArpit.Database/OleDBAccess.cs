using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database
{
    public sealed class OleDBAccess<T> : MarshalByRefObject, IDBAccess<T>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IamArpitDBAccessConnectionString"].ConnectionString;

        private readonly IConnectionManager connectionManager;

        public OleDBAccess()
        {
            connectionManager = new OleDBConnectionManager(connectionString);
        }


        public List<T> Fetch(string query)
        {
            using (var connection = connectionManager.GetConnection())
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    IDataReader dataReader = command.ExecuteReader();

                    return DataReaderMapToList(dataReader);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int Save(string query)
        {
            using (var connection = connectionManager.GetConnection())
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    var count = (int)command.ExecuteNonQuery();

                    return count;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private List<T> DataReaderMapToList(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
