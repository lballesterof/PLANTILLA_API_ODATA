using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CrmAplazarAviso
    {
        public decimal IdAplazar { get; set; }
        public decimal IdAviso { get; set; }
        public string Asunto { get; set; }
        public DateTime FechaAviso { get; set; }
        public string HoraAviso { get; set; }
        public decimal Tiempo { get; set; }
        public string UnidadTiempo { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
