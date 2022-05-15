using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleTabla
    {
        [ForeignKey("Codigo")]
        public string Codigo { get; set; }
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string FlagSys { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Referencia4 { get; set; }
        public string Referencia5 { get; set; }
        public string Referencia6 { get; set; }
        public string Referencia7 { get; set; }
        public string Referencia8 { get; set; }
        public string Referencia9 { get; set; }
        public string Referencia10 { get; set; }
        public byte[] Imagen1 { get; set; }
        public string Referencia11 { get; set; }
        public string Referencia12 { get; set; }
        public string Referencia13 { get; set; }
        public string Referencia14 { get; set; }
        public string Referencia15 { get; set; }
        public string Referencia16 { get; set; }
        public string Referencia17 { get; set; }
        public string Referencia18 { get; set; }
        public string Referencia19 { get; set; }
        public string Referencia20 { get; set; }
        public string Referencia21 { get; set; }
        public string Referencia22 { get; set; }
        public string Referencia23 { get; set; }
        public string Referencia24 { get; set; }
        public string Referencia25 { get; set; }
        public string Referencia26 { get; set; }
        public string Referencia27 { get; set; }
        public string Referencia28 { get; set; }
        public string Referencia29 { get; set; }
        public string Referencia30 { get; set; }
        public string Referencia31 { get; set; }
        public string Referencia32 { get; set; }
        public string Referencia33 { get; set; }
        public string Referencia34 { get; set; }
        public string Referencia35 { get; set; }
        public virtual OpeTabla tabla { get; set; }
    }
}
