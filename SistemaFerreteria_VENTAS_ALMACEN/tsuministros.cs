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
    
    public partial class tsuministros
    {
        public int codigo_suministro { get; set; }
        public string dni_proveedor { get; set; }
        public int codigo_producto { get; set; }
    
        public virtual tproductos tproductos { get; set; }
        public virtual tproveedoresnaturales tproveedoresnaturales { get; set; }
    }
}