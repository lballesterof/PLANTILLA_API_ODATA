using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeReprogramacionOc
    {
        public decimal IdOc { get; set; }
        public decimal IdProducto { get; set; }
        public int SecOc { get; set; }
        public decimal Secuencia { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string TipoFecha { get; set; }
        public string Estado { get; set; }
        public string Canal { get; set; }
    }
}
