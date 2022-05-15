using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaProdCtum
    {
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string CuentaExistencia { get; set; }
        public string CuentaRecibir { get; set; }
        public string CuentaVenta { get; set; }
        public string CuentaCostoVenta { get; set; }
        public string CuentaCompra { get; set; }
        public string CuentaIngrProducto { get; set; }
        public string CuentaProcProducto { get; set; }
        public string CuentaVtaDiferida { get; set; }
        public string CuentaDevVta { get; set; }
        public string CuentaVarExi { get; set; }
        public string CuentaDevCompra { get; set; }
        public string CuentaSalOf { get; set; }
        public string CuentaDevOf { get; set; }
        public string CuentaSalCon { get; set; }
        public string CuentaDevCon { get; set; }
        public string CuentaPuente { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
