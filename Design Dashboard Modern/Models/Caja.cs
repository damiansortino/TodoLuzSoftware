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
    
    public partial class Caja
    {
        public int CajaId { get; set; }
        public System.DateTime fechaCaja { get; set; }
        public Nullable<System.DateTime> fechaCierreCaja { get; set; }
        public double montoCaja { get; set; }
        public int SucursalId { get; set; }
    }
}
