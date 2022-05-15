using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCrequerimiento
    {
        public string CodigoRequerimiento { get; set; }
        public string TipoRequerimiento { get; set; }
        public string Estado { get; set; }
        public string Entregado { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string HoraSolicitud { get; set; }
        public string SolicitadoPor { get; set; }
        public decimal? IdPersona { get; set; }
        public decimal? IdProveedor { get; set; }
        public string Manager { get; set; }
        public string Supervisor { get; set; }
        public string Site { get; set; }
        public string NombreSite { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public string HoraRequerida { get; set; }
        public string Transporte { get; set; }
        public string AgenciaTransporte { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreContacto1 { get; set; }
        public string DniContacto1 { get; set; }
        public string TelefonoContacto1 { get; set; }
        public string NombreContacto2 { get; set; }
        public string DniContacto2 { get; set; }
        public string TelefonoContacto2 { get; set; }
        public string TipoTransporte { get; set; }
        public string SwtReq { get; set; }
        public string Almacen { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaAtendido { get; set; }
        public string HoraAtendido { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public string HoraProgramada { get; set; }
        public DateTime? FechaTransito { get; set; }
        public string HoraTransito { get; set; }
        public DateTime? FechaAgencia { get; set; }
        public string HoraAgencia { get; set; }
        public string NodoDespacho { get; set; }
        public string CdgCeco { get; set; }
        public DateTime? FechaProgramaAlmacen { get; set; }
        public string UsuarioProgramaAlmacen { get; set; }
        public decimal? IdReq { get; set; }
    }
}
