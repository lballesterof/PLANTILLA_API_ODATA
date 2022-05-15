using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeLiquidacionm
    {
        public decimal IdDocumento { get; set; }
        public string Codigo { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string SwtPlomo { get; set; }
        public string SwtZinc { get; set; }
        public string SwtCobre { get; set; }
        public string DatoProceso { get; set; }
        public decimal? TmhProcesado { get; set; }
        public decimal? TotalIngresado { get; set; }
        public string Moneda { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public decimal? ImpAdel1 { get; set; }
        public decimal? ImpAdel2 { get; set; }
        public decimal? ImpAdel3 { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string UsuarioAutoriza { get; set; }
        public DateTime? FechaAutoriza { get; set; }
    }
}
