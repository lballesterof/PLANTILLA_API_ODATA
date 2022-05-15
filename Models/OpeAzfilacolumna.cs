using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAzfilacolumna
    {
        public string CodigoSucursal { get; set; }
        public string CodigoZona { get; set; }
        public string Fila { get; set; }
        public string Columna { get; set; }
        public string CantItems { get; set; }
        public decimal? Area { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
