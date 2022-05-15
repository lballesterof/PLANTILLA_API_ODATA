using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwCajab
    {
        public string FecDocu { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string Codigo { get; set; }
        public string NumRef { get; set; }
        public string Girado { get; set; }
        public string DesPrv { get; set; }
        public string Moneda { get; set; }
        public decimal? Ingresome { get; set; }
        public decimal? Salidame { get; set; }
        public int SaldoRestanteme { get; set; }
        public string FechaTc { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Ingresomn { get; set; }
        public decimal? Egresomn { get; set; }
        public int Tipo { get; set; }
        public string CdgBcoEmp { get; set; }
        public string CtaCteEmp { get; set; }
        public DateTime? FechMovBco { get; set; }
        public string Mon { get; set; }
    }
}
