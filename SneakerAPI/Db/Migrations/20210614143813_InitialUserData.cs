using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerAPI.Db.Migrations
{
    public partial class InitialUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("506f5ebb-3704-46ac-a60e-de158f326657"));

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("c2f19056-d96a-496d-a7bd-a4bfc979d8e1"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin_role", "5439e5ab-23c8-4bea-a500-781d9278f4b2", "admin", "ADMIN" },
                    { "reader_role", "92aa41b8-42aa-43a8-a4f0-f60b723c1945", "reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "029976c6-5457-488c-ad46-675e626ef00d", 0, "8d2cdf48-ea98-4aab-8f42-b2ddafd47a4e", "admin@gmail.com", true, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGCCZ/XH4RgobZKC0O0mZd44T1SjyHdWPrkNtuUGt2OIfTSnsmjq/AqxW6pMSeSpbg==", null, false, "5ad0dc33-9fbd-4399-a4de-ad931d6a1b8a", false, "admin@gmail.com" },
                    { "0cb46b1c-3452-4194-ae9d-1b086c135017", 0, "82dcf9c4-0ca3-4e08-b831-43075bbf8da3", null, true, false, null, null, "READER@GMAIL.COM", "AQAAAAEAACcQAAAAEErH+miEGhdfWzo96mjrOZyGs0DPric2ySA46BbuHPhUzidoMvEJqLUD8nl91HBwdA==", null, false, "a27b4a90-212f-403e-a63c-bb913bd6a904", false, "reader@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[,]
                {
                    { new Guid("0e3e7912-46c7-43f0-b2bd-952869c1b61e"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45556667-fbb5-49c6-b50a-9db11629411f"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin_role", "029976c6-5457-488c-ad46-675e626ef00d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "reader_role", "0cb46b1c-3452-4194-ae9d-1b086c135017" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin_role", "029976c6-5457-488c-ad46-675e626ef00d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "reader_role", "0cb46b1c-3452-4194-ae9d-1b086c135017" });

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("0e3e7912-46c7-43f0-b2bd-952869c1b61e"));

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: new Guid("45556667-fbb5-49c6-b50a-9db11629411f"));

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
                keyValue: "029976c6-5457-488c-ad46-675e626ef00d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cb46b1c-3452-4194-ae9d-1b086c135017");

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("c2f19056-d96a-496d-a7bd-a4bfc979d8e1"), "Nike", "White", "Perhaps the most iconic Nike sneaker of all-time.", "Air Force 1", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "Brand", "ColorWay", "Description", "Name", "ReleaseYear" },
                values: new object[] { new Guid("506f5ebb-3704-46ac-a60e-de158f326657"), "Adidas ", "White", "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet.", "Stan Smith", new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
