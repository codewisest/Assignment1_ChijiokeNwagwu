using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns "Hello world" when it receives a post request
        /// <example>Post api/greeting -> Hello world</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Hello world</returns> 
        public string Post()
        {
            return "Hello World";
        }

        /// <summary>
        /// Returns a string when it receives a get request with a parameter
        /// <example>Get api/greeting/3 -> Greetings to 3 people!</example>
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>A string according to the input number</returns> 
        public string Get(int id)
        {
            return "Greetings to " + id + " people";
        }
    }
}
