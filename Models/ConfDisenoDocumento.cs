using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfDisenoDocumento
    {
        public string Tipo { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreColumna { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Longitud { get; set; }
        public int Orden { get; set; }
        public string SaltoLinea { get; set; }
        public string Alineacion { get; set; }
        public string Fuente { get; set; }
        public string Estilo { get; set; }
        public string Tamano { get; set; }
        public int? NroDecimal { get; set; }
    }
}
