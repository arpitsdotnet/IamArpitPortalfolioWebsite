using System.Data.OleDb;

namespace IamArpit.Database
{
    public class OleDBConnectionManager : IConnectionManager
    {
        private string _connectionString;

        public OleDBConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(_connectionString);
        }
    }
}
