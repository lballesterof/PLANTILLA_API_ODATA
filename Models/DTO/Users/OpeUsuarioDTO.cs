namespace PLANTILLA_API_ODATA.Models.DTO.Users
{
    public class OpeUsuarioDTO
    {
        public string USUARIO { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CODIGO_EMPRESA { get; set; }
        public int ID_CLIENTE { get; set; }
        public string POR_IGV { get; set; }
        public string CDGMONEDA { get; set; }
        public string VALIDEZ { get; set; }
        public string CDGPAGO { get; set; }
        public string SUCURSAL { get; set; }
        public string USUARIOAUTORIZA { get; set; }
        public string USUARIOCREACION { get; set; }
        public string NOMBREMOZO { get; set; }
        public string DESCUENTO { get; set; }
        public string SERIEPEDIDO { get; set; }
        public string ESTADOPEDIDO { get; set; }
        public string TIPOCAMBIO { get; set; }
        public string FACTURA_ADELANTADA => "0";
        public string ID_COTIZACION => "0";
        public string PUNTO_VENTA => "0";
        public string REDONDEO => "0";
        public string? MOTIVO => null;
        public string? CORRELATIVO => null;
        public string? CENTRO_COSTO => null;
        public string? CDG_VENDEDOR { get; set; }
        public string? LISTA_PRECIO => "LPR0000001";
        public string? RUC { get; set; }
        public string? NOMBRE { get; set; }
        public int? FLOGIN { get; set; }
    }
}
