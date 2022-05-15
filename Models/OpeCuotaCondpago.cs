using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCuotaCondpago
    {
        public string NumCopa { get; set; }
        public decimal NumCuota { get; set; }
        public decimal Dias { get; set; }
        public decimal PorCuota { get; set; }
    }
}
