using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeNiGastoImportacion
    {
        public string NigaFileImportacion { get; set; }
        public string NigaIngreso { get; set; }
        public decimal NigaPorcentaje { get; set; }
        public string NigaProrrateo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string NigaTipoDocumento { get; set; }
        public string NigaNumDocu { get; set; }
        public string NigaRuc { get; set; }
        public decimal? NigaImporteDolar { get; set; }
        public decimal? NigaTc { get; set; }
        public int? Secuencia { get; set; }
        public string Cuenta { get; set; }
        public string Glosa { get; set; }
        public int? SecuenciaDocu { get; set; }
        public string CdgGasto { get; set; }
        public string CdgCosteo { get; set; }
    }
}
