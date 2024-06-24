using IamArpit.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database.Portfolios
{
    public class PortfolioRepo : IPortfolioRepo
    {
        private readonly IDBAccess<PortfolioModel> dBAccess;

        public PortfolioRepo(IDBAccess<PortfolioModel> dBAccess)
        {
            this.dBAccess = dBAccess;
        }
        public int Activate(int ID, bool IsActive)
        {
            throw new NotImplementedException();
        }

        public int Create(PortfolioModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<PortfolioModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PortfolioModel GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(PortfolioModel model)
        {
            throw new NotImplementedException();
        }
    }
}
