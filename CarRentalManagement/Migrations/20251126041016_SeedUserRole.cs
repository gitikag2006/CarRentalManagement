using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6b5569f7-b88e-4afc-a52e-9f8315d664c9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECnXUJB9kSWlUlf63aGXGV8mlCTfdSv8gfy/0MpegDE1U/fvqUwt+BrzY1gbKmqjQw==", null, false, "0ed471f9-ecf1-446a-8d01-0ab02987ce42", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(3967), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4230), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4233), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4480), new DateTime(2025, 11, 26, 12, 10, 15, 441, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7415), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7420), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7680), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7683), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7786), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7788), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7790), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateUpdated", "Datecreated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7792), new DateTime(2025, 11, 26, 12, 1, 25, 762, DateTimeKind.Local).AddTicks(7792) });
        }
    }
}
