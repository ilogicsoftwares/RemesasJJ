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
    
    public partial class acesos
    {
        public acesos()
        {
            this.roleacess = new HashSet<roleacess>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string link { get; set; }
        public sbyte active { get; set; }
        public Nullable<int> peso { get; set; }
    
        public virtual ICollection<roleacess> roleacess { get; set; }
    }
}
