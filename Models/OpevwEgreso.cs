using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwEgreso
    {
        public string Turno { get; set; }
        public string CodigoSucursal { get; set; }
        public DateTime FechaPago { get; set; }
        public string Registro { get; set; }
        public string Operacion { get; set; }
        public string NomOperacion { get; set; }
        public string Persona { get; set; }
        public string Observacion { get; set; }
        public decimal? Importe { get; set; }
    }
}
