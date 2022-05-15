using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServActividadTecnico
    {
        public decimal IdProyecto { get; set; }
        public decimal Secuencia { get; set; }
        public decimal IdTecnico { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
