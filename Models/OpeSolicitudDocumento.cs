using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSolicitudDocumento
    {
        public decimal IdSolicitud { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public decimal? IdDocumento { get; set; }
        public decimal? IdPersona { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Anticipo { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal PorIgv { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public decimal? IdGuia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
    }
}
