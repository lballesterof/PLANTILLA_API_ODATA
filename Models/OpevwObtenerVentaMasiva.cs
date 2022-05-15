using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwObtenerVentaMasiva
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public int Desayuno { get; set; }
        public int Almuerzo { get; set; }
        public int Cena { get; set; }
        public int Lonche { get; set; }
        public int Break1 { get; set; }
        public int Referencia1 { get; set; }
        public int Referencia2 { get; set; }
        public int Referencia3 { get; set; }
        public int Referencia4 { get; set; }
    }
}
