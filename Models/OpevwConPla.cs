using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwConPla
    {
        public string Ano { get; set; }
        public int Mes { get; set; }
        public string Con { get; set; }
        public decimal ValDet { get; set; }
        public string CdgPlanilla { get; set; }
        public string TipoTrab { get; set; }
        public string Cuentatd { get; set; }
        public string Cuentaod { get; set; }
        public string Cuentath { get; set; }
        public string Cuentaoh { get; set; }
    }
}
