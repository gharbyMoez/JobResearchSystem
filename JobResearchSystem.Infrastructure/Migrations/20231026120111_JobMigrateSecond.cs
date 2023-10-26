using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class JobMigrateSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 15, 1, 11, 298, DateTimeKind.Local).AddTicks(1994));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 14, 57, 57, 593, DateTimeKind.Local).AddTicks(6023));
        }
    }
}
