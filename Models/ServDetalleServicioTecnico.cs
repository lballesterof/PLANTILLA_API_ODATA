using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServDetalleServicioTecnico
    {
        public string NumeroFre { get; set; }
        public string SerieGenerada { get; set; }
        public string Falla { get; set; }
        public string Motivo { get; set; }
        public string IdTipoPrueba { get; set; }
        public string IdRevisionInterna { get; set; }
        public string IdDiagnostico { get; set; }
        public string IdDescripcion { get; set; }
        public string IdRecomendacion { get; set; }
        public string Observacion { get; set; }
        public string Tipo { get; set; }
        public int Secuencia { get; set; }
    }
}
