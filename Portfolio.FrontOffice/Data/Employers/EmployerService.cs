using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;
using System.Collections.Generic;

namespace Portfolio.FrontOffice.Data.Employers
{
    public class EmployerService
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
