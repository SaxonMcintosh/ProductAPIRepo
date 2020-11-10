using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Pasketti and Yeetballs", Category = "Grockeries", Price = 100 },
            new Product { Id = 2, Name = "Yo-yo Ma", Category = "Cellists", Price = 50 },
            new Product { Id = 3, Name = "Mjolnir", Category = "Tangible Metaphors", Price = 80.75M }
        };

        public ProductsController() 
        { 
        
        }

        public ProductsController(Product[] products) 
        { 
            this.products = products; 
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}