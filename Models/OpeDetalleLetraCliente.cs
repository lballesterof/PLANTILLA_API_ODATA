using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleLetraCliente
    {
        public string NumeroLetra { get; set; }
        public int IdPersona { get; set; }
        public string RucCli { get; set; }
        public string Banco { get; set; }
        public string NumeroCuenta { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Moneda { get; set; }
        public int Plazo { get; set; }
        public DateTime Vencimiento { get; set; }
        public decimal Importe { get; set; }
        public DateTime? FechaGiro { get; set; }
        public string LugarGiro { get; set; }
        public string ReferenciaGiro { get; set; }
        public string NombreAval { get; set; }
        public string DireccionAval { get; set; }
        public string RucAval { get; set; }
        public string TelefonoAval { get; set; }
        public string NumeroBanco { get; set; }
        public string NumeroLori { get; set; }
        public string Estado { get; set; }
        public string Seccion { get; set; }
        public string CorLren { get; set; }
        public string NumeroLren { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public decimal? ImporteRet { get; set; }
        public decimal TipoCambio { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Referencia1 { get; set; }
        public decimal? Interes { get; set; }
        public decimal? ImpInteres { get; set; }
    }
}
