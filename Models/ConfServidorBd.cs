using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfServidorBd
    {
        public string Ruc { get; set; }
        public string Servidor { get; set; }
        public string BaseDato { get; set; }
        public string TipoSeguridad { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string RutaBaseDato { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NomServidor { get; set; }
    }
}
