using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServProyecto
    {
        public decimal IdProyecto { get; set; }
        public string Codigo { get; set; }
        public decimal? IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public string Observacion { get; set; }
        public string DireccionServicio { get; set; }
        public DateTime FechaInicioEstimada { get; set; }
        public DateTime FechaFinEstimada { get; set; }
        public DateTime? FechaInicioReal { get; set; }
        public DateTime? FechaFinReal { get; set; }
        public string Estado { get; set; }
        public string Responsable1 { get; set; }
        public string Responsable2 { get; set; }
        public string Moneda { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Margen { get; set; }
        public decimal? ValorVenta { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public decimal? IdPresupuesto { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string Prioridad { get; set; }
        public string TipoOt { get; set; }
        public DateTime? FechaAmpliacion { get; set; }
        public DateTime? FechaFinRealAmpliacion1 { get; set; }
        public string MotivoAmpliacion1 { get; set; }
        public DateTime? FechaFinRealAmpliacion2 { get; set; }
        public string MotivoAmpliacion2 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string UsuarioAprobacionA1 { get; set; }
        public DateTime? FechaAprobacionA1 { get; set; }
        public string UsuarioAprobacionA2 { get; set; }
        public DateTime? FechaAprobacionA2 { get; set; }
        public string EstadoAmpliacion { get; set; }
        public string EstadoProyecto { get; set; }
        public decimal? IdPedido { get; set; }
        public string Numcor { get; set; }
    }
}
