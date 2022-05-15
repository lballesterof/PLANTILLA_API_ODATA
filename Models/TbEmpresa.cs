using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbEmpresa
    {
        public string CodiEmpr { get; set; }
        public string RucEmpr { get; set; }
        public string RazoSoci { get; set; }
        public string NombCome { get; set; }
        public string Ubigeo { get; set; }
        public string DireEmpr { get; set; }
        public string UrbaEmpr { get; set; }
        public string ProvEmpr { get; set; }
        public string DptoEmpr { get; set; }
        public string DistEmpr { get; set; }
        public string Fono1 { get; set; }
        public string Fono2 { get; set; }
        public string FaxEmpr { get; set; }
        public string CorreoEmpr { get; set; }
        public string ReprLega { get; set; }
        public string DniReprLega { get; set; }
        public byte[] LogoEmpr { get; set; }
        public string NombLogo { get; set; }
        public string UsuarioSol { get; set; }
        public string ClaveSol { get; set; }
        public byte[] FirmaDigi { get; set; }
        public string NombFirm { get; set; }
        public string ClaveFirma { get; set; }
        public string ServSmtp { get; set; }
        public int? Ancho { get; set; }
        public int? Alto { get; set; }
        public string Resolucion { get; set; }
        public string RutaArchivo { get; set; }
        public string WebEmpr { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime? FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
        public string Puerto { get; set; }
        public string Correofe { get; set; }
        public string PassCorr { get; set; }
        public string CcCorreo { get; set; }
        public decimal? Ssl { get; set; }
    }
}
