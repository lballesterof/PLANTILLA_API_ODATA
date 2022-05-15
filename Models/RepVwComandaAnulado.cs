using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwComandaAnulado
    {
        public DateTime DdFechaPedido { get; set; }
        public DateTime? DdFechaAnulacion { get; set; }
        public string NumeroPedido { get; set; }
        public string Mesa { get; set; }
        public string Zona { get; set; }
        public string Cpago { get; set; }
        public string SimboloMoneda { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public string Mozo { get; set; }
        public string UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
