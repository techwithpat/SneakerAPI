using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerAPI.Db.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sneakers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sneakers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("c8a7a264-d47f-4ce6-81cc-5671c796e881"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("adbd6c98-5945-4f8b-9b26-ea7332cabc6b"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sneakers");
        }
    }
}
