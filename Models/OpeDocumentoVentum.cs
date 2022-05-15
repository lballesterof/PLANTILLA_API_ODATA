using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDocumentoVentum
    {
        public OpeDocumentoVentum()
        {
            OpeDetalleDocumentoVenta = new HashSet<OpeDetalleDocumentoVentum>();
        }

        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal IdDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Hora { get; set; }
        public int IdPersona { get; set; }
        public string CondicionPago { get; set; }
        public string TipoVenta { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSerie { get; set; }
        public string Moneda { get; set; }
        public decimal PorIgv { get; set; }
        public decimal Igv { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Abono { get; set; }
        public decimal Vuelto { get; set; }
        public string Estado { get; set; }
        public string NumeroMaquina { get; set; }
        public string Mozo { get; set; }
        public string Turno { get; set; }
        public string CodigoCajero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? Visa { get; set; }
        public decimal? Mastercard { get; set; }
        public decimal? Ripley { get; set; }
        public decimal? Saga { get; set; }
        public decimal? Otros { get; set; }
        public string NumeroComanda { get; set; }
        public string Ruc { get; set; }
        public string NombrePersona { get; set; }
        public string DireccionPersona { get; set; }
        public decimal? ComisionVisa { get; set; }
        public decimal? ComisionMastercard { get; set; }
        public decimal? ComisionRipley { get; set; }
        public decimal? ComisionSaga { get; set; }
        public decimal? ComisionOtros { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? IdPedido { get; set; }
        public decimal? IdDocumento2 { get; set; }
        public string TipoDocumento2 { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime? FechaReferencia { get; set; }
        public DateTime? FecVcto { get; set; }
        public DateTime? FecCanc { get; set; }
        public string DocRef { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public decimal? TotCob { get; set; }
        public decimal? ValFpag { get; set; }
        public string Observacion { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Redondeo { get; set; }
        public string Anticipo { get; set; }
        public decimal? IdGuia { get; set; }
        public string UsuarioCreacion { get; set; }
        public decimal? ValAnticipo { get; set; }
        public decimal? ValPercepcion { get; set; }
        public string RefZonas { get; set; }
        public decimal? IdCheckinout { get; set; }
        public decimal? IdCotizacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public decimal? CantDecimal { get; set; }
        public DateTime? FechaApertura { get; set; }
        public decimal? Propina { get; set; }
        public string Caja { get; set; }
        public string SwtCuo { get; set; }
        public string ValorResumen { get; set; }
        public string TextoImporte { get; set; }
        public string ValorFirma { get; set; }
        public string MError { get; set; }
        public string MExito { get; set; }
        public decimal? MContingencia { get; set; }
        public string UsuarioContingencia { get; set; }
        public DateTime? FechaContingencia { get; set; }
        public string RefeCorr { get; set; }
        public decimal? ImpOperacionGravada { get; set; }
        public decimal? ImpOperacionInafecta { get; set; }
        public decimal? ImpOperacionExonerada { get; set; }
        public decimal? ImpOperacionExportacion { get; set; }
        public string Refletra { get; set; }
        public string SwtCc { get; set; }
        public string UsuarioCaja { get; set; }
        public string SwtCanje { get; set; }
        public decimal? Icbper { get; set; }
        public bool? FlagError { get; set; }
        public bool? FlagEnvio { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string UsuarioEnvio { get; set; }
        public string SwtFe { get; set; }
        public string SwtBj { get; set; }
        public string SwtGn { get; set; }
        public string StrMot { get; set; }
        public string Dni { get; set; }
        public string NombreApellido { get; set; }
        public string TelCelular { get; set; }
        public string CdgCeco { get; set; }
        public string CdgSceco { get; set; }
        public decimal? PtosVta { get; set; }
        public decimal? DsctoPtosVta { get; set; }
        public decimal? PtosVtaAplica { get; set; }
        public string TipoOperacion { get; set; }
        public decimal? ImpRed { get; set; }
        public string NumPlaca { get; set; }
        public decimal? ImpCredito { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaSalida { get; set; }
        public string TextoContrato { get; set; }
        public string TextoContrato2 { get; set; }
        public decimal? Minutos { get; set; }
        public decimal? Horas { get; set; }
        public decimal? Minutose { get; set; }
        public decimal? Horase { get; set; }
        public decimal? Minutosst { get; set; }
        public decimal? Horasst { get; set; }
        public decimal? Tarifa { get; set; }
        public decimal? CantHs { get; set; }
        public decimal? TarifaPlana { get; set; }
        public decimal? IdContrato { get; set; }
        public string NomDelivery { get; set; }
        public decimal? PorRetencion { get; set; }
        public decimal? ImpRetencion { get; set; }
        public decimal? PorRetencionOtro { get; set; }
        public decimal? ImpRetencionOtro { get; set; }
        public decimal? IdMedico { get; set; }
        public string CdgEspe { get; set; }

        public virtual ICollection<OpeDetalleDocumentoVentum> OpeDetalleDocumentoVenta { get; set; }
    }
}
