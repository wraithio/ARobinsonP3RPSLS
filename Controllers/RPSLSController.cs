using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ARobinsonP3RPSLS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace ARobinsonP3RPSLS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RPSLSServices _rpslsServices;

        public RPSLSController(RPSLSServices rpslsServices)
        {
            _rpslsServices = rpslsServices;
        }

        [HttpGet]
        [Route("GoRPSLS")]

        public string GoRPSLS()
        {
            return _rpslsServices.GoRPSLS();     
        }

       
    }
}