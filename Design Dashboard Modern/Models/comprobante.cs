//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Design_Dashboard_Modern.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comprobante
    {
        public int Id { get; set; }
        public int TipoComprobanteId { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string codigo { get; set; }
        public double importe { get; set; }
        public double bonificacion { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public double efectivo { get; set; }
        public double tarjeta { get; set; }
        public double CtaCte { get; set; }
    }
}