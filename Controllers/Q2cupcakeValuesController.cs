using System.Numerics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2cupcakeValuesController : ControllerBase
    {
        /// <summary>
        /// This endpoint calculates how many cupcakes will be left over 
        /// after distributing one cupcake to each of the 28 students in a class.
        /// regular holds 8 and small holds 3 cupcakes.
        /// </summary>
        /// <param name="regular"></param>
        /// <param name="small"></param>
        /// In this string represents the number of leftout cupcakes after distributing one cupcake to each student. 
        /// <returns>
        ///  A string represents the number of leftout cupcakes after distributing one cupcake to each student
        /// If the number of cupcakes is less than 28 then the output will be 0.
        /// </returns>
        /// <example>
        /// C:\Users\jasha>curl -X POST "https://localhost:7147/api/cupcakeValues/cupcake?regular=2&small=5" -H "accept: text/plain" -d ""
        /// output :3
        /// C:\Users\jasha>curl -X POST "https://localhost:7147/api/cupcakeValues/cupcake?regular=2&small=4" -H "accept: text/plain" -d ""
        /// output:0
        ///  </example>
        //
        [HttpPost(template:"cupcake")]
        public string cupcakes(int regular, int small)

        { //Total number of cupcakes on input values
            int calculate = regular * 8 + small * 3;
            // minus the student to get the leftout cupcakes
            int leftout = calculate - 28;
            // return the leftout cupcakes
            return leftout.ToString();
        }
    }

        }
