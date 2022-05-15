using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CrmSeguimiento
    {
        public string CodigoCampana { get; set; }
        public decimal IdSeguimiento { get; set; }
        public decimal? IdClienteCampana { get; set; }
        public string Situacion { get; set; }
        public string Usuario { get; set; }
        public string UsuarioPara { get; set; }
        public decimal? Prioridad { get; set; }
        public decimal? IdCliente { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string HoraInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string HoraFin { get; set; }
        public string Lugar { get; set; }
        public string Tipo { get; set; }
        public string Procedencia { get; set; }
        public string TipoSolucion { get; set; }
        public string Descripcion { get; set; }
        public string Solucion { get; set; }
        public string Ref1 { get; set; }
        public string TipoEvento { get; set; }
        public string UsuarioFinalizacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public string HoraFinalizacion { get; set; }
        public string UsuarioRef1 { get; set; }
        public DateTime? FechaRef1 { get; set; }
        public string HoraRef1 { get; set; }
        public string Nota { get; set; }
        public string EtapaVenta { get; set; }
        public string Moneda { get; set; }
        public decimal? ImporteEstimado { get; set; }
        public decimal? MesCierre { get; set; }
        public decimal? AnoCierre { get; set; }
        public decimal? IdMainParent { get; set; }
        public decimal? IdParent { get; set; }
        public string MotivoPerdida { get; set; }
        public string Competencia { get; set; }
        public string NotaPerdida { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? IdProducto { get; set; }
        public string Asunto { get; set; }
        public string Sitio { get; set; }
        public string Tecnico { get; set; }
        public string Sucursal { get; set; }
        public string NumCor { get; set; }
        public string Estado { get; set; }
    }
}
