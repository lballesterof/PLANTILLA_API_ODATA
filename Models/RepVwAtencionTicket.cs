using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwAtencionTicket
    {
        public string NumTicket { get; set; }
        public string Persona { get; set; }
        public DateTime DdFechaEmision { get; set; }
        public DateTime? DdDfechaAtencion { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
    }
}
