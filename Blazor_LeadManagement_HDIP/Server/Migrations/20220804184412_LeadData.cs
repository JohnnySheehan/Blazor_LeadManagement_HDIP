using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_LeadManagement_HDIP.Server.Migrations
{
    public partial class LeadData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MyLeads",
                columns: new[] { "ID", "CompanyName", "CustomerEmail", "CustomerNumber", "FirstName", "LastName", "LeadDescription" },
                values: new object[,]
                {
                    { 1, "IBM", "j.sheehan@ibm.com", "0979282743", "John", "Sheehan", "Attended Event: Blal blah" },
                    { 2, "Amazon", "j.b@aws.com", "097343433", "Jeff", "Bezos", "Attended Event: AWS" },
                    { 3, "Tesla", "elon.m@teslamotors.com", "09792832323", "Elon", "Musk", "Attended Event: AI and Ethics" },
                    { 4, "HSE", "j.sheehan@hse.ie", "0979282222", "Jenny", "Sheehan", "Attended Event: Engineering for the future" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyLeads",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MyLeads",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MyLeads",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MyLeads",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
