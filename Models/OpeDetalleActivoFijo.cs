using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleActivoFijo
    {
        public OpeDetalleActivoFijo()
        {
            OpeAsignacionActivoFijos = new HashSet<OpeAsignacionActivoFijo>();
        }

        public decimal DafId { get; set; }
        public int IdProducto { get; set; }
        public string DafSerie { get; set; }
        public string DafMarca { get; set; }
        public string DafModelo { get; set; }
        public int? DafCantidad { get; set; }
        public string DafNumeroFactura { get; set; }
        public string IdMoneda { get; set; }
        public int? ProveedorCodigo { get; set; }
        public DateTime? DafFechaAdquisicion { get; set; }
        public DateTime? DafFechaCapitalizacion { get; set; }
        public decimal? DafValorAdquisicion { get; set; }
        public string DafClase { get; set; }
        public string DafNivelAbsolescencia { get; set; }
        public string DafUso { get; set; }
        public string DafEstadoFisico { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<OpeAsignacionActivoFijo> OpeAsignacionActivoFijos { get; set; }
    }
}
