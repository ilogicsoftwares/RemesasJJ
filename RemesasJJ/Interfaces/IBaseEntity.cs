using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasJJ.Interfaces
{
    interface IBaseEntity<T>
    {


        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        
    }
}
