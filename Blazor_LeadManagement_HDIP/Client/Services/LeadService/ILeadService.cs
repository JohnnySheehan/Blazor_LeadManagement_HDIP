namespace Blazor_LeadManagement_HDIP.Client.Services.LeadService
{
    public interface ILeadService
    {
        List<Lead> Leads { get; set; }
        Task GetLeads();
    }
}
