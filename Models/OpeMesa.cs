using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeMesa
    {
        public string Piso { get; set; }
        public int IdMesa { get; set; }
        public string Estado { get; set; }
        public string EstadoTrans { get; set; }
        public string Tipo { get; set; }
        public decimal? Secuencia { get; set; }
        public decimal? IdPedido { get; set; }
        public string NombreMozo { get; set; }
    }
}
