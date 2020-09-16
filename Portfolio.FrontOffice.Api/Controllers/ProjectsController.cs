using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Repositories.ReadOnly;
using Portfolio.FrontOffice.Common.Routing;

namespace Portfolio.FrontOffice.Api.Controllers
{
    [Route(ApiRoutes.Projects)]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectReadOnlyRepository
    }
}
