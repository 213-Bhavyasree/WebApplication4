using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Product1", "Product2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "This is Products";
        }

        // POST api/<ProductController>
        [HttpPost]
        public string Post()
        {
            return "This is a Post request";
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public string Put()
        {
            return "This is a Put request";
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        public string Delete()
        {
            return "This is a Delete request";
        }
    }
}
