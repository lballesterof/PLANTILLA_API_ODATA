using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhCtaCteTrabajador
    {
        public int IdPersona { get; set; }
        public string Moneda { get; set; }
        public string CdgPara { get; set; }
        public string Numero { get; set; }
        public decimal Importe { get; set; }
        public decimal? Pagado { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
