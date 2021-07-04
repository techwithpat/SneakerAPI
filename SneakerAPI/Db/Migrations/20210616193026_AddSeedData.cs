using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerAPI.Db.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("4ab05a67-9cbc-44cc-aa7d-72751a7fee12"));

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("c7703c0b-d481-4109-8a7d-63766be5530a"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin_role", "453c781c-9f7f-4a24-b077-e15b2a05f4a6", "admin", "ADMIN" },
                    { "reader_role", "a8e89d41-3d60-497b-aacb-c4792af7b55f", "reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "0c2b67f3-8d42-446d-9d95-822226dc842a", "patrick@fakemail.com", true, false, null, null, "PATRICK", "AQAAAAEAACcQAAAAEI7AVJXbE/K4aKG2mQL3j0xiKZcMWsS9thwbsh7hmdN6OYUen7bI7B/vvMSAYcxi6Q==", null, false, "875e9f7c-adb3-4ed0-ae38-596227573afc", false, "patrick" },
                    { "2", 0, "cc356f1f-2a34-43f1-b19a-227d133b5e8c", "mike@fakemail.Com", true, false, null, null, "MIKE", "AQAAAAEAACcQAAAAEGSwhPJ1h3VYq8kkEpMJOO0LENYXPf9zOiCxkQIKVLboQhaWCNp5O7kswUb7noJk3Q==", null, false, "4ec8f105-c83f-4ff8-acb8-f329dbb477dc", false, "mike" }
                });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[,]
                {
                    { new Guid("d2979f67-44b4-470e-83dc-58fa5821c53c"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3a4d0ea-d25d-437b-aeec-3f638beb9411"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin_role", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "reader_role", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin_role", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "reader_role", "2" });

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("d2979f67-44b4-470e-83dc-58fa5821c53c"));

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("d3a4d0ea-d25d-437b-aeec-3f638beb9411"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "reader_role");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("4ab05a67-9cbc-44cc-aa7d-72751a7fee12"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("c7703c0b-d481-4109-8a7d-63766be5530a"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
