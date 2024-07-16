Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDocuRefMant
    Private ELORDEN_MANTBL As New ELORDEN_MANTBL
    Private ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
    Private Sub FormDocuRefMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim item As ListViewItem
        lvbusqueda1.Items.Clear()
        dt = ELORDEN_MANTBL.list1(gsCode7)
        For Each row As DataRow In dt.Rows
            item = lvbusqueda1.Items.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")))
            item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
            item.SubItems.Add(IIf(IsDBNull(row("ORDEN_MANT")), "", row("ORDEN_MANT")))
            item.SubItems.Add(IIf(IsDBNull(row("FECHA")), "", row("FECHA")))
            item.SubItems.Add(IIf(IsDBNull(row("PRIORIDAD")), "", row("PRIORIDAD")))
            item.SubItems.Add(IIf(IsDBNull(row("ASUNTO")), "", row("ASUNTO")))
            item.SubItems.Add(IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")))
            item.SubItems.Add(IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")))
            item.SubItems.Add(IIf(IsDBNull(row("DESCSOL")), "", row("DESCSOL")))
            item.SubItems.Add(IIf(IsDBNull(row("EST")), "", row("EST")))
        Next
    End Sub
    'Private Sub SaveData()
    '    Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE
    '    Dim|| ELMVLOGSBE As New ELMVLOGSBE
    '    For i = 0 To lvbusqueda1.Items.Count - 1
    '        If lvbusqueda1.Items(i).Checked = True Then
    '            ELTBMANTENIMIENTOBE.T_DOC_REF = lvbusqueda1.Items(i).SubItems(0).Text
    '            ELTBMANTENIMIENTOBE.SER_DOC_REF = lvbusqueda1.Items(i).SubItems(1).Text
    '            ELTBMANTENIMIENTOBE.NRO_DOC_REF = lvbusqueda1.Items(i).SubItems(2).Text
    '            ELTBMANTENIMIENTOBE.ART_COD = lvbusqueda1.Items(i).SubItems(6).Text
    '            ELTBMANTENIMIENTOBE.EST = "1"
    '            gsError = ELORDEN_MANTBL.SaveRow1(ELTBMANTENIMIENTOBE, ELMVLOGSBE, "M")
    '        End If
    '    Next
    '
    'End Sub
    Private Sub FormDocuRefMant_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If lvbusqueda1.Items.Count <= 0 Then
            MsgBox("No hay datos para pasar ", MsgBoxStyle.Information)
        Else
            If flagAccion1 = "N" Then
            Else
                Dim a As Integer = FormOrdenMantenimiento.dgvt_doc.Rows.Count
                Dim indic As Integer = FormOrdenMantenimiento.dgvt_doc.Rows.Count
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        If a > 0 Then
                            For j = 0 To FormOrdenMantenimiento.dgvt_doc.Rows.Count - 1
                                ' If  FormOrdenMantenimiento.dgvt_doc.Rows(j).Cells().Value = lvbusqueda1.Items(i).SubItems(1).Text And
                                If FormOrdenMantenimiento.dgvt_doc.Rows(j).Cells("nro_mant").Value = lvbusqueda1.Items(i).SubItems(2).Text And
                                FormOrdenMantenimiento.dgvt_doc.Rows(j).Cells("Art_cod").Value = lvbusqueda1.Items(i).SubItems(6).Text Then
                                    MsgBox("Este articulo ya se encuentra listado elija otro")
                                    Exit Sub
                                End If
                            Next
                        End If

                        'If CInt(lvbusqueda1.Items(i).SubItems(10).Text) = 0 Then
                        '    Dim frm As New FormOrdenProgramas_Agregar
                        '    If MessageBox.Show("Artículo sin duración desea vincularle un proceso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        '       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        '    Else
                        '        frm.lblcod_art.Text = lvbusqueda1.Items(i).SubItems(3).Text
                        '        frm.lbldes_art.Text = lvbusqueda1.Items(i).SubItems(4).Text
                        '        frm.ShowDialog()
                        '        FormDocuRefContaff_Load(sender, e)
                        '    End If
                        '    Exit Sub
                        'End If
                    End If
                Next
                a = 0
                If indic > 0 Then
                    indic = FormOrdenMantenimiento.dgvt_doc.Rows(indic - 1).Cells("SEQ").Value
                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = indic + 1

                            FormOrdenMantenimiento.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text,
                                                                    lvbusqueda1.Items(i).SubItems(4).Text, lvbusqueda1.Items(i).SubItems(5).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(8).Text, "EN CURSO",
                                                                    lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                        End If
                    Next
                Else
                    For i = 0 To lvbusqueda1.Items.Count - 1
                        If lvbusqueda1.Items(i).Checked = True Then
                            a = a + 1
                            FormOrdenMantenimiento.dgvt_doc.Rows.Add(a, lvbusqueda1.Items(i).SubItems(2).Text, lvbusqueda1.Items(i).SubItems(3).Text,
                                                                    lvbusqueda1.Items(i).SubItems(4).Text, lvbusqueda1.Items(i).SubItems(5).Text,
                                                                    lvbusqueda1.Items(i).SubItems(6).Text, lvbusqueda1.Items(i).SubItems(7).Text,
                                                                    lvbusqueda1.Items(i).SubItems(8).Text, "EN CURSO",
                                                                    lvbusqueda1.Items(i).SubItems(0).Text, lvbusqueda1.Items(i).SubItems(1).Text,
                                                                    lvbusqueda1.Items(i).SubItems(2).Text)
                        End If
                    Next
                End If

                'SaveData()
                Dispose()
            End If
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If lvbusqueda1.Items.Count = 0 Then
            MsgBox("No hay items para anular")
        Else
            If lvbusqueda1.CheckedItems.Count = 0 Then
                MsgBox("Seleccione algun item que desee anular")
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1
                    If lvbusqueda1.Items(i).Checked = True Then
                        If lvbusqueda1.Items(i).SubItems(9).Text = "PENDIENTE" Then

                            Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE
                            Dim ELMVLOGSBE As New ELMVLOGSBE
                            ELTBMANTENIMIENTOBE.T_DOC_REF = lvbusqueda1.Items(i).SubItems(0).Text
                            ELTBMANTENIMIENTOBE.SER_DOC_REF = lvbusqueda1.Items(i).SubItems(1).Text
                            ELTBMANTENIMIENTOBE.NRO_DOC_REF = lvbusqueda1.Items(i).SubItems(2).Text
                            ELTBMANTENIMIENTOBE.ART_COD = lvbusqueda1.Items(i).SubItems(6).Text
                            ELMVLOGSBE.log_codusu = gsCodUsr
                            gsError = ELTBMANTENIMIENTOBL.SaveRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, "AO", Nothing, Nothing)
                            If gsError = "OK" Then
                                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                                FormMain.LblError.Text = ""
                            Else
                                FormMain.LblError.Text = gsError
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("La orden de Mantenimiento " + lvbusqueda1.Items(i).SubItems(0).Text + " - " + lvbusqueda1.Items(i).SubItems(1).Text + " - " + lvbusqueda1.Items(i).SubItems(2).Text + " no se puede ANULAR por que esta en " + lvbusqueda1.Items(i).SubItems(9).Text)
                        End If
                    End If
                Next

                FormDocuRefMant_Load(sender, e)

            End If
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If lvbusqueda1.Items.Count = 0 Then
            MsgBox("No hay items para cerrar")
        Else
            If lvbusqueda1.CheckedItems.Count = 0 Then
                MsgBox("Seleccione algun item que desee cerrar")
            Else
                For i = 0 To lvbusqueda1.Items.Count - 1

                    If lvbusqueda1.Items(i).Checked = True Then
                        If lvbusqueda1.Items(i).SubItems(9).Text = "PROCESO" Then
                            Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE
                            Dim ELORDEN_DET_PROGRAMBE As New ELORDEN_DET_PROGRAMBE
                            Dim ELMVLOGSBE As New ELMVLOGSBE
                            ELTBMANTENIMIENTOBE.SER_DOC_REF = lvbusqueda1.Items(i).SubItems(1).Text
                            ELTBMANTENIMIENTOBE.NRO_DOC_REF = lvbusqueda1.Items(i).SubItems(2).Text
                            ELTBMANTENIMIENTOBE.ART_COD = lvbusqueda1.Items(i).SubItems(6).Text
                            ELMVLOGSBE.log_codusu = gsCodUsr
                            gsError = ELTBMANTENIMIENTOBL.SaveRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, "C", Nothing, Nothing)

                            If gsError = "OK" Then
                                MsgBox("Se Cerro Correctamente", MsgBoxStyle.Information)
                                FormMain.LblError.Text = ""
                            Else
                                FormMain.LblError.Text = gsError
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("La orden de Mantenimiento " + lvbusqueda1.Items(i).SubItems(0).Text + " - " + lvbusqueda1.Items(i).SubItems(1).Text + " - " + lvbusqueda1.Items(i).SubItems(2).Text + " no se puede CERRAR por que esta en " + lvbusqueda1.Items(i).SubItems(9).Text)
                        End If
                    End If

                Next
                FormDocuRefMant_Load(sender, e)

            End If
        End If
    End Sub
    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        If chkmarcar.Checked Then
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = False Then
                    lvbusqueda1.Items(i).Checked = True
                End If

            Next
        Else
            For i = 0 To lvbusqueda1.Items.Count - 1
                If lvbusqueda1.Items(i).Checked = True Then
                    lvbusqueda1.Items(i).Checked = False
                End If
            Next
        End If
    End Sub
End Class