using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleInventarioFisico
    {
        public string Codigo { get; set; }
        public decimal IdProducto { get; set; }
        public bool? Inventariado { get; set; }
        public bool? Contado { get; set; }
        public decimal? CantidadContada { get; set; }
        public decimal? Faltante { get; set; }
        public decimal? Sobrante { get; set; }
        public decimal? Conciliado { get; set; }
        public decimal? UtilmoOc { get; set; }
        public decimal? CostoPromedio { get; set; }
        public decimal? CostoPromediod { get; set; }
        public string Observacion { get; set; }
        public decimal? Secuencia { get; set; }
        public string CodigoEmpresa { get; set; }
    }
}
