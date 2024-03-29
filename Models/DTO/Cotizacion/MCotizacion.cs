﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Cotizacion
{
    public class MCotizacion
    {
        public decimal? ID_COTIZACION { get; set; }

        public string NUMERO_COTIZACION { get; set; }

        public string CODIGO_VENDEDOR { get; set; }

        public string CODIGO_VENDEDOR_ASIGNADO { get; set; }

        public string CODIGO_CPAGO { get; set; }

        public string CODIGO_MONEDA { get; set; }

        public DateTime? FECHA_COTIZACION { get; set; }

        public string NUMERO_OCLIENTE { get; set; }

        public decimal? IMPORTE_STOT { get; set; }

        public decimal? IMPORTE_DESCUENTO { get; set; }

        public decimal? VALOR_VENTA { get; set; }

        public decimal? IMPORTE_IGV { get; set; }

        public decimal? IMPORTE_TOTAL { get; set; }

        public decimal? PORCENTAJE_DESCUENTO { get; set; }

        public decimal? PORCENTAJE_IGV { get; set; }

        public string OBSERVACION { get; set; }

        public string ESTADO { get; set; }

        public decimal? ID_CLIENTE { get; set; }

        public decimal? ID_CLIENTE_FACTURA { get; set; }

        public decimal? IMPORTE_ISC { get; set; }

        public string CONTACTO { get; set; }

        public string EMAIL_CONTACTO { get; set; }

        public string USUARIO_CREACION { get; set; }

        public DateTime? FECHA_CREACION { get; set; }

        public string USUARIO_MODIFICACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        public string CODIGO_EMPRESA { get; set; }

        public string CODIGO_SUCURSAL { get; set; }

        public string TIPO_FECHA_ENTREGA { get; set; }

        public int? DIAS_ENTREGA { get; set; }

        public DateTime? FECHA_ENTREGA { get; set; }

        public string USUARIO_AUTORIZA { get; set; }

        public DateTime? FECHA_AUTORIZACION { get; set; }

        public string LUGAR_ENTREGA { get; set; }

        public decimal? COMISION { get; set; }

        public string REDONDEO { get; set; }

        public string VALIDEZ { get; set; }

        public string MOTIVO { get; set; }

        public string CORRELATIVO { get; set; }

        public string CENTRO_COSTO { get; set; }

        public decimal? TIPO_CAMBIO { get; set; }

        public decimal? ID_COTIZACION_PARENT { get; set; }

        public string TELEFONOS { get; set; }

        public string SUCURSAL { get; set; }

        public string TIPO_ENTREGA { get; set; }

        public int? DIAS_ENTREGA2 { get; set; }

        public string OBSERVACION2 { get; set; }

        public decimal? COSTO { get; set; }

        public decimal? ID_OPORTUNIDAD { get; set; }

        public string MOTIVO_PERDIDA { get; set; }

        public string COMPETENCIA { get; set; }

        public string NOTA_PERDIDA { get; set; }

        public string SEPARAR_STOCK { get; set; }

        public string TIPO_DSCTO { get; set; }

        public decimal? ID_PROYECTO { get; set; }

        public string SWT_VISADO { get; set; }

        public string USUARIO { get; set; }

        public string NOM_MONEDA { get; set; }
        public string DIRECCION { get; set; }
        public string RUC { get; set; }
        public string PERSONA { get; set; }
        public string TIPO_CLIENTE { get; set; }

        public List<DCotizacion> DetCotizacion
        { get; set; }
    }
}
