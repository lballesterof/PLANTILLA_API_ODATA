using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTarjetaEquipo
    {
        public decimal IdSerie { get; set; }
        public string Serie { get; set; }
        public string SerieGen { get; set; }
        public string SerieReem { get; set; }
        public string CdgMarca { get; set; }
        public string CdgModelo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Ubicacion { get; set; }
        public string CdgEstado { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int? IdPedido { get; set; }
        public int? IdGuia { get; set; }
        public string NumFre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Recordatorio { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
