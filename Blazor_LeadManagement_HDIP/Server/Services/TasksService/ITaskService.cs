namespace Blazor_LeadManagement_HDIP.Server.Services.TasksService
{
    public interface ITaskService
    {
        Task<ResponseMessage<List<LeadTask>>> GetTasksAsync();
        Task<ResponseMessage<List<LeadTask>>> GetTaskByLeadID(int leadid);
    }
}
