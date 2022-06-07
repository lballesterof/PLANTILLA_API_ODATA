using AutoMapper;
using Dapper;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using Spring.Objects.Factory.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Pedido
{
    public class OpePedidoService: IOpePedidoService
    {


        private DataContext db;
        public OpePedidoService(DataContext context)
        {
            db = context;
        }

		public CabeceraPedidoDTO SavePedido(CabeceraPedidoDTO pedido)
		{
			using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
			{
				db.Open();
				using (SqlTransaction sqlTransaction = (SqlTransaction)db.BeginTransaction())
				{
					try
					{
						DynamicParameters dynamicParameters1 = new DynamicParameters();
						dynamicParameters1.Add("@ID_PEDIDO", (object)pedido.ID_PEDIDO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@NUMERO_PEDIDO", (object)pedido.NUMERO_PEDIDO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_VENDEDOR", (object)pedido.CODIGO_VENDEDOR, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_CPAGO", (object)pedido.CODIGO_CPAGO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_MONEDA", (object)pedido.CODIGO_MONEDA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@FECHA_PEDIDO", (object)pedido.FECHA_PEDIDO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@NUMERO_OCLIENTE", (object)pedido.NUMERO_OCLIENTE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@IMPORTE_STOT", (object)pedido.IMPORTE_STOT, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@IMPORTE_IGV", (object)pedido.IMPORTE_IGV, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@IMPORTE_DESCUENTO", (object)pedido.IMPORTE_DESCUENTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@IMPORTE_TOTAL", (object)pedido.IMPORTE_TOTAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@PORCENTAJE_DESCUENTO", (object)pedido.PORCENTAJE_DESCUENTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@PORCENTAJE_IGV", (object)pedido.PORCENTAJE_IGV, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@OBSERVACION", (object)pedido.OBSERVACION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ESTADO", (object)pedido.ESTADO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ID_CLIENTE", (object)pedido.ID_CLIENTE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@IMPORTE_ISC", (object)pedido.IMPORTE_ISC, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@VALOR_VENTA", (object)pedido.VALOR_VENTA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ID_CLIENTE_FACTURA", (object)pedido.ID_CLIENTE_FACTURA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_VENDEDOR_ASIGNADO", (object)pedido.CODIGO_VENDEDOR_ASIGNADO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@FECHA_PROGRAMADA", (object)pedido.FECHA_PROGRAMADA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CONTACTO", (object)pedido.CONTACTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@EMAIL_CONTACTO", (object)pedido.EMAIL_CONTACTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@LUGAR_ENTREGA", (object)pedido.LUGAR_ENTREGA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@FACTURA_ADELANTADA", (object)pedido.FACTURA_ADELANTADA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ID_COTIZACION", (object)pedido.ID_COTIZACION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_EMPRESA", (object)pedido.CODIGO_EMPRESA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_SUCURSAL", (object)pedido.CODIGO_SUCURSAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@USUARIO", (object)pedido.USUARIO_AUTORIZA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@COMISION", (object)pedido.COMISION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@PUNTO_VENTA", (object)pedido.PUNTO_VENTA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@REDONDEO", (object)pedido.REDONDEO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@VALIDEZ", (object)pedido.VALIDEZ, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@MOTIVO", (object)pedido.MOTIVO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CORRELATIVO", (object)pedido.CORRELATIVO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CENTRO_COSTO", (object)pedido.CENTRO_COSTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TIPO_CAMBIO", (object)pedido.TIPO_CAMBIO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@SUCURSAL", (object)pedido.SUCURSAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@SERIE", (object)pedido.SERIE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						int num = db.ExecuteScalar<int>("InsertPedidoVenta", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, new int?(), new CommandType?(CommandType.StoredProcedure));
						foreach (DetallePedidoDTO devolucionDetalle in pedido.Detalle)
						{
							DynamicParameters dynamicParameters2 = new DynamicParameters();
							dynamicParameters2.Add("@ID_PRODUCTO", (object)devolucionDetalle.ID_PRODUCTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@ID_PEDIDO", (object)num, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@CANTIDAD", (object)devolucionDetalle.CANTIDAD, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@PRECIO", (object)devolucionDetalle.PRECIO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@DESCUENTO", (object)devolucionDetalle.DESCUENTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@IGV", (object)devolucionDetalle.IGV, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@IMPORTE", (object)devolucionDetalle.IMPORTE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@CANT_DESPACHADA", (object)devolucionDetalle.CANT_DESPACHADA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@CANT_FACTURADA", (object)devolucionDetalle.CANT_FACTURADA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@OBSERVACION", (object)devolucionDetalle.OBSERVACION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SECUENCIA", (object)devolucionDetalle.SECUENCIA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@PRECIO_ORIGINAL", (object)devolucionDetalle.PRECIO_ORIGINAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@TIPO", (object)devolucionDetalle.TIPO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@IMPORTE_DSCTO", (object)devolucionDetalle.IMPORTE_DSCTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@COMISION", (object)devolucionDetalle.COMISION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@AFECTO_IGV", (object)devolucionDetalle.AFECTO_IGV, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@ID_PRESUPUESTO", (object)devolucionDetalle.ID_PRESUPUESTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@UNIDAD", (object)devolucionDetalle.UNIDAD, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@FACTOR_CONVERSION", (object)devolucionDetalle.FACTOR_CONVERSION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SWT_PIGV", (object)devolucionDetalle.SWT_PIGV, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SWT_PROM", (object)devolucionDetalle.SWT_PROM, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@CANT_KIT", (object)devolucionDetalle.CANT_KIT, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SWT_DCOM", (object)devolucionDetalle.SWT_DCOM, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SWT_SABOR", (object)devolucionDetalle.SWT_SABOR, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@SWT_FREE", (object)devolucionDetalle.SWT_FREE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@POR_DETRACCION", (object)devolucionDetalle.POR_DETRACCION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							dynamicParameters2.Add("@DETRACCION", (object)devolucionDetalle.DETRACCION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
							db.ExecuteScalar("InsertDetallePedido", (object)dynamicParameters2, (IDbTransaction)sqlTransaction, new int?(), new CommandType?(CommandType.StoredProcedure));
						}



						sqlTransaction.Commit();
					}
					catch (Exception)
					{
						sqlTransaction.Rollback();
						throw;
					}
				}
				db.Dispose();
				return pedido;
			}
		}


        IQueryable<OpePedido> IOpePedidoService.RetrieveAllPedidos()
        {
            List<OpePedido> _List = db.OpePedidos.ToList();
            IQueryable<OpePedido> retrievedUsers = _List.AsQueryable();
            return retrievedUsers;
        }

      
    }
}
