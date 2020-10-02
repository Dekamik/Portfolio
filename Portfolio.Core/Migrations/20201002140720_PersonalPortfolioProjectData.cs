using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Core.Migrations
{
    public partial class PersonalPortfolioProjectData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Category", "Customer", "Description", "EmployerId", "EndDate", "IsHighlighted", "Name", "Role", "Show", "StartDate" },
                values: new object[] { 18, 2, null, "Realized my old WiX-portfolio wasn't up for the task, so I decided to build one from scratch using my skills in .NET Core.", null, new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Personal portfolio (dennisvonbargen.com)", "Full-stack .NET Developer", true, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 104, "Entity Framework Core (EF Core)" },
                    { 105, "Docker" },
                    { 106, "Docker Compose" },
                    { 107, "Docker Hub" },
                    { 108, "Digital Ocean" },
                    { 109, "Automated Builds" },
                    { 110, "Blazor" },
                    { 111, "Component-based UI Design" },
                    { 112, "Domain name administration" }
                });

            migrationBuilder.UpdateData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 196,
                column: "SkillId",
                value: 104);

            migrationBuilder.InsertData(
                table: "ProjectSkills",
                columns: new[] { "Id", "ProjectId", "SkillId" },
                values: new object[,]
                {
                    { 199, 18, 62 },
                    { 207, 18, 110 },
                    { 206, 18, 109 },
                    { 205, 18, 108 },
                    { 204, 18, 107 },
                    { 203, 18, 106 },
                    { 202, 18, 105 },
                    { 200, 18, 104 },
                    { 210, 18, 111 },
                    { 218, 18, 58 },
                    { 216, 18, 67 },
                    { 215, 18, 14 },
                    { 214, 18, 71 },
                    { 213, 18, 66 },
                    { 212, 18, 86 },
                    { 209, 18, 7 },
                    { 208, 18, 55 },
                    { 201, 18, 90 },
                    { 217, 18, 15 },
                    { 211, 18, 112 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.InsertData(
                table: "ProjectSkills",
                columns: new[] { "Id", "ProjectId", "SkillId" },
                values: new object[] { 196, 17, 103 });
        }
    }
}
