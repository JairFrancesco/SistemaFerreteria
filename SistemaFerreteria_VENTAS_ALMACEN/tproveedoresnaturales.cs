//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFerreteria_VENTAS_ALMACEN
{
    using System;
    using System.Collections.Generic;
    
    public partial class tproveedoresnaturales
    {
        public tproveedoresnaturales()
        {
            this.tsuministros = new HashSet<tsuministros>();
        }
    
        public string dni_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public System.DateTime nacimiento_proveedor { get; set; }
        public string apellidos_proveedor { get; set; }
        public int telefono_proveedor { get; set; }
    
        public virtual ICollection<tsuministros> tsuministros { get; set; }
    }
}
