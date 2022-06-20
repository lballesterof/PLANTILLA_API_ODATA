Imports Microsoft.VisualBasic

Public Class PrecuentaPDF
    Private lineaActual As Integer, SWTL_IMP_CAB As Boolean = False
    Dim dtResumenDiario As DataTable, FLAG_DETA As Boolean = False
    Dim TEXTO_PRINT As String = "", VR As String = "", VF As String = "", TIPO_DOCU_CLIE As String, RCU_CLIE As String
    Dim TIPO_DOCU_FE As String = "", LETRA_TD_FE As String = "", FLAG_PARTE As Boolean = False

    Private Sub ImprimirPreCuenta(IDdOCU As Long)

        lineaActual = 0
        SWTL_IMP_CAB = False
        FLAG_PARTE = False
        TEXTO_PRINT = ""
        VR = ""
        VF = ""
        TIPO_DOCU_CLIE = ""
        RCU_CLIE = ""

        Try
            dtResumenDiario = igFacade.OPESS_CONSULTA_PED_RESTFEALL(IDdOCU)
            Dim printDoc As PrintDocument
            Dim itemImp As DataRowView = CType(Me.cmbSucursalPedido.SelectedItem, DataRowView)
            printDoc = New PrintDocument
            AddHandler printDoc.PrintPage, AddressOf Imprime_Precuenta



            WriteLog(util.NullToString(itemImp.Item("IMPRESORA_MATRICIAL")), "IMPRESIONPRECUENTA")


            If vgPreviewDocumentoFE = "N" Then
                ' Si pones la impresora predeterminada, no es necesario poner la siguiente rutina
                printDoc.PrinterSettings.PrinterName = util.NullToString(itemImp.Item("IMPRESORA_MATRICIAL")) ' getImpresoraPorDefecto() ' util.NullToString(itemImp.Item("IMPRESORA_CAJA"))  ' “EPSON TM-U220 Receipt”
                printDoc.Print()

            Else
                Me.PrintPreviewDialog1.Document = printDoc
                Me.PrintPreviewDialog1.WindowState = Windows.Forms.FormWindowState.Maximized
                Me.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
                Me.PrintPreviewDialog1.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, Me.MENSAJE_SISTEMA)
        End Try








    End Sub

    Private Sub Imprime_Precuenta(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        On Error Resume Next
        Dim xPos As Single = 0
        Dim prFont As New System.Drawing.Font("Calibri", 9, FontStyle.Bold)
        Dim yPos As Single = 0
        Dim Lineas As String = vbNullString
        Dim lineHeight As Single
        Dim itemP As DataRow
        lineHeight = prFont.GetHeight(e.Graphics)
        Lineas = "------------------------------------------------------------"
        Dim item As DataRowView
        Do
            If lineaActual <= dtResumenDiario.Rows.Count - 1 Then
                itemP = dtResumenDiario.Rows(lineaActual)
                If util.NullToString(itemP.Item("TIPO")) = "IMP_LOGO" Then
                    If util.NullToString(itemP.Item("REF2")) = "S" And REF_TDOC <> "PV" Then
                        Dim currentX As Drawing.Image = Drawing.Image.FromFile(Application.StartupPath & "\" & "logoTicket" & ".bmp")
                        Dim AuxPbX As New PictureBox
                        AuxPbX.Image = currentX
                        yPos = yPos + 10
                        e.Graphics.DrawImage(AuxPbX.Image, 10, yPos, 240, 50)
                        yPos = yPos + 55
                    Else
                        yPos = yPos + 10
                    End If
                Else
                    yPos = yPos + 10
                End If
                Dim rect2 As New Drawing.Rectangle(5, yPos, 250, 15)
                Dim stringFormat2 As New StringFormat()

                If util.NullToString(itemP.Item("TIPO")) = "TITULO" Then
                    prFont = New System.Drawing.Font("Century", 8, FontStyle.Bold)
                    stringFormat2.Alignment = StringAlignment.Center
                    stringFormat2.LineAlignment = StringAlignment.Center
                    e.Graphics.DrawString(util.NullToString(itemP.Item("REF2")), prFont, Brushes.Black, rect2, stringFormat2)
                    e.Graphics.DrawRectangle(Pens.White, rect2)
                    yPos = yPos + 20
                End If
                prFont = New System.Drawing.Font(“Arial”, 5, FontStyle.Regular)
                If util.NullToString(itemP.Item("TIPO")) = "SUCURSAL" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "ZONA" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "MESA" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    If util.NullToString(itemP.Item("REF2")) <> "70" Then
                        TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    Else
                        TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + " Para llevar", 60, HorizontalAlignment.Left).Trim
                    End If
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "PEDIDO" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "MESERO" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "OBSERVACION2" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "FECHA Y HORA" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "TURNO" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If


                If util.NullToString(itemP.Item("TIPO")) = "NUMERO" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Near
                    stringFormat.LineAlignment = StringAlignment.Near
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")) + util.NullToString(itemP.Item("REF2")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If
                If util.NullToString(itemP.Item("TIPO")) = "DE" Then
                    yPos = yPos + 15
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Center
                    stringFormat.LineAlignment = StringAlignment.Center
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Center
                    stringFormat.LineAlignment = StringAlignment.Center
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")), 60, HorizontalAlignment.Center).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                    LETRA_TD_FE = util.NullToString(itemP.Item("REF2")).Split("-").GetValue(0)
                    TIPO_DOCU_FE = util.NullToString(itemP.Item("REF2")).Split("-").GetValue(1)

                End If

                If util.NullToString(itemP.Item("TIPO")) = "DETALLE" Then
                    If FLAG_PARTE = False Then
                        prFont = New System.Drawing.Font(“Arial”, 8, FontStyle.Bold)
                        'yPos = yPos + 20 : e.Graphics.DrawString("TD  SERIE    DESDE       HASTA        CANT.    TOTAL", prFont, Brushes.Black, 5, yPos)
                        yPos = yPos + 20 : e.Graphics.DrawString("Producto                 Cant.        P.Unit.          Importe", prFont, Brushes.Black, 5, yPos)
                        FLAG_PARTE = True
                    Else
                        prFont = New System.Drawing.Font(“Arial”, 8, FontStyle.Bold)
                        yPos = yPos + 10 : e.Graphics.DrawString(util.NullToString(itemP.Item("REF1")), prFont, Brushes.Black, 5, yPos)
                        'e.Graphics.DrawString(util.NullToString(itemP.Item("SERIE")), prFont, Brushes.Black, 30, yPos)
                        'e.Graphics.DrawString(util.NullToString(itemP.Item("DE")), prFont, Brushes.Black, 70, yPos)
                        'e.Graphics.DrawString(util.NullToString(itemP.Item("HASTA")), prFont, Brushes.Black, 135, yPos)

                        If util.NullToZero(itemP.Item("CANT")) > 0 And util.NullToZero(itemP.Item("PRECIO")) > 0 And util.NullToZero(itemP.Item("IMPORTE")) > 0 Then
                            xPos = 135 '220
                            xPos = xPos - e.Graphics.MeasureString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("CANT")), vgCantDecimalDV)), prFont).Width
                            e.Graphics.DrawString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("CANT")), vgCantDecimalDV)), prFont, Brushes.Black, xPos, yPos)
                            xPos = 200 ' 280
                            xPos = xPos - e.Graphics.MeasureString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("PRECIO")), vgCantDecimalPrecioDV)), prFont).Width
                            e.Graphics.DrawString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("PRECIO")), vgCantDecimalPrecioDV)), prFont, Brushes.Black, xPos, yPos)
                            xPos = 280
                            xPos = xPos - e.Graphics.MeasureString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("IMPORTE")), 2)), prFont).Width
                            e.Graphics.DrawString(util.NullToString(FormatNumber(util.NullToZero(itemP.Item("IMPORTE")), 2)), prFont, Brushes.Black, xPos, yPos)
                        Else
                            xPos = 135 '220
                            xPos = xPos - e.Graphics.MeasureString((""), prFont).Width
                            e.Graphics.DrawString((""), prFont, Brushes.Black, xPos, yPos)
                            xPos = 200 ' 280
                            xPos = xPos - e.Graphics.MeasureString((""), prFont).Width
                            e.Graphics.DrawString((""), prFont, Brushes.Black, xPos, yPos)
                            xPos = 280
                            xPos = xPos - e.Graphics.MeasureString((""), prFont).Width
                            e.Graphics.DrawString((""), prFont, Brushes.Black, xPos, yPos)
                        End If


                    End If
                End If





                If util.NullToString(itemP.Item("TIPO")) = "TOTAL" Then
                    yPos = yPos + 20
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    xPos = 280
                    xPos = xPos - e.Graphics.MeasureString("Total : " + util.NullToString(itemP.Item("REF1")) + " " + util.NullToString(FormatNumber(util.NullToZero(itemP.Item("IMPORTE")), 2)), prFont).Width
                    e.Graphics.DrawString("Total : " + util.NullToString(itemP.Item("REF1")) + " " + util.NullToString(FormatNumber(util.NullToZero(itemP.Item("IMPORTE")), 2)), prFont, Brushes.Black, xPos, yPos)
                End If




                If util.NullToString(itemP.Item("TIPO")) = "LINEA" Then
                    yPos = yPos + 20
                End If



                If util.NullToString(itemP.Item("TIPO")) = "TEXTO" Then
                    yPos = yPos + 10
                    Dim rect1 As New Drawing.Rectangle(5, yPos, 250, 15)
                    Dim stringFormat As New StringFormat()
                    stringFormat.Alignment = StringAlignment.Center
                    stringFormat.LineAlignment = StringAlignment.Center
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    rect1 = New Drawing.Rectangle(5, yPos, 250, 15)
                    stringFormat = New StringFormat()
                    stringFormat.Alignment = StringAlignment.Center
                    stringFormat.LineAlignment = StringAlignment.Center
                    prFont = New System.Drawing.Font(“Century”, 8, FontStyle.Bold)
                    TEXTO_PRINT = ajustar(util.NullToString(itemP.Item("REF1")), 60, HorizontalAlignment.Left).Trim
                    e.Graphics.DrawString(TEXTO_PRINT, prFont, Brushes.Black, rect1, stringFormat)
                    e.Graphics.DrawRectangle(Pens.White, rect1)
                End If



            End If


            lineaActual += 1

        Loop Until yPos >= e.MarginBounds.Bottom OrElse lineaActual >= dtResumenDiario.Rows.Count


        If lineaActual < dtResumenDiario.Rows.Count Then
            e.HasMorePages = True
            SWTL_IMP_CAB = True
        Else


            e.HasMorePages = False
            'End If



        End If






    End Sub
End Class
