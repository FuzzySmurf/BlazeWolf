using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace BlazeWolf.Controllers.API
{
    [Route("api/DataRequests")]
    public class NightBear : Controller
    {
        [HttpGet("/HighScore")]
        public JsonResult Get() {
            return Json(new {name = "test"});
        }

        [HttpPost("PostData")]
        public JsonResult Post([FromBody]string name)
        {
            if (ModelState.IsValid) {
                Response.StatusCode = (int) HttpStatusCode.Created;
                return Json(true);
            }
            Response.StatusCode = (int) HttpStatusCode.BadRequest;
            return Json(false);
        }
    }
}
