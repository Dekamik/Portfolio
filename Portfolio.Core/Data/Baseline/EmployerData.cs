using Portfolio.Core.Entities;
using System;

namespace Portfolio.Core.Data.Baseline
{
    public static class EmployerData
    {
        public static readonly Employer Adssets = new Employer
        {
            Id = 1,
            Name = "Adssets",
            StartDate = DateTime.Parse("2014-06-02"),
            EndDate = DateTime.Parse("2016-05-04"),
            EmployerDescription = "Adssets is a small company that creates and serves rich-media advertisements on web publications.",
            RoleDescription = "With this employment, Dennis was thrust into the programming world with a bang. Due to the company's small size, Dennis seized the opportunity to get busy working with several apps, as well as the server infrastructure that ran the apps."
        };

        public static readonly Employer CybercomGroup = new Employer
        {
            Id = 2,
            Name = "Cybercom Group",
            StartDate = DateTime.Parse("2016-05-04"),
            EndDate = DateTime.Parse("2016-08-08"),
            EmployerDescription = "Cybercom Group is a swedish IT-consultancy firm.",
            RoleDescription = "Dennis was briefly assigned to CrossKey as a Java consultant, where he helped the Cards and Loans team develop new functionality and create regression tests with Selenium, to ensure web-flows work as intended."
        };

        public static readonly Employer SvrviveStudios = new Employer
        {
            Id = 3,
            Name = "SVRVIVE Studios",
            StartDate = DateTime.Parse("2016-08-08"),
            EndDate = DateTime.Parse("2018-03-14"),
            EmployerDescription = "SVRVIVE Studios (now Antler Interactive) is a small game studio which was initially focused on VR gaming. The studio has created games like SVRVIVE - The Deus Helix, Kartong - Death By Cardboard! and Krystal Kart AR.",
            RoleDescription = "As a VR-developer, Dennis helped finish and release SVRVIVE Studios first game (SVRVIVE - The Deus Helix) and helped bring the game to the chinese markets through Viveport. Additionally, since the company was so small, Dennis took the opportunity to handle much of the studios IT-infrastructure and also tried a short tenure as a producer for an unreleased game."
        };

        public static readonly Employer SopraSteria = new Employer
        {
            Id = 4,
            Name = "Sopra Steria",
            StartDate = DateTime.Parse("2018-03-14"),
            EndDate = null,
            EmployerDescription = "Sopra Steria is a large multi-national IT-consultancy firm based in France.",
            RoleDescription = "As a full-stack .NET consultant, Dennis has been involved in several projects, both in-house and on-site, for customers like Kammarkollegiet, Rovio Entertainment (famous for Angry Birds) and Tandvårdsförvaltningen Region Stockholm, Region Västmanland and Region Dalarna. Dennis has also done lectures for Sopra Sterias graduates within Unity3D programming, and Test Driven Development (TDD)."
        };
    }
}
