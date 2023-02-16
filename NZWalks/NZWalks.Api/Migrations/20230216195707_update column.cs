using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class updatecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lenght",
                table: "WalkDifficulty");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "WalkDifficulty");

            migrationBuilder.DropColumn(
                name: "WalkDifficultyId",
                table: "WalkDifficulty");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WalkDifficulty",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "WalkDifficulty",
                newName: "Name");

            migrationBuilder.AddColumn<double>(
                name: "Lenght",
                table: "WalkDifficulty",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "RegionId",
                table: "WalkDifficulty",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WalkDifficultyId",
                table: "WalkDifficulty",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
