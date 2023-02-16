using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRegintablecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "Regions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Regions");
        }
    }
}
