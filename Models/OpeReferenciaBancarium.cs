using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeReferenciaBancarium
    {
        public decimal Secuencia { get; set; }
        public decimal IdPersona { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public string Cci { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
