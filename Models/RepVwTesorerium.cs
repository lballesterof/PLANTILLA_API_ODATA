using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwTesorerium
    {
        public short Ano { get; set; }
        public short Mes { get; set; }
        public string CdgBco { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string CdgMon { get; set; }
        public string Moneda { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public string Numero { get; set; }
        public string Concepto { get; set; }
        public string Proveedor { get; set; }
        public string CdgTmov { get; set; }
        public string Movimiento { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal? DebeSoles { get; set; }
        public decimal? HaberSoles { get; set; }
        public string Cheque { get; set; }
        public string FechaRef1 { get; set; }
        public string FormaPago { get; set; }
        public string NumRef { get; set; }
    }
}
