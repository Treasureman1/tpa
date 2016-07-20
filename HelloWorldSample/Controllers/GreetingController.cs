using HelloWorldSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldSample.Controllers
{
    public class GreetingController : ApiController
    {
        private List<Greeting> greetings = new List<Greeting>()
        {
            new Greeting {ID = 1, Message = "Hello World" }
        };
        public string Get()
        {
            return "Hello World";
            
        }
        public IHttpActionResult Get(int id)
        {
            var greeting = greetings.Where(x => x.ID == id);
            if (greeting == null)
                return NotFound();
            return Ok(greeting);
        }

    }
}
