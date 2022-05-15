using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServControlCalidadProyecto
    {
        public decimal IdProyecto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string SwtCheck { get; set; }
        public decimal? Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
