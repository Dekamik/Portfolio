using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Core.Migrations
{
    public partial class UpdateCopyTacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleDescription",
                value: "With this employment, Dennis was thrust into the programming world with a bang. Due to the company's small size, Dennis seized the opportunity to get busy working with several apps, as well as the server infrastructure that ran the apps.");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmployerDescription",
                value: "Sopra Steria is a large multi-national IT-consultancy firm based in France.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Adsscore is an internal statistics system geared towards professional clients. Through this system the clients could view their Adssets advert's results. As a Java developer Dennis developed new features and maintained the system. He also helped improve the apps performance through quicker response times, which improved the client's user experience. Dennis also maintained the application's infrastructure, namely web servers, application servers and database servers.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "MetroMaze is a top-down 2D RPG created during Global Game Jam 2016. In accordance with the theme \"Ritual\", you are a teenager chosen to complete the MetroMaze as your coming of age ritual, solve puzzles and uncover its mysteries. It was made using King's (then beta) game engine Defold. As a developer Dennis created most of the games base functionality in Lua: movement, interaction, text boxes, as well as the logic around graphics, sound and music.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Cards and Loans is a part of the Internet banking system that concerns application and management of debit and credit cards, and different type of bank loans. As java developer Dennis developed new features and bug-fixes for the Internet banking software. He also helped the company to increase its regression testing coverage in JUnit, which improved the app's stability.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "SVRVIVE - The Deus Helix is the first game from SVRVIVE Studios made in Unity3D. You are Agent Null, an abducted human being who's been hired by aliens to search for pieces of the Deus Helix (the DNA of the universe) on exotic planets. As VR developer, Dennis developed gaming mechanics and puzzles in the game. Dennis was mainly responsible for integrating the game towards SteamVR and Viveport, as well as developing the game's checkpoints, saving and loading and VR menus. He also developed an internal localization solution and implemented it in the game, which meant that the company could translate the game to Chinese for the chinese Viveport market. This localization system also allows people to easily translate several languages and select language in the menu.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "ZpazeWavez was a vertical scrolling shoot-ém-up made for Global Game Jam 2017. The game was created within 48 hours and plays much like Ikaruga, where you must match your plasma weapons color with the enemy's color. As sound programmer, Dennis implemented sound in the game with FMOD, an external sound engine for Unity3D. Dennis contributed with basic dynamics for the sound, for example minor changes in pitch in repeating sounds, making them sound more natural.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "A private tool for performing technical analyses on entire stock indexes. The analysis is based on a value investment strategy and was run each weekday from Dennis' private server.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Rewrite of the autonomous stock analysis tool to .NET Core and Azure Functions. The solution is hosted on the Azure cloud service and gets called by Dennis' home server through HTTPS. When the service registers the call it performs a technical analysis outlined by post data in JSON format and delivers an excel file which the server stores for later analysis.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "EndDate" },
                values: new object[] { @"Dennis realized his old WiX-portfolio wasn't up to task, so he built a personal portfolio CMS from scratch in .NET Core.

You're currently looking at the results in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.
This page is overengineered to showcase Dennis' skills. He's also planning on setting up a backoffice for easier content management.

The source code is available on GitHub.", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleDescription",
                value: "With this employment, Dennis was thrust into the programming world with a bang. Due to the company''s small size, Dennis seized the opportunity to get busy working with several apps, as well as the server infrastructure that ran the apps.");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmployerDescription",
                value: "Sopra Steria is a french multi-national IT-consultancy firm.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Adsscore is an internal statistics system geared towards professional clients. Through this system the clients could view their Adssets advert''s results. As a Java developer Dennis developed new features and maintained the system. He also helped improve the apps performance through quicker response times, which improved the client''s user experience. Dennis also maintained the application''s infrastructure, namely web servers, application servers and database servers.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "MetroMaze is a top-down 2D RPG created during Global Game Jam 2016. In accordance with the theme \"Ritual\", you are a teenager chosen to complete the MetroMaze as your coming of age ritual, solve puzzles and uncover its mysteries. It was made using King''s (then beta) game engine Defold. As a developer Dennis created most of the games base functionality in Lua: movement, interaction, text boxes, as well as the logic around graphics, sound and music.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Cards and Loans is a part of the Internet banking system that concerns application and management of debit and credit cards, and different type of bank loans. As java developer Dennis developed new features and bug-fixes for the Internet banking software. He also helped the company to increase its regression testing coverage in JUnit, which improved the app''s stability.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "SVRVIVE - The Deus Helix is the first game from SVRVIVE Studios made in Unity3D. You are Agent Null, an abducted human being who''s been hired by aliens to search for pieces of the Deus Helix (the DNA of the universe) on exotic planets. As VR developer, Dennis developed gaming mechanics and puzzles in the game. Dennis was mainly responsible for integrating the game towards SteamVR and Viveport, as well as developing the game''s checkpoints, saving and loading and VR menus. He also developed an internal localization solution and implemented it in the game, which meant that the company could translate the game to Chinese for the chinese Viveport market. This localization system also allows people to easily translate several languages and select language in the menu.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "ZpazeWavez was a vertical scrolling shoot-ém-up made for Global Game Jam 2017. The game was created within 48 hours and plays much like Ikaruga, where you must match your plasma weapons color with the enemy''s color. As sound programmer, Dennis implemented sound in the game with FMOD, an external sound engine for Unity3D. Dennis contributed with basic dynamics for the sound, for example minor changes in pitch in repeating sounds, making them sound more natural.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "A private tool for performing technical analyses on entire stock indexes. The analysis is based on a value investment strategy and is run each weekday from Dennis private server.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Rewrite of the autonomous stock analysis tool to .NET Core and Azure Functions. The solution is hosted on the Azure cloud service and gets called by Dennis'' home server through HTTPS. When the service registers the call it performs a technical analysis outlined by post data in JSON format and delivers an excel file which the server stores for later analysis.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "EndDate" },
                values: new object[] { @"Dennis realized his old WiX-portfolio wasn't up for the task, so he decided to build a personal portfolio CMS from scratch in .NET Core.

You're currently looking at this project live in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.
This page is overengineered in order to showcase Dennis' skills. He's also planning on setting up a backoffice for easier content management.

The source code is available on his GitHub.", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
