using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCosteoImportacion
    {
        public string CiFileImportacion { get; set; }
        public string CiNumeroIngreso { get; set; }
        public decimal IdProducto { get; set; }
        public decimal CiCantidad { get; set; }
        public decimal CiPrecioCompra { get; set; }
        public decimal CiPrecioEstandar { get; set; }
        public decimal CiPrecioReal { get; set; }
        public decimal CiAno { get; set; }
        public decimal CiMes { get; set; }
        public DateTime CiFecha { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CiEstado { get; set; }
        public string CdgCosteo { get; set; }
        public decimal? CiPorcentajeFob { get; set; }
        public decimal? CiIncrementoReal { get; set; }
        public decimal? CiCostoTotal { get; set; }
        public decimal? CiRatioImportacion { get; set; }
        public decimal? CiIncrementoRealD { get; set; }
        public decimal? CiPrecioRealD { get; set; }
        public decimal? CiCostoTotalD { get; set; }
    }
}
