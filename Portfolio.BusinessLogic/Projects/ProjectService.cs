using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;

namespace Portfolio.BusinessLogic.Projects
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectReadOnlyRepository _repository;

        public ProjectService(IProjectReadOnlyRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProjectModel> GetProjects()
        {
            IQueryable<Project> projects = _repository.GetAll()
                .Include(p => p.Employer)
                .Include(p => p.ProjectSkills)
                    .ThenInclude(ps => ps.Skill)
                .OrderByDescending(p => p.StartDate);
            IEnumerable<ProjectModel> projectModels = GetProjectModels(projects);
            return projectModels;
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
