using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonP3RPSLS.Services
{
    public class RPSLSServices
    {
        public string GoRPSLS(string userChoice, string cpuChoice)
        {
            if(userChoice == "rock")
            {
                switch(cpuChoice)
                {
                    case "paper":
                        return "You lose. The CPU chose paper.";
                    case "scissors":
                        return "You win. The CPU chose scissors.";
                    case "lizard":
                        return "You win. The CPU chose lizard.";
                    case "spock":
                        return "You lose. The CPU chose spock.";
                    default:
                    break;
                    ;
                }
            }else if(userChoice == "paper")
                {
                    switch(cpuChoice)
                    {
                        case "rock":
                            return "You win. The CPU chose rock.";
                        case "scissors":
                            return "You lose. The CPU chose scissors.";
                        case "lizard":
                            return "You lose. The CPU chose lizard.";
                        case "spock":
                            return "You win. The CPU chose spock.";
                        default:
                        break;    
                    }
                }else if(userChoice == "scissors")
                    {
                        switch(cpuChoice)
                        {
                            case "rock":
                                return "You lose. The CPU chose rock.";
                            case "paper":
                                return "You win. The CPU chose paper.";
                            case "lizard":
                                return "You win. The CPU chose lizard.";
                            case "spock":
                                return "You lose. The CPU chose spock.";
                            default:
                            break; 
                        }
                    }else if(userChoice == "lizard")
                        {
                            switch(cpuChoice)
                            {
                                case "rock":
                                    return "You lose. The CPU chose rock.";
                                case "paper":
                                    return "You win. The CPU chose paper.";
                                case "scissors":
                                    return "You lose. The CPU chose scissors.";
                                case "spock":
                                    return "You win. The CPU chose spock.";
                                default:
                                break; 
                            }
                        }else if(userChoice == "spock")
                            {
                                switch(cpuChoice)
                                {
                                    case "rock":
                                        return "You win. The CPU chose rock.";
                                    case "paper":
                                        return "You lose. The CPU chose paper.";
                                    case "scissors":
                                        return "You win. The CPU chose scissors.";
                                    case "lizard":
                                        return "You lose. The CPU chose lizard.";
                                    default:
                                    break; 
                                }
                            }
        return "Your input is invalid.";
        }
    }
}