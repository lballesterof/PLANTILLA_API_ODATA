using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeParqueoVehiculo
    {
        public decimal IdMovimiento { get; set; }
        public string NumCochera { get; set; }
        public string NumPlaca { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string HoraIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string HoraSalida { get; set; }
        public string TipoVehiculo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string DescripcionVehiculo { get; set; }
        public decimal? TarifaIatp { get; set; }
        public decimal? ImporteIatp { get; set; }
        public decimal? HoraIatp { get; set; }
        public decimal? MinIatp { get; set; }
    }
}
