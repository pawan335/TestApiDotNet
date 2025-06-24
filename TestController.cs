using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading; // Unused import - will be flagged

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
         private static readonly List<string> Products = new List<string>
        {
            "Laptop",
            "Smartphone",
            "Tablet"
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllProducts()
        {
            if (Products.Count == 0)
            {
                // Returns HTTP 404 Not Found if the list is empty
                return NotFound("No products found.");
            }
            if (Products.Count > 0)
            {
                return Ok(Products);
            }
            // Returns HTTP 200 OK with the product list
            return Ok(Products);
        }

    }
   
}
