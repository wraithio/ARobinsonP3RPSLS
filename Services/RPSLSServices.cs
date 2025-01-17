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
                    case "rock":
                        return "rock";
                    case "paper":
                        return "paper";
                    case "scissors":
                        return "scissors";
                    case "lizard":
                        return "lizard";
                    case "spock":
                        return "spock";
                    default:
                    break;
                }
        return "Your input is invalid.";
        }
    }
}