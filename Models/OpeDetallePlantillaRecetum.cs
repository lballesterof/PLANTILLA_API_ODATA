using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallePlantillaRecetum
    {
        public string Codigo { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public int Secuencia { get; set; }
        public string Tipo { get; set; }
        public string ListaPrecio { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? Total { get; set; }
        public string Imprime { get; set; }
        public string Unidad { get; set; }
    }
}
