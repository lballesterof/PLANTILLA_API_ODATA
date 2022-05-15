using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePresupuesto
    {
        public OpePresupuesto()
        {
            OpeDetallePresupuestos = new HashSet<OpeDetallePresupuesto>();
        }

        public decimal IdPresupuesto { get; set; }
        public string Codigo { get; set; }
        public decimal IdCliente { get; set; }
        public string IdRequerimiento { get; set; }
        public string Categoria { get; set; }
        public string Servicio { get; set; }
        public string CdgIng { get; set; }
        public string Moneda { get; set; }
        public decimal IdParent { get; set; }
        public string Estado { get; set; }
        public decimal Costo { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal TipoCambio { get; set; }
        public string Observacion { get; set; }
        public string Observacion2 { get; set; }
        public string SwtMain { get; set; }
        public int Cantidad { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public decimal? GastoAdministrativo { get; set; }
        public decimal? GastoGeneral { get; set; }
        public decimal? Margen { get; set; }
        public decimal? ImporteAdministrativo { get; set; }
        public decimal? ImporteGeneral { get; set; }
        public decimal? ImporteMargen { get; set; }
        public string Sucursal { get; set; }
        public string SubTipoServicio { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public decimal? CantidadServicio { get; set; }
        public decimal? FrecuenciaServicio { get; set; }
        public decimal? TiempoOnside { get; set; }
        public decimal? CantMesesFact { get; set; }
        public string Renovacion { get; set; }
        public decimal? IdFacturar { get; set; }
        public string SwtPres { get; set; }
        public decimal? IdOportunidad { get; set; }
        public decimal? IdProyecto { get; set; }
        public string EjecProy { get; set; }
        public string RespProy { get; set; }
        public string EstaProy { get; set; }
        public string SwtFact { get; set; }
        public decimal? ImporteAproxFacturar { get; set; }
        public decimal? ImporteAmpliacion { get; set; }
        public decimal? TotalAproxFacturar { get; set; }
        public decimal? GananciaProyecto { get; set; }
        public decimal? PorcentajeProyecto { get; set; }
        public string MotivoAmpliacion1 { get; set; }
        public string UsuarioAprobacionA1 { get; set; }
        public DateTime? FechaAprobacionA1 { get; set; }
        public string EstadoAmpliacion { get; set; }
        public decimal? Secuencia { get; set; }
        public decimal? ImpGgDirectomn { get; set; }
        public decimal? ImpGgIndirectomn { get; set; }
        public decimal? ImpGgDirectome { get; set; }
        public decimal? ImpGgIndirectome { get; set; }
        public decimal? ImpMn { get; set; }
        public decimal? ImpMe { get; set; }
        public decimal? TotalCostoOperativo { get; set; }
        public decimal? UtilidadOperativa { get; set; }
        public decimal? UtilidadAntesImpuesto { get; set; }
        public decimal? PorRentaRepartoutilidad { get; set; }
        public decimal? RentaRepartoutilidad { get; set; }
        public decimal? UtilidadNeta { get; set; }

        public virtual ICollection<OpeDetallePresupuesto> OpeDetallePresupuestos { get; set; }
    }
}
