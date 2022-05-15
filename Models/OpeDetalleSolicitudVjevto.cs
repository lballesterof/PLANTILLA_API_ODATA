using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleSolicitudVjevto
    {
        public decimal IdSolicitud { get; set; }
        public string Tipo { get; set; }
        public decimal Secuencia { get; set; }
        public string TipoAt { get; set; }
        public string CdgVje { get; set; }
        public string CdgVto { get; set; }
        public string CdgPersonal { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal CantPersona { get; set; }
        public decimal Importe { get; set; }
        public string CdgCeco { get; set; }
        public string NomVje { get; set; }
        public string NomVto { get; set; }
    }
}
