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
            var lista = context.remesas.Include("Bancos").OrderByDescending(x=>x.id).Take(3000).ToList();
            
            return lista;
        }

        public remesas GetByID(int id)
        {
            var entity = context.remesas.FirstOrDefault(x => x.id == id);
            return entity;
        }
        public IEnumerable<remesas> GetByFecha(DateTime date)
        {
            var entity = context.remesas.Include("bancosempre").ToList().Where(x => x.fecha.Value.Date.Equals(date.Date));


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

        public bool?  processRemesa(int id, string idDeposito, string idTransf, int idBanco,int BancoTrans)
        {
            var exist=getByTicketId(idDeposito);
            if (exist != null)
                return false;

            try {
                var remesa = GetByID(id);
                remesa.ticketSerial = idDeposito;
                remesa.idtransf = idTransf;
                remesa.fechaTransf = DateTime.Now;
                remesa.bancoDeposito = idBanco;
                remesa.estatus = 2;
                remesa.BancoTrans = BancoTrans;
                Update(remesa);
                Save();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
  
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
