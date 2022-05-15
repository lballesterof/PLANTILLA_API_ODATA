using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwListadoProducto
    {
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal IdProducto { get; set; }
    }
}
