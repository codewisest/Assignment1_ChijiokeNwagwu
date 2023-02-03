using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns 10 more than the integer input {id}.
        /// <example>GET api/AddTen/10 -> 20</example>
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Ten plus the input</returns> 
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
