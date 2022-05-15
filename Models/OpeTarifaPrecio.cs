using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTarifaPrecio
    {
        public decimal IdTarifa { get; set; }
        public string Temporada { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Alojamiento { get; set; }
        public decimal Desayuno { get; set; }
        public decimal MediaPension { get; set; }
        public decimal PensionCompleta { get; set; }
        public decimal TodoIncluido { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
