using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhDetalleHorario
    {
        public string CdgHorario { get; set; }
        public short Dia { get; set; }
        public string LimiteInicio { get; set; }
        public string DiaLimite { get; set; }
        public string LimiteFin { get; set; }
        public string Ingreso { get; set; }
        public string Salida { get; set; }
        public string SalidaRefrigerio { get; set; }
        public string EntradaRefrigerio { get; set; }
    }
}
