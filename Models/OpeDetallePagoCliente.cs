using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallePagoCliente
    {
        public string NumeroCobro { get; set; }
        public string TipoDocumento { get; set; }
        public string Moneda { get; set; }
        public int IdDocumento { get; set; }
        public string FormaPago { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal ImporteCobro { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Numero { get; set; }
        public decimal IdPersona { get; set; }
        public string Banco { get; set; }
        public string Cheque { get; set; }
        public DateTime FechaCobro { get; set; }
        public string RucCli { get; set; }
        public string MonedaOri { get; set; }
        public decimal? Interes { get; set; }
        public decimal? IdPedido { get; set; }
    }
}
