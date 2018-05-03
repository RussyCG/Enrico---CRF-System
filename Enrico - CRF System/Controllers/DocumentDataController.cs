using BusinessLogic.Controllers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Enrico___CRF_System.Controllers
{
    public class BaseController : ApiController
    {

        [HttpPost]        
        public async Task<string> GetCollections([FromBody]JToken body) {

            var docController = new DocumentController();
            await docController.POST(body.ToString());
           
            return await docController.Get();

        }

    }
}