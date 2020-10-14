using Portfolio.Core.Entities;
using Portfolio.Common.Enums;
using System;

namespace Portfolio.Core.Data.Baseline
{
    public static class ProjectData
    {
        public static readonly Project CnCRedAlert3ResurrectionMod = new Project
        {
            Id = 1,
            Name = "C&C Red Alert 3 - Resurrection (Mod)",
            Role = "Music producer",
            Description = "",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2009-07-01"),
            EndDate = DateTime.Parse("2010-04-01"),
            IsHighlighted = false,
            Show = false,
            Customer = "Team Vikestart",
            EmployerId = null
        };

        public static readonly Project Adsscore = new Project
        {
            Id = 2,
            Name = "Adsscore",
            Role = "Java Developer",
            Description = "Adsscore is an internal statistics system geared towards professional clients. Through this system the clients could view their Adssets advert's results. As a Java developer Dennis developed new features and maintained the system. He also helped improve the apps performance through quicker response times, which improved the client's user experience. Dennis also maintained the application's infrastructure, namely web servers, application servers and database servers.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2014-06-02"),
            EndDate = DateTime.Parse("2016-05-04"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.Adssets.Id
        };

        public static readonly Project AdssetsSysAdmin = new Project
        {
            Id = 3,
            Name = "Systems administration",
            Role = "Systems Administrator",
            Description = "",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2014-07-15"),
            EndDate = DateTime.Parse("2016-05-04"),
            IsHighlighted = false,
            Show = false,
            Customer = null,
            EmployerId = EmployerData.Adssets.Id
        };

        public static readonly Project DataGatherer = new Project
        {
            Id = 4,
            Name = "Data gatherer",
            Role = "Java Developer",
            Description = "Data gatherer was an application that took raw advertising data from a bunch of servers and then compiled the data for presentation in Adsscore. Above all Dennis contributed with performance improvements as a Java developer and ensured the app could compile more data faster.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2014-09-15"),
            EndDate = DateTime.Parse("2016-05-04"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.Adssets.Id
        };

        public static readonly Project MetroMaze = new Project
        {
            Id = 5,
            Name = "MetroMaze (Global Gamejam 2016)",
            Role = "Defold Developer",
            Description = "MetroMaze is a top-down 2D RPG created during Global Game Jam 2016. In accordance with the theme \"Ritual\", you are a teenager chosen to complete the MetroMaze as your coming of age ritual, solve puzzles and uncover its mysteries. It was made using King's (then beta) game engine Defold. As a developer Dennis created most of the games base functionality in Lua: movement, interaction, text boxes, as well as the logic around graphics, sound and music.",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2016-01-29"),
            EndDate = DateTime.Parse("2016-01-31"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = null
        };

        public static readonly Project CardsAndLoans = new Project
        {
            Id = 6,
            Name = "Cards and Loans",
            Role = "Java Consultant",
            Description = "Cards and Loans is a part of the Internet banking system that concerns application and management of debit and credit cards, and different type of bank loans. As java developer Dennis developed new features and bug-fixes for the Internet banking software. He also helped the company to increase its regression testing coverage in JUnit, which improved the app's stability.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2016-05-10"),
            EndDate = DateTime.Parse("2016-08-08"),
            IsHighlighted = false,
            Show = true,
            Customer = "CrossKey",
            EmployerId = EmployerData.CybercomGroup.Id
        };

        public static readonly Project SvrviveTheDeusHelix = new Project
        {
            Id = 7,
            Name = "SVRVIVE - The Deus Helix",
            Role = "Unity Developer",
            Description = "SVRVIVE - The Deus Helix is the first game from SVRVIVE Studios made in Unity3D. You are Agent Null, an abducted human being who's been hired by aliens to search for pieces of the Deus Helix (the DNA of the universe) on exotic planets. As VR developer, Dennis developed gaming mechanics and puzzles in the game. Dennis was mainly responsible for integrating the game towards SteamVR and Viveport, as well as developing the game's checkpoints, saving and loading and VR menus. He also developed an internal localization solution and implemented it in the game, which meant that the company could translate the game to Chinese for the chinese Viveport market. This localization system also allows people to easily translate several languages and select language in the menu.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2016-08-08"),
            EndDate = DateTime.Parse("2017-09-15"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.SvrviveStudios.Id
        };

        public static readonly Project ZpazeWavez = new Project
        {
            Id = 8,
            Name = "ZpazeWavez",
            Role = "Sound programmer & music producer",
            Description = "ZpazeWavez was a vertical scrolling shoot-ém-up made for Global Game Jam 2017. The game was created within 48 hours and plays much like Ikaruga, where you must match your plasma weapons color with the enemy's color. As sound programmer, Dennis implemented sound in the game with FMOD, an external sound engine for Unity3D. Dennis contributed with basic dynamics for the sound, for example minor changes in pitch in repeating sounds, making them sound more natural.",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2017-01-20"),
            EndDate = DateTime.Parse("2017-01-22"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = null
        };

        public static readonly Project KartongDeathByCardboard = new Project
        {
            Id = 9,
            Name = "Kartong - Death By Cardboard!",
            Role = "AWS Developer",
            Description = "Kartong - Death By Cardboard! is a game created in Unreal Engine 4. You run in a procedurally generated mini maze made of cardboard. Your mission is to avoid traps and crazy, dangerous, and creepy toy experiments in order to get yourself to the mazes exit. The developers that worked on this game asked Dennis of a content delivery system for external partners that the company was talking to. They needed to store images and information on these people on a server outside of the game, and be able to programmatically reach these files from the client-side. Dennis created a simple REST-API on Amazon Web Services, where API Gateway mapped directly against objects in an S3 bucket. Thus the developers could easily load images and JSON-files to this bucket, download these files on-the-fly and use them in-game.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2017-11-01"),
            EndDate = DateTime.Parse("2018-03-14"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.SvrviveStudios.Id
        };

        public static readonly Project SvrviveClassified1 = new Project
        {
            Id = 10,
            Name = "CLASSIFIED PROJECT",
            Role = "Unity Developer & Producer",
            Description = "Anonymous VR game project. As a VR developer and producer, Dennis initally setup the project; he ensured that VRTK was installed, that all VR platforms were configured and worked. He also ensured that you could load and unload levels without disrupting user experience. As producer Dennis was responsible for the projects pre-production. Dennis ensured all key-people in all areas of expertise (art, game design, programming, sound & QA) drew up plans, planned and held meetings, helped when help was needed and reported to management upstairs.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2017-06-05"),
            EndDate = DateTime.Parse("2017-10-10"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.SvrviveStudios.Id
        };

        public static readonly Project KrystalKartAr = new Project
        {
            Id = 11,
            Name = "Krystal Kart AR",
            Role = "NodeJS Developer",
            Description = "SVRVIVE Studios needed a first revision of a backend API for its client-side. The game was based on asynchronous multiplayer, and therefore needed a central API that handled player data. As a NodeJS developer, Dennis recieved the requirements from the developer responsible for the application. Together they defined what data the game needed to store, so Dennis could model and generate the database in MySQL Workbench, and then setup the environment on Amazon Web Services (API Gateway, Lambda & RDBS). After he created the first tests and functions he pushed on with the project. In the end the client could send requests to the server without issues.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2018-02-10"),
            EndDate = DateTime.Parse("2018-03-14"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = EmployerData.SvrviveStudios.Id
        };

        public static readonly Project KammarkollegietsTolkavropstjänst = new Project
        {
            Id = 12,
            Name = "Kammarkollegiets Tolkavropstjänst",
            Role = "Full-stack .NET Developer",
            Description = "A public-sector service for ordering interpretation services. The service is available to Swedish authorities, under the responsibility of the Chamber of Commerce. As a .NET developer, Dennis creates the remaining functionality required to get the first partial delivery of the service through the door. With a focus on what is required in the present, Dennis took on the tasks in the assignment and solved the tasks one by one.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2018-06-15"),
            EndDate = DateTime.Parse("2019-04-11"),
            IsHighlighted = true,
            Show = true,
            Customer = "Kammarkollegiet",
            EmployerId = EmployerData.SopraSteria.Id
        };

        public static readonly Project AutonomousStockAnalysisTool = new Project
        {
            Id = 13,
            Name = "Autonomous Stock Analysis Tool",
            Role = "Python Developer",
            Description = "A private tool for performing technical analyses on entire stock indexes. The analysis is based on a value investment strategy and was run each weekday from Dennis' private server.",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2019-01-15"),
            EndDate = DateTime.Parse("2019-08-15"),
            IsHighlighted = false,
            Show = true,
            Customer = null,
            EmployerId = null
        };

        public static readonly Project RovioClassified1 = new Project
        {
            Id = 14,
            Name = "CLASSIFIED PROJECT",
            Role = ".NET Developer",
            Description = "Dennis was brought into this assignment to substitute a senior DevOps who went on parental leave. Since this role included multiple areas of responsibility, Dennis got to handle and build out the build servers, the cloud infrastructure, as well as the admin tooling for an ongoing game project. After that he helped develop the server application on which the game relied on. In order to bring the project to its next phase, a migration of the server application to virtual servers was necessary. Dennis performed this migration so the project could proceed. Thereafter he helped with improvements of the infrastructure and futher development of the codebase.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2019-04-11"),
            EndDate = DateTime.Parse("2019-06-27"),
            IsHighlighted = false,
            Show = true,
            Customer = "Rovio Entertainment Corporation",
            EmployerId = EmployerData.SopraSteria.Id
        };

        public static readonly Project Smidas = new Project
        {
            Id = 15,
            Name = "Smidas",
            Role = ".NET Developer",
            Description = "Rewrite of the autonomous stock analysis tool to .NET Core and Azure Functions. The solution is hosted on the Azure cloud service and gets called by Dennis' home server through HTTPS. When the service registers the call it performs a technical analysis outlined by post data in JSON format and delivers an excel file which the server stores for later analysis.",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2019-09-15"),
            EndDate = DateTime.Parse("2019-12-10"),
            IsHighlighted = true,
            Show = true,
            Customer = null,
            EmployerId = null
        };

        public static readonly Project DentalCareSystems = new Project
        {
            Id = 16,
            Name = "Dental Care Systems",
            Role = "Full-stack .NET Developer",
            Description = "Making modifications to existing dental care systems, and getting them ready to release for Region Västmanland and Region Dalarna.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2019-07-15"),
            EndDate = null,
            IsHighlighted = false,
            Show = true,
            Customer = "Tandvårdsenheten Region Västmanland & Region Dalarna",
            EmployerId = EmployerData.SopraSteria.Id
        };

        public static readonly Project Libretto2 = new Project
        {
            Id = 17,
            Name = "Libretto 2.0",
            Role = "Full-stack .NET Developer",
            Description = "New version of an existing application, which focuses on a better user experience and better performance.",
            Category = ProjectCategory.Work,
            StartDate = DateTime.Parse("2020-03-01"),
            EndDate = DateTime.Parse("2020-08-14"),
            IsHighlighted = false,
            Show = true,
            Customer = "Tandvårdsenheten Region Stockholm",
            EmployerId = EmployerData.SopraSteria.Id
        };

        public static readonly Project PersonalPortfolio2020 = new Project
        {
            Id = 18,
            Name = "Personal portfolio (dennisvonbargen.com)",
            Role = "Full-stack .NET Developer",
            Description = "Dennis realized his old WiX-portfolio wasn't up to task, so he built a personal portfolio CMS from scratch in .NET Core.\n\nYou're currently looking at the results in your browser. It's a dockerized Blazor Server website that runs on a virtual server that talks to a Postgres database cluster on DigitalOcean.\nThis page is overengineered to showcase Dennis' skills. He's also planning on setting up a backoffice for easier content management.\n\nThe source code is available on GitHub.",
            Category = ProjectCategory.FreeTime,
            StartDate = DateTime.Parse("2020-09-15"),
            EndDate = DateTime.Parse("2020-10-14"),
            IsHighlighted = true,
            Show = true,
            Customer = null,
            EmployerId = null
        };
    }
}
