using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePlanFacturacionOc
    {
        public decimal IdOc { get; set; }
        public decimal Item { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaEstimada { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
    }
}
