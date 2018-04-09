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
    public class Clients : BaseRepository, IBaseEntity<clientes>
    {
        public void Delete(int id)
        {
            var entity = context.clientes.Find(id);
            context.clientes.Remove(entity);
        }

        public IEnumerable<clientes> GetAll()
        {
            var lista = context.clientes.ToList();
            return lista;
        }

        public clientes GetByID(int id)
        {
            var entity = context.clientes.FirstOrDefault(x => x.id == id);
            return entity;
        }

        public void Insert(clientes entity)
        {
            context.clientes.Add(entity);
        }

        public IEnumerable<beneficiarios> GetAllBenefits(int id)
        {
            var lista = context.beneficiarios.Where(x => x.cliente == id).ToList();
            return lista;
        }

        public void Update(clientes entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
