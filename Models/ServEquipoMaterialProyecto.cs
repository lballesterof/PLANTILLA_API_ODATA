using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServEquipoMaterialProyecto
    {
        public decimal IdProyecto { get; set; }
        public decimal IdRequerimiento { get; set; }
        public decimal IdProducto { get; set; }
        public string Moneda { get; set; }
        public string Unidad { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Importe { get; set; }
        public decimal Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
