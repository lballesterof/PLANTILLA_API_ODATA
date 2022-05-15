using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePagoCliente
    {
        public string CodigoEmpresa { get; set; }
        public string NumeroCobro { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Cobrador { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public string Banco { get; set; }
        public string NumCta { get; set; }
        public string NumCor { get; set; }
        public string RefBanc { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoSucursal { get; set; }
        public string Caja { get; set; }
        public string SwtCuo { get; set; }
        public decimal? ImportePaga { get; set; }
        public decimal? ImporteVuelto { get; set; }
    }
}
