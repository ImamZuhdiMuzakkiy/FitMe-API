using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_role",
                columns: new[] { "RoleId", "description", "name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Admin can control dashboard", "Admin" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Coach can make new program workout", "Coach" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Member can follow programworkout", "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "RoleId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "RoleId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "RoleId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));
        }
    }
}
