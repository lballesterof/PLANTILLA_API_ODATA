using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwMovimientoImportacion
    {
        public string OrdenCompra { get; set; }
        public DateTime FechaOc { get; set; }
        public string Carpeta { get; set; }
        public string NomCarpeta { get; set; }
        public string NotaIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Ruc { get; set; }
        public string Proveedor { get; set; }
        public string Pa { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal? FobUnit { get; set; }
        public decimal? CimpUnit { get; set; }
        public decimal? CfobTotal { get; set; }
        public decimal? CimpTotal { get; set; }
        public decimal? RatioImp { get; set; }
        public decimal? TipoCambio { get; set; }
        public string IdMoneda { get; set; }
        public string Estado { get; set; }
        public string CoocEstado { get; set; }
        public decimal? Flete { get; set; }
        public decimal? Cfr { get; set; }
        public decimal? Seguro { get; set; }
        public decimal? Cif { get; set; }
        public decimal? AdValorem { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Ipm { get; set; }
    }
}
