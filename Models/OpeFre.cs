using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeFre
    {
        public string NumeroFre { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaComprometida { get; set; }
        public string Contacto { get; set; }
        public string DniContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Referencia { get; set; }
        public string Notas { get; set; }
        public int IdCliente { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CdgEstado { get; set; }
    }
}
