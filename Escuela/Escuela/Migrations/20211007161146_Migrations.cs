using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escuela.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Course",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Course", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Student",
                columns: table => new
                {
                    studendId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enrollmentsDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Student", x => x.studendId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Enrollment",
                columns: table => new
                {
                    enrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    studendId = table.Column<int>(type: "int", nullable: false),
                    grade = table.Column<int>(type: "int", nullable: true),
                    FK_IdCoursecourseId = table.Column<int>(type: "int", nullable: true),
                    FK_IdStudentstudendId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Enrollment", x => x.enrollmentId);
                    table.ForeignKey(
                        name: "FK_Tbl_Enrollment_Tbl_Course_FK_IdCoursecourseId",
                        column: x => x.FK_IdCoursecourseId,
                        principalTable: "Tbl_Course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Enrollment_Tbl_Student_FK_IdStudentstudendId",
                        column: x => x.FK_IdStudentstudendId,
                        principalTable: "Tbl_Student",
                        principalColumn: "studendId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Enrollment_FK_IdCoursecourseId",
                table: "Tbl_Enrollment",
                column: "FK_IdCoursecourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Enrollment_FK_IdStudentstudendId",
                table: "Tbl_Enrollment",
                column: "FK_IdStudentstudendId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Enrollment");

            migrationBuilder.DropTable(
                name: "Tbl_Course");

            migrationBuilder.DropTable(
                name: "Tbl_Student");
        }
    }
}
