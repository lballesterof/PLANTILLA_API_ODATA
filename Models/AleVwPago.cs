using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AleVwPago
    {
        public DateTime? Fecha { get; set; }
        public string Movimiento { get; set; }
        public string NumComp { get; set; }
        public int? NumItm { get; set; }
        public string CdgBco { get; set; }
        public string Banco { get; set; }
        public string NumCta { get; set; }
        public string Mon { get; set; }
        public decimal? Imp { get; set; }
        public DateTime? FecVenc { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public string CdgMon { get; set; }
        public string Solicitante { get; set; }
        public string Numdocu { get; set; }
        public string Tdoc { get; set; }
    }
}
