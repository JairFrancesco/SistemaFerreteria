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
    
    public partial class tTipopagos
    {
        public tTipopagos()
        {
            this.tcompras = new HashSet<tcompras>();
        }
    
        public int id_tipopago { get; set; }
        public string nombre_Tipopago { get; set; }
    
        public virtual ICollection<tcompras> tcompras { get; set; }
    }
}
