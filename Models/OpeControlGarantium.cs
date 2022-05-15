using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeControlGarantium
    {
        public string Nombre { get; set; }
        public string Serie { get; set; }
        public string SerieReem { get; set; }
        public int IdProducto { get; set; }
        public int Recordatorio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int? IdGuia { get; set; }
        public int? IdPedido { get; set; }
        public string Tipo { get; set; }
        public int? IdCliente { get; set; }
        public string Nota { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
