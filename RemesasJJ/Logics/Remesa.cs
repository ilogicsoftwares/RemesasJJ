using RemesasJJ.Interfaces;
using RemesasJJ.Models;
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
    public class Remesa : BaseRepository, IBaseEntity<remesas>
    {
        public void Delete(int id)
        {
            var entity = context.remesas.Find(id);
            context.remesas.Remove(entity);
        }

        public remesas New()
        {
            remesas remesa = new remesas();
            return remesa;
        }

        public IEnumerable<remesas> GetAll()
        {
            var lista = context.remesas.Include("Bancos").OrderByDescending(x=>x.id).ToList();
            
            return lista;
        }

        public remesas GetByID(int id)
        {
            var entity = context.remesas.FirstOrDefault(x => x.id == id);
            return entity;
        }
        public IEnumerable<remesas> GetByFecha(DateTime date)
        {
            var entity = context.remesas.Where(x => x.fecha == date).ToList();
            return entity;
        }

    

        public IEnumerable<remesas> GetByEstatus(estatus estatus) { 
            var entity = context.remesas.Where(x => x.estatus1 == estatus).ToList();
            return entity;
        }
        public IEnumerable<remesas> GetByType(int remesaTypeId)
        {
            var entity = context.remesas.Where(x => x.remesaType == remesaTypeId).ToList();
            return entity;
        }
        public remesas getByTicketId(string ticketSerial)
        {
            var entity = context.remesas.FirstOrDefault(x => x.ticketSerial == ticketSerial);
            return entity;
        }

        public void updateTicket(int id,string ticketSerial)
        {
            var entity = GetByID(id);
            entity.ticketSerial=ticketSerial;
            Update(entity);
             
        }
        public void updateStatus(int id,estatus estatus)
        {
            var entity = GetByID(id);
            entity.estatus1 = estatus;
            Update(entity);
        }

        public void Insert(remesas entity)
        {
            context.remesas.Add(entity);
        }

        public void Update(remesas entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
