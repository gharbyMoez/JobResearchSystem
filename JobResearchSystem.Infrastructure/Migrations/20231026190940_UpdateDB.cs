using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobStatus");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Experiances");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApplicantStatus");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Applicants");

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "UserTypeName" },
                values: new object[] { new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(861), "SystemAdminstrators" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Qualifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Experiances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ApplicantStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Applicants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3143), 0 });

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3162), 0 });

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "ApplicantStatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3171), 0 });

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(2931), 0 });

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3071), 0 });

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "JobStatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3081), 0 });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3216), 0 });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Id" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3232), 0 });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Id", "UserTypeName" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3240), 0, "Admin" });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeId", "DateCreated", "DateDeleted", "DateUpdated", "Id", "IsDeleted", "UserTypeName" },
                values: new object[] { 4, new DateTime(2023, 10, 26, 21, 26, 43, 538, DateTimeKind.Local).AddTicks(3248), null, null, 0, false, "SuperAdmin" });
        }
    }
}
