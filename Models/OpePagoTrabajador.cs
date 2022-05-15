using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePagoTrabajador
    {
        public int IdPersona { get; set; }
        public string Ruc { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public decimal ImpPago { get; set; }
        public string CdgMon { get; set; }
        public decimal TipCmb { get; set; }
        public string NumCor { get; set; }
        public string NumCta { get; set; }
        public string CdgBco { get; set; }
        public string NumCheq { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public DateTime FecPago { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CdgFpag { get; set; }
        public string CdgVend { get; set; }
        public string CdgMonOri { get; set; }
        public decimal? ImpPagoSoles { get; set; }
        public decimal? ImpPagoDolar { get; set; }
    }
}
