using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeClistaPrecio
    {
        public OpeClistaPrecio()
        {
            OpeListaPrecio2s = new HashSet<OpeListaPrecio2>();
        }

        public string Codigo { get; set; }
        public string Moneda { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public decimal Factor { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string MetodoRedondeo { get; set; }
        public string CodigoBase { get; set; }
        public string GrupoUsuario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string TipoCliente { get; set; }
        public string Tipo { get; set; }
        public string SwtWeb { get; set; }

        public virtual ICollection<OpeListaPrecio2> OpeListaPrecio2s { get; set; }
    }
}
