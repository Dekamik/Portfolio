USE Portfolio;

BEGIN TRANSACTION;

DELETE FROM ProjectSkills;
DBCC CHECKIDENT ('Portfolio.dbo.ProjectSkills', RESEED, 0);

DELETE FROM Skills;
DBCC CHECKIDENT ('Portfolio.dbo.Skills', RESEED, 0);

DELETE FROM Projects;
DBCC CHECKIDENT ('Portfolio.dbo.Projects', RESEED, 0);

DELETE FROM Employers;
DBCC CHECKIDENT ('Portfolio.dbo.Employers', RESEED, 0);

ROLLBACK;
--COMMIT;