using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSalInvPorMov3
    {
        public string CodigoEmpresa { get; set; }
        public string Almacen { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal? PrecioCompra { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal IdDocumento { get; set; }
        public int Secuencia { get; set; }
        public string TipoGuia { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Persona { get; set; }
        public string Numero { get; set; }
        public string CodigoGenerado { get; set; }
        public string Movimiento { get; set; }
        public decimal IdOc { get; set; }
        public decimal? Costo { get; set; }
        public string Oc { get; set; }
        public string Op { get; set; }
        public string IdCategoria { get; set; }
        public string Loteserie { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
