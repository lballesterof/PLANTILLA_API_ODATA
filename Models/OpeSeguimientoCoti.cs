using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSeguimientoCoti
    {
        public decimal IdSecuencia { get; set; }
        public decimal IdCotizacion { get; set; }
        public decimal? AnoCierre { get; set; }
        public string MesCierre { get; set; }
        public decimal? AnoEntrega { get; set; }
        public string MesEntrega { get; set; }
        public DateTime FechaSeguimiento { get; set; }
        public DateTime FechaProxSeg { get; set; }
        public decimal ProbCierre { get; set; }
        public decimal PorcAvance { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
