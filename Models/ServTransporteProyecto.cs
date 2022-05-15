using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServTransporteProyecto
    {
        public decimal IdProyecto { get; set; }
        public decimal Secuencia { get; set; }
        public string Chofer { get; set; }
        public string Licencia { get; set; }
        public string Vehiculo { get; set; }
        public string Placa { get; set; }
        public string Certificado { get; set; }
        public decimal Kilometraje { get; set; }
        public string DepartamentoDe { get; set; }
        public string ProvinciaDe { get; set; }
        public string DistritoDe { get; set; }
        public string DepartamentoHasta { get; set; }
        public string ProvinciaHasta { get; set; }
        public string DistritoHasta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
