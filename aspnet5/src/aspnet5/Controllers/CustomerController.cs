using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnet5.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            Cliente item = null;
            string mensaje = $"Hello world {DateTime.Now}, qué es de la vida de {item?.Nombre?.ToUpper()}";
            return "Hello World";
        }


        public class  Cliente
        {
            public string Nombre { get; set; } = "Guino Henostroza";
        }
    }
}
