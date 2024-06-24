using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Services.Models
{
    public class PortfolioModel
    {
        public int ID { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreateDate { get; set; }

        public int CustomerNumber { get; set; }
        public virtual CustomerModel Customer { get; set; }

        public int ProjectCategoryCore { get; set; }
        public virtual ProjectCategoryMasterModel ProjectCategoryMaster { get; set; }

        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string PageUrl { get; set; }

    }
}
