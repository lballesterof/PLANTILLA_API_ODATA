using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServServicioTecnicoImagen
    {
        public string NumeroFre { get; set; }
        public string SerieGenerada { get; set; }
        public string NombreImagen { get; set; }
        public string Titulo { get; set; }
        public byte[] ImgImagen { get; set; }
        public int Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
