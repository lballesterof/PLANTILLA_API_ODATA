using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhUtil
    {
        public decimal IdPersona { get; set; }
        public decimal Importe { get; set; }
        public long Ano { get; set; }
        public decimal Mes { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
