using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwCompromisoFinanciero
    {
        public string Referencia { get; set; }
        public string Compromiso { get; set; }
        public string NumComp { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string NumCor { get; set; }
        public string Moneda { get; set; }
        public DateTime? DdFechaDesembolso { get; set; }
        public DateTime? DdFechaVencimiento { get; set; }
        public string NumItm { get; set; }
        public string FechaDocu { get; set; }
        public string FechaVencDocu { get; set; }
        public string Tdoc { get; set; }
        public string NumDocu { get; set; }
        public decimal? Cuota { get; set; }
        public decimal? Pago { get; set; }
        public decimal? Saldo { get; set; }
    }
}
