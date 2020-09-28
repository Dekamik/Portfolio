using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Core.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "EmployerDescription", "EndDate", "Name", "RoleDescription", "StartDate" },
                values: new object[,]
                {
                    { 1, "Adssets is a small company that creates and serves rich-media advertisements on web publications.", new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adssets", "With this employment, Dennis was thrust into the programming world with a bang. Due to the company''s small size, Dennis seized the opportunity to get busy working with several apps, as well as the server infrastructure that ran the apps.", new DateTime(2014, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Cybercom Group is a swedish IT-consultancy firm.", new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cybercom Group", "Dennis was briefly assigned to CrossKey as a Java consultant, where he helped the Cards and Loans team develop new functionality and create regression tests with Selenium, to ensure web-flows work as intended.", new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "SVRVIVE Studios (now Antler Interactive) is a small game studio which was initially focused on VR gaming. The studio has created games like SVRVIVE - The Deus Helix, Kartong - Death By Cardboard! and Krystal Kart AR.", new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SVRVIVE Studios", "As a VR-developer, Dennis helped finish and release SVRVIVE Studios first game (SVRVIVE - The Deus Helix) and helped bring the game to the chinese markets through Viveport. Additionally, since the company was so small, Dennis took the opportunity to handle much of the studios IT-infrastructure and also tried a short tenure as a producer for an unreleased game.", new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Sopra Steria is a french multi-national IT-consultancy firm.", null, "Sopra Steria", "As a full-stack .NET consultant, Dennis has been involved in several projects, both in-house and on-site, for customers like Kammarkollegiet, Rovio Entertainment (famous for Angry Birds) and Tandvårdsförvaltningen Region Stockholm, Region Västmanland and Region Dalarna. Dennis has also done lectures for Sopra Sterias graduates within Unity3D programming, and Test Driven Development (TDD).", new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Category", "Customer", "Description", "EmployerId", "EndDate", "IsHighlighted", "Name", "Role", "Show", "StartDate" },
                values: new object[,]
                {
                    { 1, 2, "Team Vikestart", "", null, new DateTime(2010, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "C&C Red Alert 3 - Resurrection (Mod)", "Music producer", false, new DateTime(2009, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, null, "MetroMaze is a top-down 2D RPG created during Global Game Jam 2016. In accordance with the theme \"Ritual\", you are a teenager chosen to complete the MetroMaze as your coming of age ritual, solve puzzles and uncover its mysteries. It was made using King''s (then beta) game engine Defold. As a developer Dennis created most of the games base functionality in Lua: movement, interaction, text boxes, as well as the logic around graphics, sound and music.", null, new DateTime(2016, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MetroMaze (Global Gamejam 2016)", "Defold Developer", true, new DateTime(2016, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, null, "ZpazeWavez was a vertical scrolling shoot-ém-up made for Global Game Jam 2017. The game was created within 48 hours and plays much like Ikaruga, where you must match your plasma weapons color with the enemy''s color. As sound programmer, Dennis implemented sound in the game with FMOD, an external sound engine for Unity3D. Dennis contributed with basic dynamics for the sound, for example minor changes in pitch in repeating sounds, making them sound more natural.", null, new DateTime(2017, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ZpazeWavez", "Sound programmer & music producer", true, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, null, "A private tool for performing technical analyses on entire stock indexes. The analysis is based on a value investment strategy and is run each weekday from Dennis private server.", null, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Autonomous Stock Analysis Tool", "Python Developer", true, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, null, "Rewrite of the autonomous stock analysis tool to .NET Core and Azure Functions. The solution is hosted on the Azure cloud service and gets called by Dennis'' home server through HTTPS. When the service registers the call it performs a technical analysis outlined by post data in JSON format and delivers an excel file which the server stores for later analysis.", null, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Smidas", ".NET Developer", true, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 67, "GitExtensions" },
                    { 68, "gulp.js" },
                    { 69, "Less" },
                    { 70, "LINQ" },
                    { 75, "SQL Server" },
                    { 72, "Model-view-controller (MVC)" },
                    { 73, "Razor (HTML5)" },
                    { 74, "Regular expressions" },
                    { 66, "FluentAssertions" },
                    { 71, "Microsoft Visual Studio" },
                    { 65, "Entity Framework (EF)" },
                    { 61, "Node.js" },
                    { 63, "Atlassian Confluence" },
                    { 62, ".NET Core" },
                    { 76, "T-SQL" },
                    { 60, "Test Driven Development (TDD)" },
                    { 59, "Mocha" },
                    { 58, "Database modeling" },
                    { 57, "Chai.js" },
                    { 56, "Batch script" },
                    { 55, "Unit testing" },
                    { 54, "REST API" },
                    { 64, "Bootstrap" },
                    { 77, "Unified Modeling Language (UML)" },
                    { 81, "Pycharm" },
                    { 79, "Stocks" },
                    { 101, "React Router" },
                    { 100, "Azure DevOps" },
                    { 99, "WebForms" },
                    { 98, ".NET Framework" },
                    { 97, "Microsoft Excel" },
                    { 96, "curl" },
                    { 95, "Azure Functions" },
                    { 94, "Unix" },
                    { 93, "TeamCity" },
                    { 92, "Rider" },
                    { 78, "xUnit" },
                    { 91, "React.js" },
                    { 89, "OS X" },
                    { 88, "Infrastructure as Code (IaC)" },
                    { 87, "HashiCorp Terraform" },
                    { 86, "FakeItEasy" },
                    { 85, "XPath" },
                    { 84, "Value investment" },
                    { 83, "Synology DSM" },
                    { 82, "Synology" },
                    { 53, "Amazon Web Services (AWS)" },
                    { 80, "Stock analysis" },
                    { 90, "PostgreSQL" },
                    { 52, "VRTK" },
                    { 47, "Unity3D" },
                    { 50, "FL Studio" },
                    { 22, "NGINX" },
                    { 21, "Python" },
                    { 20, "Shell script" },
                    { 19, "SQL" },
                    { 18, "JSON" },
                    { 17, "jQuery" },
                    { 16, "JDBC" },
                    { 15, "GitHub" },
                    { 14, "Git" },
                    { 13, "EJB (Enterprise JavaBeans)" },
                    { 23, "Backup & restore" },
                    { 12, "Atlassian Jira" },
                    { 10, "JavaScript" },
                    { 9, "SSH" },
                    { 8, "Bash" },
                    { 7, "Ubuntu" },
                    { 6, "GlassFish" },
                    { 5, "MySQL" },
                    { 4, "CSS" },
                    { 3, "HTML" },
                    { 2, "Linux" },
                    { 1, "JavaEE" },
                    { 11, "AJAX" },
                    { 24, "Cron" },
                    { 25, "Defold Engine" },
                    { 26, "Lua" },
                    { 49, "Virtual Reality" },
                    { 48, "Viveport" },
                    { 102, "TypeScript" },
                    { 46, "Steamworks" },
                    { 45, "SteamVR" },
                    { 44, "Sourcetree" },
                    { 43, "Prototyping" },
                    { 42, "Oculus Rift" },
                    { 41, "NewtonVR" },
                    { 40, "HTC Vive" },
                    { 39, "GitLab" },
                    { 38, "Git LFS" },
                    { 37, "FMOD" },
                    { 36, "C#" },
                    { 35, "Agile development" },
                    { 34, "Jenkins" },
                    { 33, "Automated UI testing" },
                    { 32, "Scrum" },
                    { 31, "Selenium" },
                    { 30, "SVN" },
                    { 29, "Oracle Database" },
                    { 28, "JUnit" },
                    { 27, "Game design" },
                    { 51, "Project management" },
                    { 103, "React Hooks" }
                });

            migrationBuilder.InsertData(
                table: "ProjectSkills",
                columns: new[] { "Id", "ProjectId", "SkillId" },
                values: new object[,]
                {
                    { 136, 13, 31 },
                    { 68, 8, 47 },
                    { 70, 8, 50 },
                    { 139, 13, 60 },
                    { 166, 15, 62 },
                    { 135, 13, 74 },
                    { 174, 15, 74 },
                    { 141, 13, 77 },
                    { 128, 13, 79 },
                    { 167, 15, 79 },
                    { 129, 13, 80 },
                    { 168, 15, 80 },
                    { 133, 13, 81 },
                    { 137, 13, 82 },
                    { 138, 13, 83 },
                    { 140, 13, 84 },
                    { 175, 15, 84 },
                    { 142, 13, 85 },
                    { 176, 15, 85 },
                    { 169, 15, 95 },
                    { 71, 8, 37 },
                    { 69, 8, 36 },
                    { 173, 15, 97 },
                    { 72, 8, 27 },
                    { 41, 5, 27 },
                    { 40, 5, 26 },
                    { 39, 5, 25 },
                    { 134, 13, 21 },
                    { 172, 15, 15 },
                    { 131, 13, 15 },
                    { 171, 15, 14 },
                    { 130, 13, 14 },
                    { 132, 13, 2 },
                    { 170, 15, 96 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Category", "Customer", "Description", "EmployerId", "EndDate", "IsHighlighted", "Name", "Role", "Show", "StartDate" },
                values: new object[,]
                {
                    { 3, 1, null, "", 1, new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Systems administration", "Systems Administrator", false, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, null, "Data gatherer was an application that took raw advertising data from a bunch of servers and then compiled the data for presentation in Adsscore. Above all Dennis contributed with performance improvements as a Java developer and ensured the app could compile more data faster.", 1, new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Data gatherer", "Java Developer", true, new DateTime(2014, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, "CrossKey", "Cards and Loans is a part of the Internet banking system that concerns application and management of debit and credit cards, and different type of bank loans. As java developer Dennis developed new features and bug-fixes for the Internet banking software. He also helped the company to increase its regression testing coverage in JUnit, which improved the app''s stability.", 2, new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cards and Loans", "Java Consultant", true, new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, null, "SVRVIVE - The Deus Helix is the first game from SVRVIVE Studios made in Unity3D. You are Agent Null, an abducted human being who''s been hired by aliens to search for pieces of the Deus Helix (the DNA of the universe) on exotic planets. As VR developer, Dennis developed gaming mechanics and puzzles in the game. Dennis was mainly responsible for integrating the game towards SteamVR and Viveport, as well as developing the game''s checkpoints, saving and loading and VR menus. He also developed an internal localization solution and implemented it in the game, which meant that the company could translate the game to Chinese for the chinese Viveport market. This localization system also allows people to easily translate several languages and select language in the menu.", 3, new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "SVRVIVE - The Deus Helix", "Unity Developer", true, new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, null, "Kartong - Death By Cardboard! is a game created in Unreal Engine 4. You run in a procedurally generated mini maze made of cardboard. Your mission is to avoid traps and crazy, dangerous, and creepy toy experiments in order to get yourself to the mazes exit. The developers that worked on this game asked Dennis of a content delivery system for external partners that the company was talking to. They needed to store images and information on these people on a server outside of the game, and be able to programmatically reach these files from the client-side. Dennis created a simple REST-API on Amazon Web Services, where API Gateway mapped directly against objects in an S3 bucket. Thus the developers could easily load images and JSON-files to this bucket, download these files on-the-fly and use them in-game.", 3, new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kartong - Death By Cardboard!", "AWS Developer", true, new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, "Tandvårdsenheten Region Västmanland & Region Dalarna", "Making modifications to existing dental care systems, and getting them ready to release for Region Västmanland and Region Dalarna.", 4, null, false, "Dental Care Systems", "Full-stack .NET Developer", true, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, null, "SVRVIVE Studios needed a first revision of a backend API for its client-side. The game was based on asynchronous multiplayer, and therefore needed a central API that handled player data. As a NodeJS developer, Dennis recieved the requirements from the developer responsible for the application. Together they defined what data the game needed to store, so Dennis could model and generate the database in MySQL Workbench, and then setup the environment on Amazon Web Services (API Gateway, Lambda & RDBS). After he created the first tests and functions he pushed on with the project. In the end the client could send requests to the server without issues.", 3, new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Krystal Kart AR", "NodeJS Developer", true, new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, "Kammarkollegiet", "A public-sector service for ordering interpretation services. The service is available to Swedish authorities, under the responsibility of the Chamber of Commerce. As a .NET developer, Dennis creates the remaining functionality required to get the first partial delivery of the service through the door. With a focus on what is required in the present, Dennis took on the tasks in the assignment and solved the tasks one by one.", 4, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kammarkollegiets Tolkavropstjänst", "Full-stack .NET Developer", true, new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, "Rovio Entertainment Corporation", "Dennis was brought into this assignment to substitute a senior DevOps who went on parental leave. Since this role included multiple areas of responsibility, Dennis got to handle and build out the build servers, the cloud infrastructure, as well as the admin tooling for an ongoing game project. After that he helped develop the server application on which the game relied on. In order to bring the project to its next phase, a migration of the server application to virtual servers was necessary. Dennis performed this migration so the project could proceed. Thereafter he helped with improvements of the infrastructure and futher development of the codebase.", 4, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CLASSIFIED PROJECT", ".NET Developer", true, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, "Tandvårdsenheten Region Stockholm", "New version of an existing application, which focuses on a better user experience and better performance.", 4, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Libretto 2.0", "Full-stack .NET Developer", true, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, null, "Anonymous VR game project. As a VR developer and producer, Dennis initally setup the project; he ensured that VRTK was installed, that all VR platforms were configured and worked. He also ensured that you could load and unload levels without disrupting user experience. As producer Dennis was responsible for the projects pre-production. Dennis ensured all key-people in all areas of expertise (art, game design, programming, sound & QA) drew up plans, planned and held meetings, helped when help was needed and reported to management upstairs.", 3, new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CLASSIFIED PROJECT", "Unity Developer & Producer", true, new DateTime(2017, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, "Adsscore is an internal statistics system geared towards professional clients. Through this system the clients could view their Adssets advert''s results. As a Java developer Dennis developed new features and maintained the system. He also helped improve the apps performance through quicker response times, which improved the client''s user experience. Dennis also maintained the application''s infrastructure, namely web servers, application servers and database servers.", 1, new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adsscore", "Java Developer", true, new DateTime(2014, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProjectSkills",
                columns: new[] { "Id", "ProjectId", "SkillId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 114, 12, 3 },
                    { 115, 12, 68 },
                    { 116, 12, 10 },
                    { 117, 12, 17 },
                    { 118, 12, 69 },
                    { 119, 12, 70 },
                    { 120, 12, 71 },
                    { 113, 12, 67 },
                    { 121, 12, 72 },
                    { 123, 12, 74 },
                    { 124, 12, 75 },
                    { 125, 12, 76 },
                    { 126, 12, 77 },
                    { 127, 12, 78 },
                    { 143, 14, 62 },
                    { 144, 14, 53 },
                    { 122, 12, 73 },
                    { 112, 12, 14 },
                    { 111, 12, 66 },
                    { 110, 12, 65 },
                    { 93, 11, 56 },
                    { 94, 11, 57 },
                    { 95, 11, 58 },
                    { 96, 11, 18 },
                    { 97, 11, 59 },
                    { 98, 11, 5 },
                    { 99, 11, 61 },
                    { 100, 11, 19 },
                    { 101, 11, 60 },
                    { 102, 12, 62 },
                    { 103, 12, 11 },
                    { 104, 12, 12 },
                    { 105, 12, 63 },
                    { 106, 12, 64 },
                    { 107, 12, 36 },
                    { 108, 12, 4 },
                    { 109, 12, 55 },
                    { 145, 14, 8 },
                    { 92, 11, 55 },
                    { 146, 14, 36 },
                    { 148, 14, 86 },
                    { 181, 16, 86 },
                    { 182, 16, 71 },
                    { 183, 16, 75 },
                    { 184, 16, 76 },
                    { 185, 16, 78 },
                    { 198, 16, 99 },
                    { 186, 17, 62 },
                    { 180, 16, 55 },
                    { 187, 17, 100 },
                    { 189, 17, 14 },
                    { 190, 17, 67 },
                    { 191, 17, 103 },
                    { 192, 17, 101 },
                    { 193, 17, 32 },
                    { 194, 17, 75 },
                    { 195, 17, 102 },
                    { 188, 17, 36 },
                    { 179, 16, 56 },
                    { 178, 16, 100 },
                    { 177, 16, 98 },
                    { 149, 14, 66 },
                    { 150, 14, 87 },
                    { 151, 14, 88 },
                    { 152, 14, 10 },
                    { 153, 14, 2 },
                    { 154, 14, 61 },
                    { 155, 14, 89 },
                    { 156, 14, 90 },
                    { 157, 14, 91 },
                    { 158, 14, 20 },
                    { 159, 14, 92 },
                    { 160, 14, 93 },
                    { 161, 14, 60 },
                    { 162, 14, 7 },
                    { 163, 14, 47 },
                    { 164, 14, 94 },
                    { 165, 14, 78 },
                    { 147, 14, 55 },
                    { 91, 11, 53 },
                    { 81, 10, 49 },
                    { 80, 10, 52 },
                    { 23, 3, 8 },
                    { 24, 3, 21 },
                    { 25, 3, 6 },
                    { 26, 3, 22 },
                    { 27, 3, 23 },
                    { 28, 3, 24 },
                    { 29, 3, 12 },
                    { 22, 3, 20 },
                    { 30, 4, 8 },
                    { 32, 4, 14 },
                    { 33, 4, 6 },
                    { 34, 4, 16 },
                    { 35, 4, 1 },
                    { 36, 4, 5 },
                    { 37, 4, 19 },
                    { 38, 4, 7 },
                    { 31, 4, 13 },
                    { 21, 3, 5 },
                    { 20, 3, 7 },
                    { 19, 3, 2 },
                    { 2, 2, 3 },
                    { 3, 2, 4 },
                    { 4, 2, 5 },
                    { 5, 2, 6 },
                    { 6, 2, 7 },
                    { 7, 2, 8 },
                    { 8, 2, 9 },
                    { 9, 2, 10 },
                    { 10, 2, 11 },
                    { 11, 2, 12 },
                    { 12, 2, 13 },
                    { 13, 2, 14 },
                    { 14, 2, 15 },
                    { 15, 2, 16 },
                    { 16, 2, 17 },
                    { 17, 2, 18 },
                    { 18, 2, 19 },
                    { 42, 6, 28 },
                    { 43, 6, 1 },
                    { 44, 6, 29 },
                    { 45, 6, 30 },
                    { 67, 7, 49 },
                    { 82, 9, 35 },
                    { 83, 9, 53 },
                    { 84, 9, 14 },
                    { 85, 9, 38 },
                    { 86, 9, 39 },
                    { 87, 9, 54 },
                    { 88, 9, 32 },
                    { 89, 9, 44 },
                    { 90, 9, 49 },
                    { 73, 10, 36 },
                    { 74, 10, 27 },
                    { 75, 10, 40 },
                    { 76, 10, 42 },
                    { 77, 10, 51 },
                    { 78, 10, 43 },
                    { 79, 10, 47 },
                    { 66, 7, 48 },
                    { 196, 17, 103 },
                    { 65, 7, 47 },
                    { 63, 7, 45 },
                    { 46, 6, 31 },
                    { 47, 6, 32 },
                    { 48, 6, 33 },
                    { 49, 6, 34 },
                    { 50, 7, 35 },
                    { 51, 7, 36 },
                    { 52, 7, 37 },
                    { 53, 7, 27 },
                    { 54, 7, 14 },
                    { 55, 7, 38 },
                    { 56, 7, 39 },
                    { 57, 7, 40 },
                    { 58, 7, 41 },
                    { 59, 7, 42 },
                    { 60, 7, 43 },
                    { 61, 7, 32 },
                    { 62, 7, 44 },
                    { 64, 7, 46 },
                    { 197, 17, 76 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProjectSkills",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
