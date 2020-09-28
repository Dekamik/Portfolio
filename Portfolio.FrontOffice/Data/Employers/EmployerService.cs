using Portfolio.Common.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
