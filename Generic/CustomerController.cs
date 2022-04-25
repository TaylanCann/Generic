using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class CustomerController : ICustomer
    {
        private static List<Customer> _customers = new List<Customer>() {
        new Customer { Id = 1, FullName = "Serdar YILMAZ", Address = "Kocaeli" },
        new Customer { Id = 2, FullName = "Behzat GÖK", Address = "Sakarya" },
        new Customer { Id = 3, FullName = "Sinem ER", Address = "Bolu" }
    };
        public List<Customer> List()
        {
            return _customers;
        }
        public Customer Find(int id)
        {
            return _customers.Find(x => x.Id == id);
        }
        public bool Remove(Customer customer)
        {
            return _customers.Remove(customer);
        }
    }
}
