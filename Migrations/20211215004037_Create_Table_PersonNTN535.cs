using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class Create_Table_PersonNTN535 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonNTN535s",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PersonName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonNTN535s", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonNTN535s");
        }
    }
}
