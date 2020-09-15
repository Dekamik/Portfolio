﻿using System;

namespace Portfolio.Web.Common
{
    public class EmployerModel
    {
        public int EmployerId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}