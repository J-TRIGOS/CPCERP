Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting

Public Class FormBonoProduccion
    Dim PRODUCCIONBL As New PRODUCCIONBL
    Dim BONOPRODBE As New BONOPRODBE
    Dim cc = "0000"
    Dim dtDatos As New DataTable
    Dim validacion = 0
    Dim fila = 0


    Private Sub FormBonoProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvDatosPersonal.ShowCellToolTips = True
        Me.Text = "Registro Bono Producción"
        Dim dtCC As DataTable = PRODUCCIONBL.SelectCC()
        GetCmb("cod", "nom", dtCC, CmbCC)
        CmbCC.SelectedIndex = -1
        CmbCC.Enabled = False
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1

    End Function

    Private Sub CmbCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCC.SelectedIndexChanged
        If CheckBox1.Checked = True Then
            gsCode = CmbCC.SelectedValue.ToString
            Dim FormMantELTBPROC As New FormMantELTBPROC
            estadoProduccion = "1"
            With FormMantELTBPROC
                .ShowDialog()
            End With
            For i = 0 To DgvDatosPersonal.Columns.Count - 1
                DgvDatosPersonal.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End If
    End Sub

    Private Sub FormBonoProduccion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub DgvDatosPersonal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosPersonal.CellDoubleClick
        If e.ColumnIndex = 2 Then
            Dim fila = e.RowIndex
            Dim colum = e.ColumnIndex
            If Not fila >= 0 And colum >= 0 Then
                Exit Sub
            End If

            sBusAlm = "040106"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                DgvDatosPersonal.Rows(fila).Cells("ORDPRO").Value = gLinea
                DgvDatosPersonal.Rows(fila).Cells("CODART").Value = gSubLinea
                DgvDatosPersonal.Rows(fila).Cells("DESCRIPCION").Value = gLinea2
                DgvDatosPersonal.Rows(fila).Cells("CANTIDAD").Value = gLinea3
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
                gLinea3 = Nothing
                Dim dtProcArt As New DataTable
                dtProcArt = PRODUCCIONBL.BuscarProcXArticulo(DgvDatosPersonal.Rows(fila).Cells("CODART").Value)

                If dtProcArt.Rows.Count > 0 Then
                    DgvDatosPersonal.Rows(fila).Cells("CODPROCESO").Value = dtProcArt.Rows(0).Item(0)
                    DgvDatosPersonal.Rows(fila).Cells("UNIDHORA").Value = dtProcArt.Rows(0).Item(1)
                    codProcesoBP = dtProcArt.Rows(0).Item(2)
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gLinea2 = Nothing
                    gLinea3 = Nothing
                    Dim frm1 As New BusquedaPersonal
                    sBusAlm = "040106OPE"
                    frm1.ShowDialog()
                    DgvDatosPersonal.Rows(fila).Cells("UNIPROD").Value = InputBox("Ingrese Cantidad Producida por Operario")
                    If gLinea <> Nothing And gSubLinea <> Nothing Then
                        DgvDatosPersonal.Rows(fila).Cells("CODPROCESO").Value = gLinea
                        DgvDatosPersonal.Rows(fila).Cells("UNIDHORA").Value = gSubLinea
                        DgvDatosPersonal.Rows(fila).Cells("UNIPROD").Selected = True
                        DgvDatosPersonal.Rows(fila).Cells.Item("ORDPRO").Selected = False
                        DgvDatosPersonal.Rows(fila).Cells.Item("ORDPRO").ReadOnly = True
                        DgvDatosPersonal.CurrentCell = DgvDatosPersonal.Rows(fila).Cells("ORDPRO")
                        If DatFechaPro.Value.DayOfWeek = 6 Then
                            DgvDatosPersonal.Rows(fila).Cells("HORAINI").Value = "08:00"
                            DgvDatosPersonal.Rows(fila).Cells("HORAFIN").Value = "17:15"
                        Else
                            DgvDatosPersonal.Rows(fila).Cells("HORAINI").Value = "08:00"
                            DgvDatosPersonal.Rows(fila).Cells("HORAFIN").Value = "17:15"
                        End If
                    End If
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gLinea2 = Nothing
                    gLinea3 = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gLinea2 = Nothing
                    gLinea3 = Nothing
                End If
            End If
        End If

        'For i = 0 To DgvDatosPersonal.Rows.Count - 1
        '    If Not DgvDatosPersonal.Rows(i).Cells.Item(1).Value Is Nothing Then
        '        Dim dtProcArt As New DataTable
        '        Dim codigo = DgvDatosPersonal.Rows(i).Cells.Item(1).Value
        '        dtProcArt = PRODUCCIONBL.BuscarProcXArticulo(codigo)
        '        If dtProcArt.Rows.Count > 0 Then
        '            DgvDatosPersonal.Rows(i).Cells.Item(4).Value = dtProcArt.Rows(0).Item(0)
        '            DgvDatosPersonal.Rows(i).Cells.Item(5).Value = dtProcArt.Rows(0).Item(1)
        '            codProcesoBP = dtProcArt.Rows(0).Item(2)
        '            sBusAlm = "040106OPE"
        '            Dim frm As New BusquedaPersonal
        '            frm.ShowDialog()
        '            If gLinea <> Nothing And gSubLinea <> Nothing Then
        '                DgvDatosPersonal.Rows(i).Cells.Item(4).Value = gLinea
        '                DgvDatosPersonal.Rows(i).Cells.Item(5).Value = gSubLinea
        '            End If
        '        End If
        '    End If
        'Next

    End Sub


    Private Sub DgvDatosPersonal_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosPersonal.CellValueChanged
        If validacion = 0 Then
            Dim horaIni As String = "00:00"
            Dim horaFin As String = "00:00"
            Dim cantidadxHora = 0.0000
            Dim produccion = 0.00
            If ((e.ColumnIndex > -1) AndAlso (e.RowIndex > -1)) Then
                If e.ColumnIndex = 9 Then

                    horaIni = DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAINI").Value
                    If Not IsDate(horaIni) Then
                        MsgBox("Ingrese horas entre 00:00 - 23:59 ")
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAINI").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("PRODJOR").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("INDPRO").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAINI").Selected = True
                        Exit Sub
                    End If
                    Exit Sub
                End If
                If e.ColumnIndex = 10 Then
                    horaFin = DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAFIN").Value
                    horaIni = DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAINI").Value

                    If Not IsDate(horaFin) Then
                        MsgBox("Ingrese horas entre 00:00 - 23:59 ")
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAFIN").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("PRODJOR").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("INDPRO").Value = ""
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("HORAFIN").Selected = True
                        Exit Sub
                    End If

                    cantidadxHora = DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("UNIDHORA").Value
                    produccion = DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("UNIPROD").Value
                    If CDate(horaIni) > CDate(horaFin) Then
                        horaIni = CDate(horaIni).AddHours(-12)
                        horaFin = CDate(horaFin).AddHours(12)

                    End If
                    Dim tiempo = CDate(horaFin) - CDate(horaIni)
                    Dim horas = tiempo.ToString.Substring(0, 2)
                    Dim minutos = tiempo.ToString.Substring(3, 2)

                    Dim produccionDia = 0.00
                    produccionDia = (horas * cantidadxHora + minutos * (cantidadxHora / 60))

                    DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("PRODJOR").Value = Int(produccionDia)
                    If DatFechaPro.Value.DayOfWeek = 6 Then
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("INDPRO").Value = (Math.Round(produccion / produccionDia, 4)) - 0.65
                    Else
                        DgvDatosPersonal.Rows(e.RowIndex).Cells.Item("INDPRO").Value = (Math.Round(produccion / produccionDia, 4)) - 1
                    End If


                End If
            End If
        End If
        For i = 0 To DgvDatosPersonal.Columns.Count - 1
            DgvDatosPersonal.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        validacion = 1
        If DgvDatosPersonal.SelectedRows.Count > 0 Then
            Dim fila = DgvDatosPersonal.CurrentRow.Index
            DgvDatosPersonal.Rows.Remove(DgvDatosPersonal.CurrentRow)
        Else
            MsgBox("Seleccione Fila Para Borrar")
        End If
        validacion = 0
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Sub SaveData()
        Dim resultado = MsgBox("Desea Grabar los Registros", MsgBoxStyle.YesNo)
        If resultado = 7 Then
            Exit Sub
        End If
        Dim dtLinea As New DataTable

        flagAccion = "N"
        Dim dato As String = ""
        For i = 0 To DgvDatosPersonal.Rows.Count - 1
            If Not DgvDatosPersonal.Rows(i).Cells("ORDPRO").Value = "" Then
                BONOPRODBE.PER_COD = DgvDatosPersonal.Rows(i).Cells("COD").Value
                BONOPRODBE.EMPLEADO = DgvDatosPersonal.Rows(i).Cells("EMPLEADO").Value
                BONOPRODBE.ORD_PROD = DgvDatosPersonal.Rows(i).Cells("ORDPRO").Value
                BONOPRODBE.COD_ART = DgvDatosPersonal.Rows(i).Cells("CODART").Value
                BONOPRODBE.ARTICULO = DgvDatosPersonal.Rows(i).Cells("DESCRIPCION").Value
                BONOPRODBE.CANTIDAD = DgvDatosPersonal.Rows(i).Cells("CANTIDAD").Value
                BONOPRODBE.NOM_PROCESO = DgvDatosPersonal.Rows(i).Cells("CODPROCESO").Value
                dtLinea = PRODUCCIONBL.BuscarLineaPersona(BONOPRODBE.PER_COD)
                BONOPRODBE.COD_LINEA = dtLinea.Rows(0).Item(0)
                BONOPRODBE.NOM_LINEA = dtLinea.Rows(0).Item(1)
                BONOPRODBE.UNIDHORA = DgvDatosPersonal.Rows(i).Cells("UNIDHORA").Value
                BONOPRODBE.PROD_OPER = DgvDatosPersonal.Rows(i).Cells("UNiPROD").Value
                BONOPRODBE.HORA_INI = DgvDatosPersonal.Rows(i).Cells("HORAINI").Value
                BONOPRODBE.HORA_FIN = DgvDatosPersonal.Rows(i).Cells("HORAFIN").Value
                BONOPRODBE.PROD_DIA = DgvDatosPersonal.Rows(i).Cells("PRODJOR").Value
                BONOPRODBE.IND_PROD = DgvDatosPersonal.Rows(i).Cells("INDPRO").Value
                BONOPRODBE.USUARIO = gsUser
                BONOPRODBE.FEC_REGISTRO = Today
                BONOPRODBE.FEC_PROD = DatFechaPro.Value.ToString("d")
                PRODUCCIONBL.SaveRow(BONOPRODBE, flagAccion)
            End If
        Next
        MsgBox("Registro Grabados Correctamente")
        Dispose()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        fila = DgvDatosPersonal.Rows.Count
        sBusAlm = "3720"
        'sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            DgvDatosPersonal.Rows.Add()
            DgvDatosPersonal.Rows(fila).Cells("COD").Value = gLinea
            DgvDatosPersonal.Rows(fila).Cells("EMPLEADO").Value = gSubLinea

            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CmbCC.Enabled = True
        Else
            CmbCC.Enabled = False
        End If
    End Sub

    Private Sub DgvDatosPersonal_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosPersonal.CellMouseEnter
        If ((e.ColumnIndex > -1) AndAlso (e.RowIndex > -1)) Then
            If e.ColumnIndex = 3 Then
                Me.DgvDatosPersonal.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = DgvDatosPersonal.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value
            End If
        End If
    End Sub

    Private Sub DgvDatosPersonal_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DgvDatosPersonal.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) And DgvDatosPersonal.CurrentRow.Cells("ORDPRO").Selected = True Then
            If DgvDatosPersonal.CurrentRow.Cells("ORDPRO").Selected = True Then
                Dim fila = DgvDatosPersonal.CurrentRow.Index
                If Not fila >= 0 Then
                    Exit Sub
                End If

                sBusAlm = "040106"
                Dim frm As New BusquedaPersonal
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    DgvDatosPersonal.Rows(fila).Cells("ORDPRO").Value = gLinea
                    DgvDatosPersonal.Rows(fila).Cells("CODART").Value = gSubLinea
                    DgvDatosPersonal.Rows(fila).Cells("DESCRIPCION").Value = gLinea2
                    DgvDatosPersonal.Rows(fila).Cells("CANTIDAD").Value = gLinea3
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gLinea2 = Nothing
                    gLinea3 = Nothing
                    Dim dtProcArt As New DataTable
                    dtProcArt = PRODUCCIONBL.BuscarProcXArticulo(DgvDatosPersonal.Rows(fila).Cells("CODART").Value)

                    If dtProcArt.Rows.Count > 0 Then
                        DgvDatosPersonal.Rows(fila).Cells("CODPROCESO").Value = dtProcArt.Rows(0).Item(0)
                        DgvDatosPersonal.Rows(fila).Cells("UNIDHORA").Value = dtProcArt.Rows(0).Item(1)
                        codProcesoBP = dtProcArt.Rows(0).Item(2)
                        gLinea = Nothing
                        gSubLinea = Nothing
                        gLinea2 = Nothing
                        gLinea3 = Nothing
                        Dim frm1 As New BusquedaPersonal

                        sBusAlm = "040106OPE"
                        frm1.ShowDialog()
                        DgvDatosPersonal.Rows(fila).Cells("UNIPROD").Value = InputBox("Ingrese Cantidad Producida por Operario")
                        If gLinea <> Nothing And gSubLinea <> Nothing Then
                            DgvDatosPersonal.Rows(fila).Cells("CODPROCESO").Value = gLinea
                            DgvDatosPersonal.Rows(fila).Cells("UNIDHORA").Value = gSubLinea
                            DgvDatosPersonal.Rows(fila).Cells("UNIPROD").Selected = True
                            DgvDatosPersonal.Rows(fila).Cells.Item("ORDPRO").Selected = False
                            DgvDatosPersonal.Rows(fila).Cells.Item("ORDPRO").ReadOnly = True
                            If DatFechaPro.Value.DayOfWeek = 6 Then
                                DgvDatosPersonal.CurrentCell = DgvDatosPersonal.Rows(fila).Cells("ORDPRO")
                                DgvDatosPersonal.Rows(fila).Cells("HORAINI").Value = "08:00"
                                DgvDatosPersonal.Rows(fila).Cells("HORAFIN").Value = "13:30"
                            Else
                                DgvDatosPersonal.Rows(fila).Cells("HORAINI").Value = "08:00"
                                DgvDatosPersonal.Rows(fila).Cells("HORAFIN").Value = "17:15"
                            End If
                        End If
                        gLinea = Nothing
                        gSubLinea = Nothing
                        gLinea2 = Nothing
                        gLinea3 = Nothing
                    Else
                        gLinea = Nothing
                        gSubLinea = Nothing
                        gLinea2 = Nothing
                        gLinea3 = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FormBonoProduccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class