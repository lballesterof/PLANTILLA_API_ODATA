using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOrdenFabricacion
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string CdgPlan { get; set; }
        public string Estado { get; set; }
        public int? IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal? AProducir { get; set; }
        public string CdgCc { get; set; }
        public string IdParent { get; set; }
        public decimal? Producido { get; set; }
        public decimal? Secuencia { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public decimal? CostoUnitario { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string TipoOf { get; set; }
        public string Almacen { get; set; }
    }
}
