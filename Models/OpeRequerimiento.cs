using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeRequerimiento
    {
        public string CodigoRequerimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int? IdPersona { get; set; }
        public string Prioridad { get; set; }
        public string Motivo { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public string HoraAtencion { get; set; }
        public string CdgIngeniero { get; set; }
        public string Descripcion { get; set; }
        public string CdgVendCreacion { get; set; }
        public string CdgVendAsignado { get; set; }
        public string TipoRequ { get; set; }
        public string CentroCosto { get; set; }
        public int? IdProducto { get; set; }
        public decimal? CantidadPedida { get; set; }
        public decimal? Precio { get; set; }
        public int? IdOc { get; set; }
        public decimal? CantidadIngresada { get; set; }
        public int? Secuencia { get; set; }
        public string CdgPlan { get; set; }
        public string CdgOrd { get; set; }
        public int? IdProductoOf { get; set; }
        public string CdgServ { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CdgOp { get; set; }
        public int? SecuenciaOc { get; set; }
        public string CdgScc { get; set; }
    }
}
