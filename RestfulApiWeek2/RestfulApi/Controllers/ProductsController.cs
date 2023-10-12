using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RestfulApi.Application.Services;
using RestfulApi.Base.Models;
using Serilog;

namespace RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
        
    {
        private readonly FakeService fakeService;
        
        private static readonly List<Product> Products = new List<Product>
        {
            new Product {
                Id = 1,
                Title = "IPhone",
                Price = 300
            },
            new Product {
                Id = 2,
                Title = "Macbook",
                Price = 500
            }
        };
        // Fake service dependency injection
        public ProductsController(FakeService fakeService)
        {
            this.fakeService = fakeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            Log.Information("GetAll executed.");
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Log.Information("GetById executed.");
            var product = Products.Find(x => x.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        [HttpPost]
        public IActionResult InsertProduct([FromBody] Product product)
        {
            Log.Information("InsertProduct executed.");
            Products.Insert(Products.Count, product);
            return Created($"Created Product {product.Id}",product);
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            Log.Information("UpdateProduct executed.");
            var record = Products.Find(x => x.Id == product.Id);
            if(record == null)
            {
                return NotFound();
            }
            else
            {
                record.Price = product.Price;
                record.Title = product.Title;
                return Ok(record);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateProductPatch(int id,[FromBody] JsonPatchDocument<Product> document)
        {
            Log.Information("UpdateProductPatch executed.");
            var product = Products.Find(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                document.ApplyTo(product,ModelState);
                return Ok(product);
            }
        }

        [HttpDelete()]
        public IActionResult DeleteProduct([FromQuery] int id)
        {
            Log.Information("DeleteProduct executed.");
            var record = Products.Find(x => x.Id == id);
            Products.Remove(record);
            return Ok(true);
        }
    }
}
