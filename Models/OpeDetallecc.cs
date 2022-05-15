using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallecc
    {
        public string Codigo { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public int Secuencia { get; set; }
        public string Afecto { get; set; }
        public decimal? Importe { get; set; }
        public string Observacion { get; set; }
        public string Afina { get; set; }
        public string SwtCom { get; set; }
        public int? SecP { get; set; }
        public string CodigoP { get; set; }
        public string CdgCeco { get; set; }
        public string CdgSceco { get; set; }
        public decimal? IdReq { get; set; }

        public virtual OpeCotizacionc CodigoNavigation { get; set; }
    }
}
