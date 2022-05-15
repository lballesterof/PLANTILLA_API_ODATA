using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwMovimientoUbicacion
    {
        public string CodigoGenerado { get; set; }
        public DateTime DdFechaMovimiento { get; set; }
        public string Mov { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Producto { get; set; }
        public string Ubicacion { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Salida { get; set; }
    }
}
