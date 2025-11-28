using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class SeederWorkoutPS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("11263469-1d43-4b9c-9e5b-89492c9560e3"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("55b6322f-7068-4cb0-a599-4ddeb95df7dc"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("949561eb-b7cd-4244-85c3-6c9c127198cd"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("a99b02a2-cc2b-4328-8d2d-85fb0c2df930"));

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("12300000-0000-0000-0000-000000000003"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6612), "coach3@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6613), 65.0 },
                    { new Guid("12345000-0000-0000-0000-000000000003"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6620), "coach4@gmail.com", null, "Female", 175.0, false, null, "1234", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6621), 65.0 },
                    { new Guid("23a99bfb-75e9-45e1-b61a-7f2a6060c612"), 25, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6504), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6517), 65.0 },
                    { new Guid("3508a3cd-3e2f-4f55-9579-1e71461e551b"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6601), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6602), 65.0 },
                    { new Guid("d4b8649a-bdc0-4111-af61-442b3daf6ba7"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6526), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6527), 65.0 },
                    { new Guid("f5671bf8-63a8-47ef-b29c-3f763d379a8d"), 30, new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6607), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 28, 11, 9, 47, 555, DateTimeKind.Local).AddTicks(6608), 65.0 }
                });

            migrationBuilder.InsertData(
                table: "tbl_workout_program",
                columns: new[] { "workout_program_id", "created_at", "description", "difficulty", "duration_weeks", "status", "title", "updated_at", "user_id" },
                values: new object[] { new Guid("12300000-1234-0000-0000-000000000003"), new DateTime(2025, 11, 28, 11, 9, 47, 556, DateTimeKind.Local).AddTicks(6124), "Perlu mengikuti step by step", "Intermediate", 0, "Active", "Bulking", new DateTime(2025, 11, 28, 11, 9, 47, 556, DateTimeKind.Local).AddTicks(6144), new Guid("12300000-0000-0000-0000-000000000003") });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12345000-0000-0000-0000-000000000003"));

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

            migrationBuilder.DeleteData(
                table: "tbl_workout_program",
                keyColumn: "workout_program_id",
                keyValue: new Guid("12300000-1234-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("12300000-0000-0000-0000-000000000003"));

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("11263469-1d43-4b9c-9e5b-89492c9560e3"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3560), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3561), 65.0 },
                    { new Guid("55b6322f-7068-4cb0-a599-4ddeb95df7dc"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3552), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3553), 65.0 },
                    { new Guid("949561eb-b7cd-4244-85c3-6c9c127198cd"), 25, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3503), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3520), 65.0 },
                    { new Guid("a99b02a2-cc2b-4328-8d2d-85fb0c2df930"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3527), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3528), 65.0 }
                });
        }
    }
}
