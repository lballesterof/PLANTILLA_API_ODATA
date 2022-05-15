using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCierreMe
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string CodigoModulo { get; set; }
        public int Ano { get; set; }
        public string Mes { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCierre { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Tipo { get; set; }
        public int? IMes { get; set; }
    }
}
