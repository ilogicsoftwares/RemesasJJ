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
    
    public partial class beneficiarios
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombreCompleto { get; set; }
        public string cuenta { get; set; }
        public Nullable<int> cuentaType { get; set; }
        public Nullable<int> cedulaType { get; set; }
        public Nullable<int> ultimaRemesa { get; set; }
        public int cliente { get; set; }
    
        public virtual clientes clientes { get; set; }
    }
}
