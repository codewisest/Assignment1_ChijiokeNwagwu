using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// performs four arithmetic operations on an input.
        /// </summary>
        /// <param name="id">GET api/NumberMachine/{id}</param>
        /// <returns>
        /// a number
        /// </returns>
        public int Get(int id)
        {
            return id + 7 * 2 / 4 - 10;
        }
    }
}
