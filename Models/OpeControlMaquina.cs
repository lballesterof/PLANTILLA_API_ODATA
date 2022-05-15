using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeControlMaquina
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
