using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1_problem_Deliv_e_droidController : ControllerBase
    {
        [HttpPost(template: "j1deliveroid")]
        public int J1_problem_Deliv_e_droid(int packageDelivery, int collisions)

        {
            /// <summary>
            /// It  calculates the final score in the Deliv-e-droid game based on packages delivered and collisions.
            /// </summary>
            /// <param name="packageDelivery">The number of packages successfully delivered.</param>
            /// <param name="collisions">The number of times the deliveroid collided with obstacles.</param>
            /// <returns>The final score calculated based on the given inputs with collision and package delivery.</returns>
            /// <example>
            /// input C: \Users\jasha > curl - X POST "https://localhost:7147/api/J1_problem_Deliv_e_droid/j1deliveroid?packageDelivery=5&collisions=2" - H "accept: text/plain" - d ""
            ///output: 730
            /// input:C:\Users\jasha>curl -X POST "https://localhost:7147/api/J1_problem_Deliv_e_droid/j1deliveroid?packageDelivery=0&collisions=10" -H "accept: text/plain" -d ""
            /// output :-100
            /// input:C:\Users\jasha>curl -X POST "https://localhost:7147/api/J1_problem_Deliv_e_droid/j1deliveroid?packageDelivery=2&collisions=3" -H "accept: text/plain" -d ""
            /// output:70
            /// </example>


            int score = (packageDelivery * 50) - (collisions * 10);
            if (packageDelivery > collisions)
            {
                score += 500;
            }

            return score;
        }
    }

}






