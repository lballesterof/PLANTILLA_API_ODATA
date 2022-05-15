using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeNotasReq
    {
        public decimal IdNota { get; set; }
        public string CodigoRequerimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Tipo { get; set; }
    }
}
