using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_LeadManagement_HDIP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {

        private readonly Data.AppContext _context;
        public LeadController(Data.AppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Lead>>> GetLeads()
        {
            var leads = await _context.MyLeads.ToListAsync();
            return Ok(leads);
        }
    }
}
