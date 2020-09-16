using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Common.Api.BaseCrud
{
    interface IReadOnlyApi
    {
        [HttpGet, Route("{id}")]
        IActionResult Get(int id);

        [HttpGet]
        IActionResult GetAll();
    }
}
