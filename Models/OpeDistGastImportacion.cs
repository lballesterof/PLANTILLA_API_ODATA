using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDistGastImportacion
    {
        public string CiCodigo { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string RucProv { get; set; }
        public string BaseProrrateo { get; set; }
        public decimal Valor { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CiCodigo2 { get; set; }
        public string TipoDocumentoO { get; set; }
        public string NumeroDocumentoO { get; set; }
        public string RucProvO { get; set; }
        public string CdgCosteo { get; set; }
        public int? Secuencia { get; set; }
        public int? SecuenciaDocu { get; set; }
    }
}
