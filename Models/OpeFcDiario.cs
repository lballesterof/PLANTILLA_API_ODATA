using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeFcDiario
    {
        public string TipoFlujo { get; set; }
        public string MovimientoFlujo { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Ruc { get; set; }
        public string TipoPersona { get; set; }
        public string MovimientoBanco { get; set; }
        public DateTime? FechaCaja { get; set; }
        public string TipoOperacion { get; set; }
        public string Banco { get; set; }
        public string EstadoDocumento { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? ImporteSoles { get; set; }
        public decimal? ImporteDolar { get; set; }
        public decimal? TipoCambio { get; set; }
        public string EstadoFlujoCaja { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
