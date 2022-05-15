using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwSaldoNegativo
    {
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Inventariable { get; set; }
        public string Almacen { get; set; }
        public string UsuarioProcesoUltimaValorizacion { get; set; }
        public DateTime FechaProcesoUltimaValorizacion { get; set; }
        public decimal AñO { get; set; }
        public decimal Mes { get; set; }
        public decimal SaldoMes { get; set; }
        public DateTime? DdFechaFinMes { get; set; }
    }
}
