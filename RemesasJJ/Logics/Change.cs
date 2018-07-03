using RemesasJJ.Interfaces;
using RemesasJJ.Repositorys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasJJ.Logics
{
    public class Change : BaseRepository, IBaseEntity<cambio>
    {
        public void Delete(int id)
        {
            var entity = context.cambio.Find(id);
            context.cambio.Remove(entity);
        }

        public IEnumerable<cambio> GetAll()
        {
            var lista = context.cambio.ToList();
            return lista;
        }

        public cambio GetByID(int id)
        {
            var entity = context.cambio.FirstOrDefault(x => x.id == id);
            return entity;
        }
        public cambio GetActualChange() {

            var fecha = DateTime.Now;
            var cambio = context.cambio.Where(x => x.fecha >= fecha).OrderByDescending(x=>x.fecha).FirstOrDefault();

            if (cambio == null)
            {
               cambio= context.cambio.ToList().Last();
            }
            return cambio;

        }
        public cambio GetActualChange(DateTime date)
        {

            var fecha = date;
            var cambio = context.cambio.ToList().Where(x => x.fecha.Value.Date == fecha.Date).OrderByDescending(x => x.fecha).FirstOrDefault();

            if (cambio == null)
            {
                cambio = context.cambio.ToList().Last();
            }
            return cambio;

        }

        public void Insert(cambio entity)
        {
            context.cambio.Add(entity);
        }
        public IEnumerable<cambio> GetByEstatus(int? estatus)
        {

            var entity = context.cambio.Where(x => x.estatus==estatus);
            return entity;
        }

        

        public void Update(cambio entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
