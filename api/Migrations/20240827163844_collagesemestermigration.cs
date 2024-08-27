using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class collagesemestermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subject_College_CollegeId",
                table: "subject");

            migrationBuilder.DropIndex(
                name: "IX_subject_CollegeId",
                table: "subject");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e95baf2-6e14-4742-a56a-c3c67b951975");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "534ad906-e132-44e2-87ce-2f9e9eea4353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de7c729a-f034-408f-85b0-4dd40a08d53a");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "subject");

            migrationBuilder.CreateTable(
                name: "CollageSemesterSubject",
                columns: table => new
                {
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    Semestersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollageSemesterSubject", x => new { x.CollegesId, x.Semestersid });
                    table.ForeignKey(
                        name: "FK_CollageSemesterSubject_College_CollegesId",
                        column: x => x.CollegesId,
                        principalTable: "College",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollageSemesterSubject_semester_Semestersid",
                        column: x => x.Semestersid,
                        principalTable: "semester",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeSubject",
                columns: table => new
                {
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeSubject", x => new { x.CollegesId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_CollegeSubject_College_CollegesId",
                        column: x => x.CollegesId,
                        principalTable: "College",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeSubject_subject_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69df1e83-82d1-4c95-b1a0-4ff2ca8aeffb", null, "CollegeAdmin", "COLLEGEADMIN" },
                    { "6ae73b33-fdd5-40bd-af48-75f481a013cd", null, "Lecturer", "LECTURER" },
                    { "b2d06d8f-fded-4dce-924d-19d5f773717f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollageSemesterSubject_Semestersid",
                table: "CollageSemesterSubject",
                column: "Semestersid");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubject_SubjectsId",
                table: "CollegeSubject",
                column: "SubjectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollageSemesterSubject");

            migrationBuilder.DropTable(
                name: "CollegeSubject");

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

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "subject",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e95baf2-6e14-4742-a56a-c3c67b951975", null, "Lecturer", "LECTURER" },
                    { "534ad906-e132-44e2-87ce-2f9e9eea4353", null, "Admin", "ADMIN" },
                    { "de7c729a-f034-408f-85b0-4dd40a08d53a", null, "CollegeAdmin", "COLLEGEADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_subject_CollegeId",
                table: "subject",
                column: "CollegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_subject_College_CollegeId",
                table: "subject",
                column: "CollegeId",
                principalTable: "College",
                principalColumn: "Id");
        }
    }
}
