using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePermisoPersona
    {
        public string CodigoEmpresa { get; set; }
        public int IdPersona { get; set; }
        public DateTime Fecha { get; set; }
        public short Desayuno { get; set; }
        public short Almuerzo { get; set; }
        public short Cena { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CodigoSucursal { get; set; }
        public short? Lonche { get; set; }
        public short? Break1 { get; set; }
        public short? Referencia1 { get; set; }
        public short? Referencia2 { get; set; }
        public short? Referencia3 { get; set; }
        public short? Referencia4 { get; set; }
    }
}
