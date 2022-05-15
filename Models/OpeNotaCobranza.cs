using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeNotaCobranza
    {
        public decimal IdSeguimiento { get; set; }
        public decimal IdPersona { get; set; }
        public string Nota { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaProximoSeg { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Referencia { get; set; }
    }
}
