using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCotizacionVentum
    {
        public OpeCotizacionVentum()
        {
            OpeAnexoCotizacions = new HashSet<OpeAnexoCotizacion>();
        }

        public decimal IdCotizacion { get; set; }
        public string NumeroCotizacion { get; set; }
        public string CodigoVendedor { get; set; }
        public string CodigoVendedorAsignado { get; set; }
        public string CodigoCpago { get; set; }
        public string CodigoMoneda { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public string NumeroOcliente { get; set; }
        public decimal ImporteStot { get; set; }
        public decimal ImporteDescuento { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ImporteIgv { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal PorcentajeIgv { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdClienteFactura { get; set; }
        public decimal? ImporteIsc { get; set; }
        public string Contacto { get; set; }
        public string EmailContacto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string TipoFechaEntrega { get; set; }
        public int DiasEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string UsuarioAutoriza { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string LugarEntrega { get; set; }
        public decimal? Comision { get; set; }
        public string Redondeo { get; set; }
        public string Validez { get; set; }
        public string Motivo { get; set; }
        public string Correlativo { get; set; }
        public string CentroCosto { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? IdCotizacionParent { get; set; }
        public string Telefonos { get; set; }
        public string Sucursal { get; set; }
        public string TipoEntrega { get; set; }
        public int? DiasEntrega2 { get; set; }
        public string Observacion2 { get; set; }
        public decimal? Costo { get; set; }
        public decimal? IdOportunidad { get; set; }
        public string MotivoPerdida { get; set; }
        public string Competencia { get; set; }
        public string NotaPerdida { get; set; }
        public string SepararStock { get; set; }
        public string TipoDscto { get; set; }
        public decimal? IdProyecto { get; set; }
        public string SwtVisado { get; set; }

        public virtual ICollection<OpeAnexoCotizacion> OpeAnexoCotizacions { get; set; }
    }
}
