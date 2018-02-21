using BusinessLogic.Controllers;
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

        [HttpGet]        
        public async Task<string> GetCollections() {

            var docController = new DocumentController();
            await docController.Post(new List<KeyValuePair<string, object>>() {
                new KeyValuePair<string, object>("Name","Test"),
                new KeyValuePair<string, object>("Age",18)
            });
           
            return await docController.Get();

        }

    }
}