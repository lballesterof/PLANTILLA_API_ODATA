using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallePresupuesto2
    {
        public decimal IdPresupuesto { get; set; }
        public decimal IdProducto { get; set; }
        public string CdgServ { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Margen { get; set; }
        public decimal Dscto { get; set; }
        public decimal ValorUnit { get; set; }
        public string Observacion { get; set; }
        public string Observacion2 { get; set; }
        public string Tipo { get; set; }
        public int Secuencia { get; set; }
        public string Moneda { get; set; }
        public decimal ValorOri { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Importe2 { get; set; }
        public string Unidad { get; set; }
        public int? IdProveedor { get; set; }
    }
}
