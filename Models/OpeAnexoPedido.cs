using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAnexoPedido
    {
        public decimal IdPedido { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public decimal Secuencia { get; set; }
        public string Extension { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual OpePedido IdPedidoNavigation { get; set; }
    }
}
