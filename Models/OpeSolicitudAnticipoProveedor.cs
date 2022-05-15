using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSolicitudAnticipoProveedor
    {
        public decimal IdSolicitud { get; set; }
        public string Codigo { get; set; }
        public decimal IdOc { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string TipoAnal { get; set; }
        public string CodigoAnal { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
        public decimal Total { get; set; }
        public string CdgCeco { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
    }
}
