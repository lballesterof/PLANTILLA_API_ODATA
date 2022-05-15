using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwVentaComensal
    {
        public string Codigo { get; set; }
        public string Ruc { get; set; }
        public string Comensal { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal IdPersona { get; set; }
        public string TipoTrabajador { get; set; }
    }
}
