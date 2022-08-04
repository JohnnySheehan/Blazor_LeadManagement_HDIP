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
        }
        public DbSet<Lead> MyLeads { get; set; }
    }

}
