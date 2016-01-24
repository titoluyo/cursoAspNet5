using System;
using aspnet5.Models;
using Microsoft.AspNet.Mvc;

namespace aspnet5.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var model = new CustomerRepository().GetList();
            return View(model);
        }
        // GET: /<controller>/
        public string Sample()
        {
            Cliente item = null;
            string mensaje = $"Hello world {DateTime.Now}, qué es de la vida de {item?.Nombre?.ToUpper()}";
            return mensaje;
        }

        public IActionResult New(int id)
        {
            return View();
        }


        public class  Cliente
        {
            public string Nombre { get; set; } = "Guino Henostroza";
        }
    }
}
