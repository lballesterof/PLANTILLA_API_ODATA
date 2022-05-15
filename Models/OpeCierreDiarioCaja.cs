using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCierreDiarioCaja
    {
        public string CodigoSucursal { get; set; }
        public DateTime FechaCaja { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Egreso { get; set; }
        public decimal SaldoFinal { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CdgCaja { get; set; }
        public string CodigoTurno { get; set; }
        public string CodigoMoneda { get; set; }
        public string CodigoCajero { get; set; }
    }
}
