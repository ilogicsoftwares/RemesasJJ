//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemesasJJ
{
    using System;
    using System.Collections.Generic;
    
    public partial class pagotype
    {
        public pagotype()
        {
            this.pagosremesa = new HashSet<pagosremesa>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<pagosremesa> pagosremesa { get; set; }
    }
}
