using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface IProduct
    {
        List<Product> List();
        Product Find(int id);
        bool Remove(Product product);
    }

    
}
