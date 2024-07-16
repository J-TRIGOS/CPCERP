Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormBUSQSELECTMULT
    Private Sub FormBUSQSELECTMULT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sBusAlm = "FARDODETALMACEN" Then
            ListColm("1")
        End If
    End Sub
    Private Sub ListColm(ByVal ncol As String)
        If ncol = "1" Then
            LstVBusq1.Visible = True
            ' Cabeza de Columna ListView 1
            LstVBusq1.CheckBoxes = True
            LstVBusq1.Columns.Add("X", 20, HorizontalAlignment.Center)
            LstVBusq1.Columns.Add("COD_FAR", 90, HorizontalAlignment.Center)
            LstVBusq1.Columns.Add("NRO_DOC", 85, HorizontalAlignment.Center)
            LstVBusq1.Columns.Add("CANTIDAD", 70, HorizontalAlignment.Center)

            ' Cabeza de Columna ListView 2
            LstVBusq2.CheckBoxes = True
            LstVBusq2.Columns.Add("X", 20, HorizontalAlignment.Center)
            LstVBusq2.Columns.Add("COD_FAR", 90, HorizontalAlignment.Center)
            LstVBusq2.Columns.Add("NRO_DOC", 85, HorizontalAlignment.Center)
            LstVBusq2.Columns.Add("CANTIDAD", 70, HorizontalAlignment.Center)

            '   ListView 1
            LstVBusq1.Width = 290 ' Ancho
            LstVBusq1.Height = 246 ' Alto
            LstVBusq1.Location = New Point(4, 89)


            '   ListView 2
            LstVBusq2.Visible = True
            LstVBusq2.Width = 290 ' Ancho
            LstVBusq2.Height = 246 ' Alto
            LstVBusq2.Location = New Point(358, 89) ' Ubicacion en Formulario

            ' Boton Pasar
            btnpasar.Text = "Agregar"
            btnpasar.Location = New Point(300, 165) ' Ubicacion del boton
            btnpasar.Width = 54 ' Ancho

            'Boton Quitar
            btnquitar.Text = "Quitar"
            btnquitar.Location = New Point(300, 194) ' Ubicacion del boton
            btnquitar.Width = 54 ' Ancho

            'boton Agregar o guardar
            btnGuardar.Location = New Point(497, 64)

            'Boton Salir
            btnsalir.Location = New Point(573, 64)

            'Habilitar Filtro Generico
            txt_generic.Visible = True
            chkgeneric.Visible = True
            chkgeneric.Text = "Fardo" 'nombre del chek

            'Datos Guardados
            DataM()

            'Datos al cargar ListView
            Data()
        End If
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If sBusAlm = "FARDODETALMACEN" Then
            If LstVBusq1.Visible = True Then
                If chkmarcar.Checked Then
                    For i = 0 To LstVBusq1.Items.Count - 1
                        If LstVBusq1.Items(i).Checked = False Then
                            LstVBusq1.Items(i).Checked = True
                        End If

                    Next
                Else
                    For i = 0 To LstVBusq1.Items.Count - 1
                        If LstVBusq1.Items(i).Checked = True Then
                            LstVBusq1.Items(i).Checked = False
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnpasar_Click(sender As Object, e As EventArgs) Handles btnpasar.Click
        If sBusAlm = "FARDODETALMACEN" Then
            For i = 0 To LstVBusq1.Items.Count - 1
                If LstVBusq1.Items(i).Checked = True Then
                    Dim ListDos As New ListViewItem
                    ListDos.SubItems.Add(LstVBusq1.Items(i).SubItems(1).Text)
                    ListDos.SubItems.Add(LstVBusq1.Items(i).SubItems(2).Text)
                    ListDos.SubItems.Add(LstVBusq1.Items(i).SubItems(3).Text)
                    LstVBusq2.Items.Add(ListDos)
                End If
            Next
            Data()
            chkmarcar.Checked = False
            chkmarcar_CheckedChanged(sender, e)
        End If
    End Sub
    Private Sub Data()
        Dim dt As DataTable
        If sBusAlm = "FARDODETALMACEN" Then
            ' Datos Ingresados ListView 1
            Dim FormBUSQSELECTMULTBL As New FormBUSQSELECTMULTBL
            Dim valor As String = "0"
            LstVBusq1.Items.Clear()
            dt = FormBUSQSELECTMULTBL.list1Fardo(txtt_doc.Text, txtser_doc.Text, txt_num.Text, txt_generic.Text)
            For Each row As DataRow In dt.Rows
                For i = 0 To LstVBusq2.Items.Count - 1
                    If LstVBusq2.Items(i).SubItems(1).Text = IIf(IsDBNull(row("COD_FAR")), "", row("COD_FAR")) Then
                        valor = "1"
                    End If
                Next
                If valor = "0" Then
                    Dim ListUno As New ListViewItem
                    ListUno.SubItems.Add(IIf(IsDBNull(row("COD_FAR")), "", row("COD_FAR")))
                    ListUno.SubItems.Add(IIf(IsDBNull(row("NRO_DOC")), "", row("NRO_DOC")))
                    ListUno.SubItems.Add(IIf(IsDBNull(row("HOJAS")), "", row("HOJAS")))
                    LstVBusq1.Items.Add(ListUno)
                End If
                valor = "0"
            Next
        End If
    End Sub
    Private Sub DataM()
        Dim dt As DataTable
        ' Datos Ingresados ListView 2
        If sBusAlm = "FARDODETALMACEN" Then
            ' Datos Ingresados ListView 2
            Dim FormBUSQSELECTMULTBL As New FormBUSQSELECTMULTBL
            LstVBusq2.Items.Clear()
            dt = FormBUSQSELECTMULTBL.list2Fardo(lblTdoc.Text, lblSdoc.Text, lblNdoc.Text, lblGen.Text)
            For Each row As DataRow In dt.Rows
                Dim ListDos As New ListViewItem
                ListDos.SubItems.Add(IIf(IsDBNull(row("COD_FAR")), "", row("COD_FAR")))
                ListDos.SubItems.Add(IIf(IsDBNull(row("NRO_DOC")), "", row("NRO_DOC")))
                ListDos.SubItems.Add(IIf(IsDBNull(row("HOJAS")), "", row("HOJAS")))
                LstVBusq2.Items.Add(ListDos)
            Next
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Data()
    End Sub
    Private Sub txtt_doc_TextChanged(sender As Object, e As EventArgs) Handles txtt_doc.TextChanged
        If txtt_doc.TextLength > 0 Then
            chktipo.Checked = True
        Else
            chktipo.Checked = False
        End If
    End Sub
    Private Sub txtser_doc_TextChanged(sender As Object, e As EventArgs) Handles txtser_doc.TextChanged
        If txtser_doc.TextLength > 0 Then
            chkser.Checked = True
        Else
            chkser.Checked = False
        End If
    End Sub

    Private Sub txt_num_TextChanged(sender As Object, e As EventArgs) Handles txt_num.TextChanged
        If txt_num.TextLength > 0 Then
            chknum.Checked = True
        Else
            chknum.Checked = False
        End If
    End Sub

    Private Sub txt_generic_TextChanged(sender As Object, e As EventArgs) Handles txt_generic.TextChanged
        If txt_generic.TextLength > 0 Then
            chkgeneric.Checked = True
        Else
            chkgeneric.Checked = False
        End If
    End Sub

    Private Sub FormBUSQSELECTMULT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim j As Integer = 0
        If sBusAlm = "FARDODETALMACEN" Then
            j = LstVBusq2.Items.Count - 1
            For i As Integer = j To 0 Step -1
                If LstVBusq2.Items(i).Checked = True Then
                    LstVBusq2.Items.RemoveAt(i)
                End If
            Next
            Data()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If sBusAlm = "FARDODETALMACEN" Then
            Dim TextFardo As String = "INI"
            Dim CanFardo As Integer
            For i = 0 To LstVBusq2.Items.Count - 1
                If TextFardo = "INI" Then
                    TextFardo = LstVBusq2.Items(i).SubItems(1).Text
                    CanFardo = LstVBusq2.Items(i).SubItems(3).Text
                Else
                    TextFardo = TextFardo + "/"
                    TextFardo = TextFardo + LstVBusq2.Items(i).SubItems(1).Text
                    CanFardo = CanFardo + LstVBusq2.Items(i).SubItems(3).Text
                End If
            Next
            If TextFardo <> "INI" Then
                FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value = TextFardo
                FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = CanFardo
            End If
            Dispose()
            End If
    End Sub

End Class