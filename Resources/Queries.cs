

using Microsoft.OData.ModelBuilder;

namespace PLANTILLA_API_ODATA.Controllers
{
    public class Queries
    {
        public static string InsertPedidoVenta_Comanda()
        {
            return ("       INSERT INTO OPE_DETALLE_PEDIDO(\r\n          ID_PEDIDO,\r\n          ID_PRODUCTO,\r\n          CANTIDAD,\r\n          PRECIO,\r\n          DESCUENTO,\r\n          IGV,\r\n          IMPORTE,\r\n          CANT_DESPACHADA,\r\n          CANT_FACTURADA,\r\n          OBSERVACION,\r\n          SECUENCIA,\r\n          PRECIO_ORIGINAL,\r\n          TIPO,\r\n          IMPORTE_DSCTO ,\r\n          AFECTO_IGV,\r\n          COMISION,\r\n          ID_PRESUPUESTO,UNIDAD,\r\n\t\t  FACTOR_CONVERSION  ,\r\n\t\t  SWT_PIGV  ,\r\n\t\t  SWT_PROM  , \r\n\t\t\tCANT_KIT  ,\r\n\t\t\tSWT_DCOM  , \r\n\t\t\tSWT_SABOR  , \r\n\t\t\tSWT_FREE   ,  \r\n\t\t\tPOR_DETRACCION  ,\r\n\t\t\tDETRACCION,\r\n\t\t\tCOMANDA,\r\n\t\t\tFLAG_COLOR\r\n\r\n)\r\n       VALUES(\r\n          @ID_PEDIDO,\r\n          @ID_PRODUCTO,\r\n          @CANTIDAD,\r\n          @PRECIO,\r\n          @DESCUENTO,\r\n          @IGV,\r\n          @IMPORTE,\r\n          @CANT_DESPACHADA,\r\n          @CANT_FACTURADA,\r\n          @OBSERVACION,\r\n          @SECUENCIA,\r\n          @PRECIO_ORIGINAL,\r\n          @TIPO,\r\n          @IMPORTE_DSCTO,\r\n          @AFECTO_IGV,\r\n          @COMISION,\r\n          @ID_PRESUPUESTO ,@UNIDAD , @FACTOR_CONVERSION  ,\r\n\t\t  @SWT_PIGV  ,\r\n\t\t  @SWT_PROM  , \r\n\t\t\t@CANT_KIT  ,\r\n\t\t\t@SWT_DCOM  , \r\n\t\t\t@SWT_SABOR  , \r\n\t\t\t@SWT_FREE   ,  \r\n\t\t\t@POR_DETRACCION  ,\r\n\t\t\t@DETRACCION,\r\n\t\t\t@COMANDA,@FLAG_COLOR\r\n\r\n)");
        }
    }
}
