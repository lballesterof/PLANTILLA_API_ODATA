using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCotizacionc
    {
        public OpeCotizacionc()
        {
            OpeDetalleccs = new HashSet<OpeDetallecc>();
        }

        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string LugarEntrega { get; set; }
        public string CondicionPago { get; set; }
        public string Moneda { get; set; }
        public int? IdPersona { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Dscto { get; set; }
        public decimal? PorcentajeDscto { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string SwtCoti { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Responsable { get; set; }
        public decimal? ValorCompra { get; set; }

        public virtual ICollection<OpeDetallecc> OpeDetalleccs { get; set; }
    }
}
