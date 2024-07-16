Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormActCntSolm
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBACTUALIZAR_DATOSBL As New ELTBACTUALIZAR_DATOSBL
    Private npr As String = "0"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormActCntSolm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbserie.SelectedIndex = 0
        cmbAlmacen.SelectedIndex = 0
        txtanho.Text = Date.Now.Year
        cmbTipo.SelectedIndex = 0
        ' cmbSerie3.Items.Add(Date.Now.Year)
        cmbSerie3.SelectedIndex = 0
        'TabPage2.TabPages.Item(3).Enabled = False

        ' Produccion

        For number As Integer = 2021 To (Date.Now.Year)
            cmbSerProd.Items.Add(number)
        Next
        'cmbSerProd.Items.Add(Date.Now.Year)
        cmbSerProd.SelectedIndex = 0
        cmdTipProd.SelectedIndex = 0

        ' Reingreso
        cmbSerRein.Items.Add(Date.Now.Year)
        cmbSerRein.SelectedIndex = 0
        cmbTipRein.SelectedIndex = 0

        ' Fallados
        cmbSerFall.Items.Add(Date.Now.Year)
        cmbSerFall.SelectedIndex = 0
        cmbTipFall.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SOLMATERIALESBE As New SOLMATERIALESBE
        SOLMATERIALESBE.SER_DOC_REF = cmbserie.Text
        SOLMATERIALESBE.NRO_DOC_REF = txtnumero.Text
        gsError = SOLMATERIALESBL.UpdRow(SOLMATERIALESBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Solm Actualizada", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ARTICULOBE As New ARTICULOBE
        If cmbAlmacen.Text = "0001 - GALERA 108 PANAMA" Then
            ARTICULOBE.alm_cod = "0001"
        ElseIf cmbAlmacen.Text = "0002 - FALLADO PANAMA" Then
            ARTICULOBE.alm_cod = "0002"
        ElseIf cmbAlmacen.Text = "0003 - LURIN" Then
            ARTICULOBE.alm_cod = "0003"
        End If
        ARTICULOBE.anho = txtanho.Text
        ARTICULOBE.art_cod = txtart.Text
        gsError = ARTICULOBL.UpdRow(ARTICULOBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Articulo Actualizada", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
        End If
    End Sub



    Private Sub txtnro3_LostFocus(sender As Object, e As EventArgs) Handles txtnro3.LostFocus
        'If Len(txtnro3.Text) = 6 Then
        If txtnro3.TextLength <> 7 Then
            MsgBox("Debe ingresar un numero correcto")
            txtnro3.Text = ""
            Exit Sub
        End If
        Dim dt As DataTable
        dt = SOLMATERIALESBL.SelectArt(cmbTipo.Text, cmbSerie3.Text, txtnro3.Text)
        GetCmb("nro_doc_ref", "art_cod", dt, cmbArt3)

        txtTipo03.Text = ""
        txtSer03.Text = ""
        txtnro03.Text = ""
        CheckBox1.Checked = False
        'End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'cmbSer1.Items.Add(txtSer03.Text)
        For number As Integer = 2022 To (Date.Now.Year)
            cmbSer1.Items.Add(number)
        Next
        'cmbSer1.Items.Add(Date.Now.Year)
        cmbSer1.SelectedIndex = 0
        'cmbTipo1.Items.Add(txtTipo03.Text)
        cmbTipo1.Items.Add("OPRD")
        cmbTipo1.SelectedIndex = 0

        Dim dtDocu As DataTable

        dtDocu = SOLMATERIALESBL.SelectRow(cmbTipo.Text, cmbSerie3.Text, txtnro3.Text, cmbArt3.Text)

        For Each Registro In dtDocu.Rows
            ' txtTipo03.Text = IIf(IsDBNull(Registro("T_DOC_REF1")), "", Registro("T_DOC_REF1"))
            ' txtSer03.Text = IIf(IsDBNull(Registro("SER_DOC_REF1")), "", Registro("SER_DOC_REF1"))
            cmbTipo1.Text = IIf(IsDBNull(Registro("T_DOC_REF1")), "", Registro("T_DOC_REF1"))
            cmbSer1.Text = IIf(IsDBNull(Registro("SER_DOC_REF1")), "", Registro("SER_DOC_REF1"))
            txtnro03.Text = IIf(IsDBNull(Registro("NRO_DOC_REF1")), "", Registro("NRO_DOC_REF1"))
        Next

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtTipo03.Text = cmbTipo.Text
            txtSer03.Text = cmbSerie3.Text
            txtnro03.Text = txtnro3.Text
            cmbTipo1.Visible = False
            cmbSer1.Visible = False
        Else
            txtTipo03.Text = ""
            txtSer03.Text = ""
            txtnro03.Text = ""
            cmbTipo1.Visible = True
            cmbSer1.Visible = True
            cmbTipo1.Items.Clear()
            cmbSer1.Items.Clear()
        End If
    End Sub
    Private Function OkData() As Boolean
        If cmbTipo.Text = "" Then
            MsgBox("Por favor eliga el tipo de documento", MsgBoxStyle.Exclamation)
            cmbTipo.Select()
            Return False
        End If
        If cmbSerie3.Text = "" Then
            MsgBox("Por favor eliga la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerie3.Select()
            Return False
        End If
        If txtnro3.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtnro3.Select()
            Return False
        End If
        If cmbArt3.Text = "" Then
            MsgBox("Por favor eliga el articulo del documento", MsgBoxStyle.Exclamation)
            txtnro3.Select()
            Return False
        End If
        If CheckBox1.Checked = True Then
            If txtTipo03.Text = "" Then
                MsgBox("Por favor ingrese el tipo de documento", MsgBoxStyle.Exclamation)
                cmbTipo.Select()
                Return False
            End If
            If txtSer03.Text = "" Then
                MsgBox("Por favor ingrese la serie del documento", MsgBoxStyle.Exclamation)
                cmbSerie3.Select()
                Return False
            End If
            If txtnro03.Text = "" Then
                MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
                txtnro03.Select()
                Return False
            End If
        Else
            If cmbTipo1.SelectedIndex = -1 And cmbTipo1.Text = "" Then
                MsgBox("Por favor ingrese el tipo de documento", MsgBoxStyle.Exclamation)
                cmbTipo.Select()
                Return False
            End If
            If cmbSer1.SelectedIndex = -1 And cmbSer1.Text = "" Then
                MsgBox("Por favor ingrese la serie del documento", MsgBoxStyle.Exclamation)
                cmbSerie3.Select()
                Return False
            End If
            If txtnro03.Text = "" Then
                MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
                txtnro03.Select()
                Return False
            End If
        End If

        If gsUser = "DCONDOR" Or gsUser = "JVALVERDE" Or gsUser = "SISTEMA" Or gsUser = "JREMENTERIA" Or gsUser = "CQUITO" Then
        Else
            Return False
        End If
        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Desea actualizar la Solm",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If

        Dim SOLMATERIALESBE As New SOLMATERIALESBE
        SOLMATERIALESBE.T_DOC_REF = cmbTipo.Text
        SOLMATERIALESBE.SER_DOC_REF = cmbSerie3.Text
        SOLMATERIALESBE.NRO_DOC_REF = txtnro3.Text
        SOLMATERIALESBE.ART_COD = cmbArt3.Text
        If CheckBox1.Checked = True Then
            SOLMATERIALESBE.T_DOC_REF1 = txtTipo03.Text
            SOLMATERIALESBE.SER_DOC_REF1 = txtSer03.Text
            SOLMATERIALESBE.NRO_DOC_REF1 = txtnro03.Text
        Else
            SOLMATERIALESBE.T_DOC_REF1 = cmbTipo1.Text
            SOLMATERIALESBE.SER_DOC_REF1 = cmbSer1.Text
            SOLMATERIALESBE.NRO_DOC_REF1 = txtnro03.Text
        End If
        gsError = SOLMATERIALESBL.UpdRowDoc(SOLMATERIALESBE, "M")
        If gsError = "OK" Then
            MsgBox("Solm Actualizada", MsgBoxStyle.Information)
            txtnro3.Text = Nothing
            txtnro03.Text = Nothing
            cmbArt3.SelectedIndex = -1
            cmbTipo1.SelectedIndex = -1
            cmbSer1.SelectedIndex = -1

        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar Solm", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub cmbArt3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArt3.SelectedIndexChanged
        txtTipo03.Text = ""
        txtSer03.Text = ""
        txtnro03.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Sub cmbSerie3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSerie3.SelectedIndexChanged
        txtTipo03.Text = ""
        txtSer03.Text = ""
        txtnro03.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Sub txtNroProd_LostFocus(sender As Object, e As EventArgs) Handles txtNroProd.LostFocus

        If Len(txtNroProd.Text) = 7 Then
            Dim dt As DataTable
            dt = ELTBACTUALIZAR_DATOSBL.SelectArt(cmdTipProd.Text, cmbSerProd.Text, txtNroProd.Text)
            For Each Registro In dt.Rows
                GetCmb("nro_doc_ref", "art_cod", dt, cmbArtProd)
                npr = "1"
            Next
        Else
            cmbArtProd.DataSource = Nothing
        End If
        cmbSerPro.Items.Clear()
        txtNroPro.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dtDocuPro As DataTable
        Dim Anho As String = Date.Now.Year
        cmbSerPro.Items.Clear()
        dtDocuPro = ELTBACTUALIZAR_DATOSBL.SelectRowPro(cmdTipProd.Text, cmbSerProd.Text, txtNroProd.Text, cmbArtProd.Text)

        For Each Registro In dtDocuPro.Rows
            For number As Integer = 2022 To (Date.Now.Year)
                cmbSerPro.Items.Add(number)
            Next
            cmbSerPro.SelectedIndex = 1
            txtNroPro.Text = IIf(IsDBNull(Registro("NRO_ORDEN")), "", Registro("NRO_ORDEN"))
        Next
    End Sub
    Private Sub FormActCntSolm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If MessageBox.Show("Desea actualizar la Producción",
           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkDataPro() = False Then
            Exit Sub
        End If

        Dim ELTBACTUALIZAR_DATOSBE As New ELTBACTUALIZAR_DATOSBE
        ELTBACTUALIZAR_DATOSBE.T_DOC_REF = cmdTipProd.Text
        ELTBACTUALIZAR_DATOSBE.SER_DOC_REF = cmbSerProd.Text
        ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF = txtNroProd.Text
        ELTBACTUALIZAR_DATOSBE.ART_COD = cmbArtProd.Text

        ELTBACTUALIZAR_DATOSBE.SER_ORDEN = cmbSerPro.Text
        ELTBACTUALIZAR_DATOSBE.NRO_ORDEN = txtNroPro.Text

        gsError = ELTBACTUALIZAR_DATOSBL.UpdRowDoc(ELTBACTUALIZAR_DATOSBE, "MPRO")
        If gsError = "OK" Then
            MsgBox("Produccion Actualizada", MsgBoxStyle.Information)
            txtNroProd.Text = Nothing
            txtNroPro.Text = Nothing
            cmbArtProd.SelectedIndex = -1
            cmbSerPro.SelectedIndex = -1
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar la Producción", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function OkDataPro() As Boolean
        If cmdTipProd.Text = "" Then
            MsgBox("Por favor eliga el tipo de documento", MsgBoxStyle.Exclamation)
            cmdTipProd.Select()
            Return False
        End If
        If cmbSerProd.Text = "" Then
            MsgBox("Por favor eliga la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerProd.Select()
            Return False
        End If
        If txtNroProd.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroProd.Select()
            Return False
        End If
        If cmbArtProd.Text = "" Then
            MsgBox("Por favor eliga el articulo del documento", MsgBoxStyle.Exclamation)
            cmbArtProd.Select()
            Return False
        End If
        If cmbSerPro.SelectedIndex = -1 And cmbSerPro.Text = "" Then
            MsgBox("Por favor ingrese la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerPro.Select()
            Return False
        End If
        If txtNroPro.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroPro.Select()
            Return False
        End If
        If gsUser = "DCONDOR" Or gsUser = "JVALVERDE" Or gsUser = "SISTEMA" Or gsUser = "JREMENTERIA" Or gsUser = "CQUITO" Then
        Else
            Return False
        End If
        Return True
    End Function


    'Reingreso
    Private Sub txtNroRein_LostFocus(sender As Object, e As EventArgs) Handles txtNroRein.LostFocus
        If Len(txtNroRein.Text) = 7 Then

            Dim dt As DataTable
            dt = ELTBACTUALIZAR_DATOSBL.SelectArtRein(cmbTipRein.Text, cmbSerRein.Text, txtNroRein.Text)
            GetCmb("nro_doc_ref", "art_cod", dt, cmbArtRein)

        Else
            cmbArtRein.DataSource = Nothing
        End If
        cmbSerRei.Items.Clear()
        txtNroRei.Text = ""
        txtNroRei.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim dtDocuPro As DataTable
        Dim Anho As String = Date.Now.Year
        cmbSerRei.Items.Clear()
        dtDocuPro = ELTBACTUALIZAR_DATOSBL.SelectRowRein(cmbTipRein.Text, cmbSerRein.Text, txtNroRein.Text, cmbArtRein.Text)

        For Each Registro In dtDocuPro.Rows
            For number As Integer = 2021 To (Date.Now.Year)
                cmbSerRei.Items.Add(number)
            Next
            cmbSerRei.SelectedIndex = 1
            txtNroRei.Text = IIf(IsDBNull(Registro("NRO_ORDEN")), "", Registro("NRO_ORDEN"))
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If MessageBox.Show("Desea actualizar el Reingreso",
            Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkDataRein() = False Then
            Exit Sub
        End If

        Dim ELTBACTUALIZAR_DATOSBE As New ELTBACTUALIZAR_DATOSBE
        ELTBACTUALIZAR_DATOSBE.T_DOC_REF = cmbTipRein.Text
        ELTBACTUALIZAR_DATOSBE.SER_DOC_REF = cmbSerRein.Text
        ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF = txtNroRein.Text
        ELTBACTUALIZAR_DATOSBE.ART_COD = cmbArtRein.Text

        ELTBACTUALIZAR_DATOSBE.SER_ORDEN = cmbSerRei.Text
        ELTBACTUALIZAR_DATOSBE.NRO_ORDEN = txtNroRei.Text

        gsError = ELTBACTUALIZAR_DATOSBL.UpdRowDoc(ELTBACTUALIZAR_DATOSBE, "MREIN")
        If gsError = "OK" Then
            MsgBox("Reingreso Actualizada", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar Reingreso", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function OkDataRein() As Boolean
        If cmbTipRein.Text = "" Then
            MsgBox("Por favor eliga el tipo de documento", MsgBoxStyle.Exclamation)
            cmbTipRein.Select()
            Return False
        End If
        If cmbSerRein.Text = "" Then
            MsgBox("Por favor eliga la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerRein.Select()
            Return False
        End If
        If txtNroRein.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroRein.Select()
            Return False
        End If
        If cmbArtRein.Text = "" Then
            MsgBox("Por favor eliga el articulo del documento", MsgBoxStyle.Exclamation)
            cmbArtRein.Select()
            Return False
        End If
        If cmbSerRei.SelectedIndex = -1 And cmbSerRei.Text = "" Then
            MsgBox("Por favor ingrese la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerRei.Select()
            Return False
        End If
        If txtNroRei.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroRei.Select()
            Return False
        End If
        If gsUser = "DCONDOR" Or gsUser = "JVALVERDE" Or gsUser = "SISTEMA" Or gsUser = "JREMENTERIA" Or gsUser = "CQUITO" Then
        Else
            Return False
        End If
        Return True
    End Function

    'Fallados
    Private Sub txtNroFall_LostFocus(sender As Object, e As EventArgs) Handles txtNroFall.LostFocus
        If Len(txtNroFall.Text) = 7 Then

            Dim dt As DataTable
            dt = ELTBACTUALIZAR_DATOSBL.SelectArtFall(cmbTipFall.Text, cmbSerFall.Text, txtNroFall.Text)
            GetCmb("nro_doc_ref", "art_cod", dt, cmbArtFall)
        Else
            cmbArtFall.DataSource = Nothing
        End If
        cmbSerFal.Items.Clear()
        txtNroFal.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim dtDocuPro As DataTable
        Dim Anho As String = Date.Now.Year
        cmbSerFal.Items.Clear()
        dtDocuPro = ELTBACTUALIZAR_DATOSBL.SelectRowFall(cmbTipFall.Text, cmbSerFall.Text, txtNroFall.Text, cmbArtFall.Text)

        For Each Registro In dtDocuPro.Rows
            For number As Integer = 2021 To (Date.Now.Year)
                cmbSerFal.Items.Add(number)
            Next
            cmbSerFal.Text = IIf(IsDBNull(Registro("SER_ORDEN")), "", Registro("SER_ORDEN"))
            txtNroFal.Text = IIf(IsDBNull(Registro("NRO_ORDEN")), "", Registro("NRO_ORDEN"))
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If MessageBox.Show("Desea actualizar Fallados",
    Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkDataFall() = False Then
            Exit Sub
        End If

        Dim ELTBACTUALIZAR_DATOSBE As New ELTBACTUALIZAR_DATOSBE
        ELTBACTUALIZAR_DATOSBE.T_DOC_REF = cmbTipFall.Text
        ELTBACTUALIZAR_DATOSBE.SER_DOC_REF = cmbSerFall.Text
        ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF = txtNroFall.Text
        ELTBACTUALIZAR_DATOSBE.ART_COD = cmbArtFall.Text

        ELTBACTUALIZAR_DATOSBE.SER_ORDEN = cmbSerFal.Text
        ELTBACTUALIZAR_DATOSBE.NRO_ORDEN = txtNroFal.Text

        gsError = ELTBACTUALIZAR_DATOSBL.UpdRowDoc(ELTBACTUALIZAR_DATOSBE, "MFAL")
        If gsError = "OK" Then
            MsgBox("Fallado Actualizado", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar Fallado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function OkDataFall() As Boolean
        If cmbTipFall.Text = "" Then
            MsgBox("Por favor eliga el tipo de documento", MsgBoxStyle.Exclamation)
            cmbTipFall.Select()
            Return False
        End If
        If cmbSerFall.Text = "" Then
            MsgBox("Por favor eliga la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerFall.Select()
            Return False
        End If
        If txtNroFall.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroFall.Select()
            Return False
        End If
        If cmbArtFall.Text = "" Then
            MsgBox("Por favor eliga el articulo del documento", MsgBoxStyle.Exclamation)
            cmbArtFall.Select()
            Return False
        End If
        If cmbSerFal.SelectedIndex = -1 And cmbSerRei.Text = "" Then
            MsgBox("Por favor ingrese la serie del documento", MsgBoxStyle.Exclamation)
            cmbSerFal.Select()
            Return False
        End If
        If txtNroFal.Text = "" Then
            MsgBox("Por favor ingrese el numero del documento", MsgBoxStyle.Exclamation)
            txtNroFal.Select()
            Return False
        End If
        If gsUser = "DCONDOR" Or gsUser = "JVALVERDE" Or gsUser = "SISTEMA" Or gsUser = "JREMENTERIA" Or gsUser = "CQUITO" Then
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub txtnro03_LostFocus(sender As Object, e As EventArgs) Handles txtnro03.LostFocus
        If txtnro03.TextLength <> 9 Then
            MsgBox("Debe ingresar un numero correcto")
            Exit Sub
        End If
        Dim numerocantop As Integer = SOLMATERIALESBL.listTot(cmbSer1.Text, txtnro03.Text)
        If numerocantop = 0 Then
            MsgBox("Esta Numero de OP se encuentra anulada")
            txtnro03.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub txtNroPro_LostFocus(sender As Object, e As EventArgs) Handles txtNroPro.LostFocus
        If txtNroPro.TextLength <> 9 Then
            MsgBox("Debe ingresar un numero correcto")
            Exit Sub
        End If
        Dim numerocantop As Integer = SOLMATERIALESBL.listTot(cmbSerPro.Text, txtNroPro.Text)
        If numerocantop = 0 Then
            MsgBox("Esta Numero de OP se encuentra anulada")
            txtNroPro.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub txtNroRei_LostFocus(sender As Object, e As EventArgs) Handles txtNroRei.LostFocus
        If txtNroRei.TextLength <> 9 Then
            MsgBox("Debe ingresar un numero correcto")
            Exit Sub
        End If
        Dim numerocantop As Integer = SOLMATERIALESBL.listTot(cmbSerRein.Text, txtNroRei.Text)
        If numerocantop = 0 Then
            MsgBox("Esta Numero de OP se encuentra anulada")
            txtNroRei.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub txtNroFal_LostFocus(sender As Object, e As EventArgs) Handles txtNroFal.LostFocus
        If txtNroFal.TextLength <> 9 Then
            MsgBox("Debe ingresar un numero correcto")
            Exit Sub
        End If
        Dim numerocantop As Integer = SOLMATERIALESBL.listTot(cmbSerFall.Text, txtNroFal.Text)
        If numerocantop = 0 Then
            MsgBox("Esta Numero de OP se encuentra anulada")
            txtNroFal.Text = ""
            Exit Sub
        End If
    End Sub
End Class