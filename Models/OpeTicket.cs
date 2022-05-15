using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTicket
    {
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public string NumTicket { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public string CodigoTurno { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
