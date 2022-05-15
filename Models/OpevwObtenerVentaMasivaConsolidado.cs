using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwObtenerVentaMasivaConsolidado
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string TipoTrab { get; set; }
        public string Ruc { get; set; }
        public string CentroCosto { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Cliente { get; set; }
        public decimal? Desayuno { get; set; }
        public decimal? Almuerzo { get; set; }
        public decimal? Cena { get; set; }
        public decimal? Lonche { get; set; }
        public decimal? Break1 { get; set; }
        public decimal? Referencia1 { get; set; }
        public decimal? Referencia2 { get; set; }
        public decimal? Referencia3 { get; set; }
        public decimal? Referencia4 { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
