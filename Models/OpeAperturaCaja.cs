using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAperturaCaja
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string CodigoCaja { get; set; }
        public string CodigoCajero { get; set; }
        public string CodigoTurno { get; set; }
        public string NumeroMaquina { get; set; }
        public DateTime FechaApertura { get; set; }
        public string HoraApertura { get; set; }
        public string NumeroSerie { get; set; }
        public decimal ImporteApertura { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NumeroSerieFact { get; set; }
        public string CodigoImpresora { get; set; }
        public string RutaImpresora { get; set; }
        public string CdgLista { get; set; }
        public string Vendedores { get; set; }
        public decimal? ImporteAperturad { get; set; }
        public DateTime? FechaCierre { get; set; }
        public decimal? ImporteCierre { get; set; }
        public decimal? ImporteCierred { get; set; }
        public decimal? ImporteCierreTarj { get; set; }
        public decimal? ImporteCierreTarjd { get; set; }
        public decimal? ImporteCierreOtro { get; set; }
        public decimal? ImporteCierreOtrod { get; set; }
        public string Estado2 { get; set; }
    }
}
