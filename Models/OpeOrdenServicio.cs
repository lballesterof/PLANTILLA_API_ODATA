using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOrdenServicio
    {
        public string CodigoServicio { get; set; }
        public string CodigoProd { get; set; }
        public string Glosa { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public decimal Secuencia { get; set; }
        public int? IdPedido { get; set; }
        public string Estado { get; set; }
        public decimal? Costo { get; set; }
        public string CentroCosto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
