using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using HelloWorldSample.Models;

namespace HelloWorldSample.Controllers
{
    public class SimpleTestController : ApiController
    {
        List<Greeting> greetings = new List<Greeting>();
        private SimpleTestController testGreetings;
        private object testGreetings1;

        public SimpleTestController() { }

        public SimpleTestController(object testGreetings1)
        {
            this.testGreetings1 = testGreetings1;
        }

        public SimpleTestController(SimpleTestController testGreetings)
        {
            this.testGreetings = testGreetings;
        }

        public SimpleTestController(List<Greeting> greetings)
        {
            this.greetings = greetings;
        }

        public IEnumerable<Greeting> GetAllGreetings()
        {
            return greetings;
        }

        public async Task<IEnumerable<Greeting>> GetAllGreetingsAsync()
        {
            return await Task.FromResult(GetAllGreetings());
        }

        public IHttpActionResult GetGreeting(int id)
        {
            var greeting = greetings.FirstOrDefault((p) => p.ID == id);
            if (greeting == null)
            {
                return NotFound();
            }
            return Ok(greeting);
        }

        public async Task<IHttpActionResult> GetGreetingAsync(int id)
        {
            return await Task.FromResult(GetGreeting(id));
        }
    }
}
