using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleReqitem
    {
        public decimal IdRequerimiento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string Unidad { get; set; }
        public decimal? FactorConversion { get; set; }
        public string CdgResponsable { get; set; }
        public string CdgUso { get; set; }
        public string CdgPrioridad { get; set; }
        public string CdgCuso { get; set; }
    }
}
