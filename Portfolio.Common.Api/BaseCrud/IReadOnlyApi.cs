using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseCrud
{
    interface IReadOnlyApi
    {
        [HttpGet, Route("{id}")]
        Task<IActionResult> Get(int id);

        [HttpGet]
        IActionResult GetAll();
    }
}
