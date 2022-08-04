namespace Blazor_LeadManagement_HDIP.Server.Services.LeadService
{
    public class LeadService : ILeadService
    {
        private readonly Data.AppContext _context;

        public LeadService(Data.AppContext context)
        {
            _context = context;
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
