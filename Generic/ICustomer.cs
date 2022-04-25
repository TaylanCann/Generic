using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface ICustomer
    {
        List<Customer> List();
        Customer Find(int id);
        bool Remove(Customer customer);
    }
}
