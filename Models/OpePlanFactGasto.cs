using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePlanFactGasto
    {
        public string Tipo { get; set; }
        public decimal IdProyecto { get; set; }
        public string Ano { get; set; }
        public string CdgCc { get; set; }
        public decimal? Enero { get; set; }
        public decimal? Febrero { get; set; }
        public decimal? Marzo { get; set; }
        public decimal? Abril { get; set; }
        public decimal? Mayo { get; set; }
        public decimal? Junio { get; set; }
        public decimal? Julio { get; set; }
        public decimal? Agosto { get; set; }
        public decimal? Setiembre { get; set; }
        public decimal? Octubre { get; set; }
        public decimal? Noviembre { get; set; }
        public decimal? Diciembre { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
