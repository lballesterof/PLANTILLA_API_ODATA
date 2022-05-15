using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeConvenioLab
    {
        public decimal IdConvenio { get; set; }
        public decimal IdPersona { get; set; }
        public string NumGarantia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
