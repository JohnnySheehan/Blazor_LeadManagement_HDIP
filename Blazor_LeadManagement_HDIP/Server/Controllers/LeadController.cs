using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_LeadManagement_HDIP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        
        private readonly ILeadService _leadService;

        public LeadController(ILeadService leadService) //no db context, we are injecting the lead service
        {
            
            _leadService = leadService;
        }
        //thin controllers : passing data from a request (logic is in the services)
        [HttpGet]
        public async Task<ActionResult<ResponseMessage<List<Lead>>>> GetLeads()
        {
            var leadsresult = await _leadService.GetLeadsAsync(); //accessing the lead service to return data
            return Ok(leadsresult);
        }

        [HttpGet]
        [Route("{leadid}")]
        public async Task<ActionResult<ResponseMessage<Lead>>> GetLead(int leadid)
        {
            var leadresult = await _leadService.GetLeadAsync(leadid);
            return Ok(leadresult);
        }
    }
}
