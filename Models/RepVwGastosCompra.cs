using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwGastosCompra
    {
        public int IdDocumento { get; set; }
        public decimal NumSec { get; set; }
        public decimal IdPersona { get; set; }
        public DateTime DdFechaEmision { get; set; }
        public DateTime? FecCmp { get; set; }
        public string Num { get; set; }
        public string RucPrv { get; set; }
        public string NumDocu { get; set; }
        public string Tdoc { get; set; }
        public string Proveedor { get; set; }
        public string Mon { get; set; }
        public decimal Total { get; set; }
        public string Glosa { get; set; }
        public string CdgGasto { get; set; }
        public string NombreGasto { get; set; }
        public string CuentaReferenciaGasto { get; set; }
        public string CdgCc { get; set; }
        public string CentroCosto { get; set; }
        public string Cuenta { get; set; }
        public string NombreCuenta { get; set; }
    }
}
