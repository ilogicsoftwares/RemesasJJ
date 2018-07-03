using RemesasJJ.Interfaces;
using RemesasJJ.Repositorys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasJJ.Logics
{
    public class Usuarios : BaseRepository, IBaseEntity<users>
    {
        public void Delete(int id)
        {
            var entity = context.users.Find(id);
            context.users.Remove(entity);
        }

        public IEnumerable<users> GetAll()
        {
            var lista = context.users.ToList();
            return lista;
        }
       

        public users GetByID(int id)
        {
            var entity = context.users.FirstOrDefault(x => x.id == id);
            return entity;
        }
      
        public void Insert(users entity)
        {
            context.users.Add(entity);
        }

        public void Update(users entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
