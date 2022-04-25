using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface ICategory
    {
        List<Category> List();
        Category Find(int id);
        bool Remove(Category category);
    }
}
