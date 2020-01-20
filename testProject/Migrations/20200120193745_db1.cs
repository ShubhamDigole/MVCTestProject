using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Countries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Countries",
                newName: "Name");
        }
    }
}
