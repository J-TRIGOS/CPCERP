Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormEtiquetasCaja
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELETIQUETABL As New ELETIQUETABL
    Dim variable As String

    Private Sub FormEtiquetasCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        variable = "LOTE DE TAPA"
        GetData()
    End Sub

    Private Sub GetData()
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELETIQUETABL.SelectRow()
        For Each Registro In dtUsuario.Rows
            txtcliente.Text = IIf(IsDBNull(Registro("CLIENTE")), "", Registro("CLIENTE"))
            lblcliente.Text = IIf(IsDBNull(Registro("CLIENTE_DES")), "", Registro("CLIENTE_DES"))
            txtarticulo.Text = IIf(IsDBNull(Registro("ARTICULO")), "", Registro("ARTICULO"))
            lblarticulo.Text = IIf(IsDBNull(Registro("ART_DES")), "", Registro("ART_DES"))
            txtcantop.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtund.Text = IIf(IsDBNull(Registro("MEDIDA")), "", Registro("MEDIDA"))
            lblund.Text = IIf(IsDBNull(Registro("MEDI_DES")), "", Registro("MEDI_DES"))
            txtlotenvase.Text = IIf(IsDBNull(Registro("LOTE_ENVASE")), "", Registro("LOTE_ENVASE"))
            dtpfec.Value = IIf(IsDBNull(Registro("FECHA_PRODUCCION")), "", Registro("FECHA_PRODUCCION"))
            txtlotetapa.Text = IIf(IsDBNull(Registro("LOTE")), "", Registro("LOTE"))
            txttotal.Text = IIf(IsDBNull(Registro("TOTAL")), "", Registro("TOTAL"))
            Dim d As String = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
            If d = "LOTE DE TAPA" Then
                rd1.Checked = True
                rd2.Checked = False
            Else
                rd1.Checked = False
                rd2.Checked = True
            End If
        Next
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If OkData() = False Then
            Exit Sub
        Else
            ReDim gsRptArgs(8)
            gsRptArgs(0) = lblcliente.Text
            gsRptArgs(1) = lblarticulo.Text
            gsRptArgs(2) = variable & " : " & txtlotetapa.Text
            gsRptArgs(3) = Format(dtpfec.Value, "dd/MM/yyyy")
            gsRptArgs(4) = txtlotenvase.Text
            gsRptArgs(5) = txtcantop.Text
            gsRptArgs(6) = lblund.Text
            gsRptArgs(7) = txttotal.Text
            gsRptArgs(8) = 0
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_CAJA.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            Dim ELETIQUETABE As New ELETIQUETABE

            ELETIQUETABE.cliente = txtcliente.Text
            ELETIQUETABE.articulo = txtarticulo.Text
            ELETIQUETABE.cantidad = txtcantop.Text
            ELETIQUETABE.medida = txtund.Text
            ELETIQUETABE.tipo = variable
            ELETIQUETABE.lote = txtlotetapa.Text
            ELETIQUETABE.fecha_produ = dtpfec.Value
            ELETIQUETABE.lote_envase = txtlotenvase.Text
            ELETIQUETABE.cod = ELETIQUETABL.SelectMaxTransp()
            ELETIQUETABE.total = txttotal.Text

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
        If txtcliente.Text = "" Then
            MsgBox("ingrese el Nombre del cliente", MsgBoxStyle.Exclamation)
            txtcliente.Focus()
            Return False
        End If
        If txtarticulo.Text = "" Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Exclamation)
            txtarticulo.Focus()
            Return False
        End If
        If txtlotetapa.Text = "" Then
            MsgBox("Ingrese el Nombre del lote", MsgBoxStyle.Exclamation)
            txtlotetapa.Focus()
            Return False
        End If
        If txtcantop.Text = "" Or txtcantop.Text = 0 Then
            MsgBox("Ingrese la Cantidad", MsgBoxStyle.Exclamation)
            txtlotetapa.Focus()
            Return False
        End If
        If txttotal.Text = "" Or txttotal.Text = "0" Then
            MsgBox("Ingrese el Total de unidades", MsgBoxStyle.Exclamation)
            txtlotetapa.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        If rd2.Checked = True Then
            variable = rd2.Text
            rd1.Checked = False
        End If
    End Sub
    Private Sub rd1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        If rd1.Checked = True Then
            variable = rd1.Text
            rd2.Checked = False
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtcantop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal.KeyPress, txtcantop.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcliente.Text = gLinea
                lblcliente.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

    Private Sub txtarticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo.KeyDown
        If variable = "LOTE DE TAPA" Then
            gArt = "1"
        Else
            gArt = "0"
        End If

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "99"
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
        gArt = ""
    End Sub
    Private Sub txtund_KeyDown(sender As Object, e As KeyEventArgs) Handles txtund.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "100"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtund.Text = gLinea
                lblund.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gSubLinea = ""
        gLinea = ""
    End Sub

End Class