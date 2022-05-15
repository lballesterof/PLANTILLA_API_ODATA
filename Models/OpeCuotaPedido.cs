using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCuotaPedido
    {
        public decimal IdPedido { get; set; }
        public decimal Cuota { get; set; }
        public string Letra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public decimal Importe { get; set; }
        public decimal Interes { get; set; }
        public decimal ImporteInteres { get; set; }
        public decimal ImporteTotal { get; set; }
        public string TipoDocumento { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? InteresSigv { get; set; }
        public decimal? ValorInafecto { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Igv50 { get; set; }
        public decimal? CapitalFinal { get; set; }
        public decimal? CapitalAmortizado { get; set; }
        public decimal? ValorAfecto { get; set; }
        public decimal? Amortizacion { get; set; }
    }
}
