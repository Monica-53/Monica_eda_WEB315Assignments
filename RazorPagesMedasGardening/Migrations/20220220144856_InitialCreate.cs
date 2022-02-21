using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedasGardening.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garden",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    plantingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TypeOfGarden = table.Column<string>(type: "TEXT", nullable: true),
                    PriceOfSeeds = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garden", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garden");
        }
    }
}
