using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WCF = ShoppingCartServiceReference;

namespace ShoppingSite.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingRestController : Controller
    {


        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<WCF.ItemDetailsModel>> Get()
        {
            IEnumerable<WCF.ItemDetailsModel> query;
            WCF.IService1 proxy = new WCF.Service1Client();
            var request = await proxy.GetItemDetailsAsync(new WCF.GetItemDetailsRequest());
            query = request.GetItemDetailsResult.ToList();
            proxy = null;

            return query;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]WCF.ItemDetailsModel itemCar)
        {
            return false;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
