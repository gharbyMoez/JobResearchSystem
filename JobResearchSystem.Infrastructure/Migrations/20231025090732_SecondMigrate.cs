using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 12, 7, 31, 624, DateTimeKind.Local).AddTicks(1883));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 0, 54, 33, 995, DateTimeKind.Local).AddTicks(9667));
        }
    }
}
