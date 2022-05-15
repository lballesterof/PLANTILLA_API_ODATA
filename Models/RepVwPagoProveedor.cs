using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwPagoProveedor
    {
        public DateTime DdFechaEmision { get; set; }
        public string Ruc { get; set; }
        public string Proveedor { get; set; }
        public string NombreContacto1 { get; set; }
        public string TelefonoContacto1 { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string CuentaCci { get; set; }
        public string CondicionPago { get; set; }
        public string ContadoCredito { get; set; }
        public string Tdoc { get; set; }
        public string NumDocu { get; set; }
        public string Mon { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
