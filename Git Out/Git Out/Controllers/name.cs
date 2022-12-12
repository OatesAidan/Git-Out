using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Git_Out.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //Aidan Oates
    public class name : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var name = new NameOutClass();
            name.name = "Aidan Oates";
            return Ok(name); 
        }
    }
}
