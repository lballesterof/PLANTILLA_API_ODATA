using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeNumeroDocumento
    {
        public OpeNumeroDocumento()
        {
            OpeDetalleNumeroDocumentos = new HashSet<OpeDetalleNumeroDocumento>();
        }

        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string TipoDocumento { get; set; }
        public string Serie { get; set; }
        public string NumeroInicio { get; set; }
        public string NumeroFin { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<OpeDetalleNumeroDocumento> OpeDetalleNumeroDocumentos { get; set; }
    }
}
