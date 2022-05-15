using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhSemana
    {
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Semana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal NumeroHora { get; set; }
        public decimal? NumeroFeriado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CdgProy { get; set; }
        public decimal? DiasFeriado { get; set; }
    }
}
