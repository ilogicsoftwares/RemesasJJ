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
    
    public partial class remesas
    {
        public int id { get; set; }
        public Nullable<int> clienteid { get; set; }
        public Nullable<int> beneficiarioid { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public decimal montoDeposito { get; set; }
        public int monedaDeposito { get; set; }
        public int paisDestino { get; set; }
        public int monedaDestino { get; set; }
        public decimal montoDestino { get; set; }
        public int estatus { get; set; }
        public string cedulaCliente { get; set; }
        public string nombreCliente { get; set; }
        public string telefonoCliente { get; set; }
        public string correoCliente { get; set; }
        public string nombreBenef { get; set; }
        public string cedulaBenef { get; set; }
        public Nullable<int> cedulaBenefType { get; set; }
        public string cuentaBenef { get; set; }
        public Nullable<int> cuentaBenefType { get; set; }
        public Nullable<System.DateTime> fechaTransf { get; set; }
        public Nullable<int> cambioid { get; set; }
        public Nullable<int> bancoBenef { get; set; }
        public string ticketSerial { get; set; }
        public int remesaType { get; set; }
        public string file { get; set; }
        public string idtransf { get; set; }
        public Nullable<int> bancoDeposito { get; set; }
        public string imgTrans { get; set; }
        public Nullable<int> BancoTrans { get; set; }
        public string unulaDetail { get; set; }
    
        public virtual bancos bancos { get; set; }
        public virtual bancosempre bancosempre { get; set; }
        public virtual bancostrans bancostrans { get; set; }
        public virtual cambio cambio { get; set; }
        public virtual cedulatype cedulatype { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual country country { get; set; }
        public virtual cuentastype cuentastype { get; set; }
        public virtual estatus estatus1 { get; set; }
        public virtual moneda moneda { get; set; }
        public virtual remesatype remesatype1 { get; set; }
    }
}
