using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeederUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("ae702b8d-f3ca-4e71-abb9-da12599b246f"), 25, new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9864), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9882), 65.0 },
                    { new Guid("b8f21e11-4c43-42c2-9af7-1759671ce6cf"), 30, new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9894), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9896), 65.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("ae702b8d-f3ca-4e71-abb9-da12599b246f"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("b8f21e11-4c43-42c2-9af7-1759671ce6cf"));
        }
    }
}
