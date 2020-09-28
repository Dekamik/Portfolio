using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.BusinessLogic.Employers
{
    public interface IEmployerService
    {
        IEnumerable<Employer> GetEmployers();
    }
}
