using Microsoft.AspNetCore.Mvc;
using glassnomad1.Domain.Catalog;

namespace glassnomad1.Api.Controllers {
    [ApiController]
	[Route("[controller]")]
	public class CatalogController: ControllerBase{
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello World!");
        }
    }
}