using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeProducto
    {
        //public OpeProducto()
        //{
        //    OpeDetalleDocumentoCompras = new HashSet<OpeDetalleDocumentoCompra>();
        //}

        public string CodigoEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string Codigo { get; set; }
        public string CodigoAnterior { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string DescripcionExtendida { get; set; }
        public string IdUnidadCompra { get; set; }
        public decimal? CantUnidadCompra { get; set; }
        public string IdUnidadEmpaqueCompra { get; set; }
        public decimal? CantUnidadEmpaqueCompra { get; set; }
        public string IdUnidadVenta { get; set; }
        public decimal? CantUnidadVenta { get; set; }
        public string IdUnidadEmpaqueVenta { get; set; }
        public decimal? CantUnidadEmpaqueVenta { get; set; }
        public string IdUnidadInventario { get; set; }
        public string IdTipoProducto { get; set; }
        public string IdCategoria { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string Compra { get; set; }
        public string Venta { get; set; }
        public string Inventario { get; set; }
        public string Inventariable { get; set; }
        public decimal? StockMinimo { get; set; }
        public decimal? StockMaximo { get; set; }
        public string Estado { get; set; }
        public decimal? PagoTrabajador { get; set; }
        public string IdUnidadPagoTrabajador { get; set; }
        public decimal? PagoEmpresa { get; set; }
        public string IdUnidadPagoEmpresa { get; set; }
        public string AfectoIgv { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string VentaMasiva { get; set; }
        public string Desayuno { get; set; }
        public string Almuerzo { get; set; }
        public string Cena { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioComprad { get; set; }
        public string RutaFicha { get; set; }
        public string Presentacion { get; set; }
        public decimal? IgvCosto { get; set; }
        public decimal? CostoConIgv { get; set; }
        public decimal? ComisionContado { get; set; }
        public decimal? ComisionCredito { get; set; }
        public string Promocion { get; set; }
        public string EditaPrecio { get; set; }
        public string EditaDescripcion { get; set; }
        public string ManejaSerie { get; set; }
        public int? MesesGarantia { get; set; }
        public string ManejaLote { get; set; }
        public decimal? Maximo { get; set; }
        public decimal? Minimo { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
        public string RutaImagen { get; set; }
        public string Ubicacion { get; set; }
        public string DestinoComanda { get; set; }
        public string Adicional { get; set; }
        public string Lonche { get; set; }
        public string Break1 { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public string Procedencia { get; set; }
        public decimal? CadaBulto { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Xcm { get; set; }
        public decimal? Ycm { get; set; }
        public decimal? Zcm { get; set; }
        public decimal? Maxpiso { get; set; }
        public string GrupoPlanificacion { get; set; }
        public string TecnicaReposicion { get; set; }
        public string MetodoAbastecimiento { get; set; }
        public string IntervaloPedido { get; set; }
        public decimal? PedidoMultiple { get; set; }
        public decimal? CantMinCompra { get; set; }
        public decimal? TiempoEntrega { get; set; }
        public string TamanoLote { get; set; }
        public decimal? FactorMes { get; set; }
        public decimal? Multiplicador { get; set; }
        public decimal? PeriodoPasado { get; set; }
        public decimal? VenceEn { get; set; }
        public string UnidadVenceEn { get; set; }
        public decimal? TiempoRetraso { get; set; }
        public string Indicador { get; set; }
        public string ModeloGestionInventario { get; set; }
        public int? ProveedorPreferido { get; set; }
        public decimal? StockSeguridad { get; set; }
        public string AfectoPercepcion { get; set; }
        public decimal? Detraccion { get; set; }
        public decimal? PercepcionVenta { get; set; }
        public decimal? AplicaImporte { get; set; }
        public string Referencia5 { get; set; }
        public string Referencia6 { get; set; }
        public string Referencia7 { get; set; }
        public decimal? IdEquiProd { get; set; }
        public string PesoEmpaVenta { get; set; }
        public string XcmEmpaVenta { get; set; }
        public string YcmEmpaVenta { get; set; }
        public string ZcmEmpaVenta { get; set; }
        public string CuentaVenta { get; set; }
        public string CuentaCompra { get; set; }
        public int? Orden { get; set; }
        public decimal? AplicaImporteDetraccion { get; set; }
        public string NumLab { get; set; }
        public string NumPre { get; set; }
        public string NumGen { get; set; }
        public string NumAfa { get; set; }
        public string BienServicio { get; set; }
        public string NumAfa2 { get; set; }
        public string NumAfa3 { get; set; }
        public string NumComp { get; set; }
        public string NumConc { get; set; }
        public string NumViad { get; set; }
        public string SwtReme { get; set; }
        public string NumRefmed { get; set; }
        public string GrupUmed { get; set; }
        public string IdUnidadRec { get; set; }
        public decimal? CantUnidadRec { get; set; }
        public string CdgCaja { get; set; }
        public string CdgColumna { get; set; }
        public string CdgCasillero { get; set; }
        public string SwtImp1 { get; set; }
        public string SwtImp2 { get; set; }
        public string SwtWeb { get; set; }
        public decimal? Vencimiento { get; set; }
        public string CodigoSunat { get; set; }
        public decimal? IdCategoria1 { get; set; }
        public decimal? IdSubCategoria { get; set; }
        public decimal? Precio1 { get; set; }
        public decimal? Precio2 { get; set; }
        public decimal? Precio3 { get; set; }
        public decimal? Precio4 { get; set; }
        public string NumLab2 { get; set; }
        public string SwtResta { get; set; }
        public string CondicionClinica { get; set; }
        public string CondicionPaciente { get; set; }
        public string CondicionMuestra { get; set; }
        public string CondicionContenedor { get; set; }
        public decimal? VmiH { get; set; }
        public decimal? VmaH { get; set; }
        public decimal? VmiM { get; set; }
        public decimal? VmaM { get; set; }
        public string UnidadValor { get; set; }

        //public virtual ICollection<OpeDetalleDocumentoCompra> OpeDetalleDocumentoCompras { get; set; }
    }
}
