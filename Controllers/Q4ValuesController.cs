using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4ValuesController : ControllerBase
    {

        /// <summary>
        /// Counts the number of parking spaces that were occupied on both yesterday and today.
        /// </summary>
        /// <param name="n">Number of parking spaces</param>
        /// <param name="yesterday">String representing yesterday's parking state (C for occupied, . for empty)</param>
        /// <param name="today">String representing today's parking state (C for occupied, . for empty)</param>
        /// <returns>Count of spaces that were occupied both days</returns>
        /// <example> C:\Users\jasha>curl -X GET "https://localhost:7147/api/Q4Values?n=5&yesterday=CC..C&today=.CC..." -H "accept: text/plain"
        /// OUTPUT 1
        /// C:\Users\jasha>curl -X "GET" "https://localhost:7147/api/Q4Values?n=7&yesterday=CCCCCCC&today=C.C.C.C" -H "accept: text/plain"
        /// OUTPUT 4
        /// </example>
        [HttpGet]
        public int CountConsistentlyOccupiedSpaces(int n, string yesterday, string today)
        {
            int count = 0;// starting count for spaces on both days
            for (int i = 0; i < n; i++)
            {
                // to check space was occupied on both days
                if (yesterday[i] == 'C' && today[i] == 'C')
                {
                    count++;// increment count if occupied on both days
                }
            }
            return count;// return count of spaces occupied on both days
        }
    }
}

    

