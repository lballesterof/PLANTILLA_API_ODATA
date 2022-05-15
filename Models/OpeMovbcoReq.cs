using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeMovbcoReq
    {
        public decimal IdMovimiento { get; set; }
        public string Codigo { get; set; }
        public string CdgBcoEmp { get; set; }
        public string CtaCteEmp { get; set; }
        public DateTime? FechMovBco { get; set; }
        public string NumRef { get; set; }
        public decimal? ImpBco { get; set; }
        public string Docs { get; set; }
        public string Tipo { get; set; }
        public string Docs2 { get; set; }
        public string Cmitf { get; set; }
        public decimal? Tc { get; set; }
        public string Girado { get; set; }
        public string Detraccion { get; set; }
    }
}
