using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeImpProdWeb
    {
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public string Ruta { get; set; }
        public string NombreImagen { get; set; }
        public string NombreCarpeta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
