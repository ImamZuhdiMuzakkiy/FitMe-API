using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "RoleId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "tbl_role",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "tbl_role",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "tbl_role",
                columns: new[] { "RoleId", "description", "name" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000003"), "Member can follow programworkout", "Member" });
        }
    }
}
