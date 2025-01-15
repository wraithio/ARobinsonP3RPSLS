using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonP3RPSLS.Services
{
    public class RPSLSServices
    {
        public string GoRPSLS()
        {
            string[] choices = ["rock","paper","scissors","lizard","spock"];
            Random rng = new Random();
            int randomNum = rng.Next(5);
                switch(choices[randomNum])
                {
                    case "paper":
                        return "The CPU chose paper.";
                    case "scissors":
                        return "The CPU chose scissors.";
                    case "lizard":
                        return "The CPU chose lizard.";
                    case "spock":
                        return "The CPU chose spock.";
                    default:
                    break;
                }
        return "Your input is invalid.";
        }
    }
}