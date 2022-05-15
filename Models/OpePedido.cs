using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePedido
    {
        public OpePedido()
        {
            OpeAnexoPedidos = new HashSet<OpeAnexoPedido>();
        }

        public decimal IdPedido { get; set; }
        public string NumeroPedido { get; set; }
        public string CodigoVendedor { get; set; }
        public string CodigoCpago { get; set; }
        public string CodigoMoneda { get; set; }
        public DateTime FechaPedido { get; set; }
        public string NumeroOcliente { get; set; }
        public decimal ImporteStot { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal ImporteIgv { get; set; }
        public decimal ImporteDescuento { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal PorcentajeIgv { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public decimal IdCliente { get; set; }
        public decimal? ImporteIsc { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int? IdClienteFactura { get; set; }
        public string CodigoVendedorAsignado { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public string FacturaAdelantada { get; set; }
        public string Contacto { get; set; }
        public string EmailContacto { get; set; }
        public string UsuarioAutoriza { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string LugarEntrega { get; set; }
        public int? IdCotizacion { get; set; }
        public string EstadoFactura { get; set; }
        public decimal? Comision { get; set; }
        public string PuntoVenta { get; set; }
        public string Redondeo { get; set; }
        public string Validez { get; set; }
        public string Motivo { get; set; }
        public string Correlativo { get; set; }
        public string CentroCosto { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Sucursal { get; set; }
        public decimal? Costo { get; set; }
        public decimal? IdOportunidad { get; set; }
        public decimal? ValPercepcion { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime? FechaProgramadaEntrega { get; set; }
        public string Observacion2 { get; set; }
        public decimal? Pax { get; set; }
        public string Mesa { get; set; }
        public string Piso { get; set; }
        public string SwtEsta { get; set; }
        public string Delivery { get; set; }
        public string CdgMensajero { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public decimal? Inicial { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaVenc { get; set; }
        public decimal? Sinicial { get; set; }
        public string TipoDscto { get; set; }
        public decimal? Icbper { get; set; }
        public string SwtPd { get; set; }
        public string Numpain { get; set; }
        public decimal? IdProyecto { get; set; }
        public decimal? PorcentajeInicial { get; set; }
        public string TipoContrato { get; set; }
        public decimal? Puntos { get; set; }
        public decimal? PrecioPunto { get; set; }
        public string Calendario { get; set; }
        public decimal? MontoInicialHoy { get; set; }
        public decimal? PorcentajeInicialHoy { get; set; }
        public string FormaDePago1InicialHoy { get; set; }
        public string FpGa { get; set; }
        public decimal? MontoGa { get; set; }
        public DateTime? VencGa { get; set; }
        public string BancoGa { get; set; }
        public string RefGa { get; set; }
        public DateTime? FechaProcesable { get; set; }
        public string Estatus { get; set; }
        public decimal? MontoAFinanciar { get; set; }
        public decimal? PorcentajeMontoFinanciar { get; set; }
        public decimal? NumCuotaFinanciar { get; set; }
        public decimal? PorcentajeInteresMensual { get; set; }
        public decimal? MontoCuotaMensual { get; set; }
        public DateTime? VencPrimeraCuota { get; set; }
        public string SwtWeb { get; set; }
        public string PrimerAnoUso { get; set; }
        public decimal? CantidadAnoContrato { get; set; }
        public string CdgSceco { get; set; }
        public decimal? IdOrder { get; set; }
        public string OrderGuid { get; set; }
        public decimal? CustomerId { get; set; }
        public string OrdeStatus { get; set; }
        public string PaymentStatusId { get; set; }
        public string PaymentMethodSystemName { get; set; }
        public decimal? OrderTotal { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? PaidDateUtc { get; set; }
        public string CustomerIp { get; set; }
        public decimal? PaymentMethodAdditionalFeeInclTax { get; set; }
        public decimal? PaymentMethodAdditionalFeeExclTax { get; set; }
        public string Estadoc { get; set; }

        public virtual ICollection<OpeAnexoPedido> OpeAnexoPedidos { get; set; }
    }
}
