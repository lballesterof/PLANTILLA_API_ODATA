namespace PLANTILLA_API_ODATA.Reports.Precuenta
{
    public class CrearPrecuenta
    {
        public byte[] CrearBoleta()
        {
            TicketPDF boleta = new TicketPDF();
            //boleta.Path = Path.GetDirectoryName(pathOut) + "\\";
            boleta.FileName = $"Precuenta.PDF";
            boleta.HeaderImage = null;

            boleta.AddHeaderLine1("PRECUENTA");
            
            boleta.AddHeaderLine("PEDIDO: ");
            boleta.AddHeaderLine("ZONA:   ");
            boleta.AddHeaderLine("MESA:   ");
            boleta.AddHeaderLine("MESERO: ");
            boleta.AddHeaderLine("FECHA Y HORA: ");

            boleta.AddSubHeaderLine("Dato 1");
            boleta.AddSubHeaderLine("Dato 2");
            boleta.AddSubHeaderLine("Dato 3");
            boleta.AddSubHeaderLine("Dato 4");
            boleta.AddSubHeaderLine("Dato 5");

            int Cantidad = 1;
            string Producto = "Stacarbone 100";
            int Total = 1500;
            // Detalles
            boleta.AddItem(Cantidad.ToString(), Producto.Substring(0, 11), Total.ToString());
            boleta.AddTotal("Total S/.", "22.50");
           return boleta.Print();

        }
    }
}
