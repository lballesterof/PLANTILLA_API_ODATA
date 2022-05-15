using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAlmacenzona
    {
        public string CodigoSucursal { get; set; }
        public string CodigoZona { get; set; }
        public string NombreZona { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
