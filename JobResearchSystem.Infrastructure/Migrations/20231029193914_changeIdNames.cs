using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeIdNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerSkill_JobSeekers_JobSeekersJobSeekerId",
                table: "JobSeekerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerSkill_Skills_SkillsSkillId",
                table: "JobSeekerSkill");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "UserTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "Skills",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "QualificationId",
                table: "Qualifications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobStatusId",
                table: "JobStatus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SkillsSkillId",
                table: "JobSeekerSkill",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "JobSeekersJobSeekerId",
                table: "JobSeekerSkill",
                newName: "JobSeekersId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerSkill_SkillsSkillId",
                table: "JobSeekerSkill",
                newName: "IX_JobSeekerSkill_SkillsId");

            migrationBuilder.RenameColumn(
                name: "JobSeekerId",
                table: "JobSeekers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Jobs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExperianceId",
                table: "Experiances",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Companies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ApplicantStatusId",
                table: "ApplicantStatus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ApplicantId",
                table: "Applicants",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ApplicantStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "JobStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 29, 21, 39, 13, 742, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerSkill_JobSeekers_JobSeekersId",
                table: "JobSeekerSkill",
                column: "JobSeekersId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerSkill_Skills_SkillsId",
                table: "JobSeekerSkill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerSkill_JobSeekers_JobSeekersId",
                table: "JobSeekerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerSkill_Skills_SkillsId",
                table: "JobSeekerSkill");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserTypes",
                newName: "UserTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Skills",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Qualifications",
                newName: "QualificationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobStatus",
                newName: "JobStatusId");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "JobSeekerSkill",
                newName: "SkillsSkillId");

            migrationBuilder.RenameColumn(
                name: "JobSeekersId",
                table: "JobSeekerSkill",
                newName: "JobSeekersJobSeekerId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerSkill_SkillsId",
                table: "JobSeekerSkill",
                newName: "IX_JobSeekerSkill_SkillsSkillId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobSeekers",
                newName: "JobSeekerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jobs",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Experiances",
                newName: "ExperianceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companies",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApplicantStatus",
                newName: "ApplicantStatusId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Applicants",
                newName: "ApplicantId");

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
                column: "DateCreated",
                value: new DateTime(2023, 10, 26, 22, 9, 40, 101, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerSkill_JobSeekers_JobSeekersJobSeekerId",
                table: "JobSeekerSkill",
                column: "JobSeekersJobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "JobSeekerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerSkill_Skills_SkillsSkillId",
                table: "JobSeekerSkill",
                column: "SkillsSkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
