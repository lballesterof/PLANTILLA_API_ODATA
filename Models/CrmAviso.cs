using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CrmAviso
    {
        public decimal IdAviso { get; set; }
        public decimal IdSeguimiento { get; set; }
        public string Tipo { get; set; }
        public string TipoEvento { get; set; }
        public string DeUsuario { get; set; }
        public string ParaUsuarioGrupo { get; set; }
        public string Asunto { get; set; }
        public DateTime FechaAviso { get; set; }
        public string HoraAviso { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
