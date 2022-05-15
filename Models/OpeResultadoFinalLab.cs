using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeResultadoFinalLab
    {
        public decimal Secuenciadoc { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public decimal Secuenciaresul { get; set; }
        public string CdgAgrupacion { get; set; }
        public string TipoDato { get; set; }
        public string ValorDefecto { get; set; }
        public string NomCampo { get; set; }
        public string ValorOpcion { get; set; }
        public string UnidadValor { get; set; }
        public string ValorRango { get; set; }
        public string ValorRefrencia { get; set; }
        public string Metodo { get; set; }
        public string CdgRealizado { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModifcacion { get; set; }
    }
}
