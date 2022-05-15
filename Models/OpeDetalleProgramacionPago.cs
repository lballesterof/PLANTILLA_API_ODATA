using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleProgramacionPago
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string Num { get; set; }
        public string TipoDocumento { get; set; }
        public string Moneda { get; set; }
        public int IdDocumento { get; set; }
        public string FormaPago { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ImportePago { get; set; }
        public string Estado { get; set; }
        public decimal? IdPersona { get; set; }
        public string Numero { get; set; }
        public string Banco { get; set; }
        public string NumeroCheque { get; set; }
        public string CuentaBancaria { get; set; }
        public string RucProv { get; set; }
        public string MonedaOri { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
