using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Core.Migrations
{
    public partial class UpdatedPortfolioCopy3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: @"Dennis realized his old WiX-portfolio wasn't up for the task, so he decided to build a personal portfolio CMS from scratch in .NET Core.

You're currently looking at this project live in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.
This page is overengineered in order to showcase Dennis' skills. He's also planning on setting up a backoffice for easier content management.

The source code is available on his GitHub.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: @"Dennis realized his old WiX-portfolio wasn't up for the task, so he decided to build a personal portfolio CMS from scratch in .NET Core.

You're currently looking at this project live in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.
This page is overengineered in order to showcase Dennis' skills. He's also planning on setting up a backoffice for easier content management.

The source code is available on my GitHub.");
        }
    }
}
