using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwProducto
    {
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Inventariable { get; set; }
        public string UnidadCompra { get; set; }
        public string UnidadAlmacen { get; set; }
        public string UnidadVenta { get; set; }
        public decimal? Factor { get; set; }
        public string Estado { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Largo { get; set; }
        public DateTime? DdFechaCreacion { get; set; }
        public DateTime? DdFechaUltimaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
