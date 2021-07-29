using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    studentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subject1 = table.Column<int>(type: "int", nullable: false),
                    subject2 = table.Column<int>(type: "int", nullable: false),
                    subject3 = table.Column<int>(type: "int", nullable: false),
                    subject4 = table.Column<int>(type: "int", nullable: false),
                    subject5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.studentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
