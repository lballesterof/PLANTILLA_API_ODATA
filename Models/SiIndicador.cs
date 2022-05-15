using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class SiIndicador
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string TipoIndicador { get; set; }
        public string Definicion { get; set; }
        public string Objetivo { get; set; }
        public string ProcedimientoCalculo { get; set; }
        public string Formula { get; set; }
        public string Vista { get; set; }
        public string OrigenDb { get; set; }
        public decimal Meta { get; set; }
        public decimal PrecaucionDe { get; set; }
        public decimal PrecaucionHasta { get; set; }
        public decimal Critico { get; set; }
        public string Unidad { get; set; }
        public string Frecuencia { get; set; }
        public string Responsable { get; set; }
        public string Abreviatura { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
