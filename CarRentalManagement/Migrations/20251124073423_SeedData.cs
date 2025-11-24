using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateUpdated", "Datecreated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 34, 22, 381, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 11, 24, 15, 34, 22, 381, DateTimeKind.Local).AddTicks(9929), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 34, 22, 381, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 11, 24, 15, 34, 22, 381, DateTimeKind.Local).AddTicks(9964), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateUpdated", "Datecreated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(203), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(202), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(205), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(204), "Toyoto", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateUpdated", "Datecreated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(293), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(292), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(295), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(295), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(298), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(297), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 11, 24, 15, 34, 22, 382, DateTimeKind.Local).AddTicks(299), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Model",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
