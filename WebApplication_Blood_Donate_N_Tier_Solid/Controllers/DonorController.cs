using BLL_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_Blood_Donate_N_Tier_Solid.Controllers
{
    public class DonorController : ApiController
    {
        [Route("api/donors")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data = DonorService.GetDonors();
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
    }
}
