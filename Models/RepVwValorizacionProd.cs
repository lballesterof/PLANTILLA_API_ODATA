using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwValorizacionProd
    {
        public string AlmacenNombre { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public string TipoGuia { get; set; }
        public decimal? CostoTotalSoles { get; set; }
        public decimal? CostoTotalDolares { get; set; }
    }
}
