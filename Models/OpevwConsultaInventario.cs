using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwConsultaInventario
    {
        public string Tipo { get; set; }
        public string NiNs { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaMovi { get; set; }
        public string Almacen { get; set; }
        public string TipoMovi { get; set; }
        public string CtaExistencia { get; set; }
        public string Persona { get; set; }
        public string Referencia { get; set; }
        public string Oc { get; set; }
        public string Op { get; set; }
        public string CentroCosto { get; set; }
        public string SubCentroCosto { get; set; }
        public decimal IdProducto { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal? CantidadInout { get; set; }
        public decimal? PrecioCompra { get; set; }
        public string CodigoEmpresa { get; set; }
        public decimal? CostoTotal { get; set; }
        public string CdgSucursal { get; set; }
        public string UsuarioCreacion { get; set; }
        public string CdgVehi { get; set; }
        public string CdgOs { get; set; }
        public string CdgOt { get; set; }
        public string Vehiculo { get; set; }
        public string NumDocu { get; set; }
        public string EsTraslado { get; set; }
        public string Ref { get; set; }
        public string AlmacenDestino { get; set; }
        public string TipoMovimiento { get; set; }
        public string CdgEsta { get; set; }
        public string Empresa { get; set; }
    }
}
