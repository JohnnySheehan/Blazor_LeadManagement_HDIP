namespace Blazor_LeadManagement_HDIP.Server.Data
{
   public class AppContext : DbContext
    {

        public AppContext(DbContextOptions<Blazor_LeadManagement_HDIP.Server.Data.AppContext> options) : base(options)
        { }


        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Lead>().HasData(
                new Lead
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Sheehan",
                    LeadDescription = "Attended Event: Blal blah",
                    CompanyName = "IBM",
                    CustomerEmail = "j.sheehan@ibm.com",
                    CustomerNumber = "0979282743"
                },
                new Lead
                {
                    ID = 2,
                    FirstName = "Jeff",
                    LastName = "Bezos",
                    LeadDescription = "Attended Event: AWS",
                    CompanyName = "Amazon",
                    CustomerEmail = "j.b@aws.com",
                    CustomerNumber = "097343433"
                },
                new Lead
                {
                    ID = 3,
                    FirstName = "Elon",
                    LastName = "Musk",
                    LeadDescription = "Attended Event: AI and Ethics",
                    CompanyName = "Tesla",
                    CustomerEmail = "elon.m@teslamotors.com",
                    CustomerNumber = "09792832323"
                },
                new Lead
                {
                    ID = 4,
                    FirstName = "Jenny",
                    LastName = "Sheehan",
                    LeadDescription = "Attended Event: Engineering for the future",
                    CompanyName = "HSE",
                    CustomerEmail = "j.sheehan@hse.ie",
                    CustomerNumber = "0979282222"
                }
                );

            modelBuilder.Entity<LeadTask>().HasData(
                new LeadTask
                {
                    Id = 1,
                    Name = "Email Sent",
                    Description = "Email Sent asking for a call time",
                    TaskType = "Email",
                    LeadId = 1
                },
                new LeadTask
                {
                    Id = 2,
                    Name = "Call",
                    Description = "Not interested in our product, just attended event",
                    TaskType = "Call",
                    LeadId = 1
                },
                new LeadTask
                {
                    Id = 3,
                    Name = "LinkedIn Connection Sent",
                    Description = "Connection sent to stay in contact",
                    TaskType = "LinkedIn",
                    LeadId = 1
                },
                new LeadTask
                {
                    Id = 4,
                    Name = "Email Sent",
                    Description = "Email Sent asking for a demo time",
                    TaskType = "Email",
                    LeadId = 2
                },
                new LeadTask
                {
                    Id = 5,
                    Name = "Email Sent",
                    Description = "Email Sent asking what piqued their interest going to the event",
                    TaskType = "Email",
                    LeadId = 3
                }
                ); 
        }
        public DbSet<Lead> MyLeads { get; set; }
        public DbSet<LeadTask> MyLeadTasks { get; set; }
    }

}
