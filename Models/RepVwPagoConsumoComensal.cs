using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwPagoConsumoComensal
    {
        public string Ruc { get; set; }
        public string Comensal { get; set; }
        public DateTime DdFechaRegistro { get; set; }
        public DateTime? DdFechaPago { get; set; }
        public string TipoMenu { get; set; }
        public decimal MontoTrabajador { get; set; }
        public decimal MontoEmpresa { get; set; }
        public decimal? ImportePagado { get; set; }
    }
}
