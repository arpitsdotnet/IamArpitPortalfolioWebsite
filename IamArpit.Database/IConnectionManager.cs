using System.Data.OleDb;

namespace IamArpit.Database
{
    public interface IConnectionManager
    {
        OleDbConnection GetConnection();
    }
}