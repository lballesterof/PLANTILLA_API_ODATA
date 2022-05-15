using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTdocApertura
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string CodigoCaja { get; set; }
        public DateTime FechaApertura { get; set; }
        public string TipoDocumento { get; set; }
        public string Series { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
