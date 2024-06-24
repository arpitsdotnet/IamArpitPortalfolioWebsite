using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database
{
    public interface IBaseRepo<T>
    {
        List<T> GetAll();
        T GetByID(int ID);
        int Create(T model);
        int Update(T model);
        int Activate(int ID, bool IsActive);
        int Delete(int ID);
    }
}
