using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCuentaCorrienteCliente
    {
        public string TipoDocumento { get; set; }
        public string NumeroSerie { get; set; }
        public int IdPersona { get; set; }
        public string RucCliente { get; set; }
        public string Moneda { get; set; }
        public DateTime FechaDocumento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal ImporteDocumento { get; set; }
        public decimal PagoDocumento { get; set; }
        public string Estado { get; set; }
        public int IdDocumento { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string PuntoVenta { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Refletra { get; set; }
    }
}
