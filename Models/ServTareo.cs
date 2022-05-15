using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServTareo
    {
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdPersona { get; set; }
        public string CdgCc { get; set; }
        public string ScdgCc { get; set; }
        public string CdgTurno { get; set; }
        public string TipoDia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
