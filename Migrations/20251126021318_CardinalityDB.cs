using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class CardinalityDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Expired",
                table: "tbl_user",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "tbl_user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "Otp",
                table: "tbl_user",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_workout_session_workout_program_id",
                table: "tbl_workout_session",
                column: "workout_program_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_workout_program_user_id",
                table: "tbl_workout_program",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_role_id",
                table: "tbl_user",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_program_enroll_user_id",
                table: "tbl_program_enroll",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_program_enroll_workout_program_id",
                table: "tbl_program_enroll",
                column: "workout_program_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_program_enroll_tbl_user_user_id",
                table: "tbl_program_enroll",
                column: "user_id",
                principalTable: "tbl_user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_program_enroll_tbl_workout_program_workout_program_id",
                table: "tbl_program_enroll",
                column: "workout_program_id",
                principalTable: "tbl_workout_program",
                principalColumn: "workout_program_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_user_tbl_role_role_id",
                table: "tbl_user",
                column: "role_id",
                principalTable: "tbl_role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_workout_program_tbl_user_user_id",
                table: "tbl_workout_program",
                column: "user_id",
                principalTable: "tbl_user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session",
                column: "workout_program_id",
                principalTable: "tbl_workout_program",
                principalColumn: "workout_program_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_program_enroll_tbl_user_user_id",
                table: "tbl_program_enroll");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_program_enroll_tbl_workout_program_workout_program_id",
                table: "tbl_program_enroll");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_user_tbl_role_role_id",
                table: "tbl_user");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_workout_program_tbl_user_user_id",
                table: "tbl_workout_program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session");

            migrationBuilder.DropIndex(
                name: "IX_tbl_workout_session_workout_program_id",
                table: "tbl_workout_session");

            migrationBuilder.DropIndex(
                name: "IX_tbl_workout_program_user_id",
                table: "tbl_workout_program");

            migrationBuilder.DropIndex(
                name: "IX_tbl_user_role_id",
                table: "tbl_user");

            migrationBuilder.DropIndex(
                name: "IX_tbl_program_enroll_user_id",
                table: "tbl_program_enroll");

            migrationBuilder.DropIndex(
                name: "IX_tbl_program_enroll_workout_program_id",
                table: "tbl_program_enroll");

            migrationBuilder.DropColumn(
                name: "Expired",
                table: "tbl_user");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "tbl_user");

            migrationBuilder.DropColumn(
                name: "Otp",
                table: "tbl_user");
        }
    }
}
