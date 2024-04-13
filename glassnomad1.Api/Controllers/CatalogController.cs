using Microsoft.AspNetCore.Mvc;
using glassnomad1.Domain.Catalog;

namespace glassnomad1.Api.Controllers {
    [ApiController]
	[Route("[controller]")]
	public class CatalogController: ControllerBase{
        [HttpGet]
        public IActionResult GetItems(){
            var items =new List<Ites>() {
                new Items("Shirt", "Ohio State Shirt", "Nike", 29.99mm),
                new Items("Shorts", "Ohio State Shorts", "Nike", 49.99mm),
            }
            return Ok(items);
        }
    }
}

//testing