using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwDocumentoVentum
    {
        public DateTime Ano { get; set; }
        public DateTime Mes { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nroop { get; set; }
        public DateTime DdFechaVencimiento { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string FormaPago { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal? MontoDoc { get; set; }
        public decimal? TipoCambioDoc { get; set; }
        public decimal? BaseCalculada { get; set; }
        public decimal? CostoEstandarSoles { get; set; }
        public decimal? MargenBrutoSoles { get; set; }
        public decimal? PorcentajeMargen { get; set; }
        public string Almacen { get; set; }
    }
}
