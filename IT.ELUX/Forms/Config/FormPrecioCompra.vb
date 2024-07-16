Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormPrecioCompra
    Private ARTICULOBL As New ARTICULOBL
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Dim ARTICULOBE As New ARTICULOBE
            ARTICULOBE.precio = npdprecio.Value
            ARTICULOBE.art_cod = txtcod.Text
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr

            gsError = ARTICULOBL.SaveRow(ARTICULOBE, "PRECIO", ELMVLOGSBE)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormPrecioCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npdprecio.Select()
        Me.Text = "Precio de Compra"
        txtcod.ReadOnly = True
        txtdescripcion.ReadOnly = True
        txtunidad.ReadOnly = True
        Dim dtArticulo As DataTable
        dtArticulo = ARTICULOBL.SelectRow(gsCode)
        For Each Registro In dtArticulo.Rows
            txtcod.Text = IIf(IsDBNull(Registro("ART_CODIGO")), "", Registro("ART_CODIGO"))
            txtdescripcion.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            txtunidad.Text = IIf(IsDBNull(Registro("UNI_COD")), "", Registro("UNI_COD"))
            npdprecio.Text = IIf(IsDBNull(Registro("PRECIO")), 0, Registro("PRECIO"))
        Next
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
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub
End Class