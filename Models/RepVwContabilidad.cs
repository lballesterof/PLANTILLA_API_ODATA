using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwContabilidad
    {
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string Oficial { get; set; }
        public string Gerencial { get; set; }
        public DateTime? DdFechaVouc { get; set; }
        public string TipoAsiento { get; set; }
        public string TipoOperacion { get; set; }
        public string NumVouc { get; set; }
        public string CdgTana { get; set; }
        public string TipoAnalitica { get; set; }
        public string Analitica { get; set; }
        public string NombreAnalitica { get; set; }
        public string CdgAnal { get; set; }
        public string CdgCct { get; set; }
        public string Cuenta { get; set; }
        public string NombreCta { get; set; }
        public string TipoDocumento { get; set; }
        public string Numero { get; set; }
        public DateTime? DdFechaDocu { get; set; }
        public DateTime? DdFechaVenc { get; set; }
        public string Moneda { get; set; }
        public decimal? TipCmb { get; set; }
        public decimal? DebeSoles { get; set; }
        public decimal? HaberSoles { get; set; }
        public decimal? DebeDolares { get; set; }
        public decimal? HaberDolares { get; set; }
        public string Glosa { get; set; }
        public string NumeroRegistro { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
    }
}
