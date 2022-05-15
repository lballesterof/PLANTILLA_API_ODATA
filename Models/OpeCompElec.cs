using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCompElec
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public string TipoDocuClie { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Moneda { get; set; }
        public decimal Vventa { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
