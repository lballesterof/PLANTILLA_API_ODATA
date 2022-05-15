using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAnexoDocumentoCompra
    {
        public decimal IdDocumento { get; set; }
        public decimal Secuencia { get; set; }
        public string Ruta { get; set; }
        public string NombreArchivo { get; set; }
        public string Extension { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
