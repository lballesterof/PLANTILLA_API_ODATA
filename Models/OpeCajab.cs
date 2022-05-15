using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCajab
    {
        public decimal IdMovimiento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaTc { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal? IdPersona { get; set; }
        public string GiraDetalle { get; set; }
        public string Observacion { get; set; }
        public string RefChop { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
