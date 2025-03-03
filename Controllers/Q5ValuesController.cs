using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5ValuesController : ControllerBase
    {
        /// <summary>
        /// Processes a sequence of harp tuning instructions and formats them for better readability.
        /// It replaces '+' with "tighten" and '-' with "loosen", then splits instructions based on numbers.
        /// </summary>
        /// <param name="iQuery">A string containing tuning instructions in the format: 
        /// uppercase letters (strings), followed by '+' or '-', followed by a positive integer.</param>
        /// <returns>
        /// A formatted string where each tuning instruction is displayed on a new line, 
        /// with clear separation between string names, action (tighten/loosen), and turn count.
        /// </returns>
        /// <example>
        /// input- AFB+8HC-4
        /// output- AFB tighten 8 HC loosen 4
        ///  
        /// </example>
        HttpGET["Turnningharp"]
            public string Turnningharp(string input iQuery)
            string input = iQuery;// "AFB+8SC-4H  and AFB+8SC-4H-2GDPE+9
        string changedinput = "";
        string message = "";
        List<string> userinputwords = new List<string>();

        foreach(char currentchar in input)
            {
            if (currentchar=="+")
            {
            changedinput+="tighten";
             } else if (currentchar=="-")
               changedinput+="loosen";
        else
        {changedinput+=currentchar;

            {
        // how can I split before every digit and store the part in a list 

    }

