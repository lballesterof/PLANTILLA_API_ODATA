using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwReqOpCob
    {
        public DateTime DdFechaOp { get; set; }
        public string NumeroPedido { get; set; }
        public string Cliente { get; set; }
        public string MonOp { get; set; }
        public decimal TotalOp { get; set; }
        public string Sucursal { get; set; }
        public string Vendedor { get; set; }
        public string Estado { get; set; }
        public decimal? TotalOc { get; set; }
        public string Responsable { get; set; }
        public decimal? TotalCheque { get; set; }
        public decimal? TotalGcc { get; set; }
        public decimal? TotalCobrado { get; set; }
        public decimal? TotalXCobrar { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}
