using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDocumentoCompra2
    {
        public decimal IdDocumento { get; set; }
        public decimal IdPersona { get; set; }
        public string RucPrv { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public string CdgAfec { get; set; }
        public string CdgCpag { get; set; }
        public string CdgMon { get; set; }
        public DateTime FecDocu { get; set; }
        public DateTime FecVcto { get; set; }
        public DateTime? FecCanc { get; set; }
        public decimal ValFsub { get; set; }
        public decimal ValFdes { get; set; }
        public decimal ValFlet { get; set; }
        public decimal ValFigv { get; set; }
        public decimal ValFtot { get; set; }
        public decimal? ValFpag { get; set; }
        public string ObsFprv { get; set; }
        public string SwtEst { get; set; }
        public string SwtOcom { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public DateTime? FecCmp { get; set; }
        public decimal? PorTigv { get; set; }
        public decimal? ValFint { get; set; }
        public string Num { get; set; }
        public string NumPoli { get; set; }
        public string SwtPoli { get; set; }
        public string BasPorr { get; set; }
        public string EstPoli { get; set; }
        public decimal? ImpIsc { get; set; }
        public string CdgTref { get; set; }
        public string NumRef { get; set; }
        public DateTime? FecRef { get; set; }
        public decimal? Imp2 { get; set; }
        public decimal? Imp3 { get; set; }
        public decimal? Sub2 { get; set; }
        public decimal? PorTper { get; set; }
        public decimal? ValFper { get; set; }
        public DateTime? FecPgod { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoEmpresa { get; set; }
        public decimal? TipoCambio { get; set; }
        public string AfectaTotal { get; set; }
        public DateTime? FechaDetra { get; set; }
        public string NumeroDetra { get; set; }
        public decimal? TasaDetra { get; set; }
        public string Anticipo { get; set; }
        public string TipoRefImp { get; set; }
        public string CodigoSucursal { get; set; }
        public string Ref1 { get; set; }
        public string RefeCorr { get; set; }
        public decimal? IdOc { get; set; }
        public decimal? PorTir { get; set; }
        public string NumReq { get; set; }
        public decimal? Flete { get; set; }
        public string TipoDscto { get; set; }
        public decimal? IdConvenio { get; set; }
        public decimal? IdProdlab { get; set; }
        public decimal? Numsec { get; set; }
    }
}
