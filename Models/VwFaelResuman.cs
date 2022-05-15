using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelResuman
    {
        public string ConfRazonSocial { get; set; }
        public string ConfRuc { get; set; }
        public string TipoDocuEmpr { get; set; }
        public DateTime FechDocu { get; set; }
        public string TipoDocuDocu { get; set; }
        public string Moneda { get; set; }
        public string Serie { get; set; }
        public string IdTipoIdentidad { get; set; }
        public string NumeroIdentidad { get; set; }
        public decimal? InicioRango { get; set; }
        public decimal? FinRango { get; set; }
        public string TotaOperGravTipo { get; set; }
        public decimal ValoVentGravTota { get; set; }
        public string TotaOperInafTipo { get; set; }
        public decimal ValoVentInafTota { get; set; }
        public string TotaOperExonTipo { get; set; }
        public decimal ValoVentExonTota { get; set; }
        public int IndicadorSumOtroCargo { get; set; }
        public int TotalSumOtroCargo { get; set; }
        public int TotalIsc { get; set; }
        public int TotalIsc2 { get; set; }
        public string CodiIsc { get; set; }
        public string NombIsc { get; set; }
        public string CodiInteIsc { get; set; }
        public decimal VedvMontoIgv { get; set; }
        public decimal VedvMontoIgv2 { get; set; }
        public string CodiIgvTota { get; set; }
        public string NombIgvTota { get; set; }
        public string NombIgvIntTota { get; set; }
        public decimal Monto { get; set; }
        public int NumeItem { get; set; }
        public string FechGene { get; set; }
        public string VersionUbl { get; set; }
        public string VersionEstructura { get; set; }
        public string IdResumen { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public int CodigoOperacion { get; set; }
        public string TipoDocuRef { get; set; }
        public string NumeDocuRef { get; set; }
    }
}
