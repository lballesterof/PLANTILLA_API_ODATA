using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleOrdenFabricacion
    {
        public string Codigo { get; set; }
        public int IdProducto { get; set; }
        public decimal Planificado { get; set; }
        public decimal? Entregado { get; set; }
        public decimal? Requerido { get; set; }
        public decimal? CantBase { get; set; }
        public decimal? CostoPromedio { get; set; }
        public decimal? CostoPromedioD { get; set; }
        public decimal? Costo { get; set; }
        public decimal? CostoD { get; set; }
        public string DesItem { get; set; }
        public string Ref1 { get; set; }
        public decimal? Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
