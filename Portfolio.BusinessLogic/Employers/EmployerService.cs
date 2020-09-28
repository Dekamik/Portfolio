using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;
using System.Collections.Generic;

namespace Portfolio.BusinessLogic.Employers
{
    public class EmployerService : IEmployerService
    {
        private readonly IEmployerReadOnlyRepository _repository;

        public EmployerService(IEmployerReadOnlyRepository repository) 
        {
            _repository = repository;
        }

        public IEnumerable<Employer> GetEmployers()
        {
            return _repository.GetAll();
        }
    }
}
