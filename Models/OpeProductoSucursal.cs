using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProductoSucursal
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int IdProducto { get; set; }
        public decimal PagoTrabajador { get; set; }
        public string IdUnidadPagoTrabajador { get; set; }
        public decimal PagoEmpresa { get; set; }
        public string IdUnidadPagoEmpresa { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
