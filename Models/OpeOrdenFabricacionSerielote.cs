using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOrdenFabricacionSerielote
    {
        public string CodigoOf { get; set; }
        public decimal IdProducto { get; set; }
        public string NumEmbalaje { get; set; }
        public string Serie { get; set; }
        public string Lote { get; set; }
        public string Unidad { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
