using System.Collections.Generic;

namespace IamArpit.Database
{
    public interface IDBAccess<T>
    {
        List<T> Fetch(string query);
        int Save(string query);
    }
}