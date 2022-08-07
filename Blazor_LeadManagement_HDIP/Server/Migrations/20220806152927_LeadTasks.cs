using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_LeadManagement_HDIP.Server.Migrations
{
    public partial class LeadTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyLeadTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyLeadTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyLeadTasks_MyLeads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "MyLeads",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MyLeadTasks",
                columns: new[] { "Id", "Description", "LeadId", "Name", "TaskType" },
                values: new object[,]
                {
                    { 1, "Email Sent asking for a call time", 1, "Email Sent", "Email" },
                    { 2, "Not interested in our product, just attended event", 1, "Call", "Call" },
                    { 3, "Connection sent to stay in contact", 1, "LinkedIn Connection Sent", "LinkedIn" },
                    { 4, "Email Sent asking for a demo time", 2, "Email Sent", "Email" },
                    { 5, "Email Sent asking what piqued their interest going to the event", 3, "Email Sent", "Email" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyLeadTasks_LeadId",
                table: "MyLeadTasks",
                column: "LeadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyLeadTasks");
        }
    }
}
