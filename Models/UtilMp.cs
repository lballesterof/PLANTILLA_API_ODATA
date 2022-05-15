using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class UtilMp
    {
        public string CdgTabla { get; set; }
        public string Numero { get; set; }
        public string CodigoSucursal { get; set; }
        public string CdgMovi { get; set; }
        public string TipoIs { get; set; }
        public string Estado { get; set; }
        public string MotivoMp { get; set; }
        public decimal? ProbCierre { get; set; }
        public string TipoUtil { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
