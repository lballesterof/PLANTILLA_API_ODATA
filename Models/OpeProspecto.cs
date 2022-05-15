using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProspecto
    {
        public string CodigoEmpresa { get; set; }
        public decimal IdProspecto { get; set; }
        public string Codigo { get; set; }
        public string Ruc { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string EmailFe { get; set; }
        public string PaginaWeb { get; set; }
        public string Estado { get; set; }
        public string RazonSocial { get; set; }
        public string Vendedor { get; set; }
        public string CondicionPago { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string CanalVenta { get; set; }
        public string SubcanalVenta { get; set; }
        public string Region { get; set; }
        public string SectorEconomico { get; set; }
        public string SubsectorEconomico { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string ZonaVenta { get; set; }
        public string RutaVenta { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoPersona { get; set; }
        public DateTime? InicioEmpresa { get; set; }
        public string GiroEmpresa { get; set; }
    }
}
