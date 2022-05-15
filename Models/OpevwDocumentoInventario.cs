using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDocumentoInventario
    {
        public decimal? IdDocumento { get; set; }
        public string Empresa { get; set; }
        public DateTime? FechaMovi { get; set; }
        public string Persona { get; set; }
        public string Almacen { get; set; }
        public string Tdoc { get; set; }
        public string Numdoc { get; set; }
        public string Movimiento { get; set; }
        public string Almacen2 { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CdgAlmacen { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoGuia { get; set; }
        public string EsTraslado { get; set; }
        public int? IdDocumentoParent { get; set; }
        public string Numref { get; set; }
        public string Estado { get; set; }
        public string PuntoVenta { get; set; }
        public string NumRef1 { get; set; }
        public string CdgTdoc { get; set; }
        public string Modulo { get; set; }
        public string Glosa { get; set; }
    }
}
