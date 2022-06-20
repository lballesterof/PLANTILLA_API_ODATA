using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Cotizacion
{
    public class DCotizacion
    {
        public decimal? ID_COTIZACION { get; set; }

        public decimal? ID_PRODUCTO { get; set; }

        public decimal? CANTIDAD { get; set; }

        public decimal? PRECIO { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal? IGV { get; set; }

        public decimal? IMPORTE { get; set; }

        public string OBSERVACION { get; set; }

        public decimal? SECUENCIA { get; set; }

        public decimal? PRECIO_ORIGINAL { get; set; }

        public string TIPO { get; set; }

        public decimal? IMPORTE_DSCTO { get; set; }

        public string AFECTO_IGV { get; set; }

        public decimal? COMISION { get; set; }

        public decimal? ID_PRESUPUESTO { get; set; }

        public string CDG_SERV { get; set; }

        public byte[] IMAGEN_REF { get; set; }

        public string OBSERVACION2 { get; set; }

        public string UNIDAD { get; set; }

        public decimal? POR_PERCEPCION { get; set; }

        public decimal? PERCEPCION { get; set; }

        public decimal? VALOR_VEN { get; set; }

        public string UNID_VEN { get; set; }

        public DateTime? FECHA_VEN { get; set; }

        public string CDG_KIT { get; set; }

        public string SWT_PIGV { get; set; }

        public decimal? POR_DETRACCION { get; set; }

        public decimal? DETRACCION { get; set; }

        public decimal? FACTOR_CONVERSION { get; set; }

        public decimal? MARGEN { get; set; }

        public decimal? IMPORTE_MARGEN { get; set; }

        public decimal? COSTO_ADIC { get; set; }

        public decimal? CANT_KIT { get; set; }
    }
}
