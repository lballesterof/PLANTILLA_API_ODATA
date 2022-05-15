using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeRecetum
    {
        public int IdProducto { get; set; }
        public int IdReceta { get; set; }
        public decimal Cantidad { get; set; }
        public string CdgUnidad { get; set; }
        public string Tipo { get; set; }
        public int Secuencia { get; set; }
        public string TipoLista { get; set; }
        public string ListaPrecio { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Total { get; set; }
        public string Almacen { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? Cant { get; set; }
    }
}
