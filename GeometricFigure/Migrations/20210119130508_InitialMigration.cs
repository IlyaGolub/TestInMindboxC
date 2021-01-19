using Microsoft.EntityFrameworkCore.Migrations;

namespace GeometricFigure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Figure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SideA = table.Column<double>(type: "REAL", nullable: true),
                    SideB = table.Column<double>(type: "REAL", nullable: true),
                    SideС = table.Column<double>(type: "REAL", nullable: true),
                    Radius = table.Column<double>(type: "REAL", nullable: true),
                    Square = table.Column<double>(type: "REAL", nullable: true),
                    Perimeter = table.Column<double>(type: "REAL", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Figure", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Figure");
        }
    }
}
