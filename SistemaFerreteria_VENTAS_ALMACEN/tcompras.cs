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
    
    public partial class tcompras
    {
        public tcompras()
        {
            this.tdetallecompras = new HashSet<tdetallecompras>();
        }
    
        public int numero_factura { get; set; }
        public string dni_cliente { get; set; }
        public int id_tipopago { get; set; }
        public string dni_empleado { get; set; }
        public System.DateTime fecha_compra { get; set; }
    
        public virtual tclientes tclientes { get; set; }
        public virtual ICollection<tdetallecompras> tdetallecompras { get; set; }
        public virtual templeados templeados { get; set; }
        public virtual tTipopagos tTipopagos { get; set; }
    }
}
