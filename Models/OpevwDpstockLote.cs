using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDpstockLote
    {
        public string CodigoSucursal { get; set; }
        public string TipoGuia { get; set; }
        public int IdProducto { get; set; }
        public string Lote { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
    }
}
