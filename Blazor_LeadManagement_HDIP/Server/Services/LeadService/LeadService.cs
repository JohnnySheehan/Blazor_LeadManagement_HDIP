namespace Blazor_LeadManagement_HDIP.Server.Services.LeadService
{
    public class LeadService : ILeadService
    {
        private readonly Data.AppContext _context;

        public LeadService(Data.AppContext context)
        {
            _context = context;
        }

        //returning single lead associated with ID
        public async Task<ResponseMessage<Lead>> GetLeadAsync(int leadid)
        {
            var response = new ResponseMessage<Lead>();
            var singlelead = await _context.MyLeads.FindAsync(leadid);
            if (singlelead == null)
            {
                response.Success = false;
                response.Message = "No Lead Found...";
            }
            else
            {
                response.Data = singlelead;
            }
            return response;
        }

        public async Task<ResponseMessage<List<Lead>>> GetLeadsAsync()
        {
            var response = new ResponseMessage<List<Lead>>
            {
                Data = await _context.MyLeads.ToListAsync()
            };
            return response;
        }
    }
}
