using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("23a99bfb-75e9-45e1-b61a-7f2a6060c612"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("3508a3cd-3e2f-4f55-9579-1e71461e551b"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("d4b8649a-bdc0-4111-af61-442b3daf6ba7"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("f5671bf8-63a8-47ef-b29c-3f763d379a8d"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("13df2494-b8ca-4fca-ba59-b77062f45d80"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("5f73e96c-df07-4402-980e-6b2f3b14eb12"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("71fbadd8-23d4-4c17-ab97-1a0e5bc718f8"));

            migrationBuilder.UpdateData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12300000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9385), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12345000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9394), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), 25, new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9343), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9358), 65.0 },
                    { new Guid("20000000-0000-0000-0000-000000000002"), 30, new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9372), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9373), 65.0 },
                    { new Guid("20000000-0000-0000-0000-000000000003"), 30, new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9377), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9378), 65.0 },
                    { new Guid("20000000-0000-0000-0000-000000000004"), 30, new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9381), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 30, 11, 46, 8, 424, DateTimeKind.Local).AddTicks(9382), 65.0 }
                });

            migrationBuilder.UpdateData(
                table: "tbl_workout_program",
                keyColumn: "workout_program_id",
                keyValue: new Guid("12300000-1234-0000-0000-000000000003"),
                columns: new[] { "created_at", "duration_weeks", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 11, 46, 8, 428, DateTimeKind.Local).AddTicks(9128), 1, new DateTime(2025, 11, 30, 11, 46, 8, 428, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.InsertData(
                table: "tbl_workout_program",
                columns: new[] { "workout_program_id", "created_at", "description", "difficulty", "duration_weeks", "status", "title", "updated_at", "user_id" },
                values: new object[] { new Guid("12345000-1234-0000-0000-000000000003"), new DateTime(2025, 11, 30, 11, 46, 8, 428, DateTimeKind.Local).AddTicks(9148), "Perlu mengikuti step by step", "Intermediate", 1, "Pending", "LegDay", new DateTime(2025, 11, 30, 11, 46, 8, 428, DateTimeKind.Local).AddTicks(9149), new Guid("12300000-0000-0000-0000-000000000003") });

            migrationBuilder.InsertData(
                table: "tbl_workout_session",
                columns: new[] { "workout_session_id", "duration_minutes", "instructions", "title", "video_url", "workout_program_id" },
                values: new object[,]
                {
                    { new Guid("267c20e5-e1de-48a9-888b-a946e969bad9"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bla bla bla", "Step 01 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") },
                    { new Guid("caafa49e-1e8a-4e27-bb9b-927b6006fc16"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bobobo", "Step 01 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") },
                    { new Guid("e74f8687-e1da-4808-93ef-c794bad5e278"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bebebe", "Step 02 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") },
                    { new Guid("c8cdc202-c9e6-43d0-8dbc-891595857455"), "20:00", "Dalam pembelajaran ini..", "Step 01 Leg", "https/test", new Guid("12345000-1234-0000-0000-000000000003") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("267c20e5-e1de-48a9-888b-a946e969bad9"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("c8cdc202-c9e6-43d0-8dbc-891595857455"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("caafa49e-1e8a-4e27-bb9b-927b6006fc16"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_session",
                keyColumn: "workout_session_id",
                keyValue: new Guid("e74f8687-e1da-4808-93ef-c794bad5e278"));

            migrationBuilder.DeleteData(
                table: "tbl_workout_program",
                keyColumn: "workout_program_id",
                keyValue: new Guid("12345000-1234-0000-0000-000000000003"));

            migrationBuilder.UpdateData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12300000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6612), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12345000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6620), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("23a99bfb-75e9-45e1-b61a-7f2a6060c612"), 25, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6504), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6517), 65.0 },
                    { new Guid("3508a3cd-3e2f-4f55-9579-1e71461e551b"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6601), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6602), 65.0 },
                    { new Guid("d4b8649a-bdc0-4111-af61-442b3daf6ba7"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6526), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6527), 65.0 },
                    { new Guid("f5671bf8-63a8-47ef-b29c-3f763d379a8d"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6607), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6608), 65.0 }
                });

            migrationBuilder.UpdateData(
                table: "tbl_workout_program",
                keyColumn: "workout_program_id",
                keyValue: new Guid("12300000-1234-0000-0000-000000000003"),
                columns: new[] { "created_at", "duration_weeks", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 11, 9, 47, 556, DateTimeKind.Local).AddTicks(6124), 0, new DateTime(2025, 11, 28, 11, 9, 47, 556, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.InsertData(
                table: "tbl_workout_session",
                columns: new[] { "workout_session_id", "duration_minutes", "instructions", "title", "video_url", "workout_program_id" },
                values: new object[,]
                {
                    { new Guid("13df2494-b8ca-4fca-ba59-b77062f45d80"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bla bla bla", "Step 01 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") },
                    { new Guid("5f73e96c-df07-4402-980e-6b2f3b14eb12"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bobobo", "Step 01 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") },
                    { new Guid("71fbadd8-23d4-4c17-ab97-1a0e5bc718f8"), "20:00", "Dalam pembelajaran ini yang harus dipersiapkan adalah bebebe", "Step 02 Bulk", "https/test", new Guid("12300000-1234-0000-0000-000000000003") }
                });
        }
    }
}
