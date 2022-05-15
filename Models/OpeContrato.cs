using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeContrato
    {
        public decimal IdContrato { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdPersonaArrendador { get; set; }
        public decimal IdPersonaCopropietario { get; set; }
        public decimal IdPersonaGarante { get; set; }
        public decimal IdPersonaResponsablePago { get; set; }
        public decimal IdPersonaOtro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Moneda { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public DateTime? FechaInicioG { get; set; }
        public DateTime? FechaFinG { get; set; }
        public decimal? PrecioG { get; set; }
        public decimal? CantidadG { get; set; }
        public decimal? ImporteG { get; set; }
        public DateTime? FechaInicioRp { get; set; }
        public DateTime? FechaFinRp { get; set; }
        public decimal? PrecioRp { get; set; }
        public decimal? CantidadRp { get; set; }
        public decimal? ImporteRp { get; set; }
        public DateTime? FechaInicioOt { get; set; }
        public DateTime? FechaFinOt { get; set; }
        public decimal? PrecioOt { get; set; }
        public decimal? CantidadOt { get; set; }
        public decimal? ImporteOt { get; set; }
        public decimal? IdProducto { get; set; }
        public string Factura { get; set; }
        public string Operador { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
