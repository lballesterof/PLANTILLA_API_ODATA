using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelNcV03a
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public DateTime FechDocu { get; set; }
        public string ConfRazonSocial { get; set; }
        public string NombComercial { get; set; }
        public string Ubigeo { get; set; }
        public string ConfDireccion { get; set; }
        public string Urbanizacion { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Distrito { get; set; }
        public string Pais { get; set; }
        public string ConfRuc { get; set; }
        public string TipoDocuEmpr { get; set; }
        public string DocRef { get; set; }
        public string CodigoMotivoNota { get; set; }
        public string NumeDocu { get; set; }
        public string ClienteRuc { get; set; }
        public string TipoDocuClie { get; set; }
        public string ClienteNombre { get; set; }
        public string MotivoNota { get; set; }
        public string Unidad { get; set; }
        public decimal DvedvCantidad { get; set; }
        public string ExistenciaCodactual { get; set; }
        public string ExistenciaNombre { get; set; }
        public decimal? ValoUnit { get; set; }
        public decimal? Precio { get; set; }
        public string TipoPrecio { get; set; }
        public decimal? IgvItem { get; set; }
        public decimal? IgvItem2 { get; set; }
        public string AfecIgv { get; set; }
        public string CodiIgv { get; set; }
        public string NombIgv { get; set; }
        public string NombIgvInt { get; set; }
        public string TotaOperGravTipo { get; set; }
        public decimal? ValoVentGravTota { get; set; }
        public string TotaOperInafTipo { get; set; }
        public decimal? ValoVentInafTota { get; set; }
        public string TotaOperExonTipo { get; set; }
        public int ValoVentExonTota { get; set; }
        public decimal? ValoVentItem { get; set; }
        public decimal VedvMontoIgv { get; set; }
        public decimal VedvMontoIgv2 { get; set; }
        public string CodiIgvTota { get; set; }
        public string NombIgvTota { get; set; }
        public string NombIgvIntTota { get; set; }
        public string CodiDcto { get; set; }
        public decimal? VedvMontoDescuento { get; set; }
        public decimal? VedvMonto { get; set; }
        public string Moneda { get; set; }
        public string DocuRefe { get; set; }
        public string TipoDocuRefe { get; set; }
        public int DvedvSecuencia { get; set; }
        public string CodigoSunat { get; set; }
        public int ValoNoOnerItem { get; set; }
        public string TipoValoNoOnerItem { get; set; }
        public string VersionUbl { get; set; }
        public string VersionEstructura { get; set; }
        public string TipoDocu { get; set; }
        public string VedvGlosa { get; set; }
        public string CorreoCliente { get; set; }
        public string ClienteUbigeo { get; set; }
        public string DireccionCliente { get; set; }
        public string FonoCliente { get; set; }
        public string FormaPago { get; set; }
        public string TipoLeyendaMonto { get; set; }
        public string LeyendaMonto { get; set; }
        public string Usuario { get; set; }
        public string HoraEmision { get; set; }
        public string CodigoEmpresa { get; set; }
        public string DireccionSucursal { get; set; }
        public string Seccion { get; set; }
        public string Grado { get; set; }
        public string NivelAcademico { get; set; }
        public string ValorResumen { get; set; }
        public decimal IdDocumento { get; set; }
        public DateTime? FechaVenc { get; set; }
        public string MExito { get; set; }
        public DateTime? FechaReferencia { get; set; }
        public decimal? ImpCredito { get; set; }
    }
}
