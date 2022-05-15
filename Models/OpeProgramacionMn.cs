using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProgramacionMn
    {
        public decimal IdMn { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdProducto { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
