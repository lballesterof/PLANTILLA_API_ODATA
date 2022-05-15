using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CrmListaMktIntegrante
    {
        public decimal IdLista { get; set; }
        public decimal IdProspecto { get; set; }
        public decimal IdCliente { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
