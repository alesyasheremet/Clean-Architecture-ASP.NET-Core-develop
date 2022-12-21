using CustomerData.Application.Features.Categories.Commands.CreateCategory;
using CustomerData.Application.Features.Categories.Queries.GetCategoriesList;
using CustomerData.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using CustomerData.Transaction.Api.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerData.Transaction.Api.Category.v1
{
    public class CategoryController : BaseController
    {

        [HttpGet("all", Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await Mediator.Send(new GetCategoriesListQuery());
            return Ok(dtos);
        }

        [Authorize]
        [HttpGet("allwithevents", Name = "GetCategoriesWithEvents")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryEventListVm>>> GetCategoriesWithEvents(bool includeHistory)
        {
            GetCategoriesListWithEventsQuery getCategoriesListWithEventsQuery = new GetCategoriesListWithEventsQuery() { IncludeHistory = includeHistory };

            var dtos = await Mediator.Send(getCategoriesListWithEventsQuery);
            return Ok(dtos);
        }

        [Authorize]
        [HttpPost(Name = "AddCategory")]
        public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await Mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
