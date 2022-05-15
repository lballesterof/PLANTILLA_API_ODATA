using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDocumentoCompra
    {
        public OpeDocumentoCompra()
        {
            OpeDetalleDocumentoCompras = new HashSet<OpeDetalleDocumentoCompra>();
        }

        public string CodigoEmpresa { get; set; }
        public decimal IdDocumento { get; set; }
        public string Numero { get; set; }
        public DateTime FechaDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int? IdProveedor { get; set; }
        public string IdMoneda { get; set; }
        public string IdFormaPago { get; set; }
        public decimal TipoCambio { get; set; }
        public string DepartamentoPartida { get; set; }
        public string ProvinciaPartida { get; set; }
        public string UbigeoPartida { get; set; }
        public string DepartamentoLlegada { get; set; }
        public string ProvinciaLlegada { get; set; }
        public string UbigeoLlegada { get; set; }
        public string Estado { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoMovimiento { get; set; }
        public string Glosa { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string EsTraslado { get; set; }
        public string CodigoSucursalOrigen { get; set; }
        public string CodigoSucursalDestino { get; set; }
        public string Flag1 { get; set; }
        public string CodigoEmpresaDestino { get; set; }
        public int? IdDocumentoParent { get; set; }
        public string TipoGuia { get; set; }
        public string CodigoGenerado { get; set; }
        public decimal? IdOc { get; set; }
        public decimal? IdPedido { get; set; }
        public string RucTransportista { get; set; }
        public string Licencia { get; set; }
        public string Placa { get; set; }
        public string Chofer { get; set; }
        public string LugarEntrega { get; set; }
        public string LugarPartida { get; set; }
        public string PuntoVenta { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public string CdgOs { get; set; }
        public string CdgOp { get; set; }
        public string SwtIng { get; set; }
        public string Vehiculo { get; set; }
        public string CdgOt { get; set; }
        public string CdgRef { get; set; }
        public string NumFre { get; set; }
        public string NumRef { get; set; }
        public DateTime? FechaEntregaCliente { get; set; }
        public string CertificadoInscripcion { get; set; }
        public decimal? NumBultos { get; set; }
        public string NumAlu { get; set; }
        public string NumDelivery { get; set; }
        public string SwtAutorizacion { get; set; }
        public string UsuarioAutorizacion { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string SwtCuo { get; set; }
        public string Transportista { get; set; }
        public string CdgCc { get; set; }
        public string ScdgCc { get; set; }
        public decimal? IdDocumentoParent2 { get; set; }
        public string SwtWeb { get; set; }
        public string SwtWs { get; set; }
        public string NodoDespacho { get; set; }
        public string CdgCecoD { get; set; }
        public string CdgScecoD { get; set; }
        public string SwtFe { get; set; }
        public bool? FlagError { get; set; }
        public bool? FlagEnvio { get; set; }
        public string SwtBj { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string UsuarioEnvio { get; set; }
        public string MError { get; set; }
        public string MExito { get; set; }
        public string ValorResumen { get; set; }
        public string NumReq { get; set; }
        public decimal? IdReqEm { get; set; }
        public string ErrSt { get; set; }

        public virtual ICollection<OpeDetalleDocumentoCompra> OpeDetalleDocumentoCompras { get; set; }
    }
}
