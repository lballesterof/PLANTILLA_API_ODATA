using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwRq
    {
        public DateTime? DdFechapedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string Prioridad { get; set; }
        public decimal Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public string Uso { get; set; }
        public string Categoria { get; set; }
        public decimal? Stock { get; set; }
        public string ResponsableRqs { get; set; }
        public string ResponsableComp { get; set; }
        public string Proveedor { get; set; }
        public string CdgRq { get; set; }
        public string CdgOc { get; set; }
        public string CdgSol { get; set; }
        public string EstadoSol { get; set; }
        public decimal CantDevuelta { get; set; }
    }
}
