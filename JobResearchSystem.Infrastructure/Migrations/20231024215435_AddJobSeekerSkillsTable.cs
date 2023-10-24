using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobResearchSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddJobSeekerSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiances_JobSeekers_JobSeekerId",
                table: "Experiances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiances",
                table: "Experiances");

            migrationBuilder.RenameTable(
                name: "Experiances",
                newName: "Experiences");

            migrationBuilder.RenameIndex(
                name: "IX_Experiances_JobSeekerId",
                table: "Experiences",
                newName: "IX_Experiences_JobSeekerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JobSeekerSkill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSkill", x => new { x.JobSeekerId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_JobSeekerSkill_JobSeekers_JobSeekerId",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobSeekerSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerSkill_JobSeekerId_SkillId",
                table: "JobSeekerSkill",
                columns: new[] { "JobSeekerId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerSkill_SkillId",
                table: "JobSeekerSkill",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_JobSeekers_JobSeekerId",
                table: "Experiences",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_JobSeekers_JobSeekerId",
                table: "Experiences");

            migrationBuilder.DropTable(
                name: "JobSeekerSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experiances");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_JobSeekerId",
                table: "Experiances",
                newName: "IX_Experiances_JobSeekerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiances",
                table: "Experiances",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Experiances_JobSeekers_JobSeekerId",
                table: "Experiances",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
