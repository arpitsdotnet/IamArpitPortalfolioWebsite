using IamArpit.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database.Customers
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly IDBAccess<CustomerModel> dBAccess;

        public CustomerRepo(IDBAccess<CustomerModel> dBAccess)
        {
            this.dBAccess = dBAccess;
        }
        public int Activate(int ID, bool IsActive)
        {
            throw new NotImplementedException();
        }

        public int Create(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<CustomerModel> GetAll()
        {
            try
            {
                return dBAccess.Fetch("SELECT * FROM Customers ORDER BY CustomerName DESC");
            }
            catch
            {
                throw;
            }
        }

        public CustomerModel GetByCustomerNumber(string customerNumber)
        {
            throw new NotImplementedException();
        }

        public CustomerModel GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
