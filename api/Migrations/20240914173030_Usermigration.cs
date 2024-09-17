using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Usermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollageSemesterSubject_College_CollegesId",
                table: "CollageSemesterSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_CollageSemesterSubject_semester_Semestersid",
                table: "CollageSemesterSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollageSemesterSubject",
                table: "CollageSemesterSubject");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69df1e83-82d1-4c95-b1a0-4ff2ca8aeffb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae73b33-fdd5-40bd-af48-75f481a013cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2d06d8f-fded-4dce-924d-19d5f773717f");

            migrationBuilder.RenameTable(
                name: "CollageSemesterSubject",
                newName: "CollegeSemester");

            migrationBuilder.RenameIndex(
                name: "IX_CollageSemesterSubject_Semestersid",
                table: "CollegeSemester",
                newName: "IX_CollegeSemester_Semestersid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollegeSemester",
                table: "CollegeSemester",
                columns: new[] { "CollegesId", "Semestersid" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12bb7195-350c-4907-a43d-8004753e0c91", null, "Admin", "ADMIN" },
                    { "29c36d48-5efe-4ff5-9bfb-5c88a16ff54b", null, "CollegeAdmin", "COLLEGEADMIN" },
                    { "e73f9d58-4b64-4454-8ccd-a8a7898d35f8", null, "Lecturer", "LECTURER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeSemester_College_CollegesId",
                table: "CollegeSemester",
                column: "CollegesId",
                principalTable: "College",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeSemester_semester_Semestersid",
                table: "CollegeSemester",
                column: "Semestersid",
                principalTable: "semester",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeSemester_College_CollegesId",
                table: "CollegeSemester");

            migrationBuilder.DropForeignKey(
                name: "FK_CollegeSemester_semester_Semestersid",
                table: "CollegeSemester");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollegeSemester",
                table: "CollegeSemester");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12bb7195-350c-4907-a43d-8004753e0c91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29c36d48-5efe-4ff5-9bfb-5c88a16ff54b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e73f9d58-4b64-4454-8ccd-a8a7898d35f8");

            migrationBuilder.RenameTable(
                name: "CollegeSemester",
                newName: "CollageSemesterSubject");

            migrationBuilder.RenameIndex(
                name: "IX_CollegeSemester_Semestersid",
                table: "CollageSemesterSubject",
                newName: "IX_CollageSemesterSubject_Semestersid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollageSemesterSubject",
                table: "CollageSemesterSubject",
                columns: new[] { "CollegesId", "Semestersid" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69df1e83-82d1-4c95-b1a0-4ff2ca8aeffb", null, "CollegeAdmin", "COLLEGEADMIN" },
                    { "6ae73b33-fdd5-40bd-af48-75f481a013cd", null, "Lecturer", "LECTURER" },
                    { "b2d06d8f-fded-4dce-924d-19d5f773717f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CollageSemesterSubject_College_CollegesId",
                table: "CollageSemesterSubject",
                column: "CollegesId",
                principalTable: "College",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollageSemesterSubject_semester_Semestersid",
                table: "CollageSemesterSubject",
                column: "Semestersid",
                principalTable: "semester",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
