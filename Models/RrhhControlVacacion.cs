using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhControlVacacion
    {
        public decimal IdControl { get; set; }
        public int IdPersona { get; set; }
        public string TipoVaca { get; set; }
        public string Ano { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRetorno { get; set; }
        public decimal DiasEfectivo { get; set; }
        public decimal DiasVaca { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? AnoPago { get; set; }
        public int? MesPago { get; set; }
        public int? Semana { get; set; }
        public string CdgProy { get; set; }
    }
}
