using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeLabFre
    {
        public string NumeroFre { get; set; }
        public string Serie { get; set; }
        public string CdgEstado { get; set; }
        public string Observacion { get; set; }
        public string CdgResponsable { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string Observacion2 { get; set; }
        public string Tipo { get; set; }
        public int? IdProducto { get; set; }
    }
}
