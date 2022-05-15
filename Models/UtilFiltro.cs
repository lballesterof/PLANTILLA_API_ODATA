using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class UtilFiltro
    {
        public string UsuarioCreacion { get; set; }
        public string Consulta { get; set; }
        public string Filtro { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
