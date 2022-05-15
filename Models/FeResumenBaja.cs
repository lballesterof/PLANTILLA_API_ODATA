using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class FeResumenBaja
    {
        public string CodigoEmpresa { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estado { get; set; }
        public string EstReg { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string UsuarioEnvio { get; set; }
        public DateTime? FechaDocumento { get; set; }
    }
}
