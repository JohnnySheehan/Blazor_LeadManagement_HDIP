namespace Blazor_LeadManagement_HDIP.Client.Services.TaskService
{
    public class TaskService : ITaskService
    {
        private readonly HttpClient _http;

        public TaskService(HttpClient http)
        {
            _http = http;
        }
        public List<LeadTask> LeadTasks { get; set; } = new List<LeadTask>();

        public async Task GetLeadTasks()
        {
            var tasksresult = await _http.GetFromJsonAsync<ResponseMessage<List<LeadTask>>>("api/task");
            if (tasksresult != null && tasksresult.Data != null)
                LeadTasks = tasksresult.Data;
        }

       
        

        


    }
}
