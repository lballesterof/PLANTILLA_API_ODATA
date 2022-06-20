using PLANTILLA_API_ODATA.Parameters;

namespace PLANTILLA_API_ODATA.Feature.Stocks
{
    public class GetAllStocksWarehouseParameters: RequestParameter
    {
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string CdgRef { get; set; }
        public string Nombre { get; set; }
    }
}
