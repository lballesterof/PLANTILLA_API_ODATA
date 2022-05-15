using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePlantillaRecetum
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int IdProducto { get; set; }
        public string TipoLista { get; set; }
        public string ListaPrecio { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public string Imprime { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Cantidad { get; set; }
        public string Almacen { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Unidad { get; set; }
    }
}
