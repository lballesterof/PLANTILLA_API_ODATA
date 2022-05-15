using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeContratoCuotaParqueo
    {
        public decimal IdContrato { get; set; }
        public decimal Secuencia { get; set; }
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Cuota { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
