using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSucursal
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string EsPrincipal { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Valoriza { get; set; }
        public string Pedido { get; set; }
        public string Referencia1 { get; set; }
        public string Venta { get; set; }
        public string ImpresoraMatricial { get; set; }
        public string Referencia2 { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string ImpresoraCaja { get; set; }
        public string SwtWeb { get; set; }
        public string Abr { get; set; }

        public virtual OpeEmpresa CodigoEmpresaNavigation { get; set; }
    }
}
