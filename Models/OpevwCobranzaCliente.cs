using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwCobranzaCliente
    {
        public string IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string IdMoneda { get; set; }
        public string Moneda { get; set; }
        public string FormaPago { get; set; }
        public string FormaPagoDesc { get; set; }
        public string Cheque { get; set; }
        public decimal ImporteCobro { get; set; }
        public DateTime FechaCobro { get; set; }
        public string NumeroCobro { get; set; }
        public decimal IdPersona { get; set; }
        public string IdMonedaOri { get; set; }
        public decimal TipoCambio { get; set; }
        public string OrdenPedido { get; set; }
        public decimal? IdPedido { get; set; }
    }
}
