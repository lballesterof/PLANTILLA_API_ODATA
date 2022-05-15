using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleGuia2
    {
        public int IdDocumento { get; set; }
        public int IdProducto { get; set; }
        public string Lote { get; set; }
        public decimal Cantidad { get; set; }
        public string CodigoUnidad { get; set; }
        public DateTime FechaEnvasado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Meses { get; set; }
        public int Secuencia { get; set; }
        public int SecuenciaDoc { get; set; }
        public string CodigoSucursal { get; set; }
        public string Serie { get; set; }
        public string SerieGen { get; set; }
    }
}
