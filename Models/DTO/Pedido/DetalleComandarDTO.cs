namespace PLANTILLA_API_ODATA.Models.DTO.Pedido
{
    public class DetalleComandarDTO
    {
        public int ID_PRODUCTO { get; set; }
        public string PRODUCTO { get; set; }
        public double CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double IMPORTE { get; set; }
        public string OBSERVACION { get; set; }
        public string NOM_IMP { get; set; }
        public int SECUENCIA { get; set; }
    }
}
