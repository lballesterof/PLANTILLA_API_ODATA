using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOdocumentoCompra
    {
        public string NumCor { get; set; }
        public string Tdoc { get; set; }
        public string NumDocu { get; set; }
        public string Ruc { get; set; }
        public string TdocComp { get; set; }
        public string NumDocuComp { get; set; }
        public string RucComp { get; set; }
        public decimal IdPersona { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal ImporteTransaccion { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoSucursal { get; set; }
        public string AutoG { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
