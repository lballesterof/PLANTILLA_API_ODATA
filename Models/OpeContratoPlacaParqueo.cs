using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeContratoPlacaParqueo
    {
        public decimal IdContrato { get; set; }
        public string NumeroPlaca { get; set; }
        public decimal Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
