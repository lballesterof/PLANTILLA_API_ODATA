using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServPlanFacturacionProyecto
    {
        public decimal IdProyecto { get; set; }
        public string Descripcion { get; set; }
        public decimal PorFact { get; set; }
        public decimal ValorVenta { get; set; }
        public string Estado { get; set; }
        public decimal Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
