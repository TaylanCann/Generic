using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface IRepository<T> where T : class, IEntity
    {
        List<T> List();
        T Find(int id);
        bool Remove(T entity);
    }
}
