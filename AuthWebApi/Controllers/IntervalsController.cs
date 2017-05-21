using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AuthWebApi.Models;

namespace AuthWebApi.Controllers
{
    public class IntervalsController : ApiController
    {
        [Route("intervals")]
        [HttpGet]
        public IntervalsResponse LogIn()
        {
            return new IntervalsResponse();
        }
    }
}
