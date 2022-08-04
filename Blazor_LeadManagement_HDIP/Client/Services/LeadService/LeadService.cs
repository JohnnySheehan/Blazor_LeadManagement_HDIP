namespace Blazor_LeadManagement_HDIP.Client.Services.LeadService
{
    public class LeadService : ILeadService
    {
        private readonly HttpClient _http;

        //define methods and lead lists + we need to store the lead list in the blazor components (several component can access the one service)

        public LeadService(HttpClient http)
        {
            _http = http;
        }

        public List<Lead> Leads { get; set; } = new List<Lead>();

        public async Task GetLeads()
        {
            var leadresult = await _http.GetFromJsonAsync<ResponseMessage<List<Lead>>>("api/lead");
            if( leadresult != null && leadresult.Data != null)
                Leads = leadresult.Data;
        }

    }
}
