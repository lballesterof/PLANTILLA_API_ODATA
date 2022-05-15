using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhAnexoPersonal
    {
        public string CodigoEmpresa { get; set; }
        public decimal IdPersona { get; set; }
        public string CdgTdoc { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public decimal? Secuencia { get; set; }
        public string Extension { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
