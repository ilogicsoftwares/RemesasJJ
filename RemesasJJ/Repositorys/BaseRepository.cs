using RemesasJJ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasJJ.Repositorys
{
    public class BaseRepository : IDisposable
    {
        public remesasEntities context;
        public BaseRepository()
        {
            this.context = new remesasEntities();
        }

        public BaseRepository(remesasEntities context)
        {
            this.context = context;
        }

        private bool disposed = false;

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
