using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AcaCronogramaPagoAlumno
    {
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public string NumModalidad { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Nombre { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public decimal ImportePagar { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
