using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhCapacitacion
    {
        public string Codigo { get; set; }
        public decimal IdPersona { get; set; }
        public string TipoEvento { get; set; }
        public string TipoCurso { get; set; }
        public string TipoOrganizacion { get; set; }
        public string Organizacion { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaIrealizacion { get; set; }
        public DateTime FechaFrealizacion { get; set; }
        public decimal CantidadHora { get; set; }
        public string Lugar { get; set; }
        public string Nota { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
