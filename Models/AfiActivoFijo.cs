using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AfiActivoFijo
    {
        public decimal? IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal? Importe { get; set; }
        public string Moneda { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Depreciacion { get; set; }
        public string CentroCosto { get; set; }
        public decimal IdProducto { get; set; }
        public string NroSerie { get; set; }
        public string SerieGenerada { get; set; }
        public decimal Cantidad { get; set; }
        public string CdgMarca { get; set; }
        public string CdgModelo { get; set; }
        public string Observacion { get; set; }
        public string MetodoDepreciacion { get; set; }
        public string Situacion { get; set; }
        public string Depreciable { get; set; }
        public string AjusteInflacion { get; set; }
        public decimal Secuencia { get; set; }
        public decimal? MesesDepre { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
