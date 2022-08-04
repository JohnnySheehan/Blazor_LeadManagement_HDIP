using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_LeadManagement_HDIP.Shared
{
    public class Lead
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        //public string LeadType { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        //public bool EmailOptIn = true;
        public string CustomerNumber { get; set; } = string.Empty;
        //public bool NumberOptIn = true;
        public string LeadDescription { get; set; } = string.Empty;
        //public string LeadStatus { get; set; } = string.Empty;

    }
}
