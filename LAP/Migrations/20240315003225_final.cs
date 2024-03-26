using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAP.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Course_CourseID",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Trainees_TraineeID",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Course_CourseID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_DepartmentID",
                table: "Trainees");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Course_CourseID",
                table: "CrsResults",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Trainees_TraineeID",
                table: "CrsResults",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Course_CourseID",
                table: "Instructors",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_DepartmentID",
                table: "Trainees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Course_CourseID",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Trainees_TraineeID",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Course_CourseID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_DepartmentID",
                table: "Trainees");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Course_CourseID",
                table: "CrsResults",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Trainees_TraineeID",
                table: "CrsResults",
                column: "TraineeID",
                principalTable: "Trainees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Course_CourseID",
                table: "Instructors",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_DepartmentID",
                table: "Trainees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");
        }
    }
}
