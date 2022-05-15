using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeReferenciaPersona
    {
        public string Tipo { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Fax { get; set; }
        public string Telefono { get; set; }
        public int Secuencia { get; set; }
        public string CdgDst { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CdgPare { get; set; }
        public string Contacto { get; set; }
        public string Celular { get; set; }
        public string Rcp { get; set; }
        public string Nextel { get; set; }
        public string Referencia { get; set; }
        public string CdgSucursal { get; set; }
    }
}
