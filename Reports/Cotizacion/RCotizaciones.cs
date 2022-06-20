﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PLANTILLA_API_ODATA.Models.DTO.Cotizacion;

namespace PLANTILLA_API_ODATA.Reports.Cotizacion
{
    public class RCotizaciones
    {
        public static IWebHostEnvironment webHostEnvironment;
        public string webRootPath;
        public string contentRootPath;
        private int _maxColumn = 4;
        private Document _document;
        private PdfPTable _pdfPTable = new PdfPTable(4);
        private PdfPCell _pdfPCell;
        private Font _fontStyle;
        private MemoryStream _memoryStream = new MemoryStream();
        private List<CotizacionV> _pedidocab = new List<CotizacionV>();
        private List<DCotizacionV> _pedidobody = new List<DCotizacionV>();
        private PdfPTable Table = new PdfPTable(1);
        private Font smallfont = FontFactory.GetFont("Arial", 7f);
        private Font largefont = FontFactory.GetFont("Arial", "16", false, 16f, 1, BaseColor.BLACK);
        private Font mediumfont = FontFactory.GetFont("Arial", "11", false, 11f, 1, BaseColor.BLACK);
        private Font mediumfontSN = FontFactory.GetFont("Arial", "11", false, 11f, 0, BaseColor.BLACK);
        private Font letraChica = FontFactory.GetFont("Arial", "8", false, 8f, 0, BaseColor.BLACK);
        private Font letraMuyChica = FontFactory.GetFont("Arial", "6", false, 6f, 0, BaseColor.BLACK);
        private Font letraChicaN = FontFactory.GetFont("Arial", "8", false, 8f, 1, BaseColor.BLACK);
        private Font smallnumericfont = FontFactory.GetFont("Arial", "6", true, 6f, 2, BaseColor.BLACK);
        private Font smallfontBlack = FontFactory.GetFont("Arial Black", 7f);
        private PdfPTable TableTitulo = new PdfPTable(1);
        private PdfPTable TableCliente = new PdfPTable(4);
        private PdfPTable TableItem = new PdfPTable(10);
        private PdfPTable TableProducto = new PdfPTable(10);
        private PdfPTable TableSubTotal = new PdfPTable(10);
        private PdfPTable TableCondicion = new PdfPTable(10);
        private PdfPTable TableFirma = new PdfPTable(10);
        private PdfPTable TableVendedor = new PdfPTable(10);
        private PdfPTable TableClienteCab = new PdfPTable(20);


        public byte[] Report(
          List<CotizacionV> pedido,
          List<DCotizacionV> Detpedido)
        {
            _document = new Document(PageSize.A4, 10f, 10f, 20f, 30f);
            PdfWriter.GetInstance(_document, _memoryStream);
            //PdfWriter.GetInstance(this._document, (Stream)this._memoryStream).PageEvent = (IPdfPageEvent)new RCotizaciones.itsEvents(ImhdFT);
            _document.Open();
            ReportHeader(pedido);
            ReporBody(Detpedido);
            _pdfPTable.HeaderRows = 2;
            _document.Add(_pdfPTable);
            _document.Close();
            return _memoryStream.ToArray();
        }
        private void ReportHeader(List<CotizacionV> cbpedido)
        {
            _pedidocab = cbpedido;
            _pdfPCell = new PdfPCell(new Phrase("", mediumfontSN));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 1;
            TableTitulo.AddCell(_pdfPCell);
            foreach (CotizacionV cotizacionV in _pedidocab)
            {
                _pdfPCell = new PdfPCell(new Phrase("    ", mediumfontSN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableTitulo.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("COTIZACION: " + cotizacionV.NUMERO_COTIZACION, largefont));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                _pdfPCell.Border = 0;
                TableTitulo.AddCell(_pdfPCell);
                DateTime dateTime = cotizacionV.FECHA_COTIZACION;
                string str1 = dateTime.ToString("dd/mm/yyyy HH:MM");
                dateTime = DateTime.Now;
                string str2 = dateTime.ToString("dd/mm/yyyy");
                _pdfPCell = new PdfPCell(new Phrase("Fecha de Emisión: " + str1 + " / Fecha de Creación: " + str2, mediumfontSN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableTitulo.AddCell(_pdfPCell);
                _document.Add(TableTitulo);
                _pdfPCell = new PdfPCell(new Phrase("Cliente:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 2;
                _pdfPCell.HorizontalAlignment = 0;
                TableClienteCab.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.PERSONA, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 18;
                _pdfPCell.HorizontalAlignment = 0;
                TableClienteCab.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Dirección:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 2;
                _pdfPCell.HorizontalAlignment = 0;
                TableClienteCab.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.DIRECCION, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 18;
                _pdfPCell.HorizontalAlignment = 0;
                TableClienteCab.AddCell(_pdfPCell);
                _document.Add(TableClienteCab);
                _pdfPCell = new PdfPCell(new Phrase("RUC: ", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.RUC, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Teléfono(s): ", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.TELEFONO, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Motivo: ", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("VENTA", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Lugar entrega: ", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.LUGAR_ENTREGA, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("O/C", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Sucursal: ", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                string str3 = " ";
                _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Estimados Señores: " + str3, letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 4;
                _pdfPCell.HorizontalAlignment = 0;
                TableCliente.AddCell(_pdfPCell);
                TableItem.SpacingAfter = 10f;
                _document.Add(TableCliente);
            }
        }
        private void ReporBody(List<DCotizacionV> detpedido)
        {
            _pdfPCell = new PdfPCell(new Phrase("ITEM", letraChicaN));
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 1;
            TableItem.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase("DESCRIPCION", letraChicaN));
            _pdfPCell.Colspan = 6;
            _pdfPCell.HorizontalAlignment = 1;
            TableItem.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase("CANT.", letraChicaN));
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 1;
            TableItem.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase("V. UNIT", letraChicaN));
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 1;
            TableItem.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase("V. VENTA", letraChicaN));
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 1;
            TableItem.AddCell(_pdfPCell);
            TableItem.SpacingAfter = 10f;
            _document.Add(TableItem);
            _pedidobody = detpedido;
            foreach (DCotizacionV dcotizacionV in _pedidobody)
            {
                _pdfPCell = new PdfPCell(new Phrase(dcotizacionV.SECUENCIA.ToString(), letraChicaN));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableProducto.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(dcotizacionV.NOMBRE, letraChicaN));
                _pdfPCell.Colspan = 6;
                _pdfPCell.HorizontalAlignment = 1;
                TableProducto.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(dcotizacionV.CANTIDAD.ToString(), letraChicaN));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableProducto.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(dcotizacionV.PRECIO.ToString("N2"), letraChicaN));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableProducto.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(dcotizacionV.IMPORTE.ToString("N2"), letraChicaN));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 1;
                TableProducto.AddCell(_pdfPCell);
            }
            _document.Add(TableProducto);
            foreach (CotizacionV cotizacionV in _pedidocab)
            {
                DateTime dateTime = cotizacionV.FECHA_COTIZACION;
                dateTime = dateTime.AddDays(2.0);
                string str = dateTime.ToString("dd/MM/yyyy");
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 10;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 8;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Subtotal:", letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableSubTotal.AddCell(_pdfPCell);
                double num = cotizacionV.IMPORTE_STOT;
                _pdfPCell = new PdfPCell(new Phrase(num.ToString("N2"), letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 2;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 8;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Descuento:", letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableSubTotal.AddCell(_pdfPCell);
                num = cotizacionV.IMPORTE_DESCUENTO;
                _pdfPCell = new PdfPCell(new Phrase(num.ToString("N2"), letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 2;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 8;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("V.Venta:", letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableSubTotal.AddCell(_pdfPCell);
                num = cotizacionV.VALOR_VENTA;
                _pdfPCell = new PdfPCell(new Phrase(num.ToString("N2"), letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 2;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 8;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("IGV:18 %", letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableSubTotal.AddCell(_pdfPCell);
                num = cotizacionV.IMPORTE_IGV;
                _pdfPCell = new PdfPCell(new Phrase(num.ToString("N2"), letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 2;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 8;
                _pdfPCell.HorizontalAlignment = 1;
                TableSubTotal.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("Total " + cotizacionV.MON, letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 0;
                TableSubTotal.AddCell(_pdfPCell);
                num = cotizacionV.IMPORTE_TOTAL;
                _pdfPCell = new PdfPCell(new Phrase(num.ToString("N2"), letraChica));
                _pdfPCell.Colspan = 1;
                _pdfPCell.HorizontalAlignment = 2;
                TableSubTotal.AddCell(_pdfPCell);
                TableSubTotal.SpacingAfter = 10f;
                _document.Add(TableSubTotal);
                _pdfPCell = new PdfPCell(new Phrase("SON: DOS MIL SOLES CON 00 EXACTOS", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 10;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("CONDICIONES COMERCIALES:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 10;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("MONEDA:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.NOM_MONEDA, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("LUGAR DE ENTREGA:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(cotizacionV.LUGAR_ENTREGA, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("PLAZO DE ENTREGA:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase(str, letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("FORMA DE PAGO:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("CONTADO DEPOSITO", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("VALIDEZ DE LA OFERTA:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("2  DIAS", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("OBSERVACIONES:", letraChicaN));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 3;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
                _pdfPCell = new PdfPCell(new Phrase("", letraChica));
                _pdfPCell.Border = 0;
                _pdfPCell.Colspan = 7;
                _pdfPCell.HorizontalAlignment = 0;
                TableCondicion.AddCell(_pdfPCell);
            }
            _document.Add(TableCondicion);
            TableVendedor.SpacingBefore = 20f;
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 10;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 10;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase(" ", letraChicaN));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 10;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase("   ", letraChica));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 10;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 10;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _pdfPCell = new PdfPCell(new Phrase(" ", letraChica));
            _pdfPCell.Border = 0;
            _pdfPCell.Colspan = 1;
            _pdfPCell.HorizontalAlignment = 0;
            TableVendedor.AddCell(_pdfPCell);
            _document.Add(TableVendedor);
        }

        //public class itsEvents : PdfPageEventHelper
        //{
        //    private List<ImgHeadFoot> imghdft;

        //    public itsEvents(List<ImgHeadFoot> imgbyte)
        //    {
        //    }

        //    public override void OnStartPage(PdfWriter writer, Document document)
        //    {
        //        List<ImgHeadFoot> imghdft = this.imghdft;
        //        iTextSharp.text.Image instance = iTextSharp.text.Image.GetInstance("~/Images/Logogrouptito.png");
        //        instance.SetAbsolutePosition(10f, 750f);
        //        instance.ScaleAbsoluteWidth(80f);
        //        instance.ScaleAbsoluteHeight(80f);
        //        PdfPTable pdfPtable = new PdfPTable(1);
        //        pdfPtable.WidthPercentage = 100f;
        //        float[] relativeWidths = new float[1] { 10f };
        //        pdfPtable.SetWidths(relativeWidths);
        //        PdfPCell cell = new PdfPCell(instance);
        //        cell.Border = 0;
        //        cell.VerticalAlignment = 4;
        //        cell.HorizontalAlignment = 0;
        //        pdfPtable.AddCell(cell);
        //        document.Add((IElement)pdfPtable);
        //    }

        //    public override void OnEndPage(PdfWriter writer, Document document)
        //    {
        //        iTextSharp.text.Image instance = iTextSharp.text.Image.GetInstance("~/Images/Logogrouptito.png");
        //        instance.SetAbsolutePosition(0.0f, 0.0f);
        //        instance.ScaleAbsoluteWidth(450f);
        //        instance.ScaleAbsoluteHeight(100f);
        //        PdfPTable pdfPtable = new PdfPTable(1);
        //        pdfPtable.WidthPercentage = 100f;
        //        float[] relativeWidths = new float[1] { 10f };
        //        pdfPtable.SetWidths(relativeWidths);
        //        PdfPCell cell = new PdfPCell(instance);
        //        cell.Border = 0;
        //        cell.HorizontalAlignment = 0;
        //        pdfPtable.AddCell(cell);
        //        document.Add((IElement)pdfPtable);
        //    }
        //}
    }
}