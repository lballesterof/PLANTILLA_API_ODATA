using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfDocumento
    {
        public string CodigoSucursal { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreEmpresa { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Comentario { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public string Referencia5 { get; set; }
        public string Referencia6 { get; set; }
        public string Referencia7 { get; set; }
        public string Referencia8 { get; set; }
        public string Referencia9 { get; set; }
        public string Referencia10 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
