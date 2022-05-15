using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeContratoParqueo
    {
        public decimal IdContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal IdPersona { get; set; }
        public string Estado { get; set; }
        public decimal Importe { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? NroCuota { get; set; }
        public decimal? AnoInicio { get; set; }
        public decimal? MesInicio { get; set; }
        public string TipoTarifa { get; set; }
        public string TipoVechiculo { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public decimal? ImporteProrrateo { get; set; }
        public decimal? NumEspacio { get; set; }
        public string Referencia { get; set; }
    }
}
