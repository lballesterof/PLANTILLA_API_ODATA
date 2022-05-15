using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTransferencium
    {
        public string NumTran { get; set; }
        public DateTime FecTran { get; set; }
        public string RucPrv { get; set; }
        public string CdgBco { get; set; }
        public string NumCta { get; set; }
        public string CdgCta { get; set; }
        public string CdgMon { get; set; }
        public string NumCor { get; set; }
        public string NumCheq { get; set; }
        public decimal ImpTran { get; set; }
        public string BcoTran { get; set; }
        public string CtaTran { get; set; }
        public string MonTran { get; set; }
        public string ObsTran { get; set; }
        public decimal PagTran { get; set; }
        public string SwtTran { get; set; }
        public string CdgTdoc { get; set; }
        public string CdgTmov { get; set; }
        public decimal? IdPersona { get; set; }
        public string CodigoSucursal { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string RefNumero { get; set; }
        public string RefCdgTdoc { get; set; }
        public decimal? TipoCambio { get; set; }
        public string NumRequi { get; set; }
        public string SwtReq { get; set; }
        public string Referencia { get; set; }
    }
}
