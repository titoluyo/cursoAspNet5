using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet5.ViewModels.Customers;

namespace aspnet5.Models
{
    public class CustomerRepository
    {
        public IEnumerable<CustomerViewModel> GetList()
        {
            IList<CustomerViewModel> list = new List<CustomerViewModel>();
            list.Add(new CustomerViewModel { Ruc = "1234", Name = "Guino Henostroza", Email = "guino@mail.com" });
            list.Add(new CustomerViewModel { Ruc = "2345", Name = "Javier Sologorre", Email = "javier@mail.com" });
            list.Add(new CustomerViewModel { Ruc = "3456", Name = "Sandra Romero", Email = "sandra@mail.com" });
            list.Add(new CustomerViewModel { Ruc = "3456", Name = "Bety aaa", Email = "bety@mail.com" });
            list.Add(new CustomerViewModel { Ruc = "3456", Name = "Oscar Polo", Email = "oscar@mail.com", IsEnabled = true});
            list.Add(new CustomerViewModel { Ruc = "4567", Name = "Tito", Email = "tito@mail.com" });

            return list;
        }
    }
}
