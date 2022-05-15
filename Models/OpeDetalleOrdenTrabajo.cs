using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleOrdenTrabajo
    {
        public string CodigoServicio { get; set; }
        public string CodigoOrdenTrabajo { get; set; }
        public decimal IdProducto { get; set; }
        public string CdgServ { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public string Observacion { get; set; }
        public string Tipo { get; set; }
        public int Secuencia { get; set; }
        public string Moneda { get; set; }
        public decimal? ValorOri { get; set; }
        public decimal? Importe { get; set; }
        public string Referencia1 { get; set; }
        public decimal? CantReq { get; set; }
        public decimal? CantUtil { get; set; }
        public string Flag { get; set; }
    }
}
