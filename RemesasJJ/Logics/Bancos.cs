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
    public class Bancos : BaseRepository, IBaseEntity<bancos>
    {
        public void Delete(int id)
        {
            var entity = context.bancos.Find(id);
            context.bancos.Remove(entity);
        }

        public IEnumerable<bancos> GetAll()
        {
            var lista = context.bancos.ToList();
            return lista;
        }
        public IEnumerable<bancosempre> GetAllEmpre()
        {
            var lista = context.bancosempre.ToList();
            return lista;
        }

        public bancos GetByID(int id)
        {
            var entity = context.bancos.FirstOrDefault(x => x.id == id);
            return entity;
        }
        public bancosempre GetEmpreByID(int id)
        {
            var entity = context.bancosempre.FirstOrDefault(x => x.id == id);
            return entity;
        }

        public void Insert(bancos entity)
        {
            context.bancos.Add(entity);
        }

        public void Update(bancos entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
