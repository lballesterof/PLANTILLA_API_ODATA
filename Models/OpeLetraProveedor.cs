using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeLetraProveedor
    {
        public string CodigoEmpresa { get; set; }
        public int IdDocumento { get; set; }
        public string NumeroCanje { get; set; }
        public int IdPersona { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCanje { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string EstadoCanje { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public decimal TipoCambio { get; set; }
        public string Moneda { get; set; }
        public decimal ImporteSoles { get; set; }
        public decimal ImporteDolar { get; set; }
        public string MonedaCanje { get; set; }
        public string RucDoc { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NumOrigA { get; set; }
        public string NumVoucA { get; set; }
    }
}
