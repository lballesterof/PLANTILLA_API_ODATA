using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeNotaProyecto
    {
        public string Tipo { get; set; }
        public decimal IdProyecto { get; set; }
        public string Nota { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
