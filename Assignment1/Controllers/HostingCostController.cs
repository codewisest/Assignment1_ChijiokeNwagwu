using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Outputs array of strings when it receives a get request with a parameter.
        /// </summary>
        /// <param name="id">GET api/HostingCost/0</param>
        /// <returns>
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD”
        /// “Total = $6.22 CAD”
        /// </returns>
        public string[] Get(int id)
        {
            const double charge = 5.50;
            int numOfDays = id;
            string currency = " CAD";
            //if(numOfDays < 14)
            //{
            //    fortnight = Math.Ceiling((double)numOfDays / 14);
            //} else
            //{
            //    fortnight= Math.Floor((double)numOfDays / 14);

            //}

            // set value for fortnight
            double fortnight = Math.Ceiling((double)(numOfDays + 1) / 14);

            // calculate sub total
            double subTotal = fortnight * charge;

            // calsulate HST to two significant figures
            double HST = Math.Round(((double)13/100 * subTotal), 2);

            // calculate total to two significant figures
            double total = Math.Round(HST + subTotal, 2);

            // set results into an array of strings
            string[] ans = { fortnight + " fortnights at $" + String.Format("{0:0.00}", charge) + "/FN = $" + String.Format("{0:0.00}", subTotal) + currency,
                "HST 13%" + " = $" + String.Format("{0:0.00}", HST) + currency, "Total = $" + String.Format("{0:0.00}", total) + currency };

            return ans;
        }
    }
}
