using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeFormatoLab
    {
        public string Formato { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuenciadoc { get; set; }
        public decimal Secuenciapro { get; set; }
        public string CdgRealizado { get; set; }
        public string Color { get; set; }
        public string Aspecto { get; set; }
        public string Densidad { get; set; }
        public string Olor { get; set; }
        public string Reaccion { get; set; }
        public string CelEpiteliales { get; set; }
        public string Piocito { get; set; }
        public string Leucocito { get; set; }
        public string Hematies { get; set; }
        public string Cilindro { get; set; }
        public string Cristales { get; set; }
        public string Otros { get; set; }
        public string Glucosa { get; set; }
        public string Urobilinogeno { get; set; }
        public string Sangre { get; set; }
        public string Proteina { get; set; }
        public string CuerpoCetonico { get; set; }
        public string Nitrito { get; set; }
        public string Bilirrubina { get; set; }
        public string EsterasaLeucocitania { get; set; }
        public string Hemoglobina { get; set; }
        public string AcidoAscorbico { get; set; }
        public string Linfocito { get; set; }
        public string Basofilo { get; set; }
        public string Monocito { get; set; }
        public string Rango1 { get; set; }
        public string Rango2 { get; set; }
        public string ValorReferencial1 { get; set; }
        public string ValorReferencial2 { get; set; }
        public string ValorReferencial3 { get; set; }
        public string ValorReferencial4 { get; set; }
        public string Metodo1 { get; set; }
        public string Metodo2 { get; set; }
        public string Metodo3 { get; set; }
        public string Metodo4 { get; set; }
        public string Und1 { get; set; }
        public string Und2 { get; set; }
        public string Und3 { get; set; }
        public string Und4 { get; set; }
        public string ResultadoVerificado { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
