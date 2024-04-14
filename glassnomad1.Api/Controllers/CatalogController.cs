using Microsoft.AspNetCore.Mvc;
using glassnomad1.Domain.Catalog;

namespace glassnomad1.Api.Controllers {
    [ApiController]
	[Route("[controller]")]
	public class CatalogController: ControllerBase{
        [HttpGet]
        public IActionResult GetItems(){
            var items =new List<Item>() {
                new Item("Shirt", "Ohio State Shirt", "Nike", 29.99m),
                new Item("Shorts", "Ohio State Shorts", "Nike", 49.99m)
            };
            return Ok(items);
        }
    }
}



