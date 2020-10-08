using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Core.Migrations
{
    public partial class UpdatedPortfolioCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: @"Realized my old WiX-portfolio wasn't up for the task, so I decided to build one from scratch in .NET Core.

You're currently looking at this project live in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.
The idea is to create a backoffice for this website for easier editing, as well as for showcasing my skills.

The source code is available on my GitHub.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Realized my old WiX-portfolio wasn't up for the task, so I decided to build one from scratch using my skills in .NET Core.");
        }
    }
}
