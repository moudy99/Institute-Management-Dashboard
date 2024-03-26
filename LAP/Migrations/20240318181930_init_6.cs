using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAP.Migrations
{
    /// <inheritdoc />
    public partial class init_6 : Migration
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

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Course",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentID",
                table: "Course",
                newName: "IX_Course_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentId",
                table: "Course",
                column: "DepartmentId",
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
                name: "FK_Course_Departments_DepartmentId",
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

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Course",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                newName: "IX_Course_DepartmentID");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
