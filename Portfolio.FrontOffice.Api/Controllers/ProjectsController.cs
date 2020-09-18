using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Common.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;
using Portfolio.FrontOffice.Common;
using Portfolio.FrontOffice.Common.Routing;

namespace Portfolio.FrontOffice.Api.Controllers
{
    [Route(ApiRoutes.Projects)]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectReadOnlyRepository _repository;

        public ProjectsController(IProjectReadOnlyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            IQueryable<Project> projects = _repository.GetAll()
                .Include(p => p.Employer)
                .Include(p => p.ProjectSkills)
                    .ThenInclude(ps => ps.Skill)
                .OrderByDescending(p => p.StartDate);
            IEnumerable<ProjectModel> projectModels = GetProjectModels(projects);
            return Ok(projectModels);
        }

        private IEnumerable<ProjectModel> GetProjectModels(IQueryable<Project> projects)
        {
            foreach(var project in projects)
            {
                yield return new ProjectModel
                {
                    Name = project.Name,
                    Role = project.Role,
                    Description = project.Description,
                    Category = project.Category,
                    StartDate = project.StartDate,
                    EndDate = project.EndDate,
                    IsHighlighted = project.IsHighlighted,
                    Show = project.Show,
                    Customer = project.Customer,
                    Employer = project.Employer?.Name,
                    Skills = project.ProjectSkills
                        .Select(ps => ps.Skill.Name)
                        .OrderBy(s => s)
                        .ToArray()
                };
            }
        }
    }
}
