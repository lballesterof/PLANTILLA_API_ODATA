using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleCotizacion
    {
        public decimal IdCotizacion { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Igv { get; set; }
        public decimal Importe { get; set; }
        public string Observacion { get; set; }
        public decimal Secuencia { get; set; }
        public decimal PrecioOriginal { get; set; }
        public string Tipo { get; set; }
        public decimal? ImporteDscto { get; set; }
        public string AfectoIgv { get; set; }
        public decimal? Comision { get; set; }
        public decimal? IdPresupuesto { get; set; }
        public string CdgServ { get; set; }
        public byte[] ImagenRef { get; set; }
        public string Observacion2 { get; set; }
        public string Unidad { get; set; }
        public decimal? PorPercepcion { get; set; }
        public decimal? Percepcion { get; set; }
        public decimal? ValorVen { get; set; }
        public string UnidVen { get; set; }
        public DateTime? FechaVen { get; set; }
        public string CdgKit { get; set; }
        public string SwtPigv { get; set; }
        public decimal? PorDetraccion { get; set; }
        public decimal? Detraccion { get; set; }
        public decimal? FactorConversion { get; set; }
        public decimal? Margen { get; set; }
        public decimal? ImporteMargen { get; set; }
        public decimal? CostoAdic { get; set; }
        public decimal? CantKit { get; set; }
        public string SwtImp { get; set; }
        public string TipoItem { get; set; }
    }
}
