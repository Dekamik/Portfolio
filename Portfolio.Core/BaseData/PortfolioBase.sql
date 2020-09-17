﻿USE Portfolio

BEGIN TRANSACTION;

SET IDENTITY_INSERT Employers ON;
INSERT INTO Employers (Id, Name, StartDate, EndDate)
VALUES (1, 'Adssets', '2014-06-02', '2016-05-04'),
	   (2, 'Cybercom', '2016-05-04', '2016-08-08'),
	   (3, 'SVRVIVE Studios', '2016-08-08', '2018-03-14'),
	   (4, 'Sopra Steria', '2018-03-14', NULL);
SET IDENTITY_INSERT Employers OFF;

SET IDENTITY_INSERT Projects ON;
INSERT INTO Projects (Id, Name, Role, Description, Category, StartDate, EndDate, IsHighlighted, Show, Customer, EmployerId)
VALUES (1, 'C&C Red Alert 3 - Resurrection (Mod)', 'Music producer', '', 2, '2009-07-01', '2010-04-01', 0, 0, 'Team Vikestart', NULL),
	   (2, 'Adsscore', 'Java Developer', 'Adsscore is an internal statistics system geared towards professional clients. Through this system the clients could view their Adssets advert''s results. As a Java developer Dennis developed new features and maintained the system. He also helped improve the apps performance through quicker response times, which improved the client''s user experience. Dennis also maintained the application''s infrastructure, namely web servers, application servers and database servers.', 1, '2014-06-02', '2016-05-04', 0, 1, NULL, 1),
	   (3, 'Systems administration', 'Systems Administrator', '', 1, '2014-07-15', '2016-05-04', 0, 0, NULL, 1),
	   (4, 'Data gatherer', 'Java Developer', 'Data gatherer was an application that took raw advertising data from a bunch of servers and then compiled the data for presentation in Adsscore. Above all Dennis contributed with performance improvements as a Java developer and ensured the app could compile more data faster.', 1, '2014-09-15', '2016-05-04', 0, 1, NULL, 1),
	   (5, 'MetroMaze (Global Gamejam 2016)', 'Defold Developer', 'MetroMaze is a top-down 2D RPG created during Global Game Jam 2016. In accordance with the theme "Ritual", you are a teenager chosen to complete the MetroMaze as your coming of age ritual, solve puzzles and uncover its mysteries. It was made using King''s (then beta) game engine Defold. As a developer Dennis created most of the games base functionality in Lua: movement, interaction, text boxes, as well as the logic around graphics, sound and music.', 2, '2016-01-29', '2016-01-31', 0, 1, NULL, NULL),
	   (6, 'Cards and Loans', 'Java Consultant', 'Cards and Loans is a part of the Internet banking system that concerns application and management of debit and credit cards, and different type of bank loans. As java developer Dennis developed new features and bug-fixes for the Internet banking software. He also helped the company to increase its regression testing coverage in JUnit, which improved the app''s stability.', 1, '2016-05-10', '2016-08-08', 0, 1, 'CrossKey', 2),
	   (7, 'SVRVIVE - The Deus Helix', 'Unity Developer', 'SVRVIVE - The Deus Helix is the first game from SVRVIVE Studios made in Unity3D. You are Agent Null, an abducted human being who''s been hired by aliens to search for pieces of the Deus Helix (the DNA of the universe) on exotic planets. As VR developer, Dennis developed gaming mechanics and puzzles in the game. Dennis was mainly responsible for integrating the game towards SteamVR and Viveport, as well as developing the game''s checkpoints, saving and loading and VR menus. He also developed an internal localization solution and implemented it in the game, which meant that the company could translate the game to Chinese for the chinese Viveport market. This localization system also allows people to easily translate several languages and select language in the menu.', 1, '2016-08-08', '2017-09-15', 0, 1, NULL, 3),
	   (8, 'ZpazeWavez', 'Sound programmer & music producer', 'ZpazeWavez was a vertical scrolling shoot-ém-up made for Global Game Jam 2017. The game was created within 48 hours and plays much like Ikaruga, where you must match your plasma weapons color with the enemy''s color. As sound programmer, Dennis implemented sound in the game with FMOD, an external sound engine for Unity3D. Dennis contributed with basic dynamics for the sound, for example minor changes in pitch in repeating sounds, making them sound more natural.', 2, '2017-01-20', '2017-01-22', 0, 1, NULL, NULL),
	   (9, 'Kartong - Death By Cardboard!', 'AWS Developer', 'Kartong - Death By Cardboard! is a game created in Unreal Engine 4. You run in a procedurally generated mini maze made of cardboard. Your mission is to avoid traps and crazy, dangerous, and creepy toy experiments in order to get yourself to the mazes exit. The developers that worked on this game asked Dennis of a content delivery system for external partners that the company was talking to. They needed to store images and information on these people on a server outside of the game, and be able to programmatically reach these files from the client-side. Dennis created a simple REST-API on Amazon Web Services, where API Gateway mapped directly against objects in an S3 bucket. Thus the developers could easily load images and JSON-files to this bucket, download these files on-the-fly and use them in-game.', 1, '2017-09-01', '2018-03-14', 0, 1, NULL, 3),
	   (10, 'CLASSIFIED PROJECT', 'Unity Developer & Producer', 'Anonymous VR game project. As VR developer, Dennis initally setup the project; he ensured that VRTK was installed, that all VR platforms were configured and worked. He also ensured that you could load and unload levels without disrupting user experience. As producer Dennis was responsible for the projects pre-production. Dennis ensured all key-people in all areas of expertise (art, game design, programming, sound & QA) drew up plans, planned and held meetings, helped when help was needed and reported to management upstairs.', 1, '2017-06-05', '2017-10-10', 0, 1, NULL, 3),
	   (11, 'Krystal Kart AR', 'NodeJS Developer', 'SVRVIVE Studios needed a first revision of a backend API for its client-side. The game was based on asynchronous multiplayer, and therefore needed a central API that handled player data. As a NodeJS developer, Dennis recieved the requirements from the developer responsible for the application. Together they defined what data the game needed to store, so Dennis could model and generate the database in MySQL Workbench, and then setup the environment on Amazon Web Services (API Gateway, Lambda & RDBS). After he created the first tests and functions he pushed on with the project. In the end the client could send requests to the server without issues.', 1, '2018-02-10', '2018-03-14', 0, 1, NULL, 3),
	   (12, 'Kammarkollegiets Tolkavropstjänst', 'Full-stack .NET Developer', 'A public-sector service for ordering interpretation services. The service is available to Swedish authorities, under the responsibility of the Chamber of Commerce. As a .NET developer, Dennis creates the remaining functionality required to get the first partial delivery of the service through the door. With a focus on what is required in the present, Dennis took on the tasks in the assignment and solved the tasks one by one.', 1, '2018-06-15', '2019-04-11', 1, 1, 'Kammarkollegiet', 4),
	   (13, 'Autonomous Stock Analysis Tool', 'Python Developer', 'A private tool for performing technical analyses on entire stock indexes. The analysis is based on a value investment strategy and is run each weekday from Dennis private server.', 2, '2019-01-15', '2019-08-15', 0, 1, NULL, NULL),
	   (14, 'CLASSIFIED PROJECT', '.NET Developer', 'Dennis was brought into this assignment to substitute a senior DevOps who went on parental leave. Since this role included multiple areas of responsibility, Dennis got to handle and build out the build servers, the cloud infrastructure, as well as the admin tooling for an ongoing game project. After that he helped develop the server application on which the game relied on. In order to bring the project to its next phase, a migration of the server application to virtual servers was necessary. Dennis performed this migration so the project could proceed. Thereafter he helped with improvements of the infrastructure and futher development of the codebase.', 1, '2019-04-11', '2019-06-27', 0, 1, 'Rovio Entertainment Corporation', 4),
	   (15, 'Smidas', '.NET Developer', 'Rewrite of the autonomous stock analysis tool to .NET Core and Azure Functions. The solution is hosted on the Azure cloud service and gets called by Dennis'' home server through HTTPS. When the service registers the call it performs a technical analysis outlined by post data in JSON format and delivers an excel file which the server stores for later analysis.', 2, '2019-09-15', '2019-12-10', 1, 1, NULL, NULL),
	   (16, 'Dental Care Systems', 'Full-stack .NET Developer', 'Making modifications to existing dental care systems, and getting them ready to release for Region Västmanland and Region Dalarna.', 1, '2019-07-15', NULL, 0, 1, 'Tandvårdsenheten Region Västmanland & Region Dalarna', 4),
	   (17, 'Libretto 2.0', 'Full-stack .NET Developer', 'New version of an existing application, which focuses on a better user experience and better performance.', 1, '2020-03-01', '2020-08-14', 0, 1, 'Tandvårdsenheten Region Stockholm', 4);
SET IDENTITY_INSERT Projects OFF;

SET IDENTITY_INSERT Skills ON;
INSERT INTO Skills (Id, Name)
VALUES (1, 'Java EE'),
	   (2, 'Linux'),
	   (3, 'HTML'),
	   (4, 'CSS'),
	   (5, 'MySQL'),
	   (6, 'GlassFish'),
	   (7, 'Ubuntu'),
	   (8, 'Bash'),
	   (9, 'SSH'),
	   (10, 'JavaScript'),
	   (11, 'AJAX'),
	   (12, 'Atlassian Jira'),
	   (13, 'EJB (Enterprise JavaBeans)'),
	   (14, 'Git'),
	   (15, 'GitHub'),
	   (16, 'JDBC'),
	   (17, 'jQuery'),
	   (18, 'JSON'),
	   (19, 'SQL'),
	   (20, 'Shell script'),
	   (21, 'Python'),
	   (22, 'NGINX'),
	   (23, 'Backup & restore'),
	   (24, 'Cron'),
	   (25, 'Defold Engine'),
	   (26, 'Lua'),
	   (27, 'Game design'),
	   (28, 'JUnit'),
	   (29, 'Oracle Database'),
	   (30, 'SVN'),
	   (31, 'Selenium'),
	   (32, 'Scrum'),
	   (33, 'Automated UI testing'),
	   (34, 'Jenkins'),
	   (35, 'Agile development'),
	   (36, 'C#'),
	   (37, 'FMOD'),
	   (38, 'Git LFS'),
	   (39, 'GitLab'),
	   (40, 'HTC Vive'),
	   (41, 'NewtonVR'),
	   (42, 'Oculus Rift'),
	   (43, 'Prototyping'),
	   (44, 'Sourcetree'),
	   (45, 'SteamVR'),
	   (46, 'Steamworks'),
	   (47, 'Unity3D'),
	   (48, 'Viveport'),
	   (49, 'Virtual Reality'),
	   (50, 'FL Studio'),
	   (51, 'Project management'),
	   (52, 'VRTK'),
	   (53, 'Amazon Web Services (AWS)'),
	   (54, 'REST API'),
	   (55, 'Unit testing'),
	   (56, 'Batch script'),
	   (57, 'Chai.js'),
	   (58, 'Database modeling'),
	   (59, 'Mocha'),
	   (60, 'Test Driven Development (TDD)'),
	   (61, 'Node.js'),
	   (62, '.NET Core'),
	   (63, 'Atlassian Confluence'),
	   (64, 'Bootstrap'),
	   (65, 'Entity Framework (EF)'),
	   (66, 'FluentAssertions'),
	   (67, 'GitExtensions'),
	   (68, 'gulp.js'),
	   (69, 'Less'),
	   (70, 'LINQ'),
	   (71, 'Microsoft Visual Studio'),
	   (72, 'Model-view-controller (MVC)'),
	   (73, 'Razor (HTML5)'),
	   (74, 'Regular expressions'),
	   (75, 'SQL Server'),
	   (76, 'T-SQL'),
	   (77, 'Unified Modeling Language (UML)'),
	   (78, 'xUnit'),
	   (79, 'Stocks'),
	   (80, 'Stock analysis'),
	   (81, 'Pycharm'),
	   (82, 'Synology'),
	   (83, 'Synology DSM'),
	   (84, 'Value investment'),
	   (85, 'XPath'),
	   (86, 'FakeItEasy'),
	   (87, 'HashiCorp Terraform'),
	   (88, 'Infrastructure as Code (IaC)'),
	   (89, 'OS X'),
	   (90, 'PostgreSQL'),
	   (91, 'React.js'),
	   (92, 'Rider'),
	   (93, 'TeamCity'),
	   (94, 'Unix'),
	   (95, 'Azure Functions'),
	   (96, 'curl'),
	   (97, 'Microsoft Excel'),
	   (98, '.NET Framework'),
	   (99, 'WebForms'),
	   (100, 'Azure DevOps'),
	   (101, 'React Router'),
	   (102, 'TypeScript'),
	   (103, 'React Hooks');
SET IDENTITY_INSERT Skills OFF;

SET IDENTITY_INSERT ProjectSkills ON;
INSERT INTO ProjectSkills (Id, ProjectId, SkillId)
VALUES (1, 2, (SELECT Id FROM Skills WHERE Name = 'Java EE')),
	   (2, 2, (SELECT Id FROM Skills WHERE Name = 'HTML')),
	   (3, 2, (SELECT Id FROM Skills WHERE Name = 'CSS')),
	   (4, 2, (SELECT Id FROM Skills WHERE Name = 'MySQL')),
	   (5, 2, (SELECT Id FROM Skills WHERE Name = 'GlassFish')),
	   (6, 2, (SELECT Id FROM Skills WHERE Name = 'Ubuntu')),
	   (7, 2, (SELECT Id FROM Skills WHERE Name = 'Bash')),
	   (8, 2, (SELECT Id FROM Skills WHERE Name = 'SSH')),
	   (9, 2, (SELECT Id FROM Skills WHERE Name = 'JavaScript')),
	   (10, 2, (SELECT Id FROM Skills WHERE Name = 'AJAX')),
	   (11, 2, (SELECT Id FROM Skills WHERE Name = 'Atlassian Jira')),
	   (12, 2, (SELECT Id FROM Skills WHERE Name = 'EJB (Enterprise JavaBeans)')),
	   (13, 2, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (14, 2, (SELECT Id FROM Skills WHERE Name = 'GitHub')),
	   (15, 2, (SELECT Id FROM Skills WHERE Name = 'JDBC')),
	   (16, 2, (SELECT Id FROM Skills WHERE Name = 'jQuery')),
	   (17, 2, (SELECT Id FROM Skills WHERE Name = 'JSON')),
	   (18, 2, (SELECT Id FROM Skills WHERE Name = 'SQL')),
	   (19, 3, (SELECT Id FROM Skills WHERE Name = 'Linux')),
	   (20, 3, (SELECT Id FROM Skills WHERE Name = 'Ubuntu')),
	   (21, 3, (SELECT Id FROM Skills WHERE Name = 'MySQL')),
	   (22, 3, (SELECT Id FROM Skills WHERE Name = 'Shell script')),
	   (23, 3, (SELECT Id FROM Skills WHERE Name = 'Bash')),
	   (24, 3, (SELECT Id FROM Skills WHERE Name = 'Python')),
	   (25, 3, (SELECT Id FROM Skills WHERE Name = 'GlassFish')),
	   (26, 3, (SELECT Id FROM Skills WHERE Name = 'NGINX')),
	   (27, 3, (SELECT Id FROM Skills WHERE Name = 'Backup & restore')),
	   (28, 3, (SELECT Id FROM Skills WHERE Name = 'Cron')),
	   (29, 3, (SELECT Id FROM Skills WHERE Name = 'Atlassian Jira')),
	   (30, 4, (SELECT Id FROM Skills WHERE Name = 'Bash')),
	   (31, 4, (SELECT Id FROM Skills WHERE Name = 'EJB (Enterprise JavaBeans)')),
	   (32, 4, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (33, 4, (SELECT Id FROM Skills WHERE Name = 'GlassFish')),
	   (34, 4, (SELECT Id FROM Skills WHERE Name = 'JDBC')),
	   (35, 4, (SELECT Id FROM Skills WHERE Name = 'Java EE')),
	   (36, 4, (SELECT Id FROM Skills WHERE Name = 'MySQL')),
	   (37, 4, (SELECT Id FROM Skills WHERE Name = 'SQL')),
	   (38, 4, (SELECT Id FROM Skills WHERE Name = 'Ubuntu')),
	   (39, 5, (SELECT Id FROM Skills WHERE Name = 'Defold Engine')),
	   (40, 5, (SELECT Id FROM Skills WHERE Name = 'Lua')),
	   (41, 5, (SELECT Id FROM Skills WHERE Name = 'Game design')),
	   (42, 6, (SELECT Id FROM Skills WHERE Name = 'JUnit')),
	   (43, 6, (SELECT Id FROM Skills WHERE Name = 'Java EE')),
	   (44, 6, (SELECT Id FROM Skills WHERE Name = 'Oracle Database')),
	   (45, 6, (SELECT Id FROM Skills WHERE Name = 'SVN')),
	   (46, 6, (SELECT Id FROM Skills WHERE Name = 'Selenium')),
	   (47, 6, (SELECT Id FROM Skills WHERE Name = 'Scrum')),
	   (48, 6, (SELECT Id FROM Skills WHERE Name = 'Automated UI testing')),
	   (49, 6, (SELECT Id FROM Skills WHERE Name = 'Jenkins')),
	   (50, 7, (SELECT Id FROM Skills WHERE Name = 'Agile development')),
	   (51, 7, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (52, 7, (SELECT Id FROM Skills WHERE Name = 'FMOD')),
	   (53, 7, (SELECT Id FROM Skills WHERE Name = 'Game design')),
	   (54, 7, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (55, 7, (SELECT Id FROM Skills WHERE Name = 'Git LFS')),
	   (56, 7, (SELECT Id FROM Skills WHERE Name = 'GitLab')),
	   (57, 7, (SELECT Id FROM Skills WHERE Name = 'HTC Vive')),
	   (58, 7, (SELECT Id FROM Skills WHERE Name = 'NewtonVR')),
	   (59, 7, (SELECT Id FROM Skills WHERE Name = 'Oculus Rift')),
	   (60, 7, (SELECT Id FROM Skills WHERE Name = 'Prototyping')),
	   (61, 7, (SELECT Id FROM Skills WHERE Name = 'Scrum')),
	   (62, 7, (SELECT Id FROM Skills WHERE Name = 'Sourcetree')),
	   (63, 7, (SELECT Id FROM Skills WHERE Name = 'SteamVR')),
	   (64, 7, (SELECT Id FROM Skills WHERE Name = 'Steamworks')),
	   (65, 7, (SELECT Id FROM Skills WHERE Name = 'Unity3D')),
	   (66, 7, (SELECT Id FROM Skills WHERE Name = 'Viveport')),
	   (67, 7, (SELECT Id FROM Skills WHERE Name = 'Virtual Reality')),
	   (68, 8, (SELECT Id FROM Skills WHERE Name = 'Unity3D')),
	   (69, 8, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (70, 8, (SELECT Id FROM Skills WHERE Name = 'FL Studio')),
	   (71, 8, (SELECT Id FROM Skills WHERE Name = 'FMOD')),
	   (72, 8, (SELECT Id FROM Skills WHERE Name = 'Game design')),
	   (73, 9, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (74, 9, (SELECT Id FROM Skills WHERE Name = 'Game design')),
	   (75, 9, (SELECT Id FROM Skills WHERE Name = 'HTC Vive')),
	   (76, 9, (SELECT Id FROM Skills WHERE Name = 'Oculus Rift')),
	   (77, 9, (SELECT Id FROM Skills WHERE Name = 'Project management')),
	   (78, 9, (SELECT Id FROM Skills WHERE Name = 'Prototyping')),
	   (79, 9, (SELECT Id FROM Skills WHERE Name = 'Unity3D')),
	   (80, 9, (SELECT Id FROM Skills WHERE Name = 'VRTK')),
	   (81, 9, (SELECT Id FROM Skills WHERE Name = 'Virtual Reality')),
	   (82, 10, (SELECT Id FROM Skills WHERE Name = 'Agile development')),
	   (83, 10, (SELECT Id FROM Skills WHERE Name = 'Amazon Web Services (AWS)')),
	   (84, 10, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (85, 10, (SELECT Id FROM Skills WHERE Name = 'Git LFS')),
	   (86, 10, (SELECT Id FROM Skills WHERE Name = 'GitLab')),
	   (87, 10, (SELECT Id FROM Skills WHERE Name = 'REST API')),
	   (88, 10, (SELECT Id FROM Skills WHERE Name = 'Scrum')),
	   (89, 10, (SELECT Id FROM Skills WHERE Name = 'Sourcetree')),
	   (90, 10, (SELECT Id FROM Skills WHERE Name = 'Virtual Reality')),
	   (91, 11, (SELECT Id FROM Skills WHERE Name = 'Amazon Web Services (AWS)')),
	   (92, 11, (SELECT Id FROM Skills WHERE Name = 'Unit testing')),
	   (93, 11, (SELECT Id FROM Skills WHERE Name = 'Batch script')),
	   (94, 11, (SELECT Id FROM Skills WHERE Name = 'Chai.js')),
	   (95, 11, (SELECT Id FROM Skills WHERE Name = 'Database modeling')),
	   (96, 11, (SELECT Id FROM Skills WHERE Name = 'JSON')),
	   (97, 11, (SELECT Id FROM Skills WHERE Name = 'Mocha')),
	   (98, 11, (SELECT Id FROM Skills WHERE Name = 'MySQL')),
	   (99, 11, (SELECT Id FROM Skills WHERE Name = 'Node.js')),
	   (100, 11, (SELECT Id FROM Skills WHERE Name = 'SQL')),
	   (101, 11, (SELECT Id FROM Skills WHERE Name = 'Test Driven Development (TDD)')),
	   (102, 12, (SELECT Id FROM Skills WHERE Name = '.NET Core')),
	   (103, 12, (SELECT Id FROM Skills WHERE Name = 'AJAX')),
	   (104, 12, (SELECT Id FROM Skills WHERE Name = 'Atlassian Jira')),
	   (105, 12, (SELECT Id FROM Skills WHERE Name = 'Atlassian Confluence')),
	   (106, 12, (SELECT Id FROM Skills WHERE Name = 'Bootstrap')),
	   (107, 12, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (108, 12, (SELECT Id FROM Skills WHERE Name = 'CSS')),
	   (109, 12, (SELECT Id FROM Skills WHERE Name = 'Unit testing')),
	   (110, 12, (SELECT Id FROM Skills WHERE Name = 'Entity Framework (EF)')),
	   (111, 12, (SELECT Id FROM Skills WHERE Name = 'FluentAssertions')),
	   (112, 12, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (113, 12, (SELECT Id FROM Skills WHERE Name = 'GitExtensions')),
	   (114, 12, (SELECT Id FROM Skills WHERE Name = 'HTML')),
	   (115, 12, (SELECT Id FROM Skills WHERE Name = 'gulp.js')),
	   (116, 12, (SELECT Id FROM Skills WHERE Name = 'JavaScript')),
	   (117, 12, (SELECT Id FROM Skills WHERE Name = 'jQuery')),
	   (118, 12, (SELECT Id FROM Skills WHERE Name = 'Less')),
	   (119, 12, (SELECT Id FROM Skills WHERE Name = 'LINQ')),
	   (120, 12, (SELECT Id FROM Skills WHERE Name = 'Microsoft Visual Studio')),
	   (121, 12, (SELECT Id FROM Skills WHERE Name = 'Model-view-controller (MVC)')),
	   (122, 12, (SELECT Id FROM Skills WHERE Name = 'Razor (HTML5)')),
	   (123, 12, (SELECT Id FROM Skills WHERE Name = 'Regular expressions')),
	   (124, 12, (SELECT Id FROM Skills WHERE Name = 'SQL Server')),
	   (125, 12, (SELECT Id FROM Skills WHERE Name = 'T-SQL')),
	   (126, 12, (SELECT Id FROM Skills WHERE Name = 'Unified Modeling Language (UML)')),
	   (127, 12, (SELECT Id FROM Skills WHERE Name = 'xUnit')),
	   (128, 13, (SELECT Id FROM Skills WHERE Name = 'Stocks')),
	   (129, 13, (SELECT Id FROM Skills WHERE Name = 'Stock analysis')),
	   (130, 13, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (131, 13, (SELECT Id FROM Skills WHERE Name = 'GitHub')),
	   (132, 13, (SELECT Id FROM Skills WHERE Name = 'Linux')),
	   (133, 13, (SELECT Id FROM Skills WHERE Name = 'Pycharm')),
	   (134, 13, (SELECT Id FROM Skills WHERE Name = 'Python')),
	   (135, 13, (SELECT Id FROM Skills WHERE Name = 'Regular expressions')),
	   (136, 13, (SELECT Id FROM Skills WHERE Name = 'Selenium')),
	   (137, 13, (SELECT Id FROM Skills WHERE Name = 'Synology')),
	   (138, 13, (SELECT Id FROM Skills WHERE Name = 'Synology DSM')),
	   (139, 13, (SELECT Id FROM Skills WHERE Name = 'Test Driven Development (TDD)')),
	   (140, 13, (SELECT Id FROM Skills WHERE Name = 'Value investment')),
	   (141, 13, (SELECT Id FROM Skills WHERE Name = 'Unified Modeling Language (UML)')),
	   (142, 13, (SELECT Id FROM Skills WHERE Name = 'XPath')),
	   (143, 14, (SELECT Id FROM Skills WHERE Name = '.NET Core')),
	   (144, 14, (SELECT Id FROM Skills WHERE Name = 'Amazon Web Services (AWS)')),
	   (145, 14, (SELECT Id FROM Skills WHERE Name = 'Bash')),
	   (146, 14, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (147, 14, (SELECT Id FROM Skills WHERE Name = 'Unit testing')),
	   (148, 14, (SELECT Id FROM Skills WHERE Name = 'FakeItEasy')),
	   (149, 14, (SELECT Id FROM Skills WHERE Name = 'FluentAssertions')),
	   (150, 14, (SELECT Id FROM Skills WHERE Name = 'HashiCorp Terraform')),
	   (151, 14, (SELECT Id FROM Skills WHERE Name = 'Infrastructure as Code (IaC)')),
	   (152, 14, (SELECT Id FROM Skills WHERE Name = 'JavaScript')),
	   (153, 14, (SELECT Id FROM Skills WHERE Name = 'Linux')),
	   (154, 14, (SELECT Id FROM Skills WHERE Name = 'Node.js')),
	   (155, 14, (SELECT Id FROM Skills WHERE Name = 'OS X')),
	   (156, 14, (SELECT Id FROM Skills WHERE Name = 'PostgreSQL')),
	   (157, 14, (SELECT Id FROM Skills WHERE Name = 'React.js')),
	   (158, 14, (SELECT Id FROM Skills WHERE Name = 'Shell script')),
	   (159, 14, (SELECT Id FROM Skills WHERE Name = 'Rider')),
	   (160, 14, (SELECT Id FROM Skills WHERE Name = 'TeamCity')),
	   (161, 14, (SELECT Id FROM Skills WHERE Name = 'Test Driven Development (TDD)')),
	   (162, 14, (SELECT Id FROM Skills WHERE Name = 'Ubuntu')),
	   (163, 14, (SELECT Id FROM Skills WHERE Name = 'Unity3D')),
	   (164, 14, (SELECT Id FROM Skills WHERE Name = 'Unix')),
	   (165, 14, (SELECT Id FROM Skills WHERE Name = 'xUnit')),
	   (166, 15, (SELECT Id FROM Skills WHERE Name = '.NET Core')),
	   (167, 15, (SELECT Id FROM Skills WHERE Name = 'Stocks')),
	   (168, 15, (SELECT Id FROM Skills WHERE Name = 'Stock analysis')),
	   (169, 15, (SELECT Id FROM Skills WHERE Name = 'Azure Functions')),
	   (179, 15, (SELECT Id FROM Skills WHERE Name = 'curl')),
	   (180, 15, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (181, 15, (SELECT Id FROM Skills WHERE Name = 'GitHub')),
	   (182, 15, (SELECT Id FROM Skills WHERE Name = 'Microsoft Excel')),
	   (183, 15, (SELECT Id FROM Skills WHERE Name = 'Regular expressions')),
	   (184, 15, (SELECT Id FROM Skills WHERE Name = 'Value investment')),
	   (185, 15, (SELECT Id FROM Skills WHERE Name = 'XPath')),
	   (186, 16, (SELECT Id FROM Skills WHERE Name = '.NET Framework')),
	   (187, 16, (SELECT Id FROM Skills WHERE Name = 'Azure DevOps')),
	   (188, 16, (SELECT Id FROM Skills WHERE Name = 'Batch script')),
	   (189, 16, (SELECT Id FROM Skills WHERE Name = 'Unit testing')),
	   (190, 16, (SELECT Id FROM Skills WHERE Name = 'FakeItEasy')),
	   (191, 16, (SELECT Id FROM Skills WHERE Name = 'Microsoft Visual Studio')),
	   (192, 16, (SELECT Id FROM Skills WHERE Name = 'SQL Server')),
	   (193, 16, (SELECT Id FROM Skills WHERE Name = 'T-SQL')),
	   (194, 16, (SELECT Id FROM Skills WHERE Name = 'xUnit')),
	   (195, 17, (SELECT Id FROM Skills WHERE Name = '.NET Core')),
	   (196, 17, (SELECT Id FROM Skills WHERE Name = 'Azure DevOps')),
	   (197, 17, (SELECT Id FROM Skills WHERE Name = 'C#')),
	   (198, 17, (SELECT Id FROM Skills WHERE Name = 'Git')),
	   (199, 17, (SELECT Id FROM Skills WHERE Name = 'GitExtensions')),
	   (200, 17, (SELECT Id FROM Skills WHERE Name = 'React Hooks')),
	   (201, 17, (SELECT Id FROM Skills WHERE Name = 'React Router')),
	   (202, 17, (SELECT Id FROM Skills WHERE Name = 'Scrum')),
	   (203, 17, (SELECT Id FROM Skills WHERE Name = 'SQL Server')),
	   (204, 17, (SELECT Id FROM Skills WHERE Name = 'TypeScript')),
	   (205, 17, (SELECT Id FROM Skills WHERE Name = 'Entity Framework (EF)')),
	   (206, 17, (SELECT Id FROM Skills WHERE Name = 'T-SQL')),
	   (207, 16, (SELECT Id FROM Skills WHERE Name = 'WebForms'));
SET IDENTITY_INSERT ProjectSkills OFF;

ROLLBACK;
--COMMIT;
