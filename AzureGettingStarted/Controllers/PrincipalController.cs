using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureGettingStarted.Controllers
{
    public class PrincipalController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
