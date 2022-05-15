using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwGuiaDremision
    {
        public string TipoMovimiento { get; set; }
        public string CostoAutomatico { get; set; }
        public decimal VegrId { get; set; }
        public string CodigoGenerado { get; set; }
        public string CdgRef { get; set; }
        public string TipoMovi { get; set; }
        public string Almacen { get; set; }
        public string AlmacenNombre { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? DvegrPrecio { get; set; }
        public decimal? DvegrCosto { get; set; }
        public decimal? DvegrDgui { get; set; }
        public DateTime? VegrFechaSalida { get; set; }
        public string TipoGuia { get; set; }
        public decimal? CoocId { get; set; }
        public string CdgOc { get; set; }
        public string CdgOp { get; set; }
        public string Persona { get; set; }
        public string OfId { get; set; }
        public string IdMoneda { get; set; }
        public decimal? CostoCompra { get; set; }
        public decimal? CostoDocu { get; set; }
        public decimal CostoOc { get; set; }
        public string IdMonedaOc { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Tra { get; set; }
        public string Rea { get; set; }
        public decimal? PrecioDolar { get; set; }
        public decimal? CostoDolar { get; set; }
        public decimal? ImporteSoles { get; set; }
        public decimal? ImporteDolar { get; set; }
        public string NumeroDocu { get; set; }
        public string Ofs { get; set; }
        public int Orden { get; set; }
        public int? IdDocumentoParent { get; set; }
        public decimal? PvSoles { get; set; }
        public decimal? PvDolar { get; set; }
        public decimal? IdRela { get; set; }
        public string Numero { get; set; }
        public string IdCategoria { get; set; }
    }
}
