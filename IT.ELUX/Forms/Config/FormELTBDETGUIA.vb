Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Data.OleDb
Imports System.IO
Public Class FormELTBDETGUIA
    Private gpCaption As String
    Private ELTBDETDOCOPBL As New ELTBDETDOCOPBL
    Private ELTBDETGUIABL As New ELTBDETGUIABL
    Private ELTBSTIEMBL As New ELTBSTIEMBL
    Public ARCHIVO As String
    Dim xSheet As String = ""
    Private Sub FormELTBDETGUIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtt_doc.Text = "FARD"
        cmbt_doc.SelectedIndex = 0
        'cmb_serdoc.Items.Add("2022")
        cmb_serdoc.SelectedIndex = 1

        '    dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        '    dgvt_doc.Columns.Add("SER_DOC_REF", "Serie Documento") '1
        '    dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero Documento") '2
        '    dgvt_doc.Columns.Add("T_DOC_REF1", "Tipo") '3
        '    dgvt_doc.Columns.Add("SER_DOC_REF1", "Ser. Art") '4
        '    dgvt_doc.Columns.Add("NRO_DOC_REF1", "Nro. Art") '5
        '    dgvt_doc.Columns.Add("ART_COD", "Articulo") '6
        '    dgvt_doc.Columns.Add("COD_FAR", "Codigó Fardo") '7
        '    dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '8
        '    dgvt_doc.Columns.Add("FEC_GENE", "Fecha") '9
        '    dgvt_doc.Columns.Add("ESTADO", "Est") '10
        '    dgvt_doc.Columns.Add("PESO_NETO", "PESO NETO") '11
        '    dgvt_doc.Columns.Add("PESO_BRUTO", "PESO BRUTO") '12
        '    dgvt_doc.Columns.Add("HOJAS", "HOJAS") '13
        '
        '
        '
        '    dgvt_doc.Columns("T_DOC_REF1").Visible = False
        '    dgvt_doc.Columns("SER_DOC_REF1").Visible = False
        '    dgvt_doc.Columns("NRO_DOC_REF1").Visible = False
        '    dgvt_doc.Columns("FEC_GENE").Visible = False
        '    dgvt_doc.Columns("ESTADO").Visible = False
        '    dgvt_doc.Columns("HOJAS").Visible = False


        Dim dtArticulo As DataTable
            dtArticulo = ELTBDETGUIABL.SelectRow(lblTipo.Text, lblSer.Text, lblnro.Text, lblArt.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                          IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                          IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                          IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                          IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                          IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'6
                                          IIf(IsDBNull(row("COD_FAR")), "", row("COD_FAR")),'7
                                          IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'8
                                          IIf(IsDBNull(row("EST")), "", row("EST")),'9
                                          IIf(IsDBNull(row("PESO_NETO")), "", row("PESO_NETO")), '10
                                          IIf(IsDBNull(row("PESO_BRUTO")), "", row("PESO_BRUTO")),'11
                                          IIf(IsDBNull(row("HOJAS")), "", row("HOJAS"))) '12
        Next

        If dgvt_doc.RowCount > 0 Then
            flagAccion = "M"
            tsbimprimir.Enabled = True
        Else
            flagAccion = "N"
            tsbimprimir.Enabled = False
        End If
        Dim CCO_USER As String
        CCO_USER = ELTBSTIEMBL.OK_CCO_COD(gsUser)
        If CCO_USER = "301" Then
            GroupBox3.Visible = True
        End If
        Nro()
    End Sub
    Private Sub Nro()
        Dim nro As String = dgvt_doc.Rows.Count + 1
        If nro.Length = 1 Then
            txtnroop.Text = "0000000" & nro
        ElseIf nro.Length = 2 Then
            txtnroop.Text = "000000" & nro
        ElseIf nro.Length = 3 Then
            txtnroop.Text = "00000" & nro
        ElseIf nro.Length = 4 Then
            txtnroop.Text = "0000" & nro
        ElseIf nro.Length = 5 Then
            txtnroop.Text = "000" & nro
        ElseIf nro.Length = 6 Then
            txtnroop.Text = "00" & nro
        ElseIf nro.Length = 7 Then
            txtnroop.Text = "0" & nro
        ElseIf nro.Length = 6 Then
            txtnroop.Text = nro
        End If

        If flagAccion = "N" Then
            If dgvt_doc.RowCount > 0 Then
                Dim CodFardo0 As String = "0"
                Dim CodFardo1 As String = "0"
                Dim MesFardo As String = ""
                Dim AñoFardo As String = ""
                For i = 0 To dgvt_doc.Rows.Count - 1
                    CodFardo0 = dgvt_doc.Rows(i).Cells("COD_FAR").Value
                    CodFardo0 = Mid(CodFardo0, 2, 5)

                    If CodFardo0 > CodFardo1 Then
                        CodFardo1 = CodFardo0
                    End If
                Next
                CodFardo1 = CodFardo1 + 1
                If (dtpfecha.Value.Month).ToString.Length = 1 Then
                    MesFardo = "0" & dtpfecha.Value.Month
                ElseIf (dtpfecha.Value.Month).ToString.Length = 2 Then
                    MesFardo = dtpfecha.Value.Month
                End If
                AñoFardo = Mid(dtpfecha.Value.Year, 3, 2)
                txtArt.Text = "F" & CodFardo1 & MesFardo & AñoFardo & "N"
            Else
                txtArt.Text = ELTBDETGUIABL.Ncont()
            End If
        Else
            Dim CodFardo0 As String = "0"
            Dim CodFardo1 As String = "0"
            Dim MesFardo As String = ""
            Dim AñoFardo As String = ""
            For i = 0 To dgvt_doc.Rows.Count - 1
                CodFardo0 = dgvt_doc.Rows(i).Cells("COD_FAR").Value
                CodFardo0 = Mid(CodFardo0, 2, 5)
                If CodFardo0 > CodFardo1 Then
                    CodFardo1 = CodFardo0
                End If
            Next
            CodFardo1 = CodFardo1 + 1
            'If (dtpfecha.Value.Month).ToString.Length = 1 Then
            '    MesFardo = "0" & dtpfecha.Value.Month
            MesFardo = DateTime.Now.ToString("MM")
            'ElseIf (dtpfecha.Value.Month).ToString.Length = 2 Then
            '    MesFardo = dtpfecha.Value.Month
            'End If
            'AñoFardo = Mid(dtpfecha.Value.Year, 3, 2)
            AñoFardo = DateTime.Now.ToString("yy")
            If Val(Mid(txtArt.Text, 2, 9)) <= Val(CodFardo0 & MesFardo & AñoFardo) Then
                txtArt.Text = "F" & CodFardo1 & MesFardo & AñoFardo & "N"
            Else
                txtArt.Text = ELTBDETGUIABL.Ncont()
            End If
        End If
        Dim SumaCantidad, SumaPesoNeto, SumaPesoBruto As Double
        For i = 0 To dgvt_doc.Rows.Count - 1
            SumaCantidad = dgvt_doc.Rows(i).Cells("HOJAS").Value + SumaCantidad
            SumaPesoNeto = dgvt_doc.Rows(i).Cells("PESO_NETO").Value + SumaPesoNeto
            SumaPesoBruto = dgvt_doc.Rows(i).Cells("PESO_BRUTO").Value + SumaPesoBruto
        Next
        lblCanTot.Text = SumaCantidad
        npdcantidad.Value = SumaCantidad
        lblPesNet.Text = SumaPesoNeto
        lblPesBru.Text = SumaPesoBruto
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtArt.Text = "" Then
            MsgBox("Ingrese Articulo")
            Exit Sub
        End If
        If npdcantidad.Value = 0 Then
            MsgBox("Ingrese Cantidad de Hojas")
            Exit Sub
        End If

        dgvt_doc.Rows.Add(lblTipo.Text,      '0
                          lblSer.Text,       '1
                          lblnro.Text,       '2
                          txtt_doc.Text,     '3
                          cmb_serdoc.Text,   '4
                          txtnroop.Text,     '5
                          lblArt.Text,       '6 
                          txtArt.Text,       '7
                          lblFecGen.Text,    '8
                          "U",               '9
                          npdPesoNeto.Value, '10
                          npdPesoBruto.Value,'11
                          npdcantidad.Value) '12
        txtArt.Text = ""
        If ckbLimpiar.Checked = False Then
            npdcantidad.Value = 0
            npdPesoNeto.Value = 0
            npdPesoBruto.Value = 0
        End If
        Nro()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c As Integer = 0
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ESTADO").Value = "H" Or dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ESTADO").Value = "P" Then
                MessageBox.Show("Este ITEM no puede ser borrado")
                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
        Else
            MsgBox("No hay datos")
        End If

        Nro()
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        Dim mes As String
        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If
        Select Case sFunc

            Case "save"
                SaveData()
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(3)
                gsRptArgs(0) = lblTipo.Text
                gsRptArgs(1) = lblSer.Text
                gsRptArgs(2) = lblnro.Text
                gsRptArgs(3) = lblArt.Text

                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE_FARDO.rpt"


                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If

        Dim ELTBDETGUIABE As New ELTBDETGUIABE
        'If flagAccion = "N" Then
        ELTBDETGUIABE.T_DOC_REF = lblTipo.Text
        ELTBDETGUIABE.SER_DOC_REF = lblSer.Text
        ELTBDETGUIABE.NRO_DOC_REF = lblnro.Text
        ELTBDETGUIABE.ART_COD = lblArt.Text
        ELTBDETGUIABE.CFardo = ELTBDETGUIABL.Ncont()

        gsError = ELTBDETGUIABL.SaveRow(ELTBDETGUIABE, flagAccion, dgvt_doc)
        'Else
        '     gsError = ELTBDETGUIABL.SaveRow(ELTBDETGUIABE, flagAccion, dgvt_doc)
        'End If

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Private Function OkData() As Boolean
        Dim DataOP As String = 0
        Dim CanArt As Double = 0
        For l = 0 To dgvt_doc.Rows.Count - 1
            CanArt = CanArt + dgvt_doc.Rows(l).Cells("HOJAS").Value
            ' CanArt = CanArt + dgvt_doc.Rows(l).Cells("FEC_GENE").Value
        Next
        If (CanArt).ToString <> lblCant.Text Then
            MsgBox("Hojas Distinta", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub dtpfecha_LostFocus(sender As Object, e As EventArgs) Handles dtpfecha.LostFocus
        Dim CodFardo As String = Mid(txtArt.Text, 1, 6)
        Dim MesFardo As String = ""
        Dim AñoFardo As String = ""
        'Mes
        If dtpfecha.Value.Month <> Val(Mid(lblFecGen.Text, 4, 2)) Then
            If (dtpfecha.Value.Month).ToString.Length = 1 Then
                MesFardo = "0" & dtpfecha.Value.Month
            ElseIf (dtpfecha.Value.Month).ToString.Length = 2 Then
                MesFardo = dtpfecha.Value.Month
            End If
        Else
            MesFardo = Mid(txtArt.Text, 7, 2)
        End If
        'Año
        If dtpfecha.Value.Year <> Val(Mid(lblFecGen.Text, 7, 4)) Then
            AñoFardo = Mid(dtpfecha.Value.Year, 3, 2)
        Else
            AñoFardo = Mid(txtArt.Text, 9, 2)
        End If
        'Resultado
        txtArt.Text = CodFardo & MesFardo & AñoFardo & "N"
    End Sub
    ' Inicio - Importar excel 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                If ARCHIVO = "OpenFileDialog1" Then
                    Exit Sub
                End If

                Dim ds As New DataSet
                    Dim da As OleDbDataAdapter
                    Dim dt As DataTable
                    Dim conn As OleDbConnection

                    xSheet = "Hoja1"
                    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                    Try
                    da = New OleDbDataAdapter("SELECT ART_COD as ART_COD, COD_FAR as COD_FAR, PESO_NETO as PESO_NETO, PESO_BRUTO as PESO_BRUTO, HOJAS as HOJAS FROM  [" & xSheet & "$]", conn)
                    conn.Open()
                        da.Fill(ds, "MyData")
                        dt = ds.Tables("MyData")
                        importarExcel(dt)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                    Finally
                        conn.Close()
                    End Try

                End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        ' If CheckBox1.Checked = True Then
        '     Label3.Text = "Nro de Registros : " & dgvdatos1.Rows.Count
        ' ElseIf CheckBox2.Checked = True Then
        '     Label3.Text = "Nro de Registros : " & dgvdatos3.Rows.Count
        ' Else
        'Label3.Text = "Nro de Registros : " & dgvt_doc.Rows.Count
        ' End If
        Nro()
    End Sub
    Sub importarExcel(ByVal DT As DataTable)
        Dim PROVISIONESBL As New PROVISIONESBL
        Dim CTA_DEST As String

        Dim nro As String = 1
        For Each row As DataRow In DT.Rows
            '  CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))

            Dim dnro As String = Nothing

            If nro.Length = 1 Then
                dnro = "0000000" & nro
            ElseIf nro.Length = 2 Then
                dnro = "000000" & nro
            ElseIf nro.Length = 3 Then
                dnro = "00000" & nro
            ElseIf nro.Length = 4 Then
                dnro = "0000" & nro
            ElseIf nro.Length = 5 Then
                dnro = "000" & nro
            ElseIf nro.Length = 6 Then
                dnro = "00" & nro
            ElseIf nro.Length = 7 Then
                dnro = "0" & nro
            ElseIf nro.Length = 6 Then
                dnro = nro
            End If
            nro = nro + 1


            Dim MesFardo As String = DateTime.Now.ToString("MM")
            Dim AñoFardo As String = DateTime.Now.ToString("yy")


            dgvt_doc.Rows.Add(lblTipo.Text, lblSer.Text, lblnro.Text, txtt_doc.Text, cmb_serdoc.Text,
                              dnro, IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                 ("F" & (IIf(IsDBNull(row("COD_FAR")), "", row("COD_FAR"))) & MesFardo & AñoFardo & "N"),
                                 lblFecGen.Text, "U",
                                 IIf(IsDBNull(row("PESO_NETO")), "", row("PESO_NETO")),
                                 IIf(IsDBNull(row("PESO_BRUTO")), "", row("PESO_BRUTO")),
                                 IIf(IsDBNull(row("HOJAS")), "", row("HOJAS")))
            CTA_DEST = Nothing

        Next
    End Sub
End Class