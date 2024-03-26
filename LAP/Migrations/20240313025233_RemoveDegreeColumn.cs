using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAP.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDegreeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "Trainees",
                type: "int",
                nullable: true);
        }
    }
}
