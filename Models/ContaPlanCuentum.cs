using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaPlanCuentum
    {
        public string ContaCodigo { get; set; }
        public string ContaDescripcion { get; set; }
        public string ContaMovimiento { get; set; }
        public string ContaMonetaria { get; set; }
        public string ContaCentroCosto { get; set; }
        public string ContaOficial { get; set; }
        public string ContaPatrimonial { get; set; }
        public string ContaDeudora { get; set; }
        public string ContaAcrededora { get; set; }
        public string ContaTipoAnalitica { get; set; }
        public string ContaCtaDebe { get; set; }
        public string ContaCtaHaber { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string ContaEstado { get; set; }
        public string ContaCambio { get; set; }
        public string ContaGanancia { get; set; }
        public string ContaPerdida { get; set; }
        public string ContaNivelCuenta { get; set; }
        public string ContaTipoCuenta { get; set; }
        public string ContaTipoAnalisis { get; set; }
        public string ContaCtaCte { get; set; }
        public string ContaPrcGst { get; set; }
        public string ContaCtaFlujo { get; set; }
        public string ContaCtaCierre { get; set; }
        public string ContaMoneda { get; set; }
        public string ContaCodigoParent { get; set; }
        public string ContaCodigoEq { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string ContaMonetariaEspecial { get; set; }
    }
}
