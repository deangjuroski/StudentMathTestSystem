﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMathTestSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchemaV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeacherID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Exams_ExamID",
                table: "Exams");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherID",
                table: "Teachers",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentID",
                table: "Students",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_ExamID",
                table: "Exams",
                column: "ExamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeacherID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Exams_ExamID",
                table: "Exams");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherID",
                table: "Teachers",
                column: "TeacherID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentID",
                table: "Students",
                column: "StudentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_ExamID",
                table: "Exams",
                column: "ExamID",
                unique: true);
        }
    }
}
