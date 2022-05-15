using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class Categorium
    {
        public decimal IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Estado { get; set; }
        public decimal? IdParent { get; set; }
        public string NombreImagen { get; set; }
        public string Imagen { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioMoficacion { get; set; }
        public DateTime? FechaModifcacion { get; set; }
    }
}
