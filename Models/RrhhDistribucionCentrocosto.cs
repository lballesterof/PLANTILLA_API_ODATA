using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhDistribucionCentrocosto
    {
        public decimal IdPersona { get; set; }
        public string CentroCosto { get; set; }
        public string CodigoEstablecimiento { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}
