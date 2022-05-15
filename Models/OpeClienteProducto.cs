using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeClienteProducto
    {
        public string Codigo { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdProducto { get; set; }
        public string FlagP1 { get; set; }
        public string FlagP2 { get; set; }
        public string FlagP3 { get; set; }
        public string FlagP4 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
