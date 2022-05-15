using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSeguimientoImportacion
    {
        public decimal IdOc { get; set; }
        public string CdgHito { get; set; }
        public DateTime FechaHito { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Secuencia { get; set; }
    }
}
