using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseCrud
{
    public interface ICrudApi<TEntity>
    {
        [HttpPost]
        Task<IActionResult> Create(TEntity entity);

        [HttpPut]
        Task<IActionResult> Update(TEntity entity);

        [HttpDelete, Route("{id}")]
        Task<IActionResult> Delete(int id);
    }
}
