using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3chillyController : ControllerBase
    {
        /// <summary>
        /// Calculates the total Scoville heat units based on the provided chili ingredients.
        /// </summary>
        /// <param name="ingreds">Comma-separated string of chili names.</param>
        /// <returns>Total Scoville heat units of the given ingredients.</returns>
        /// <example>
        ///C:\Users\jasha>curl -X GET "https://localhost:7147/api/J3chilly/chillipeppers?ingreds=Poblano%2CCayenne%2CThai%2CPoblano" -H "accept: text/plain"
        /// Response: 118000
        /// 
        /// C:\Users\jasha>curl -X GET "https://localhost:7147/api/J3chilly/chillipeppers?ingreds=Habanero%2CHabanero%2CHabanero%2CHabanero%2CHabanero" -H "accept: text/plain"
        /// Response: 625000
        /// 
        ///C:\Users\jasha>curl -X GET "https://localhost:7147/api/J3chilly/chillipeppers?ingreds=Poblano%2CMirasol%2CSerrano%2CCayenne%2CThai%2CHabanero%2CSerrano" -H "accept: text/plain"
        /// Response: 278500
        /// </example>
        [HttpGet("chillipeppers")]
        public int Chillipeppers(string ingreds)
        {


            int heat = 0;
            string[] subs = ingreds.Split(',');
            //iterate with each chilly name
            foreach (var sub in subs)
            {

                // add SHU based on chilly type
                if (sub == "Mirasol")
                {
                    heat = heat + 6000;
                }
                else if (sub == "Habanero")
                {
                    heat = heat + 125000;
                }
                else if (sub == "Poblano")
                {
                    heat = heat + 1500;
                }
                else if (sub == "Serrano")
                {
                    heat = heat + 15500;
                }
                else if (sub == "Cayenne")
                {
                    heat = heat + 40000;
                }
                else if (sub == "Thai")
                {
                    heat = heat + 75000;
                }
            }
            // return total SHU
            return heat;
        }

    }
}
