using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwCajaChica
    {
        public string Area { get; set; }
        public string NumCaja { get; set; }
        public string FormaPago { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public DateTime DdFechaCaja { get; set; }
        public string Numero { get; set; }
        public string Movimiento { get; set; }
        public decimal Importe { get; set; }
        public DateTime? FecCierre { get; set; }
        public string Observacion { get; set; }
        public string CdgOp { get; set; }
        public string CdgOs { get; set; }
    }
}
