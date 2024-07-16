Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Imports System
Imports System.Globalization
Public Class FormDuaCompra
    Private dtExplComponente, dt2 As DataTable
    Private var5, var4, articulo, observa, Tipo, Serie, Nro,
        tipo_doc, ser_doc, nro_doc, componente, nombrecompo, nombreart As String
    Private SinExplo As String = ""
    Private bPrimero As Boolean = True
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private ELDECLARACIONDUABL As New ELDECLARACIONDUABL
    Private ARTICULOBL As New ARTICULOBL

    Private Sub cbxNuevo_CheckedChanged(sender As Object, e As EventArgs) Handles cbxNuevo.CheckedChanged
        cmbcomponente_SelectedIndexChanged(cmbcomponente.SelectedIndex, e)
        'cmbcomponente
    End Sub

    Private Contadordua As Integer = 0

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click

        If OkData() = False Then
            Exit Sub
        Else
            Dim ELDECLARACIONDUABE As New ELDECLARACIONDUABE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELDECLARACIONDUABE.t_doc_ref = "01"
            ELDECLARACIONDUABE.ser_doc_ref = txtnguia.Text.Substring(0, 4)
            ELDECLARACIONDUABE.nro_doc_ref = txtnguia.Text.Substring(7, 7)
            ELDECLARACIONDUABE.t_doc_ref1 = tipo_doc
            ELDECLARACIONDUABE.ser_doc_ref1 = ser_doc
            ELDECLARACIONDUABE.nro_doc_ref1 = nro_doc
            ELDECLARACIONDUABE.art_cod = articulo
            ELDECLARACIONDUABE.nro_dua = txtserie.Text & "-" & txtanho.Text & "-" & txtmarit.Text & "-" & txtnro.Text & "-" & txt01.Text & "-" & txt6.Text & "-" & txtmon.Text
            ELDECLARACIONDUABE.ser_dua = txtsericom.Text
            ELDECLARACIONDUABE.art_dua = cmbcomponente.SelectedItem
            ELDECLARACIONDUABE.fecha = gArt
            ELMVLOGSBE.log_codusu = gsCodUsr
            gsError = ELDECLARACIONDUABL.SaveRow(ELDECLARACIONDUABE, flagAccion, ELMVLOGSBE)

            Dim fecha As String = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpfechactual.Value.ToLongDateString.ToString).Replace("De", "de")

            ReDim gsRptArgs(4)
            gsRptArgs(0) = "01"
            gsRptArgs(1) = txtnguia.Text.Substring(0, 4)
            gsRptArgs(2) = txtnguia.Text.Substring(7, 7)
            gsRptArgs(3) = fecha
            gsRptArgs(4) = txtcodigopri.Text

            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_DECLARACIONJ.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            If flagAccion = "N" Then
                Dispose()
            End If
        End If
    End Sub

    Private Sub FormDuaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim rutaarchivo As String = "\\192.168.1.5\Fichas Tecnicas\PDF FICHAS\TWO\" & articulo & " *.pdf"
        'System.Diagnostics.Process.Start(rutaarchivo)
        'Try
        '    Dim articulo As String = "02230197"
        '    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\PDF FICHAS\TWO", FileIO.SearchOption.SearchAllSubDirectories, "" & articulo & " *.pdf")
        '        ListBox1.Items.Add(archivos)
        '    Next
        '    System.Diagnostics.Process.Start("\\192.168.1.5\Fichas Tecnicas\PDF FICHAS\TWO\02230197 FT 13 TAPA TWIST OFF 58 BESTE ERNTE P.7482 BPANI CON BOTON FULL.pdf")
        'Catch ex As Exception
        '    MsgBox("No se realizó la operación por: " & ex.Message)
        'End Try

        'Try
        '    Dim articulo As String = "02230197"
        '    Dim rutaarchivo As String
        '    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\PDF FICHAS\TWO", FileIO.SearchOption.SearchAllSubDirectories, "" & articulo & " *.pdf")
        '        rutaarchivo = archivos
        '    Next
        '    System.Diagnostics.Process.Start(rutaarchivo)
        'Catch ex As Exception
        '    MsgBox("No se realizó la operación por: " & ex.Message)
        'End Try

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                habilitar(True)
                txtnguia.Focus()
            Case 1
                flagAccion = "M"
                habilitar(False)
                GetData(sTDoc, sNDoc)
        End Select
        bPrimero = False
    End Sub

    Private Sub habilitar(ByVal F As Boolean)
        cmbcomponente.Enabled = F
        dtpfechactual.Enabled = F
        txtserie.Enabled = F
        txtanho.Enabled = F
        txtnro.Enabled = F
        'txt6.Enabled = F
        txtnguia.Enabled = F
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELDECLARACIONDUABL.SelectRow(sTDoc, sNDoc)
        For Each Registro In dtUsuario.Rows

            txtnguia.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF")) & " - " & IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            txtcodigopri.Text = IIf(IsDBNull(Registro("CODIGO")), "", Registro("CODIGO"))
            txtdesprincipal.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            txtserie.Text = Registro("NRO_DUA").ToString.Substring(0, 3)
            txtanho.Text = Registro("NRO_DUA").ToString.Substring(4, 4)
            txtnro.Text = Registro("NRO_DUA").ToString.Substring(12, 6)
            txt6.Text = Registro("NRO_DUA").ToString.Substring(22, 1)
            txtFecha.Text = IIf(IsDBNull(Registro("FECHA")), "", Registro("FECHA"))
            cmbcomponente.SelectedIndex = Registro("INDICE")

        Next

    End Sub

    Private Sub txtnguia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnguia.KeyDown

        Dim dt, dt2 As DataTable
        Dim Registro As DataRow

        If e.KeyValue = Keys.F9 Then

            sBusAlm = "224"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then

                txtnguia.Text = gLinea & " - " & gSubLinea

                dt = ELDECLARACIONDUABL.getListdgv("01", gLinea, gSubLinea)
                For i = 0 To dt.Rows.Count - 1
                    Tipo = dt.Rows(0).Item(0)
                    Serie = dt.Rows(0).Item(1)
                    Nro = dt.Rows(0).Item(2)
                Next
                dt2 = GUIADESPACHOBL.getListdgv(Tipo, Serie, Nro)
                For Each Registro In dt2.Rows
                    articulo = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                    nombreart = IIf(IsDBNull(Registro("NOM_ART")), "", Registro("NOM_ART"))
                    observa = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
                Next
                txtFecha.Text = gArt
                txtcodigopri.Text = articulo
                txtdesprincipal.Text = nombreart

                Dim arrayPalabras() As String
                Dim var3 = observa
                arrayPalabras = Strings.Split(var3, " ")

                Dim var1 As String
                For i = 0 To arrayPalabras.Length - 1
                    If arrayPalabras(i).Length = 8 Then
                        If arrayPalabras(i).Substring(2, 1) = "/" Then
                            var1 = arrayPalabras(i).Substring(0, 6)
                            var5 = var1 & CInt(arrayPalabras(i).Substring(6, 2)) + 2000
                        End If
                    End If
                Next

                gLinea = ""
                gSubLinea = ""

            End If
            e.Handled = True
        End If

    End Sub

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)
        End If

        Select Case sFunc

            Case "save"

        End Select
    End Sub
    Private Sub Explotar(ByVal sCodArt As String, ByVal dtExp As DataTable)
        Dim sTipo As String
        Dim sCodComp As String
        Dim sComponente As String

        For i = 0 To dtExp.Rows.Count - 1

            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = Mid(dtExp.Rows(i).Item(1), 11)

            Dim dtComp, dt, dt2, dt3, dt4 As New DataTable
            dtComp = ARTICULOBL.getListdgv1(sCodComp)

            If sCodComp.Substring(0, 4) = "0208" Then
                dt2 = ELDECLARACIONDUABL.SelectGetFecha(var5, sCodComp)
                var4 = dt2.Rows(0).Item(0).ToString
            End If

            Dim sum_stock As Double = 0
            Dim fecha_fin, fecha_ini, año As String
            If sCodComp = cmbcomponente.SelectedItem.ToString.Substring(0, 8) Then
                dt = ELDECLARACIONDUABL.SelectGetART_GETDATOS(var4, sCodComp)
                If dt.Rows.Count > 0 Then
                    For j = dt.Rows.Count - 1 To 0 Step -1
                        fecha_fin = dt.Rows(j).Item(0).ToString
                        año = fecha_fin.Substring(0, 4)
                        If año = "2019" Then fecha_ini = "2019/01/01" Else fecha_ini = "2018/01/01"
                        dt3 = ELDECLARACIONDUABL.SelectGetART_SUM_STK(var4, fecha_fin, sCodComp) 'suma de todos
                        dt4 = ELDECLARACIONDUABL.SelectGetART_SALDO_FEC(fecha_ini, fecha_fin, año, sCodComp) 'obtener saldo
                        Dim saldo As Double
                        saldo = dt4.Rows(0).Item(0).ToString
                        For k = 0 To dt3.Rows.Count - 1
                            sum_stock = sum_stock + CDbl(dt3.Rows(k).Item(0).ToString)
                        Next
                        If (saldo - sum_stock <= 0) Then
                            tipo_doc = dt.Rows(j).Item(1).ToString
                            ser_doc = dt.Rows(j).Item(2).ToString
                            nro_doc = dt.Rows(j).Item(3).ToString
                            componente = sCodComp
                            nombrecompo = sComponente
                            Contadordua = Contadordua + 1
                            Exit Sub
                        Else
                            sum_stock = 0
                        End If
                    Next
                Else
                    If cmbcomponente.SelectedItem.ToString.Substring(0, 8) = "05020322" Then
                        dt = ELDECLARACIONDUABL.SelectGetART_GETDATOS(var4, "05330177")
                        For j = dt.Rows.Count - 1 To 0 Step -1
                            fecha_fin = dt.Rows(j).Item(0).ToString
                            año = fecha_fin.Substring(0, 4)
                            If año = "2019" Then fecha_ini = "2019/01/01" Else fecha_ini = "2018/01/01"
                            dt3 = ELDECLARACIONDUABL.SelectGetART_SUM_STK(var4, fecha_fin, "05330177") 'suma de todos
                            dt4 = ELDECLARACIONDUABL.SelectGetART_SALDO_FEC(fecha_ini, fecha_fin, año, "05330177") 'obtener saldo
                            Dim saldo As Double
                            saldo = dt4.Rows(0).Item(0).ToString
                            For k = 0 To dt3.Rows.Count - 1
                                sum_stock = sum_stock + CDbl(dt3.Rows(k).Item(0).ToString)
                            Next
                            If (saldo - sum_stock <= 0) Then
                                tipo_doc = dt.Rows(j).Item(1).ToString
                                ser_doc = dt.Rows(j).Item(2).ToString
                                nro_doc = dt.Rows(j).Item(3).ToString
                                componente = "05330177"
                                nombrecompo = sComponente
                                Contadordua = Contadordua + 1
                                Exit Sub
                            Else
                                sum_stock = 0
                            End If
                        Next
                    ElseIf cmbcomponente.SelectedItem.ToString.Substring(0, 8) = "05020324" Then
                        dt = ELDECLARACIONDUABL.SelectGetART_GETDATOS(var4, "05330176")
                        For j = dt.Rows.Count - 1 To 0 Step -1
                            fecha_fin = dt.Rows(j).Item(0).ToString
                            año = fecha_fin.Substring(0, 4)
                            If año = "2019" Then fecha_ini = "2019/01/01" Else fecha_ini = "2018/01/01"
                            dt3 = ELDECLARACIONDUABL.SelectGetART_SUM_STK(var4, fecha_fin, "05330176") 'suma de todos
                            dt4 = ELDECLARACIONDUABL.SelectGetART_SALDO_FEC(fecha_ini, fecha_fin, año, "05330176") 'obtener saldo
                            Dim saldo As Double
                            saldo = dt4.Rows(0).Item(0).ToString
                            For k = 0 To dt3.Rows.Count - 1
                                sum_stock = sum_stock + CDbl(dt3.Rows(k).Item(0).ToString)
                            Next
                            If (saldo - sum_stock <= 0) Then
                                tipo_doc = dt.Rows(j).Item(1).ToString
                                ser_doc = dt.Rows(j).Item(2).ToString
                                nro_doc = dt.Rows(j).Item(3).ToString
                                componente = "05330176"
                                nombrecompo = sComponente
                                Contadordua = Contadordua + 1
                                Exit Sub
                            Else
                                sum_stock = 0
                            End If
                        Next
                    End If
                End If
            End If
            If Contadordua = 0 Then
                Explotar(sCodComp, dtComp)
            End If

        Next

    End Sub

    Private Function OkData() As Boolean
        If txtFecha.Text = "" And txtcodigopri.Text = "" Then
            MsgBox("No ha ingresado una factura válida", MsgBoxStyle.Exclamation)
            Return False
        End If

        If txt6.Text = "" Then
            MsgBox("No ha ingresado el siguiente campo", MsgBoxStyle.Exclamation)
            txt6.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub FormOrdenProgramas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dispose()
    End Sub
    Private Sub cmbcomponente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcomponente.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If

        Dim dtExplosion As New DataTable
        dtExplosion = ARTICULOBL.getListdgv1(articulo)
        Contadordua = 0
        Explotar(articulo, dtExplosion)
        Dim dt5 As DataTable


        dt5 = ELDECLARACIONDUABL.getListDua(tipo_doc, ser_doc, nro_doc, componente, var4)
            For i = 0 To dt5.Rows.Count - 1
                txtdesprincipal.Text = nombreart
                txtserie.Text = dt5.Rows(0).Item(1)
                txtanho.Text = dt5.Rows(0).Item(3)
            txtnro.Text = dt5.Rows(0).Item(2)
            If cbxNuevo.Checked = True Then
                txtserie.Text = "118"
                txtanho.Text = "2020"
                txtnro.Text = "345954"
            End If
        Next


    End Sub

    Private Sub txtcodigopri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigopri.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "233"
            Dim frm As New FormBUSQUEDA
            gsCode7 = Mid(txtnguia.Text, 8, 7)
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodigopri.Text = gLinea
                articulo = txtcodigopri.Text
                txtdesprincipal.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gsCode7 = ""
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gsCode7 = ""
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodigopri_LostFocus(sender As Object, e As EventArgs) Handles txtcodigopri.LostFocus
        If txtcodigopri.TextLength > 0 Then
            txtdesprincipal.Text = ARTICULOBL.SelectArt2(txtcodigopri.Text)
            articulo = txtcodigopri.Text
        Else
            txtcodigopri.Text = ""
            txtdesprincipal.Text = ""
            articulo = ""
        End If
    End Sub
End Class