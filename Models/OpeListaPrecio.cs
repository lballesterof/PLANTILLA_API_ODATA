using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeListaPrecio
    {
        public string Codigo { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public string IdTipoCliente { get; set; }
        public string Moneda { get; set; }
        public string Unidad { get; set; }
        public decimal FactorConversion { get; set; }
        public decimal? PrecioMinimo { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? Margen { get; set; }
        public string CodigoBase { get; set; }
        public string AutoP { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoBarra { get; set; }
    }
}
