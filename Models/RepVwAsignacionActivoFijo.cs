using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwAsignacionActivoFijo
    {
        public string ActivoFijo { get; set; }
        public string Serie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Clase { get; set; }
        public string NivelObs { get; set; }
        public string Uso { get; set; }
        public string EstadoFisico { get; set; }
        public string Cliente { get; set; }
        public string DdFechaRetorno { get; set; }
        public string DdFechaInicio { get; set; }
        public string Observacion { get; set; }
    }
}
