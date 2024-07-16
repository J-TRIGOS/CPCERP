Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormEtiquetasTWO

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELETIQUETABL As New ELETIQUETABL
    Dim variable As String

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged, cmb2.SelectedIndexChanged, cmb3.SelectedIndexChanged, cmb4.SelectedIndexChanged

        Dim textcmb1, textcmb2, textcmb3, textcmb4, textcmb5 As String
        If cmb1.SelectedIndex = 0 Then
            textcmb1 = ""
        Else
            textcmb1 = cmb1.SelectedItem
        End If

        If cmb2.SelectedIndex = 0 Then
            textcmb2 = ""
        Else
            textcmb2 = cmb2.SelectedIndex.ToString.PadLeft(2, "0")
        End If

        If cmb3.SelectedIndex = 0 Then
            textcmb3 = ""
        Else
            textcmb3 = cmb3.SelectedItem
        End If

        If cmb4.SelectedIndex = 0 Then
            textcmb4 = ""
        Else
            textcmb4 = cmb4.SelectedItem
        End If

        If txt5.Text = "" Then
            textcmb5 = ""
        Else
            textcmb5 = txt5.Text
        End If

        txtlotenvase.Text = textcmb1 + textcmb2 + "-" + textcmb3 + textcmb4 + textcmb5

    End Sub

    Private Sub textcmb5_LostFocus(sender As Object, e As EventArgs) Handles txt5.LostFocus
        Dim textcmb1, textcmb2, textcmb3, textcmb4, textcmb5 As String
        If cmb1.SelectedIndex = 0 Then
            textcmb1 = ""
        Else
            textcmb1 = cmb1.SelectedItem
        End If

        If cmb2.SelectedIndex = 0 Then
            textcmb2 = ""
        Else
            textcmb2 = cmb2.SelectedIndex.ToString.PadLeft(2, "0")
        End If

        If cmb3.SelectedIndex = 0 Then
            textcmb3 = ""
        Else
            textcmb3 = cmb3.SelectedItem
        End If

        If cmb4.SelectedIndex = 0 Then
            textcmb4 = ""
        Else
            textcmb4 = cmb4.SelectedItem
        End If

        If txt5.Text = "" Then
            textcmb5 = ""
        Else
            textcmb5 = txt5.Text
        End If

        txtlotenvase.Text = textcmb1 + textcmb2 + "-" + textcmb3 + textcmb4 + textcmb5
    End Sub

    Private Sub FormEtiquetasTWO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcalidad.SelectedIndex = 0
        cmb1.SelectedIndex = 0
        cmb2.SelectedIndex = 0
        cmb3.SelectedIndex = 0
        cmb4.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        GetData()
    End Sub
    Private Sub GetData()
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELETIQUETABL.SelectRow_TWO("E")
        For Each Registro In dtUsuario.Rows

            txtarticulo.Text = IIf(IsDBNull(Registro("ARTICULO")), "", Registro("ARTICULO"))
            lblarticulo.Text = IIf(IsDBNull(Registro("ART_DES")), "", Registro("ART_DES"))
            txtcant.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtfardo.Text = IIf(IsDBNull(Registro("MEDIDA")), "", Registro("MEDIDA"))
            txtlotenvase.Text = IIf(IsDBNull(Registro("LOTE_ENVASE")), "", Registro("LOTE_ENVASE"))
            dtpfec.Value = IIf(IsDBNull(Registro("FECHA_PRODUCCION")), "", Registro("FECHA_PRODUCCION"))
            txtembalador.Text = IIf(IsDBNull(Registro("CLIENTE")), "", Registro("CLIENTE"))
            cmbturno.SelectedItem = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
        Next
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If OkData() = False Then
            Exit Sub
        Else
            ReDim gsRptArgs(10)
            gsRptArgs(0) = lblarticulo.Text
            gsRptArgs(1) = txtlotenvase.Text
            gsRptArgs(2) = txtfardo.Text
            gsRptArgs(3) = Format(dtpfec.Value, "dd/MM/yyyy")
            gsRptArgs(4) = txtcant.Text
            gsRptArgs(5) = txtetiquetas.Text
            gsRptArgs(6) = cmbturno.SelectedItem
            gsRptArgs(7) = txtembalador.Text
            gsRptArgs(8) = cmbcalidad.SelectedItem
            gsRptArgs(9) = cmb4.SelectedItem
            gsRptArgs(10) = txtarticulo.Text

            If chknros.Checked = True Then
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWO.rpt"
            Else
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_TWO2.rpt"
            End If
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            Dim ELETIQUETABE As New ELETIQUETABE

            ELETIQUETABE.articulo = txtarticulo.Text
            ELETIQUETABE.cantidad = txtcant.Text
            ELETIQUETABE.medida = txtfardo.Text
            ELETIQUETABE.lote = txtcant.Text
            ELETIQUETABE.fecha_produ = dtpfec.Value
            ELETIQUETABE.lote_envase = txtlotenvase.Text
            ELETIQUETABE.cod = ELETIQUETABL.SelectMaxTranspTwo()
            ELETIQUETABE.estado = "T"
            ELETIQUETABE.tipo = cmbturno.SelectedItem               'tipo
            ELETIQUETABE.cliente = txtembalador.Text                'cliente

            flagAccion = "N"
            gsError = ELETIQUETABL.SaveRow(ELETIQUETABE, flagAccion)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If

        End If
    End Sub
    Private Function OkData() As Boolean

        If txtarticulo.Text = "" Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            txtarticulo.Focus()
            Return False
        End If
        If cmb1.SelectedIndex = 0 Then
            MsgBox("Ingrese la Cant. de Fardos", MsgBoxStyle.Exclamation)
            cmb1.Focus()
            Return False
        End If
        If cmb2.SelectedIndex = 0 Then
            MsgBox("Ingrese el Mes", MsgBoxStyle.Exclamation)
            cmb2.Focus()
            Return False
        End If
        If cmb3.SelectedIndex = 0 Then
            MsgBox("Ingrese la Cant. de Paquetes", MsgBoxStyle.Exclamation)
            cmb3.Focus()
            Return False
        End If
        If cmb4.SelectedIndex = 0 Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            cmb4.Focus()
            Return False
        End If
        If txt5.Text = "" Then
            MsgBox("Ingrese el Cod. de Litografia", MsgBoxStyle.Exclamation)
            txt5.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtarticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "113"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtarticulo.Text = gLinea
                lblarticulo.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class