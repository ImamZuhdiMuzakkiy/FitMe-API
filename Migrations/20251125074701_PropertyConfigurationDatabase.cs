using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class PropertyConfigurationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutSessions",
                table: "WorkoutSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutPrograms",
                table: "WorkoutPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramEnrolls",
                table: "ProgramEnrolls");

            migrationBuilder.RenameTable(
                name: "WorkoutSessions",
                newName: "tbl_workout_session");

            migrationBuilder.RenameTable(
                name: "WorkoutPrograms",
                newName: "tbl_workout_program");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbl_user");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "tbl_role");

            migrationBuilder.RenameTable(
                name: "ProgramEnrolls",
                newName: "tbl_program_enroll");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tbl_workout_session",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Instructions",
                table: "tbl_workout_session",
                newName: "instructions");

            migrationBuilder.RenameColumn(
                name: "WorkoutProgramId",
                table: "tbl_workout_session",
                newName: "workout_program_id");

            migrationBuilder.RenameColumn(
                name: "VideoUrl",
                table: "tbl_workout_session",
                newName: "video_url");

            migrationBuilder.RenameColumn(
                name: "DurationMinutes",
                table: "tbl_workout_session",
                newName: "duration_minutes");

            migrationBuilder.RenameColumn(
                name: "WorkoutSessionId",
                table: "tbl_workout_session",
                newName: "workout_session_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tbl_workout_program",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tbl_workout_program",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tbl_workout_program",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tbl_workout_program",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DurationWeeks",
                table: "tbl_workout_program",
                newName: "duration_weeks");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tbl_workout_program",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "WorkoutProgramId",
                table: "tbl_workout_program",
                newName: "workout_program_id");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "tbl_user",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tbl_user",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "tbl_user",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tbl_user",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "tbl_user",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "tbl_user",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tbl_user",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_role",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tbl_role",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "WorkoutProgramId",
                table: "tbl_program_enroll",
                newName: "workout_program_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tbl_program_enroll",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "tbl_program_enroll",
                newName: "start_date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "tbl_program_enroll",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "ProgramEnrollId",
                table: "tbl_program_enroll",
                newName: "program_enroll_id");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "tbl_workout_session",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "instructions",
                table: "tbl_workout_session",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "video_url",
                table: "tbl_workout_session",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "duration_minutes",
                table: "tbl_workout_session",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "tbl_workout_program",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "tbl_workout_program",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "duration_weeks",
                table: "tbl_workout_program",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "difficulty",
                table: "tbl_workout_program",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tbl_workout_program",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "tbl_user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tbl_user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "tbl_user",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tbl_role",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "tbl_role",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tbl_program_enroll",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_workout_session",
                table: "tbl_workout_session",
                column: "workout_session_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_workout_program",
                table: "tbl_workout_program",
                column: "workout_program_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_role",
                table: "tbl_role",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_program_enroll",
                table: "tbl_program_enroll",
                column: "program_enroll_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_workout_session",
                table: "tbl_workout_session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_workout_program",
                table: "tbl_workout_program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_role",
                table: "tbl_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_program_enroll",
                table: "tbl_program_enroll");

            migrationBuilder.DropColumn(
                name: "difficulty",
                table: "tbl_workout_program");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_workout_program");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "tbl_user");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_program_enroll");

            migrationBuilder.RenameTable(
                name: "tbl_workout_session",
                newName: "WorkoutSessions");

            migrationBuilder.RenameTable(
                name: "tbl_workout_program",
                newName: "WorkoutPrograms");

            migrationBuilder.RenameTable(
                name: "tbl_user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tbl_role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "tbl_program_enroll",
                newName: "ProgramEnrolls");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "WorkoutSessions",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "instructions",
                table: "WorkoutSessions",
                newName: "Instructions");

            migrationBuilder.RenameColumn(
                name: "workout_program_id",
                table: "WorkoutSessions",
                newName: "WorkoutProgramId");

            migrationBuilder.RenameColumn(
                name: "video_url",
                table: "WorkoutSessions",
                newName: "VideoUrl");

            migrationBuilder.RenameColumn(
                name: "duration_minutes",
                table: "WorkoutSessions",
                newName: "DurationMinutes");

            migrationBuilder.RenameColumn(
                name: "workout_session_id",
                table: "WorkoutSessions",
                newName: "WorkoutSessionId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "WorkoutPrograms",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "WorkoutPrograms",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "WorkoutPrograms",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "WorkoutPrograms",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "duration_weeks",
                table: "WorkoutPrograms",
                newName: "DurationWeeks");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "WorkoutPrograms",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "workout_program_id",
                table: "WorkoutPrograms",
                newName: "WorkoutProgramId");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "Users",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "Users",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Users",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Roles",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "workout_program_id",
                table: "ProgramEnrolls",
                newName: "WorkoutProgramId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "ProgramEnrolls",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "ProgramEnrolls",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "ProgramEnrolls",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "program_enroll_id",
                table: "ProgramEnrolls",
                newName: "ProgramEnrollId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "WorkoutSessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Instructions",
                table: "WorkoutSessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "WorkoutSessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "DurationMinutes",
                table: "WorkoutSessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "WorkoutPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkoutPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "DurationWeeks",
                table: "WorkoutPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutSessions",
                table: "WorkoutSessions",
                column: "WorkoutSessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutPrograms",
                table: "WorkoutPrograms",
                column: "WorkoutProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramEnrolls",
                table: "ProgramEnrolls",
                column: "ProgramEnrollId");
        }
    }
}
