using IamArpit.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database.Customers
{
    public interface ICustomerRepo : IBaseRepo<CustomerModel>
    {
        CustomerModel GetByCustomerNumber(string customerNumber);
    }
}
