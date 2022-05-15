using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleSolicitudDocumento
    {
        public decimal IdSolicitud { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal Secuencia { get; set; }
        public decimal? Subtotal { get; set; }
        public string AfectoIgv { get; set; }
        public string SwtPigv { get; set; }
        public string TipoAfecIgv { get; set; }
    }
}
