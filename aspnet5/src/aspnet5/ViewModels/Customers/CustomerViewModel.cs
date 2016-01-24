using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet5.ViewModels.Customers
{
    public class CustomerViewModel
    {
        public string Ruc { get; set; }
        [Display(Name = "Razón Social")]
        public string Name { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }
        public bool IsEnabled { get; set; }
    }
}
