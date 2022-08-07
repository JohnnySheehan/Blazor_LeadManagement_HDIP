using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_LeadManagement_HDIP.Shared
{
    public class LeadTask
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TaskType { get; set; } = string.Empty;
        public Lead? Lead { get; set; }
        public int LeadId { get; set; }

    }
}
