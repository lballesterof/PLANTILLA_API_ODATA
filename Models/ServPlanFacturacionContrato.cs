using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServPlanFacturacionContrato
    {
        public string CdgServicio { get; set; }
        public decimal IdPedido { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public string DescripcionFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public string CdgResponsable { get; set; }
        public string CdgMoneda { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public string TipoCuota { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
