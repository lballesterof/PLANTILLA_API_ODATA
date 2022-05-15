using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTarifa
    {
        public decimal IdTarifa { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Al { get; set; }
        public string Ad { get; set; }
        public string Mp { get; set; }
        public string Pc { get; set; }
        public string Ti { get; set; }
        public string CargoPersona { get; set; }
        public string CargoDia { get; set; }
        public decimal Noches { get; set; }
        public decimal AdultoMin { get; set; }
        public decimal AdultoMax { get; set; }
        public decimal NinoMax { get; set; }
        public decimal PaxMin { get; set; }
        public decimal PaxMax { get; set; }
        public decimal NocheMax { get; set; }
        public decimal NocheMin { get; set; }
        public decimal DiasDscto { get; set; }
        public decimal Dscto { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miercoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sabado { get; set; }
        public string Domingo { get; set; }
        public string ConceptoCargo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
