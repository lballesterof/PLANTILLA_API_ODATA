using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ComComisionFact
    {
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public string Vendedor { get; set; }
        public decimal Cuota { get; set; }
        public decimal? ValorNeto { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Cobranza { get; set; }
        public decimal? ComisionPagar { get; set; }
        public string Moneda { get; set; }
        public decimal PorCumplimiento { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
