namespace Blazor_LeadManagement_HDIP.Client.Services.TaskService
{
    public interface ITaskService
    {
        List<LeadTask> LeadTasks { get; set; }
        Task GetLeadTasks();

        
    }
}
