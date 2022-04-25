using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    
    public interface ICustomerController : IRepository<Customer> { }
    public interface ICategoryController : IRepository<Category> { }

    public class CustomerManager : ICustomerController
    {
        private static List<Customer> _customers = new List<Customer>() {
    new Customer { Id = 1, FullName = "Serdar YILMAZ", Address = "Kocaeli" },
    new Customer { Id = 2, FullName = "Behzat GÖK", Address = "Sakarya" },
    new Customer { Id = 3, FullName = "Sinem ER", Address = "Bolu" }
    };

        public List<Customer> List() { return _customers; }
        public Customer Find(int id) { return _customers.Find(x => x.Id == id); }
        public bool Remove(Customer customer) { return _customers.Remove(customer); }
    }

    public class CategoryManager : ICategoryController
    {
        private static List<Category> _category = new List<Category>() {
    new Category { Id = 1, Title="Yazılım"},
    new Category { Id = 2, Title="Network"},
    };

        public List<Category> List() { return _category; }
        public Category Find(int id) { return _category.Find(x => x.Id == id); }
        public bool Remove(Category category) { return _category.Remove(category); }
    }
}
