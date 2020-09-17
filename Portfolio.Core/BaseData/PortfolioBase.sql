use Portfolio

insert into Employers
values (1, 'Adssets', '2014-06-02', '2016-05-04'),
	   (2, 'Cybercom', '2016-05-04', '2016-08-08'),
	   (3, 'SVRVIVE Studios', '2016-08-08', '2018-03-14'),
	   (4, 'Sopra Steria', '2018-03-14', NULL);

insert into Projects
values (1, 'C&C Red Alert 3 - Resurrection (Mod)', 'Music producer', '', 2, '2009-07-01', '2010-04-01', 0, 0, 'Team Vikestart', NULL),
	   (2, 'Adsscore', 'Java Developer', '', 1, '2014-06-02', '2016-05-04', 0, 1, NULL, 1),
	   (3, 'Systems administration', 'Systems Administrator', '', 1, '2014-07-15', '2016-05-04', 0, 1, NULL, 1),
	   (4, 'Data gatherer', 'Java Developer', '', 1, '2014-09-15', '2016-05-04', 0, 1, NULL, 1),
	   (5, 'MetroMaze (Global Gamejam 2016)', 'Defold Developer', '', 2, '2016-01-29', '2016-01-31', 0, 1, NULL, NULL),
	   (6, 'Cards and Loans', 'Java Consultant', '', 1, '2016-05-10', '2016-08-08', 0, 1, 'CrossKey', 2),
	   (7, 'SVRVIVE - The Deus Helix', 'Unity Developer', '', 1, '2016-08-08', '2017-09-15', 0, 1, NULL, 3),
	   (8, 'ZpazeWavez', 'Sound programmer & music producer', '', 2, '2017-01-20', '2017-01-22', 0, 1, NULL, NULL),
	   (9, 'Kartong - Death By Cardboard!', 'AWS Developer', '', 1, '2017-09-01', '2018-03-14', 0, 1, NULL, 3),
	   (10, 'CLASSIFIED PROJECT', 'Unity Developer & Producer', '', 1, '2017-06-05', '2017-10-10', 0, 1, NULL, 3),
	   (11, 'Krystal Kart AR', 'NodeJS Developer', '', 1, '2018-02-10', '2018-03-14', 0, 1, NULL, 3),
	   (12, 'Kammarkollegiets Tolkavropstjänst', 'Full-stack .NET Developer', '', 1, '2018-06-15', '2019-04-11', 1, 1, 'Kammarkollegiet', 4),
	   (13, 'Autonomous Stock Analysis Tool', 'Python Developer', '', 2, '2019-01-15', '2019-08-15', 0, 1, NULL, NULL),
	   (14, 'CLASSIFIED PROJECT', '.NET Developer', '', 1, '2019-04-11', '2019-06-27', 0, 1, 'Rovio Entertainment Corporation', 4),
	   (15, 'Smidas', '.NET Developer', '', 2, '2019-09-15', '2019-12-10', 1, 1, NULL, NULL),
	   (16, 'Dental Care Systems', 'Full-stack .NET Developer', '', 1, '2019-07-15', NULL, 0, 1, 'Tandvårdsenheten Region Västmanland & Region Dalarna', 4),
	   (17, 'Libretto 2.0', 'Full-stack .NET Developer', '', 1, '2020-03-01', '2020-08-14', 0, 1, 'Tandvårdsenheten Region Stockholm', 4);

insert into Technologies
values (1, 'Java'),
	   (2, 'Linux'),
	   (3, 'HTML'),
	   (4, 'CSS'),
	   (5, 'MySQL'),
	   (6, 'GlassFish'),
	   (7, 'Ubuntu'),
	   (8, 'Bash Script');