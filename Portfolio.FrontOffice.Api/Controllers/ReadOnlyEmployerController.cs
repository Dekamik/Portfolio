using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseCrud;
using Portfolio.Core;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.ReadOnly;
using Portfolio.FrontOffice.Common.Routing;

namespace Portfolio.FrontOffice.Api.Controllers
{
    [Route(ApiRoutes.Employers)]
    [ApiController]
    public class ReadOnlyEmployerController : ReadOnlyApi<Employer, IEmployerReadOnlyRepository, PortfolioDbContext>
    {
        public ReadOnlyEmployerController(IEmployerReadOnlyRepository repository, ILogger<ReadOnlyEmployerController> logger) : base(repository, logger)
        {
        }
    }
}
