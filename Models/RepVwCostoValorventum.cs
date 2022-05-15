using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwCostoValorventum
    {
        public string Tp { get; set; }
        public string CodigoCajero { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Tipo { get; set; }
        public string Mesano { get; set; }
        public string NumeroSerie { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Mon { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? CostoUnitario { get; set; }
        public decimal? CostoTotal { get; set; }
        public decimal? Utilidad { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Td { get; set; }
    }
}
