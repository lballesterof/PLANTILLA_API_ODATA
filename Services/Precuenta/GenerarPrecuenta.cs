using iTextSharp.text.pdf;
using System.IO;
using static PLANTILLA_API_ODATA.Services.Precuenta.TicketPrecuentaPDF;

namespace PLANTILLA_API_ODATA.Services.Precuenta
{
    public class GenerarPrecuenta
    {
        private MemoryStream _memoryStream = new MemoryStream();
        public  byte[] Report(string pathOut = null)
        {

            TicketPDF boleta = new TicketPDF();

            PdfWriter.GetInstance(boleta.myDocument, _memoryStream);
            boleta.myDocument.Open();
            boleta.Path = Path.GetDirectoryName(pathOut) + "\\";
            boleta.FileName = $"{Path.GetFileNameWithoutExtension(pathOut)}.PDF";
           // boleta.HeaderImage = null;

            boleta.AddHeaderLine("TICKET_HEADER_01");
            boleta.AddHeaderLine("TICKET_HEADER_02");
            boleta.AddHeaderLine("TICKET_HEADER_03");
            boleta.AddHeaderLine("TICKET_HEADER_04");
            boleta.AddHeaderLine("TICKET_HEADER_05");

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
            return this._memoryStream.ToArray();

        }
    }
}
