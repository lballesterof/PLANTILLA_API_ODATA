using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeComisionVentaPersona
    {
        public decimal IdPedido { get; set; }
        public decimal IdPersona { get; set; }
        public string CdgCargo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
