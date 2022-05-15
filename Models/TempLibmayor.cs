using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TempLibmayor
    {
        public string Cuenta { get; set; }
        public string NomCta { get; set; }
        public string FechaOper { get; set; }
        public string NumComp { get; set; }
        public string Glosa { get; set; }
        public string Td { get; set; }
        public string Numero { get; set; }
        public string Fecha { get; set; }
        public string Anexo { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Secuencia { get; set; }
    }
}
