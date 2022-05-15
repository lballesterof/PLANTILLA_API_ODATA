using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfUsuarioAlertum
    {
        public string Alerta { get; set; }
        public string Usuario { get; set; }
        public string Liberar { get; set; }
        public string Aprobar { get; set; }
        public string Rechazar { get; set; }
    }
}
