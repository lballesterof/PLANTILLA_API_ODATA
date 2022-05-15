using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeInventarioFisico
    {
        public string Codigo { get; set; }
        public DateTime? FechaInventario { get; set; }
        public string Almacen { get; set; }
        public string ContadoPor { get; set; }
        public string AnotadoPor { get; set; }
        public string JefeEquipo { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoEmpresa { get; set; }
    }
}
