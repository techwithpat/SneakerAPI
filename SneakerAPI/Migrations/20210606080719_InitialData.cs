using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("e27ffb91-7e7f-4e50-aee6-8d68c937ecb4"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("89409cc9-f916-495b-97c0-12921487743e"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("89409cc9-f916-495b-97c0-12921487743e"));

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("e27ffb91-7e7f-4e50-aee6-8d68c937ecb4"));
        }
    }
}
