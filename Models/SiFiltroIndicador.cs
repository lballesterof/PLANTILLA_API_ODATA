using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class SiFiltroIndicador
    {
        public string CdgIndicador { get; set; }
        public string Codigo { get; set; }
        public string Numero { get; set; }
        public decimal Valor { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
