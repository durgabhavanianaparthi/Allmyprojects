using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NETCoreWebApiWithEFCoreUsingStudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class Computer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentPerformances",
                columns: table => new
                {
                    RollNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Performance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPerformances", x => x.RollNo);
                });

            migrationBuilder.CreateTable(
                name: "Studentss",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMarks = table.Column<int>(type: "int", nullable: false),
                    RollNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Studentss_StudentPerformances_RollNo",
                        column: x => x.RollNo,
                        principalTable: "StudentPerformances",
                        principalColumn: "RollNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studentss_RollNo",
                table: "Studentss",
                column: "RollNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentss");

            migrationBuilder.DropTable(
                name: "StudentPerformances");
        }
    }
}
