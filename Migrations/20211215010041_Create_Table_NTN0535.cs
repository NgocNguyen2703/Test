using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class Create_Table_NTN0535 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTN0535s",
                columns: table => new
                {
                    NTNId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTNName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NTNGender = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTN0535s", x => x.NTNId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTN0535s");
        }
    }
}
