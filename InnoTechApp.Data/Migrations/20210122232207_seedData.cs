using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnoTechApp.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Lorem pla pla pla pla pla", "Asp.Net Core", 112f },
                    { 2, "Lorem pla pla pla pla pla", "Blazor", 500f },
                    { 3, "Lorem pla pla pla pla pla", "Entity Framework Core Getting Started", 300f }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 21, "Mohammad Fayed" },
                    { 2, 9, "Ahmed Fayed" },
                    { 3, 21, "Amr Alaa" },
                    { 4, 21, "Omar Morgan" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Date", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 1, 23, 1, 22, 7, 173, DateTimeKind.Local).AddTicks(6934), 1 },
                    { 2, 2, new DateTime(2021, 3, 24, 1, 22, 7, 175, DateTimeKind.Local).AddTicks(8601), 1 },
                    { 3, 3, new DateTime(2021, 2, 22, 1, 22, 7, 175, DateTimeKind.Local).AddTicks(8762), 1 },
                    { 4, 1, new DateTime(2021, 1, 23, 21, 22, 7, 175, DateTimeKind.Local).AddTicks(8771), 2 },
                    { 6, 3, new DateTime(2021, 1, 23, 21, 22, 7, 175, DateTimeKind.Local).AddTicks(8813), 2 },
                    { 5, 1, new DateTime(2021, 1, 23, 1, 42, 7, 175, DateTimeKind.Local).AddTicks(8795), 3 },
                    { 7, 2, new DateTime(2021, 2, 23, 1, 22, 7, 175, DateTimeKind.Local).AddTicks(8816), 3 },
                    { 8, 2, new DateTime(2021, 1, 23, 7, 22, 7, 175, DateTimeKind.Local).AddTicks(8891), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
