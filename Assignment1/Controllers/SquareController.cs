using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the squre of the input {id}.
        /// <example>GET api/AddTen/4 -> 16</example>
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>square of the input</returns> 
        public int Get(int id)
        {
            return id * id;
        }
    }
}
