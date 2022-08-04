using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_LeadManagement_HDIP.Shared
{
    public class ResponseMessage<T>
    {
        public T? Data { get; set; } //will be used in crud with our models
        public bool Success { get; set; } = true; //
        public string Message { get; set; } = string.Empty;
    }
}
