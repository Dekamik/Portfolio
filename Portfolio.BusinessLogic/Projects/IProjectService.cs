using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.BusinessLogic.Projects
{
    public interface IProjectService
    {
        IEnumerable<ProjectModel> GetProjects();
    }
}
