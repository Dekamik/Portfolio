﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Entities;
using Portfolio.Core.Data.Baseline;

namespace Portfolio.Core.Data.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasData(
                SkillData.JavaEE,
                SkillData.Linux,
                SkillData.HTML,
                SkillData.CSS,
                SkillData.MySQL,
                SkillData.GlassFish,
                SkillData.Ubuntu,
                SkillData.Bash,
                SkillData.SSH,
                SkillData.JavaScript,
                SkillData.AJAX,
                SkillData.AtlassianJira,
                SkillData.EJB,
                SkillData.Git,
                SkillData.GitHub,
                SkillData.JDBC,
                SkillData.JQuery,
                SkillData.JSON,
                SkillData.SQL,
                SkillData.ShellScript,
                SkillData.Python,
                SkillData.NGINX,
                SkillData.BackupRestore,
                SkillData.Cron,
                SkillData.DefoldEngine,
                SkillData.Lua,
                SkillData.GameDesign,
                SkillData.JUnit,
                SkillData.OracleDatabase,
                SkillData.SVN,
                SkillData.Selenium,
                SkillData.Scrum,
                SkillData.AutomatedUITesting,
                SkillData.Jenkins,
                SkillData.AgileDevelopment,
                SkillData.CSharp,
                SkillData.FMOD,
                SkillData.GitLFS,
                SkillData.GitLab,
                SkillData.HTCVive,
                SkillData.NewtonVR,
                SkillData.OculusRift,
                SkillData.Prototyping,
                SkillData.Sourcetree,
                SkillData.SteamVR,
                SkillData.Steamworks,
                SkillData.Unity3D,
                SkillData.Viveport,
                SkillData.VirtualReality,
                SkillData.FLStudio,
                SkillData.ProjectManagement,
                SkillData.VRTK,
                SkillData.AWS,
                SkillData.RESTAPI,
                SkillData.UnitTesting,
                SkillData.BatchScript,
                SkillData.ChaiJS,
                SkillData.DatabaseModeling,
                SkillData.Mocha,
                SkillData.TDD,
                SkillData.NodeJS,
                SkillData.DotNetCore,
                SkillData.AtlassianConfluence,
                SkillData.Bootstrap,
                SkillData.EF,
                SkillData.FluentAssertions,
                SkillData.GitExtensions,
                SkillData.GulpJS,
                SkillData.Less,
                SkillData.LINQ,
                SkillData.MicrosoftVisualStudio,
                SkillData.MVC,
                SkillData.Razor,
                SkillData.RegularExpressions,
                SkillData.SQLServer,
                SkillData.TSQL,
                SkillData.UML,
                SkillData.XUnit,
                SkillData.Stocks,
                SkillData.StockAnalysis,
                SkillData.Pycharm,
                SkillData.Synology,
                SkillData.SynologyDSM,
                SkillData.ValueInvestment,
                SkillData.XPath,
                SkillData.FakeItEasy,
                SkillData.HashiCorpTerraform,
                SkillData.IaC,
                SkillData.OSX,
                SkillData.PostgreSQL,
                SkillData.ReactJS,
                SkillData.Rider,
                SkillData.TeamCity,
                SkillData.Unix,
                SkillData.AzureFunctions,
                SkillData.Curl,
                SkillData.MicrosoftExcel,
                SkillData.DotNetFramework,
                SkillData.WebForms,
                SkillData.AzureDevOps,
                SkillData.ReactRouter,
                SkillData.TypeScript,
                SkillData.ReactHooks,
                SkillData.EFCore,
                SkillData.Docker,
                SkillData.DockerCompose,
                SkillData.DockerHub,
                SkillData.DigitalOcean,
                SkillData.AutomatedBuilds,
                SkillData.Blazor,
                SkillData.ComponentBasedUIDesign,
                SkillData.DomainNameAdministration
            );
        }
    }
}
