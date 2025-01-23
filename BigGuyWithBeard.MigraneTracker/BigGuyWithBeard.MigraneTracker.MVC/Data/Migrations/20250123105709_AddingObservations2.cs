using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigGuyWithBeard.MigraneTracker.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingObservations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Observations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DizzynessScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FunctionScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HeadPaintScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LightSensitivtyScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Medication",
                table: "Observations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NauseaScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NeckPaintScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TirednessScore",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Observations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "DizzynessScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "FunctionScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "HeadPaintScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "LightSensitivtyScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "Medication",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "NauseaScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "NeckPaintScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "TirednessScore",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Observations");
        }
    }
}
