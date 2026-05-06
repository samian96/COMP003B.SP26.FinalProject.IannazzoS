using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.SP26.FinalProject.IannazzoS.Migrations
{
    /// <inheritdoc />
    public partial class AddReferralToPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Referral",
                table: "Patients",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Referral",
                table: "Patients");
        }
    }
}
