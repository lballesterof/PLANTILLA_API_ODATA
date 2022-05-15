using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSolicitudVjevto
    {
        public decimal IdSolicitud { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string TipoAnal { get; set; }
        public string CodigoAnal { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public string Motivo { get; set; }
        public decimal IdCliente { get; set; }
        public decimal TotalViaje { get; set; }
        public decimal TotalViatico { get; set; }
        public string Observacion { get; set; }
        public string Comentario { get; set; }
        public decimal? IdProyecto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string MotivoRechazo { get; set; }
        public string UsuarioRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public decimal? TotalAdicional { get; set; }
    }
}
