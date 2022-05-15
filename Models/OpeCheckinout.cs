using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCheckinout
    {
        public decimal IdCheckinout { get; set; }
        public string Estado { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Hora { get; set; }
        public DateTime FechaSalidaPrevista { get; set; }
        public decimal CantNoches { get; set; }
        public string NoPresentado { get; set; }
        public string Regimen { get; set; }
        public string Comida { get; set; }
        public decimal Adulto { get; set; }
        public decimal Nino { get; set; }
        public decimal Bebe { get; set; }
        public decimal? IdCliente { get; set; }
        public decimal? IdEmpresa { get; set; }
        public decimal? IdAgencia { get; set; }
        public decimal? IdTourOperador { get; set; }
        public decimal? IdClienteFacturar { get; set; }
        public string TipoTarifa { get; set; }
        public string TipoHabitacion { get; set; }
        public string Habitacion { get; set; }
        public string SwtTipoHabitacion { get; set; }
        public decimal? IdReserva { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string SwtCheckinout { get; set; }
        public decimal? IdCheckinoutParent { get; set; }
        public string HoraSalida { get; set; }
        public string Turno { get; set; }
    }
}
