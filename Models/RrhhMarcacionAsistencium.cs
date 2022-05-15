using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhMarcacionAsistencium
    {
        public decimal IdMarcacion { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime Ingreso { get; set; }
        public string HoraIngreso { get; set; }
        public DateTime Salida { get; set; }
        public string HoraSalida { get; set; }
        public string Ano { get; set; }
        public int Mes { get; set; }
        public int Semana { get; set; }
        public string CdgProy { get; set; }
        public int? Faltas { get; set; }
        public decimal HoraTrab { get; set; }
        public decimal MinuTard { get; set; }
        public decimal? He25 { get; set; }
        public decimal He35 { get; set; }
        public decimal? He60 { get; set; }
        public decimal He100 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
