using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 4, 3, 838, DateTimeKind.Local).AddTicks(4397));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 24, 23, 37, 59, 408, DateTimeKind.Local).AddTicks(8007));
        }
    }
}
