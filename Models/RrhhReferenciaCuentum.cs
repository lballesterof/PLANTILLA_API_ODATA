using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhReferenciaCuentum
    {
        public decimal IdPersona { get; set; }
        public string Banco { get; set; }
        public string NumCta { get; set; }
        public string Moneda { get; set; }
        public string TipoCta { get; set; }
        public decimal Secuencia { get; set; }
        public string Activo { get; set; }
    }
}
