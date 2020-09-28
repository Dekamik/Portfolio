﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Common.Core.Entities;
using Portfolio.Common.Enums;
using Portfolio.Core.Data.Baseline;
using System;

namespace Portfolio.Core.Data.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                ProjectData.CnCRedAlert3ResurrectionMod,
                ProjectData.Adsscore,
                ProjectData.AdssetsSysAdmin,
                ProjectData.DataGatherer,
                ProjectData.MetroMaze,
                ProjectData.CardsAndLoans,
                ProjectData.SvrviveTheDeusHelix,
                ProjectData.ZpazeWavez,
                ProjectData.KartongDeathByCardboard,
                ProjectData.SvrviveClassified1,
                ProjectData.KrystalKartAr,
                ProjectData.KammarkollegietsTolkavropstjänst,
                ProjectData.AutonomousStockAnalysisTool,
                ProjectData.RovioClassified1,
                ProjectData.Smidas,
                ProjectData.DentalCareSystems,
                ProjectData.Libretto2
            );
        }
    }
}
