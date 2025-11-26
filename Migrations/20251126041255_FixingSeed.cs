using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class FixingSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("ae702b8d-f3ca-4e71-abb9-da12599b246f"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("b8f21e11-4c43-42c2-9af7-1759671ce6cf"));

            migrationBuilder.InsertData(
                table: "tbl_role",
                columns: new[] { "RoleId", "description", "name" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000003"), "Member can follow programworkout", "Member" });

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("71226f4b-b3b5-44df-9e60-37aa782dfa6c"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8868), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8869), 65.0 },
                    { new Guid("dc876428-245d-4ad6-ae11-ae536d81dd11"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8873), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8873), 65.0 },
                    { new Guid("e81e5d36-9e96-4b32-94ae-b3e46f64c1d8"), 25, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8828), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8842), 65.0 },
                    { new Guid("3cf441d2-daa3-4eb1-9b87-6f8ddf58d198"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8876), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8877), 65.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("3cf441d2-daa3-4eb1-9b87-6f8ddf58d198"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("71226f4b-b3b5-44df-9e60-37aa782dfa6c"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("dc876428-245d-4ad6-ae11-ae536d81dd11"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("e81e5d36-9e96-4b32-94ae-b3e46f64c1d8"));

            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "RoleId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("ae702b8d-f3ca-4e71-abb9-da12599b246f"), 25, new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9864), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9882), 65.0 },
                    { new Guid("b8f21e11-4c43-42c2-9af7-1759671ce6cf"), 30, new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9894), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 4, 18, 724, DateTimeKind.Local).AddTicks(9896), 65.0 }
                });
        }
    }
}
