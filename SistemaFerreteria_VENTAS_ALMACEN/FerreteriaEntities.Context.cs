﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FerreteriaEntities : DbContext
    {
        public FerreteriaEntities()
            : base("name=FerreteriaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tclientes> tclientes { get; set; }
        public virtual DbSet<tcompras> tcompras { get; set; }
        public virtual DbSet<tdescuentos> tdescuentos { get; set; }
        public virtual DbSet<tdetallecompras> tdetallecompras { get; set; }
        public virtual DbSet<templeados> templeados { get; set; }
        public virtual DbSet<tproductos> tproductos { get; set; }
        public virtual DbSet<tproveedoresempresas> tproveedoresempresas { get; set; }
        public virtual DbSet<tproveedoresnaturales> tproveedoresnaturales { get; set; }
        public virtual DbSet<tsuministros> tsuministros { get; set; }
        public virtual DbSet<tsuministrosempresas> tsuministrosempresas { get; set; }
        public virtual DbSet<tTipopagos> tTipopagos { get; set; }
        public virtual DbSet<ttipousuarios> ttipousuarios { get; set; }
        public virtual DbSet<tusuarios> tusuarios { get; set; }
        public virtual DbSet<REPORTECLIENTES> REPORTECLIENTES { get; set; }
        public virtual DbSet<REPORTEVENTAS> REPORTEVENTAS { get; set; }
    
        public virtual int DELETECLIENTE(Nullable<int> dNI_CLIENTE)
        {
            var dNI_CLIENTEParameter = dNI_CLIENTE.HasValue ?
                new ObjectParameter("DNI_CLIENTE", dNI_CLIENTE) :
                new ObjectParameter("DNI_CLIENTE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETECLIENTE", dNI_CLIENTEParameter);
        }
    
        public virtual int DELETEPRODUCTO(Nullable<int> cODIGO_PRODUCTO)
        {
            var cODIGO_PRODUCTOParameter = cODIGO_PRODUCTO.HasValue ?
                new ObjectParameter("CODIGO_PRODUCTO", cODIGO_PRODUCTO) :
                new ObjectParameter("CODIGO_PRODUCTO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETEPRODUCTO", cODIGO_PRODUCTOParameter);
        }
    
        public virtual int DELETEPROVEEDOR(Nullable<int> rUC_EMPRESA)
        {
            var rUC_EMPRESAParameter = rUC_EMPRESA.HasValue ?
                new ObjectParameter("RUC_EMPRESA", rUC_EMPRESA) :
                new ObjectParameter("RUC_EMPRESA", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETEPROVEEDOR", rUC_EMPRESAParameter);
        }
    
        public virtual int DELETEPROVEEDOREMPRESA(string rUC_proveedorempresa)
        {
            var rUC_proveedorempresaParameter = rUC_proveedorempresa != null ?
                new ObjectParameter("RUC_proveedorempresa", rUC_proveedorempresa) :
                new ObjectParameter("RUC_proveedorempresa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETEPROVEEDOREMPRESA", rUC_proveedorempresaParameter);
        }
    
        public virtual ObjectResult<FACTURA_Result> FACTURA(Nullable<int> nUMERO_FACTURA)
        {
            var nUMERO_FACTURAParameter = nUMERO_FACTURA.HasValue ?
                new ObjectParameter("NUMERO_FACTURA", nUMERO_FACTURA) :
                new ObjectParameter("NUMERO_FACTURA", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FACTURA_Result>("FACTURA", nUMERO_FACTURAParameter);
        }
    
        public virtual int GUARDARCOMPRAS(Nullable<int> numero_Factura, Nullable<int> dni_cliente, Nullable<int> tipo_pago, Nullable<int> dni_empleado, Nullable<System.DateTime> fecha_compra)
        {
            var numero_FacturaParameter = numero_Factura.HasValue ?
                new ObjectParameter("numero_Factura", numero_Factura) :
                new ObjectParameter("numero_Factura", typeof(int));
    
            var dni_clienteParameter = dni_cliente.HasValue ?
                new ObjectParameter("dni_cliente", dni_cliente) :
                new ObjectParameter("dni_cliente", typeof(int));
    
            var tipo_pagoParameter = tipo_pago.HasValue ?
                new ObjectParameter("tipo_pago", tipo_pago) :
                new ObjectParameter("tipo_pago", typeof(int));
    
            var dni_empleadoParameter = dni_empleado.HasValue ?
                new ObjectParameter("dni_empleado", dni_empleado) :
                new ObjectParameter("dni_empleado", typeof(int));
    
            var fecha_compraParameter = fecha_compra.HasValue ?
                new ObjectParameter("fecha_compra", fecha_compra) :
                new ObjectParameter("fecha_compra", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GUARDARCOMPRAS", numero_FacturaParameter, dni_clienteParameter, tipo_pagoParameter, dni_empleadoParameter, fecha_compraParameter);
        }
    
        public virtual int GUARDARDETALLES(Nullable<int> numero_factura, Nullable<int> codigo_producto, Nullable<int> cantidad_comprada)
        {
            var numero_facturaParameter = numero_factura.HasValue ?
                new ObjectParameter("numero_factura", numero_factura) :
                new ObjectParameter("numero_factura", typeof(int));
    
            var codigo_productoParameter = codigo_producto.HasValue ?
                new ObjectParameter("codigo_producto", codigo_producto) :
                new ObjectParameter("codigo_producto", typeof(int));
    
            var cantidad_compradaParameter = cantidad_comprada.HasValue ?
                new ObjectParameter("cantidad_comprada", cantidad_comprada) :
                new ObjectParameter("cantidad_comprada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GUARDARDETALLES", numero_facturaParameter, codigo_productoParameter, cantidad_compradaParameter);
        }
    
        public virtual int IngresarUsuario(string nombre_usuario, Nullable<int> tipo_usuario, string contrasenia_usuario)
        {
            var nombre_usuarioParameter = nombre_usuario != null ?
                new ObjectParameter("nombre_usuario", nombre_usuario) :
                new ObjectParameter("nombre_usuario", typeof(string));
    
            var tipo_usuarioParameter = tipo_usuario.HasValue ?
                new ObjectParameter("tipo_usuario", tipo_usuario) :
                new ObjectParameter("tipo_usuario", typeof(int));
    
            var contrasenia_usuarioParameter = contrasenia_usuario != null ?
                new ObjectParameter("contrasenia_usuario", contrasenia_usuario) :
                new ObjectParameter("contrasenia_usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IngresarUsuario", nombre_usuarioParameter, tipo_usuarioParameter, contrasenia_usuarioParameter);
        }
    
        public virtual int INSERTCLIENTE(Nullable<int> dni_cliente, string nombre_cliente, string apellidos_cliente, Nullable<System.DateTime> nacimiento_cliente, Nullable<int> telefono_cliente)
        {
            var dni_clienteParameter = dni_cliente.HasValue ?
                new ObjectParameter("dni_cliente", dni_cliente) :
                new ObjectParameter("dni_cliente", typeof(int));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
            var apellidos_clienteParameter = apellidos_cliente != null ?
                new ObjectParameter("apellidos_cliente", apellidos_cliente) :
                new ObjectParameter("apellidos_cliente", typeof(string));
    
            var nacimiento_clienteParameter = nacimiento_cliente.HasValue ?
                new ObjectParameter("nacimiento_cliente", nacimiento_cliente) :
                new ObjectParameter("nacimiento_cliente", typeof(System.DateTime));
    
            var telefono_clienteParameter = telefono_cliente.HasValue ?
                new ObjectParameter("telefono_cliente", telefono_cliente) :
                new ObjectParameter("telefono_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTCLIENTE", dni_clienteParameter, nombre_clienteParameter, apellidos_clienteParameter, nacimiento_clienteParameter, telefono_clienteParameter);
        }
    
        public virtual int INSERTPRODUCTO(Nullable<int> cODIGO_PRODUCTO, string dESCRIPCION_PRODUCTO, Nullable<float> pRECIO_PRODUCTO, Nullable<int> eXISTENCIAS_PRODUCTO)
        {
            var cODIGO_PRODUCTOParameter = cODIGO_PRODUCTO.HasValue ?
                new ObjectParameter("CODIGO_PRODUCTO", cODIGO_PRODUCTO) :
                new ObjectParameter("CODIGO_PRODUCTO", typeof(int));
    
            var dESCRIPCION_PRODUCTOParameter = dESCRIPCION_PRODUCTO != null ?
                new ObjectParameter("DESCRIPCION_PRODUCTO", dESCRIPCION_PRODUCTO) :
                new ObjectParameter("DESCRIPCION_PRODUCTO", typeof(string));
    
            var pRECIO_PRODUCTOParameter = pRECIO_PRODUCTO.HasValue ?
                new ObjectParameter("PRECIO_PRODUCTO", pRECIO_PRODUCTO) :
                new ObjectParameter("PRECIO_PRODUCTO", typeof(float));
    
            var eXISTENCIAS_PRODUCTOParameter = eXISTENCIAS_PRODUCTO.HasValue ?
                new ObjectParameter("EXISTENCIAS_PRODUCTO", eXISTENCIAS_PRODUCTO) :
                new ObjectParameter("EXISTENCIAS_PRODUCTO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTPRODUCTO", cODIGO_PRODUCTOParameter, dESCRIPCION_PRODUCTOParameter, pRECIO_PRODUCTOParameter, eXISTENCIAS_PRODUCTOParameter);
        }
    
        public virtual int INSERTPROVEEDOR(Nullable<int> rUC_EMPRESA, string nOMBRE_EMPRESA, string tELEFONO_EMPRESA)
        {
            var rUC_EMPRESAParameter = rUC_EMPRESA.HasValue ?
                new ObjectParameter("RUC_EMPRESA", rUC_EMPRESA) :
                new ObjectParameter("RUC_EMPRESA", typeof(int));
    
            var nOMBRE_EMPRESAParameter = nOMBRE_EMPRESA != null ?
                new ObjectParameter("NOMBRE_EMPRESA", nOMBRE_EMPRESA) :
                new ObjectParameter("NOMBRE_EMPRESA", typeof(string));
    
            var tELEFONO_EMPRESAParameter = tELEFONO_EMPRESA != null ?
                new ObjectParameter("TELEFONO_EMPRESA", tELEFONO_EMPRESA) :
                new ObjectParameter("TELEFONO_EMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTPROVEEDOR", rUC_EMPRESAParameter, nOMBRE_EMPRESAParameter, tELEFONO_EMPRESAParameter);
        }
    
        public virtual int INSERTPROVEEDOREMPRESA(string rUC_proveedorempresa, string nombre_proveedorempresa, string telefono_proveedorempresa)
        {
            var rUC_proveedorempresaParameter = rUC_proveedorempresa != null ?
                new ObjectParameter("RUC_proveedorempresa", rUC_proveedorempresa) :
                new ObjectParameter("RUC_proveedorempresa", typeof(string));
    
            var nombre_proveedorempresaParameter = nombre_proveedorempresa != null ?
                new ObjectParameter("Nombre_proveedorempresa", nombre_proveedorempresa) :
                new ObjectParameter("Nombre_proveedorempresa", typeof(string));
    
            var telefono_proveedorempresaParameter = telefono_proveedorempresa != null ?
                new ObjectParameter("telefono_proveedorempresa", telefono_proveedorempresa) :
                new ObjectParameter("telefono_proveedorempresa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTPROVEEDOREMPRESA", rUC_proveedorempresaParameter, nombre_proveedorempresaParameter, telefono_proveedorempresaParameter);
        }
    
        public virtual ObjectResult<SELECTPRODUCTOS_Result> SELECTPRODUCTOS(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SELECTPRODUCTOS_Result>("SELECTPRODUCTOS", descripcionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UPDATECLIENTE(Nullable<int> dni_cliente, string nombre_cliente, string apellidos_cliente, Nullable<System.DateTime> nacimiento_cliente, Nullable<int> telefono_cliente)
        {
            var dni_clienteParameter = dni_cliente.HasValue ?
                new ObjectParameter("dni_cliente", dni_cliente) :
                new ObjectParameter("dni_cliente", typeof(int));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
            var apellidos_clienteParameter = apellidos_cliente != null ?
                new ObjectParameter("apellidos_cliente", apellidos_cliente) :
                new ObjectParameter("apellidos_cliente", typeof(string));
    
            var nacimiento_clienteParameter = nacimiento_cliente.HasValue ?
                new ObjectParameter("nacimiento_cliente", nacimiento_cliente) :
                new ObjectParameter("nacimiento_cliente", typeof(System.DateTime));
    
            var telefono_clienteParameter = telefono_cliente.HasValue ?
                new ObjectParameter("telefono_cliente", telefono_cliente) :
                new ObjectParameter("telefono_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATECLIENTE", dni_clienteParameter, nombre_clienteParameter, apellidos_clienteParameter, nacimiento_clienteParameter, telefono_clienteParameter);
        }
    
        public virtual int UPDATEPRODUCTO(Nullable<int> cODIGO_PRODUCTO, string dESCRIPCION_PRODUCTO, Nullable<float> pRECIO_PRODUCTO, Nullable<int> eXISTENCIAS_PRODUCTO)
        {
            var cODIGO_PRODUCTOParameter = cODIGO_PRODUCTO.HasValue ?
                new ObjectParameter("CODIGO_PRODUCTO", cODIGO_PRODUCTO) :
                new ObjectParameter("CODIGO_PRODUCTO", typeof(int));
    
            var dESCRIPCION_PRODUCTOParameter = dESCRIPCION_PRODUCTO != null ?
                new ObjectParameter("DESCRIPCION_PRODUCTO", dESCRIPCION_PRODUCTO) :
                new ObjectParameter("DESCRIPCION_PRODUCTO", typeof(string));
    
            var pRECIO_PRODUCTOParameter = pRECIO_PRODUCTO.HasValue ?
                new ObjectParameter("PRECIO_PRODUCTO", pRECIO_PRODUCTO) :
                new ObjectParameter("PRECIO_PRODUCTO", typeof(float));
    
            var eXISTENCIAS_PRODUCTOParameter = eXISTENCIAS_PRODUCTO.HasValue ?
                new ObjectParameter("EXISTENCIAS_PRODUCTO", eXISTENCIAS_PRODUCTO) :
                new ObjectParameter("EXISTENCIAS_PRODUCTO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATEPRODUCTO", cODIGO_PRODUCTOParameter, dESCRIPCION_PRODUCTOParameter, pRECIO_PRODUCTOParameter, eXISTENCIAS_PRODUCTOParameter);
        }
    
        public virtual int UPDATEPROVEEDOR(Nullable<int> rUC_EMPRESA, string nOMBRE_EMPRESA, string tELEFONO_EMPRESA)
        {
            var rUC_EMPRESAParameter = rUC_EMPRESA.HasValue ?
                new ObjectParameter("RUC_EMPRESA", rUC_EMPRESA) :
                new ObjectParameter("RUC_EMPRESA", typeof(int));
    
            var nOMBRE_EMPRESAParameter = nOMBRE_EMPRESA != null ?
                new ObjectParameter("NOMBRE_EMPRESA", nOMBRE_EMPRESA) :
                new ObjectParameter("NOMBRE_EMPRESA", typeof(string));
    
            var tELEFONO_EMPRESAParameter = tELEFONO_EMPRESA != null ?
                new ObjectParameter("TELEFONO_EMPRESA", tELEFONO_EMPRESA) :
                new ObjectParameter("TELEFONO_EMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATEPROVEEDOR", rUC_EMPRESAParameter, nOMBRE_EMPRESAParameter, tELEFONO_EMPRESAParameter);
        }
    
        public virtual int UPDATEPROVEEDOREMPRESA(string rUC_proveedorempresa, string nombre_proveedorempresa, string telefono_proveedorempresa)
        {
            var rUC_proveedorempresaParameter = rUC_proveedorempresa != null ?
                new ObjectParameter("RUC_proveedorempresa", rUC_proveedorempresa) :
                new ObjectParameter("RUC_proveedorempresa", typeof(string));
    
            var nombre_proveedorempresaParameter = nombre_proveedorempresa != null ?
                new ObjectParameter("Nombre_proveedorempresa", nombre_proveedorempresa) :
                new ObjectParameter("Nombre_proveedorempresa", typeof(string));
    
            var telefono_proveedorempresaParameter = telefono_proveedorempresa != null ?
                new ObjectParameter("telefono_proveedorempresa", telefono_proveedorempresa) :
                new ObjectParameter("telefono_proveedorempresa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATEPROVEEDOREMPRESA", rUC_proveedorempresaParameter, nombre_proveedorempresaParameter, telefono_proveedorempresaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> VerificarUsuario(string nombre_usuario, string contrasenia_usuario)
        {
            var nombre_usuarioParameter = nombre_usuario != null ?
                new ObjectParameter("Nombre_usuario", nombre_usuario) :
                new ObjectParameter("Nombre_usuario", typeof(string));
    
            var contrasenia_usuarioParameter = contrasenia_usuario != null ?
                new ObjectParameter("Contrasenia_usuario", contrasenia_usuario) :
                new ObjectParameter("Contrasenia_usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("VerificarUsuario", nombre_usuarioParameter, contrasenia_usuarioParameter);
        }
    }
}
