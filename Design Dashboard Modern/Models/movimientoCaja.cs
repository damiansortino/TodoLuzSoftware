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
    
    public partial class movimientoCaja
    {
        public int MovimientoCajaId { get; set; }
        public bool entra { get; set; }
        public bool sale { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public double importe { get; set; }
        public string observaciones { get; set; }
        public int tipoMovimientoCajaId { get; set; }
        public int CajaId { get; set; }
        public Nullable<int> ComprobanteId { get; set; }
    }
}
