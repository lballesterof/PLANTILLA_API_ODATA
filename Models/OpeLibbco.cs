using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeLibbco
    {
        public OpeLibbco()
        {
            OpeDetalleLibbcos = new HashSet<OpeDetalleLibbco>();
        }

        public short Ano { get; set; }
        public short Mes { get; set; }
        public string CdgBco { get; set; }
        public string NumCta { get; set; }
        public string NumCor { get; set; }
        public string CdgMon { get; set; }
        public DateTime FecDocu { get; set; }
        public string NumDocu { get; set; }
        public string ConDocu { get; set; }
        public decimal ImpDebe { get; set; }
        public decimal ImpHaber { get; set; }
        public decimal ImpSaldo { get; set; }
        public string CdgTmov { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public string CdgCta { get; set; }
        public string SwtEst { get; set; }
        public string SwtAtn { get; set; }
        public decimal? TipCmb { get; set; }
        public string DesPrv { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NumCorModulo { get; set; }
        public string Modulo { get; set; }
        public string FechaRef1 { get; set; }
        public string CdgBco2 { get; set; }
        public string NumCta2 { get; set; }
        public string SwtPro { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal? Avance { get; set; }
        public string Turno { get; set; }
        public string NumRequi { get; set; }
        public string NumRef { get; set; }
        public decimal? IdSd { get; set; }
        public string Docs { get; set; }

        public virtual ICollection<OpeDetalleLibbco> OpeDetalleLibbcos { get; set; }
    }
}
