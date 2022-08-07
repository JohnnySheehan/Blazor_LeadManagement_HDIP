namespace Blazor_LeadManagement_HDIP.Server.Services.LeadService
{
    public interface ILeadService
    {
        Task<ResponseMessage<List<Lead>>> GetLeadsAsync();
        Task<ResponseMessage<Lead>> GetLeadAsync(int leadid);
    }
}
