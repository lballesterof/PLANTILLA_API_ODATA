using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeResultadoProducto
    {
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public string CdgAgrupacion { get; set; }
        public string TipoDato { get; set; }
        public string ValorDefecto { get; set; }
        public string NomCampo { get; set; }
        public string Formula { get; set; }
        public string Opciones { get; set; }
        public decimal? VmiH { get; set; }
        public decimal? VmaH { get; set; }
        public decimal? VmiM { get; set; }
        public decimal? VmaM { get; set; }
        public string UnidadValor { get; set; }
        public string ValorRefrencia { get; set; }
        public string Metodo { get; set; }
    }
}
