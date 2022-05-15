using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbDocumentoSunat
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public string TipoDocuClie { get; set; }
        public string NumeDocuClie { get; set; }
        public string NombClie { get; set; }
        public DateTime? FechDocu { get; set; }
        public string Moneda { get; set; }
        public decimal? ValoVent { get; set; }
        public decimal? ValoIgv { get; set; }
        public decimal? ValoTota { get; set; }
        public byte[] XmlFile { get; set; }
        public byte[] ZipFile { get; set; }
        public byte[] PdfFile { get; set; }
        public byte[] ZipRpta { get; set; }
        public byte[] CodiBarra { get; set; }
        public string NumeTicket { get; set; }
        public string Mensaje { get; set; }
        public bool FlagError { get; set; }
        public bool FlagEnvio { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
