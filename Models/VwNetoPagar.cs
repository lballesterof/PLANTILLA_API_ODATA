using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwNetoPagar
    {
        public string Ida { get; set; }
        public string Ano { get; set; }
        public int Mes { get; set; }
        public decimal Importe { get; set; }
    }
}
