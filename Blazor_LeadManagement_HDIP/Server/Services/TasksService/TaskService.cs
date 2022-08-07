namespace Blazor_LeadManagement_HDIP.Server.Services.TasksService
{
    public class TaskService : ITaskService
    {
        private readonly Data.AppContext _context;

        public TaskService(Data.AppContext context)
        {
            _context = context;
        }

        public async Task<ResponseMessage<List<LeadTask>>> GetTaskByLeadID(int leadid)
        {
            var response = new ResponseMessage<List<LeadTask>>
            {
                Data = await _context.MyLeadTasks
                    .Where(p => p.LeadId.Equals(leadid)).ToListAsync()
            };

            return response;
        }

       

        public async Task<ResponseMessage<List<LeadTask>>> GetTasksAsync()
        {
            var response = new ResponseMessage<List<LeadTask>>
            {
                Data = await _context.MyLeadTasks.ToListAsync()
            };
            return response;
        }
    }
}
