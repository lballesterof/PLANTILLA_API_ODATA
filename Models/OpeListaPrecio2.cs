using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeListaPrecio2
    {
        public string Codigo { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public string IdTipoCliente { get; set; }
        public string Moneda { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Margen { get; set; }
        public decimal? PrecioVenta2 { get; set; }
        public decimal? PrecioVenta3 { get; set; }
        public decimal? PrecioVenta4 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? Margen2 { get; set; }
        public decimal? Margen3 { get; set; }
        public decimal? Margen4 { get; set; }

        public virtual OpeClistaPrecio CodigoNavigation { get; set; }
    }
}
