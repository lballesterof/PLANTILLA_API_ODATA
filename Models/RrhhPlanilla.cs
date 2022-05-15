using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhPlanilla
    {
        public decimal IdPersona { get; set; }
        public string Ano { get; set; }
        public int Mes { get; set; }
        public int Semana { get; set; }
        public string Numero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public string CentroCosto { get; set; }
        public string Obra { get; set; }
        public string CdgPlanilla { get; set; }
        public string CdgMon { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? ImpRemunerativo { get; set; }
        public decimal? ImpNoremunerativo { get; set; }
        public decimal? ImpIngreso { get; set; }
        public decimal? ImpDescuento { get; set; }
        public decimal? ImpAportacion { get; set; }
        public decimal? ImpNeto { get; set; }
        public DateTime FechaProceso { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime? FechaCese { get; set; }
        public DateTime? FechaInicioVaca { get; set; }
        public DateTime? FechaFinVaca { get; set; }
        public string RegimenPensionario { get; set; }
        public string Cuspp { get; set; }
        public string EstableContratado { get; set; }
        public string SwtPago { get; set; }
        public string AnoRef1 { get; set; }
        public string CdgProy { get; set; }
        public string NumVouc { get; set; }
        public string NumOrig { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInicioS { get; set; }
        public DateTime? FechaFinS { get; set; }
    }
}
