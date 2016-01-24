using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using aspnet5.ViewModels.Catalog;
using Microsoft.AspNet.Mvc;

namespace aspnet5.Controllers
{
    [Route("api/[controller]")]
    public class ProductRestController : Controller
    {
        private IList<ProductViewModel> producsList;

        public ProductRestController()
        {
            producsList = new List<ProductViewModel>();
            producsList.Add(new ProductViewModel { Id = 1, Description = "Surface Pro 2" });
            producsList.Add(new ProductViewModel { Id = 2, Description = "Mouse MS Wireless" });
            producsList.Add(new ProductViewModel { Id = 3, Description = "KB MS Wireles" });
            producsList.Add(new ProductViewModel { Id = 4, Description = "Surface Pro 3" });
            producsList.Add(new ProductViewModel { Id = 5, Description = "Surface Boot Pro" });
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            return this.producsList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ProductViewModel Get(int id)
        {
            var producItem = this.producsList.FirstOrDefault(i => i.Id == id);
            return producItem;
        }

        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ProductViewModel product)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                // falta invocar al componente de negocio realice el registro
                response = new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
            {
                response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return response;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public HttpResponseMessage Put(int id, [FromBody]ProductViewModel product)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                // falta invocar al componente de negocio realice el registro
                response = new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
            {
                response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return response;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.MovedPermanently);
        }
    }
}
