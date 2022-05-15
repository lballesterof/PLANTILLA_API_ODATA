using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeEquipoPresupuesto
    {
        public decimal IdPresupuesto { get; set; }
        public decimal IdProducto { get; set; }
        public string Fre { get; set; }
        public string SerieGenerada { get; set; }
        public string Serie { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
