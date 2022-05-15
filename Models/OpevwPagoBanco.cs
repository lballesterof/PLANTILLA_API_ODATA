using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwPagoBanco
    {
        public string IdTipoDocumento { get; set; }
        public int ProveedorCodigo { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string IdMoneda { get; set; }
        public string IdMonedaOri { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Moneda { get; set; }
        public string CdgFpag { get; set; }
        public string FormaPagoDesc { get; set; }
        public string Banco { get; set; }
        public string NumeroCheque { get; set; }
        public decimal ImportePago { get; set; }
        public DateTime FechaPago { get; set; }
        public string NumCor { get; set; }
    }
}
