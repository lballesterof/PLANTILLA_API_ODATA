using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhIncidenciaMemo
    {
        public decimal Secuencia { get; set; }
        public decimal IdPersona { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
