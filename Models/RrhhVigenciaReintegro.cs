using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhVigenciaReintegro
    {
        public string CdgPara { get; set; }
        public string TipoObrero { get; set; }
        public decimal Valor { get; set; }
        public string Unidad { get; set; }
        public string Ano { get; set; }
        public int Mes { get; set; }
        public string Anoi { get; set; }
        public int Mesi { get; set; }
        public string Anof { get; set; }
        public int Mesf { get; set; }
        public string CdgParaAplica { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
