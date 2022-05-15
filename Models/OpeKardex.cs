using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeKardex
    {
        public string CodigoSucursal { get; set; }
        public decimal? IdProducto { get; set; }
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Saldo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
