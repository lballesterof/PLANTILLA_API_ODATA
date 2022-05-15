using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProveedorProducto
    {
        public int IdPersona { get; set; }
        public int IdProducto { get; set; }
        public string CdgMon { get; set; }
        public decimal Precio { get; set; }
        public string NumeroParte { get; set; }
        public string Unidad { get; set; }
        public decimal? Factor { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
