using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayeredArchitecture.Data.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SurName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 1, "Adnan", "Cin" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 2, "Mehmet", "Can" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
