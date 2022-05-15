using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServServicioTecnico
    {
        public string NumeroFre { get; set; }
        public decimal IdPersona { get; set; }
        public string SerieGenerada { get; set; }
        public string SerieEquipo { get; set; }
        public decimal IdProducto { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string IdTecnico { get; set; }
        public string Observacion { get; set; }
        public string Tipo { get; set; }
        public string TipoServicio { get; set; }
        public string CondicionEquipo { get; set; }
        public string Diagnostico { get; set; }
        public string AccionSeguir { get; set; }
        public string IdResultado { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
