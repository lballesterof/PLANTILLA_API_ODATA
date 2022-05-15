using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSalInvPorMov2
    {
        public string CodigoEmpresa { get; set; }
        public string NomAlmacen { get; set; }
        public string Almacen { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal? Ingreso2 { get; set; }
        public decimal? Salida2 { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal IdDocumento { get; set; }
        public int Secuencia { get; set; }
        public string TipoGuia { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Persona { get; set; }
        public string Numero { get; set; }
        public string CodigoGenerado { get; set; }
        public string Movimiento { get; set; }
        public decimal IdOc { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Costod { get; set; }
        public decimal PrecioComprad { get; set; }
        public string Oc { get; set; }
        public string Op { get; set; }
        public string IdCategoria { get; set; }
        public decimal Costof { get; set; }
        public decimal Costol { get; set; }
        public string Docu { get; set; }
        public string Series { get; set; }
        public decimal? Factor { get; set; }
        public string CodigoUnidad { get; set; }
        public string UnidadEqui { get; set; }
        public string U1 { get; set; }
        public string U2 { get; set; }
        public string CodigoBarra { get; set; }
        public int Orden { get; set; }
        public string CdgCc { get; set; }
        public string ScdgCc { get; set; }
        public string CentroCosto { get; set; }
        public string SubCentroCosto { get; set; }
    }
}
