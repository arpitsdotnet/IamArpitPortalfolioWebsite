using IamArpit.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Database.ProjectCategoryMasters
{
    public class ProjectCategoryMasterRepo : IProjectCategoryMasterRepo
    {
        private readonly IDBAccess<ProjectCategoryMasterModel> dBAccess;

        public ProjectCategoryMasterRepo(IDBAccess<ProjectCategoryMasterModel> dBAccess)
        {
            this.dBAccess = dBAccess;
        }
        public int Activate(int ID, bool IsActive)
        {
            throw new NotImplementedException();
        }

        public int Create(ProjectCategoryMasterModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<ProjectCategoryMasterModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProjectCategoryMasterModel GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(ProjectCategoryMasterModel model)
        {
            throw new NotImplementedException();
        }
    }
}
