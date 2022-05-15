using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeUsuarioForm
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int IdForm { get; set; }
        public string Operaciones { get; set; }
        public string Codigo { get; set; }
    }
}
