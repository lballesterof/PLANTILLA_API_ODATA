using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhConceptoPersona
    {
        public string CdgPara { get; set; }
        public int IdPersona { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public int Semana { get; set; }
        public string CdgProy { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public decimal? Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? Total { get; set; }
    }
}
