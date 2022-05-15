using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwInventario
    {
        public string TipoProducto { get; set; }
        public string TipoGuia { get; set; }
        public DateTime DdFechaTransaccion { get; set; }
        public string CodigoGenerado { get; set; }
        public string CdgRef { get; set; }
        public string TipoMovi { get; set; }
        public string CtaExistencia { get; set; }
        public string AlmacenNombre { get; set; }
        public string CategoriaProducto { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public string CdgOc { get; set; }
        public string CdgOp { get; set; }
        public string Ruc { get; set; }
        public string Persona { get; set; }
        public string Tdoc { get; set; }
        public string Documento { get; set; }
        public decimal? CostoCompra { get; set; }
        public decimal? CostoDocu { get; set; }
        public decimal CostoOc { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Tra { get; set; }
        public string Rea { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioCompraSoles { get; set; }
        public decimal? CostoUnitSoles { get; set; }
        public decimal? PrecioDolar { get; set; }
        public decimal? CostoUnitDolar { get; set; }
        public decimal? ImporteSoles { get; set; }
        public decimal? ImporteDolar { get; set; }
        public string Vehiculo { get; set; }
        public string CdgOs { get; set; }
        public string CdgOt { get; set; }
    }
}
