using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwKardex
    {
        public decimal IdProducto { get; set; }
        public decimal VegrId { get; set; }
        public string TipoMovi { get; set; }
        public string Almacen { get; set; }
        public DateTime VegrFechaSalida { get; set; }
        public string AlmacenNombre { get; set; }
        public string Persona { get; set; }
        public string Numero { get; set; }
        public string CodigoGenerado { get; set; }
        public decimal? DvegrPrecio { get; set; }
        public decimal? DvegrCosto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public int Saldo { get; set; }
        public int? IdDocumentoParent { get; set; }
        public string TipoGuia { get; set; }
        public decimal? IdOc { get; set; }
        public decimal? IdDoco { get; set; }
    }
}
