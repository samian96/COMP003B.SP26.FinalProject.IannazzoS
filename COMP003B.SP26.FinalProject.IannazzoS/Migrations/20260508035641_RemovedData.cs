using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.SP26.FinalProject.IannazzoS.Migrations
{
    /// <inheritdoc />
    public partial class RemovedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicationId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicationId",
                table: "Appointments");
        }
    }
}
