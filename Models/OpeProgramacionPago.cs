using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProgramacionPago
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string Num { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Estado { get; set; }
        public decimal? ImporteMn { get; set; }
        public decimal? ImporteMe { get; set; }
        public string CdgBanco { get; set; }
        public string NumCta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
