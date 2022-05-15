using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhPermisoSancion
    {
        public decimal IdPersona { get; set; }
        public string TipoPermiso { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public int Semana { get; set; }
        public string CdgProy { get; set; }
        public decimal? Horas { get; set; }
        public string Referencia { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
