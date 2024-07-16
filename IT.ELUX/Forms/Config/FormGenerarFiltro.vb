Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormGenerarFiltro

    Private ARTICULOBL As New ARTICULOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private PROVISIONESBL As New PROVISIONESBL

    Private Sub GenerarFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpiar()
    End Sub
    Sub limpiar()
        'cmbanho.SelectedItem = DateTime.Now.ToString("yyyy")
        cmbanho.SelectedIndex = -1
        cmbmes.SelectedIndex = -1
        'cmbmes.SelectedIndex = DateTime.Now.Month - 1
        'cmbpendie.SelectedIndex = 1
    End Sub
    Private Sub txt_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "96"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_tipo.Text = gLinea
                lbl_tipo.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txt_tipo_LostFocus(sender As Object, e As EventArgs) Handles txt_tipo.LostFocus
        If (txt_tipo.Text = "") Then
            lbl_tipo.Text = ""
        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectTipodocCOD(txt_tipo.Text)
            If dt.Rows.Count > 0 Then
                txt_tipo.Text = dt.Rows(0).Item(0).ToString
                lbl_tipo.Text = dt.Rows(0).Item(1).ToString
            Else
                txt_tipo.Text = ""
                lbl_tipo.Text = ""
            End If
        End If
    End Sub

    Private Sub txtruc_LostFocus(sender As Object, e As EventArgs) Handles txtruc.LostFocus
        If (txtruc.Text = "") Then
            lblruc.Text = ""
        ElseIf txtruc.Text <> "" And lblruc.Text <> "" Then

        Else
            Dim dt As DataTable
            dt = ELDOCUMENTOBL.SelectProveedorCOD(txtruc.Text)
            If dt.Rows.Count > 0 Then
                txtruc.Text = dt.Rows(0).Item(0).ToString
                lblruc.Text = dt.Rows(0).Item(1).ToString
            Else
                txtruc.Text = ""
                lblruc.Text = ""
            End If
        End If
    End Sub

    Private Sub txtruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtruc.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "98"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtruc.Text = gLinea
                lblruc.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        If gsMenuNodeId = "0502160000" Then
            buscarDocFiltro()
            Exit Sub
        End If

        If gsMenuNodeId = "0302030000" Then
            buscarFactFiltro()
            Exit Sub
        End If

        Dim var1, var2, var3, var4, var5, var6, var7, var8, var9, var10 As String

        If cmbanho.SelectedIndex = -1 Or cmbanho.SelectedIndex = 0 Then
            var1 = " "
        Else
            var1 = cmbanho.SelectedItem
        End If

        If cmbmes.SelectedIndex = -1 Or cmbmes.SelectedIndex = 0 Then
            var2 = " "
        Else
            var2 = (cmbmes.SelectedIndex).ToString.PadLeft(2, "0")
        End If

        If txt_tipo.Text = "" Then
            var3 = " "
        Else
            var3 = txt_tipo.Text
        End If

        If txt_serie.Text = "" Then
            var4 = " "
        Else
            var4 = txt_serie.Text
        End If

        If txtnro.Text = "" Then
            var5 = " "
        Else
            var5 = txtnro.Text
        End If

        If txt_reg_nro.Text = "" Then
            var6 = " "
        Else
            var6 = txt_reg_nro.Text
        End If

        If txtruc.Text = "" Then
            var7 = " "
        Else
            var7 = txtruc.Text
        End If
        If cmbañoven.SelectedIndex = -1 Or cmbañoven.SelectedIndex = 0 Then
            var8 = " "
        Else
            var8 = cmbañoven.SelectedItem
        End If

        If cmbmesven.SelectedIndex = -1 Or cmbmesven.SelectedIndex = 0 Then
            var9 = " "
        Else
            var9 = (cmbmesven.SelectedIndex).ToString.PadLeft(2, "0")
        End If



        Dim dt As New DataTable

        If FormMain.cmbaño.SelectedIndex <> -1 And FormMain.cmbmes.SelectedIndex <> -1 Then
            'dt = PROVISIONESBL.SelectProvAll(FormMain.cmbaño.SelectedItem, (FormMain.cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
            dt = PROVISIONESBL.SelectProvAllFiltro(var1, var2, var3, var4, var5, var6, var7, var8, var9)
            FormMain.dgvMain.DataSource = dt
            FormMain.dgvMain.Refresh()
            'FormMain.dgvMain.CurrentCell = Nothing
            'FormMain.gHeader(FormMain.dgvMain)
        End If
    End Sub

    Private Sub FormGenerarFiltro_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Dispose()
    End Sub

    Private Sub buscarDocFiltro()
        Dim var1, var2, var3, var4, var5, var6, var7, var8, var9 As String

        If cmbanho.SelectedIndex = -1 Or cmbanho.SelectedIndex = 0 Then
            var1 = ""
        Else
            var1 = cmbanho.SelectedItem
        End If

        If cmbmes.SelectedIndex = -1 Or cmbmes.SelectedIndex = 0 Then
            var2 = ""
        Else
            var2 = (cmbmes.SelectedIndex).ToString.PadLeft(2, "0")
        End If

        If txt_tipo.Text = "" Then
            var3 = ""
        Else
            var3 = txt_tipo.Text
        End If

        If txt_serie.Text = "" Then
            var4 = ""
        Else
            var4 = txt_serie.Text
        End If

        If txtnro.Text = "" Then
            var5 = ""
        Else
            var5 = txtnro.Text
        End If

        If txt_reg_nro.Text = "" Then
            var6 = ""
        Else
            var6 = txt_reg_nro.Text
        End If

        If txtruc.Text = "" Then
            var7 = ""
        Else
            var7 = txtruc.Text
        End If
        If cmbañoven.SelectedIndex = -1 Or cmbañoven.SelectedIndex = 0 Then
            var8 = ""
        Else
            var8 = cmbañoven.SelectedItem
        End If

        If cmbmesven.SelectedIndex = -1 Or cmbmesven.SelectedIndex = 0 Then
            var9 = ""
        Else
            var9 = (cmbmesven.SelectedIndex).ToString.PadLeft(2, "0")
        End If
        Dim dt As New DataTable


        If FormMain.cmbaño.SelectedIndex <> -1 And FormMain.cmbmes.SelectedIndex <> -1 Then
            'dt = PROVISIONESBL.SelectProvAll(FormMain.cmbaño.SelectedItem, (FormMain.cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
            dt = ELPAGO_DOCUMENTOBL.SelectProvAllFiltro(var1, var2, var3, var4, var5, var6, var7, var8, var9)
            FormMain.dgvMain.DataSource = dt
            FormMain.dgvMain.Refresh()
            'FormMain.dgvMain.CurrentCell = Nothing
            'FormMain.gHeader(FormMain.dgvMain)
        End If


    End Sub

    Private Sub buscarFactFiltro()
        Dim var1, var2, var3, var4, var5, var6, var7, var8, var9, var10 As String

        If cmbanho.SelectedIndex = -1 Or cmbanho.SelectedIndex = 0 Then
            var1 = ""
        Else
            var1 = cmbanho.SelectedItem
        End If

        If cmbmes.SelectedIndex = -1 Or cmbmes.SelectedIndex = 0 Then
            var2 = ""
        Else
            var2 = (cmbmes.SelectedIndex).ToString.PadLeft(2, "0")
        End If

        If txt_tipo.Text = "" Then
            var3 = ""
        Else
            var3 = txt_tipo.Text
        End If

        If txt_serie.Text = "" Then
            var4 = ""
        Else
            var4 = txt_serie.Text
        End If

        If txtnro.Text = "" Then
            var5 = ""
        Else
            var5 = txtnro.Text
        End If

        If txt_reg_nro.Text = "" Then
            var6 = ""
        Else
            var6 = txt_reg_nro.Text
        End If

        If txtruc.Text = "" Then
            var7 = ""
        Else
            var7 = txtruc.Text
        End If
        If cmbañoven.SelectedIndex = -1 Or cmbañoven.SelectedIndex = 0 Then
            var8 = ""
        Else
            var8 = cmbañoven.SelectedItem
        End If

        If cmbmesven.SelectedIndex = -1 Or cmbmesven.SelectedIndex = 0 Then
            var9 = ""
        Else
            var9 = (cmbmesven.SelectedIndex).ToString.PadLeft(2, "0")
        End If

        If txtobserva1.Text = "" Then
            var10 = ""
        Else
            var10 = txtobserva1.Text
        End If
        Dim dt As New DataTable


        If FormMain.cmbaño.SelectedIndex <> -1 And FormMain.cmbmes.SelectedIndex <> -1 Then
            'dt = PROVISIONESBL.SelectProvAll(FormMain.cmbaño.SelectedItem, (FormMain.cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
            dt = ELPAGO_DOCUMENTOBL.SelectFactAllFiltro(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10)
            FormMain.dgvMain.DataSource = dt
            FormMain.dgvMain.Refresh()
            'FormMain.dgvMain.CurrentCell = Nothing
            'FormMain.gHeader(FormMain.dgvMain)
        End If


    End Sub
End Class