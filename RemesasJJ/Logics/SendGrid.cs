using RemesasJJ.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasJJ.Logics
{
    public class SendGrid : BaseRepository
    {

        public string GetKey()
        {
            return context.sendgrid.ToList().Last().llave;
        }


    }
}
