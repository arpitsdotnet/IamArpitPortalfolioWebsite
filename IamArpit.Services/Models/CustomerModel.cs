using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamArpit.Services.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string WebUrl { get; set; }
        public string WebUrl2 { get; set; }
    }
}
