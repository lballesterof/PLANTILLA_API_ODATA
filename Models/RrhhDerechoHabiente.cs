using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhDerechoHabiente
    {
        public decimal IdPersona { get; set; }
        public decimal IdDh { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string TipoDocumento { get; set; }
        public string Estado { get; set; }
        public string VinculoFamiliar { get; set; }
        public string Incapacidad { get; set; }
        public string ResolucionDirectoral { get; set; }
        public string DomicilioDh { get; set; }
        public string SituacionDh { get; set; }
        public string AltaDh { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string MotivoBaja { get; set; }
        public string BajaDh { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string TdAcreditaPaternidad { get; set; }
        public string NroAcreditaPaternidad { get; set; }
        public string Via { get; set; }
        public string Zona { get; set; }
        public string NombreVia { get; set; }
        public string NombreZona { get; set; }
        public string NroVia { get; set; }
        public string Interior { get; set; }
        public string Referencia { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Ubigeo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
