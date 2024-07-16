Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting
Public Class FormLibroDiario

    Private gpCaption As String
    Dim cmbt_movinv As New ComboBox
    Dim CONTABILIDADBL As New CONTABILIDADBL
    Dim ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private flagAccion As String = ""
    Dim sumSoles = 0
    Dim sumDolares = 0
    Dim estadoTC = 0
    Dim estadoTextoVariable = 0
    Dim estadoCargar = 0
    Dim EstadoEspecial
    Dim reporte = 0

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sumaSoles = 0
        Dim sumaDolares = 0
        For i = 0 To DgvDetLibro.Rows.Count - 1
            sumaSoles = sumaSoles + DgvDetLibro.Rows(i).Cells(12).Value
            sumaDolares = sumaDolares + DgvDetLibro.Rows(i).Cells(13).Value
        Next
        Txt_Soles.Text = sumaSoles
        Txt_Dolares.Text = sumaDolares
        Txt_Soles.Enabled = False
        Txt_Dolares.Enabled = False
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    flagAccion = "N"
                    SaveData()
                    Exit Sub
                Case "edit"
                    flagAccion = "E"
                    SaveData()
                Case "Delete"
                    DeleteData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    ImprimirRegistroContable()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FormLibroDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
        Me.Text = "Registro Libro Diario"
        DgvDetLibro.MultiSelect = False
        cmbTipReg.SelectedIndex = 4
        Txt_serie.Text = sAñoLD
        Select Case sMesLD
            Case "Enero"
                sMesLD = "01"
            Case "Febrero"
                sMesLD = "02"
            Case "Marzo"
                sMesLD = "03"
            Case "Abril"
                sMesLD = "04"
            Case "Mayo"
                sMesLD = "05"
            Case "Junio"
                sMesLD = "06"
            Case "Julio"
                sMesLD = "07"
            Case "Agosto"
                sMesLD = "08"
            Case "Septiembre"
                sMesLD = "09"
            Case "Octubre"
                sMesLD = "10"
            Case "Noviembre"
                sMesLD = "11"
            Case "Diciembre"
                sMesLD = "12"

        End Select
        DatFecha.Value = "01/" + sMesLD + "/" + sAñoLD
        Dim dtLibro As New DataTable
        Dim dtDetalleLibro As New DataTable

        Dim dtTDoc As DataTable = CONTABILIDADBL.SelectT_DOC()
        GetCmb("cod", "nom", dtTDoc, CmbTDocumento)

        Dim dtBanco As DataTable = CONTABILIDADBL.SelectBanco()
        GetCmb("cod", "nom", dtBanco, CmbBanco)

        Dim dtMoneda As DataTable = CONTABILIDADBL.SelectMoneda()
        GetCmb("cod", "nom", dtMoneda, CmbMoneda)

        Select Case gnOpcion
            Case 0
                CmbEstado.SelectedIndex = 1
                reporte = 0
                dtLibro.Clear()
                dtDetalleLibro.Clear()
            Case 1
                estadoTC = 1
                dtLibro = CONTABILIDADBL.ObtenerLibroDiario(sTDoc, sSDoc, sNDoc, sTOpe)
                dtDetalleLibro = CONTABILIDADBL.ObtenerLibroDiarioDet(sTDoc, sSDoc, sNDoc, sTOpe)
                estadoCargar = 0
                reporte = 1
                cargarLibroDiario(dtLibro)
                cargarLibroDiarioDet(dtDetalleLibro)
                EstadoEspecial = 1
                estadoTextoVariable = 0
                estadoCargar = 1
        End Select
    End Sub

    Sub cargarLibroDiario(ByVal dtLibro As DataTable)
        'Tipo Registro
        Select Case dtLibro.Rows(0).Item(21)
            Case "APE"
                cmbTipReg.SelectedIndex = 1
            Case "CIE"
                cmbTipReg.SelectedIndex = 2
            Case "COS"
                cmbTipReg.SelectedIndex = 3
            Case "MOV"
                cmbTipReg.SelectedIndex = 4
        End Select
        cmbTipReg.Enabled = False
        'Tipo Operacion
        If dtLibro.Rows(0).Item(0) = "007" Then
            CmbTOperacion.SelectedIndex = 1
        Else
            CmbTOperacion.SelectedIndex = 2
        End If
        CmbTOperacion.Enabled = False

        'Tipo Documento
        CmbTDocumento.SelectedValue = dtLibro.Rows(0).Item(1).ToString
        CmbTDocumento.Enabled = False

        'Serie 
        Txt_serie.Text = dtLibro.Rows(0).Item(2)
        Txt_serie.Enabled = False

        'Numero
        Txt_numero.Text = dtLibro.Rows(0).Item(3)
        Txt_numero.Enabled = False

        'Fecha
        DatFecha.Value = dtLibro.Rows(0).Item(4)
        DatFecha.Enabled = False

        'Tipo Cambio
        Txt_Tcambio.Text = dtLibro.Rows(0).Item(5).ToString
        Txt_Tcambio2.Text = dtLibro.Rows(0).Item(5).ToString
        'Txt_Tcambio.Enabled = False
        'Txt_Tcambio2.Enabled = False

        'Estado
        Select Case dtLibro.Rows(0).Item(6)
            Case "H"
                CmbEstado.SelectedIndex = 1
            Case "A"
                CmbEstado.SelectedIndex = 2
            Case "R"
                CmbEstado.SelectedIndex = 3
            Case "T"
                CmbEstado.SelectedIndex = 4
        End Select
        ' CmbEstado.Enabled = False

        'Banco
        CmbBanco.SelectedValue = dtLibro.Rows(0).Item(8)
        CmbBanco.Enabled = False

        'Comentario
        Txt_Concepto.Text = dtLibro.Rows(0).Item(9)
        ' Txt_Concepto.Enabled = False

        'Cobranza
        Select Case dtLibro.Rows(0).Item(10).ToString
            Case Nothing
                CmbCobranza.SelectedIndex = 1
            Case Else
                CmbCobranza.SelectedIndex = 0
        End Select
        'CmbCobranza.Enabled = False
        'Forma de Pago
        Txt_CodFpago.Text = dtLibro.Rows(0).Item(20).ToString
        If Txt_CodFpago.Text = "" Then

        Else
            Dim dtPago As DataTable
            dtPago = CONTABILIDADBL.ObtenerNombreFpago(Txt_CodFpago.Text)
            Txt_NomFpago.Text = dtPago.Rows(0).Item(0)
        End If
        'Txt_CodFpago.Enabled = False

        'Fecha Vencimiento
        If dtLibro.Rows(0).Item(15).ToString = "" Then
        Else
            DatVencimiento.Value = dtLibro.Rows(0).Item(15).ToString
        End If
        'DatVencimiento.Enabled = False

        'Moneda
        CmbMoneda.SelectedValue = dtLibro.Rows(0).Item(7)
        CmbMoneda.Enabled = False

        'Centro Costo
        Txt_CodCosto.Text = dtLibro.Rows(0).Item(13).ToString
        If Txt_CodCosto.Text = "" Then

        Else
            Dim dtCC As DataTable
            dtCC = CONTABILIDADBL.ObtenerNombreCC(Txt_CodCosto.Text)
            Txt_NomCosto.Text = dtCC.Rows(0).Item(0)
        End If
        'Txt_CodCosto.Enabled = False
        '  Txt_NomCosto.Enabled = False

        'Proveedor
        Txt_CodProveedor.Text = dtLibro.Rows(0).Item(11).ToString
        If Txt_CodProveedor.Text = "" Then

        Else
            Dim dtProveedor As DataTable
            dtProveedor = CONTABILIDADBL.ObtenerNombreProveedor(Txt_CodProveedor.Text)
            Txt_NomProveedor.Text = dtProveedor.Rows(0).Item(0)
        End If
        ' Txt_CodProveedor.Enabled = False
        ' Txt_NomProveedor.Enabled = False

        'Total Dolares
        Txt_Dolares.Text = dtLibro.Rows(0).Item(17).ToString
        Txt_Dolares.Enabled = False

        'Total Soles
        Txt_Soles.Text = dtLibro.Rows(0).Item(16).ToString
        Txt_Soles.Enabled = False
        'Registro
        Txt_RegContable.Text = dtLibro.Rows(0).Item(14).ToString
        Txt_RegContable.Enabled = True

        'Usuario
        Txt_usuario.Text = dtLibro.Rows(0).Item(18)
        Txt_usuario.Enabled = False

        'Fecha Registro
        Txt_fechareg.Text = dtLibro.Rows(0).Item(19).ToString
        Txt_fechareg.Enabled = False

        'Prov Pago
        If dtLibro.Rows(0).Item(23).ToString = 1 Then
            chkpago.Checked = True
        Else
            chkpago.Checked = False
        End If

        'Estado MOVCT
        If dtLibro.Rows(0).Item(22).ToString = "0" Then
            lblEstado.Text = "PENDIENTE"
            lblEstado.ForeColor = Color.Red
        Else
            lblEstado.Text = "PROCESADO"
            lblEstado.ForeColor = Color.Blue
        End If
    End Sub

    Sub cargarLibroDiarioDet(ByVal dtDetalleLibro As DataTable)
        DgvDetLibro.Rows.Clear()
        'Tipo Documento
        If dtDetalleLibro.Rows.Count > 0 Then
            For i = 0 To dtDetalleLibro.Rows.Count - 1
                DgvDetLibro.Rows.Add()
                DgvDetLibro.Rows(i).Cells.Item(0).Value = dtDetalleLibro.Rows(i).Item(3)
            Next
        End If

        'Nombre Documento
        For i = 0 To DgvDetLibro.Rows.Count - 1
            Dim tipDoc = DgvDetLibro.Rows(i).Cells.Item(0).Value

            Dim dtNombreDoc As DataTable
            dtNombreDoc = CONTABILIDADBL.ObtenerNombreDocumento(tipDoc)
            DgvDetLibro.Rows(i).Cells.Item(1).Value = dtNombreDoc.Rows(0).Item(0)

        Next

        'Afecto e Inafecto
        For i = 0 To DgvDetLibro.Rows.Count - 1
            If dtDetalleLibro.Rows(i).Item(6) = "S" Then
                DgvDetLibro.Rows(i).Cells(2).Value = "Afecto"
            Else
                DgvDetLibro.Rows(i).Cells(2).Value = "Inafecto"
            End If
        Next

        'Serie
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(3).Value = dtDetalleLibro.Rows(i).Item(4)
        Next

        'Numero
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(4).Value = dtDetalleLibro.Rows(i).Item(5)
        Next

        'Centro de Costo
        For i = 0 To DgvDetLibro.Rows.Count - 1
            Dim cCOsto = dtDetalleLibro.Rows(i).Item(7).ToString
            If cCOsto = "" Then

            Else
                Dim dtCCosto As DataTable
                dtCCosto = CONTABILIDADBL.ObtenerNombreCC(cCOsto)
                If dtCCosto.Rows.Count > 0 Then
                    DgvDetLibro.Rows(i).Cells.Item(5).Value = dtCCosto.Rows(0).Item(0)
                Else
                    DgvDetLibro.Rows(i).Cells.Item(5).Value = ""
                End If

            End If
        Next

        'Cuenta
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(6).Value = dtDetalleLibro.Rows(i).Item(8)
        Next

        'Cuenta Destino
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(7).Value = dtDetalleLibro.Rows(i).Item(9)
        Next

        'Nombre Proveedor
        For i = 0 To DgvDetLibro.Rows.Count - 1
            Dim codProveedor = dtDetalleLibro.Rows(i).Item(18).ToString
            If codProveedor = "" Then

            Else
                Dim dtCCosto As DataTable
                dtCCosto = CONTABILIDADBL.ObtenerNombreProveedor(codProveedor)
                If dtCCosto.Rows.Count > 0 Then
                    DgvDetLibro.Rows(i).Cells.Item(8).Value = dtCCosto.Rows(0).Item(0)
                Else
                    DgvDetLibro.Rows(i).Cells.Item(8).Value = ""
                End If

            End If
        Next

        'Signo
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(9).Value = dtDetalleLibro.Rows(i).Item(10)
        Next

        'Fecha
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(10).Value = dtDetalleLibro.Rows(i).Item(11)
        Next

        'Tipo Cambio
        estadoTC = 1
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(11).Value = dtDetalleLibro.Rows(i).Item(12)

        Next

        'T. Sopes
        For i = 0 To DgvDetLibro.Rows.Count - 1
            estadoCargar = 0
            DgvDetLibro.Rows(i).Cells(12).Value = dtDetalleLibro.Rows(i).Item(13)

        Next

        'T. Dolares
        For i = 0 To DgvDetLibro.Rows.Count - 1
            estadoCargar = 0
            DgvDetLibro.Rows(i).Cells(13).Value = dtDetalleLibro.Rows(i).Item(14)
        Next

        'Moneda
        For i = 0 To DgvDetLibro.Rows.Count - 1
            Dim codMoneda = dtDetalleLibro.Rows(i).Item(15).ToString
            If codMoneda = "00" Then
                DgvDetLibro.Rows(i).Cells.Item(14).Value = "SOLES"
            Else
                DgvDetLibro.Rows(i).Cells.Item(14).Value = "DOLARES"
            End If
        Next

        'Comprobante
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(15).Value = dtDetalleLibro.Rows(i).Item(16)
        Next

        'Observacion
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(16).Value = dtDetalleLibro.Rows(i).Item(17)
        Next

        'Fec_Venc
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells(17).Value = dtDetalleLibro.Rows(i).Item(21)
        Next

        'COD Proveedor  
        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells("CODPROVEEDOR").Value = dtDetalleLibro.Rows(i).Item(18).ToString
        Next

        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells("CODART").Value = dtDetalleLibro.Rows(i).Item(20).ToString
        Next

        For i = 0 To DgvDetLibro.Rows.Count - 1
            If dtDetalleLibro.Rows(i).Item(19).ToString = "0" Then
                DgvDetLibro.Rows(i).Cells("REPARAR").Value = False
            Else
                DgvDetLibro.Rows(i).Cells("REPARAR").Value = True
            End If
        Next



        For i = 0 To DgvDetLibro.Columns.Count - 1
            DgvDetLibro.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next


    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub Btn_BuscarPago_Click(sender As Object, e As EventArgs) Handles Btn_BuscarPago.Click
        'LIBRO DIARIO - BUSCAR PAGO
        sBusAlm = "38"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            Txt_CodFpago.Text = gLinea
            Txt_NomFpago.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Btn_BuscarCC_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCC.Click
        'LIBRO DIARIO - CENTRO COSTO
        sBusAlm = "39"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            Txt_CodCosto.Text = gLinea
            Txt_NomCosto.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Btn_Proveedor_Click(sender As Object, e As EventArgs) Handles Btn_Proveedor.Click
        'PROVEEDOR
        sBusAlm = "40"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            Txt_CodProveedor.Text = gLinea
            Txt_NomProveedor.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub DgvDetLibro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetLibro.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim fila = e.RowIndex
            Dim colum = e.ColumnIndex
            sBusAlm = "41"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = gSubLinea
                DgvDetLibro.CurrentRow.Cells(colum + 1).Selected = False
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

        If e.ColumnIndex = 5 Then
            Dim fila = e.RowIndex
            Dim colum = e.ColumnIndex
            sBusAlm = "42"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                'DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

        If e.ColumnIndex = 6 Then
            Dim fila = e.RowIndex
            Dim colum = e.ColumnIndex
            sBusAlm = "43"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If (gLinea <> Nothing And gSubLinea <> Nothing) Or gLinea2 <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = gLinea2
                DgvDetLibro.CurrentRow.Cells(colum + 2).Selected = True
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            End If
        End If

        If e.ColumnIndex = 8 Then
            Dim fila = e.RowIndex
            Dim colum = e.ColumnIndex
            sBusAlm = "44"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(colum + 11).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
        For i = 0 To DgvDetLibro.Columns.Count - 1
            DgvDetLibro.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgvDetLibro.Rows.Add()
        DgvDetLibro.Rows(0).Cells("Documento").Selected = False
        estadoTC = 0
        estadoTextoVariable = 0
    End Sub

    Private Sub FormLibroDiario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub DgvDetLibro_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetLibro.CellValueChanged

        If DgvDetLibro.Rows.Count > 0 Then
            If e.ColumnIndex = 3 Then
                Dim fila = e.RowIndex
                Dim col = e.ColumnIndex
                DgvDetLibro.Rows(fila).Cells.Item(col).Selected = False
                DgvDetLibro.Rows(fila).Cells.Item(col + 1).Selected = True
                DgvDetLibro.BeginEdit(True)
            End If

            If e.ColumnIndex = 4 Then
                Dim fila = e.RowIndex
                Dim col = e.ColumnIndex
                DgvDetLibro.Rows(fila).Cells.Item(col).Selected = True
                'DgvDetLibro.Rows(fila).Cells.Item(col + 1).Selected = True
                'DgvDetLibro.BeginEdit(True)
            End If
        End If

        If DgvDetLibro.Rows.Count > 0 Then
            If e.ColumnIndex = 0 Then
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                Dim tipDoc = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                Dim dtTipoDoc As New DataTable
                dtTipoDoc = CONTABILIDADBL.BuscarTDocumento(tipDoc)
                If dtTipoDoc.Rows.Count > 0 Then
                    DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = dtTipoDoc.Rows(0).Item(0)
                Else
                    DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = ""
                End If
                DgvDetLibro.Rows(fila).Cells.Item(colum).Selected = False

                DgvDetLibro.Rows(fila).Cells.Item(colum + 2).Selected = True
                DgvDetLibro.BeginEdit(True)
            End If

            If e.ColumnIndex = 5 Then
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                DgvDetLibro.Rows(fila).Cells.Item(colum).Selected = False
                DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Selected = True
                'DgvDetLibro.BeginEdit(True)
            End If

            If e.ColumnIndex = 6 Then
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                Dim cuenta = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                Try
                    Dim dtCuentaDest = CONTABILIDADBL.BuscarCuentaDestino(cuenta, sAñoLD)
                    If dtCuentaDest.Rows.Count > 0 Then
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = dtCuentaDest.Rows(0).Item(0).ToString
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 2).Selected = True
                    End If
                Catch ex As Exception

                End Try


            End If

            If e.ColumnIndex = 9 Then
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                DgvDetLibro.Rows(fila).Cells.Item(colum).Selected = False
                DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Selected = True
                DgvDetLibro.BeginEdit(True)
            End If
        End If


        If DgvDetLibro.Rows.Count > 0 Then
            If e.ColumnIndex = 10 And estadoTC = 0 Then 'TC 
                estadoCargar = 1
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                Dim fecha = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                Dim isValidDate As Boolean = IsDate(fecha)
                If isValidDate = True Then
                    Dim dtTcambio As New DataTable
                    dtTcambio = CONTABILIDADBL.BuscarTCambio(fecha)
                    If dtTcambio.Rows.Count > 0 Then
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = dtTcambio.Rows(0).Item(0)
                        estadoTextoVariable = 0
                        estadoTC = 0
                        DgvDetLibro.Rows(fila).Cells.Item(colum).Selected = False
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 2).Selected = True
                        DgvDetLibro.BeginEdit(True)
                    Else
                        MsgBox("Tipo de Cambio No Ingresado: " + fecha)
                    End If
                Else
                    MsgBox("Ingrese Formato de Fecha: DD/MM/YYYY")
                End If
            End If

            If estadoTextoVariable = 0 Then
                If e.ColumnIndex = 12 And estadoTC = 0 Then ' SOLES A DOLARES
                    Dim fila = e.RowIndex
                    Dim colum = e.ColumnIndex
                    Dim soles = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                    Dim isValidDate As Boolean = IsNumeric(soles)
                    If isValidDate = True Then
                        estadoTextoVariable = 0
                        If estadoCargar = 1 Then
                            DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = FormatNumber(DgvDetLibro.Rows(fila).Cells.Item(colum).Value / DgvDetLibro.Rows(fila).Cells.Item(colum - 1).Value, 2)
                            DgvDetLibro.Rows(fila).Cells.Item(colum).Value = soles
                            DgvDetLibro.Rows(fila).Cells.Item(colum + 2).Value = "SOLES"
                            Exit Sub
                        End If
                    Else
                        MsgBox("Ingrese Monto Numérico")
                    End If
                End If
            End If


            If estadoTextoVariable = 0 Then
                If e.ColumnIndex = 13 And estadoTC = 0 Then ' DOLARES A SOLES
                    Dim fila = e.RowIndex
                    Dim colum = e.ColumnIndex
                    Dim soles = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                    Dim isValidDate As Boolean = IsNumeric(soles)
                    If isValidDate = True Then
                        estadoTextoVariable = 0
                        If estadoCargar = 1 Then
                            DgvDetLibro.Rows(fila).Cells.Item(colum - 1).Value = FormatNumber(DgvDetLibro.Rows(fila).Cells.Item(colum - 2).Value * DgvDetLibro.Rows(fila).Cells.Item(colum).Value, 2)
                            DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = "DOLARES"
                            Exit Sub
                        End If

                    Else
                        MsgBox("Ingrese Monto Numérico")
                    End If
                End If
            End If

        End If

        'CARGAR TC DESPUES DE JALAR DOCUMENTOS
        If estadoTextoVariable = 0 Then
            If e.ColumnIndex = 12 And EstadoEspecial = 1 Then ' SOLES A DOLARES
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                Dim soles = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                Dim isValidDate As Boolean = IsNumeric(soles)
                If isValidDate = True Then
                    estadoTextoVariable = 0
                    If estadoCargar = 1 Then
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = FormatNumber(DgvDetLibro.Rows(fila).Cells.Item(colum).Value / DgvDetLibro.Rows(fila).Cells.Item(colum - 1).Value, 2)
                        DgvDetLibro.Rows(fila).Cells.Item(colum).Value = soles
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 2).Value = "SOLES"
                        Exit Sub
                    End If
                Else
                    MsgBox("Ingrese Monto Numérico")
                End If
            End If
        End If


        If estadoTextoVariable = 0 Then
            If e.ColumnIndex = 13 And EstadoEspecial = 1 Then ' DOLARES A SOLES
                Dim fila = e.RowIndex
                Dim colum = e.ColumnIndex
                Dim soles = DgvDetLibro.Rows(fila).Cells.Item(colum).Value
                Dim isValidDate As Boolean = IsNumeric(soles)
                If isValidDate = True Then
                    estadoTextoVariable = 0
                    If estadoCargar = 1 Then
                        DgvDetLibro.Rows(fila).Cells.Item(colum - 1).Value = FormatNumber(DgvDetLibro.Rows(fila).Cells.Item(colum - 2).Value * DgvDetLibro.Rows(fila).Cells.Item(colum).Value, 2)
                        DgvDetLibro.Rows(fila).Cells.Item(colum + 1).Value = "DOLARES"
                        Exit Sub
                    End If

                Else
                    MsgBox("Ingrese Monto Numérico")
                End If
            End If
        End If

    End Sub

    Private Sub DatFecha_ValueChanged(sender As Object, e As EventArgs) Handles DatFecha.ValueChanged
        Dim fecha = DatFecha.Value.ToString
        fecha = fecha.Substring(0, 10)
        'MsgBox(fecha)

        Dim dtTcambio As New DataTable
        dtTcambio = CONTABILIDADBL.BuscarTCambio(fecha)
        If dtTcambio.Rows.Count > 0 Then
            If dtTcambio.Rows(0).Item(1).ToString = "" Then
                Txt_Tcambio.Text = dtTcambio.Rows(0).Item(0).ToString
                Txt_Tcambio2.Text = dtTcambio.Rows(0).Item(0).ToString
            Else
                Txt_Tcambio.Text = dtTcambio.Rows(0).Item(1).ToString
                Txt_Tcambio2.Text = dtTcambio.Rows(0).Item(1).ToString
            End If
        Else
            MsgBox("Tipo de Cambio No Ingresado: " + fecha)
        End If
    End Sub



    Public Function VerificarRegistroContable(ByVal libroDiario As LIBRO_DIARIOBE) As Boolean
        Dim dtContador As New DataTable
        dtContador = CONTABILIDADBL.VerificarRegistroContable(libroDiario)
        Dim dato = dtContador.Rows(0).Item(0).ToString
        If dato > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SaveData()

        If Txt_Concepto.Text.Contains("PLANILLA") = False Then
            If DgvDetLibro.Rows.Count > 0 Then
                For i = 0 To DgvDetLibro.Rows.Count - 1
                    If DgvDetLibro.Rows(i).Cells("Ccosto").Value = "" Then
                        If DgvDetLibro.Rows(i).Cells("Cuenta").Value.ToString <> "" Then
                            Select Case DgvDetLibro.Rows(i).Cells("Cuenta").Value.ToString.Substring(0, 2)
                                Case "62", "63", "64", "65", "68"
                                    MsgBox("Ingrese Centro de Costo")
                                    DgvDetLibro.Rows(i).Cells("Ccosto").Selected = True
                                    Exit Sub
                            End Select
                        Else
                            MsgBox("Ingrese Cuenta en fila " & i + 1)
                            DgvDetLibro.Rows(i).Selected = True
                            Exit Sub
                        End If
                    End If
                Next
            End If
        End If
        ' 62, 63, 64, 65, 68 

        For i = 0 To DgvDetLibro.Rows.Count - 1
            If DgvDetLibro.Rows(i).Cells("Signo").Value.ToString = "" Then
                MsgBox("Ingrese Signo en fila " & i + 1)
                DgvDetLibro.Rows(i).Selected = True
                Exit Sub
            End If
        Next


        For i = 0 To DgvDetLibro.Rows.Count - 1
            If DgvDetLibro.Rows(i).Cells("Cuenta").Value.ToString = "" Then
                MsgBox("Ingrese Cuenta en fila " & i + 1)
                DgvDetLibro.Rows(i).Selected = True
                Exit Sub
            End If
        Next

        If CmbTOperacion.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo Operacion")
            Exit Sub
        End If

        estadoCargar = 1
        If Txt_RegContable.Text = "" Then
            flagAccion = "N"
        Else
            flagAccion = "M"
        End If


        'If MessageBox.Show("Desea grabar el Registro", gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If
        Dim LibroDiario As New LIBRO_DIARIOBE
        Dim DetLibroDiario As New DET_LIBRO_DIARIOBE

        LibroDiario = DatosLibroDiario()

        If flagAccion = "N" Then
            Dim estado = VerificarRegistroContable(LibroDiario)
            If Txt_RegContable.Text = "" Then
                If estado = True Then
                    MsgBox("Numero de Docummento: " + LibroDiario.NRO_DOC_REF + " ya esta registrado")
                    Exit Sub
                End If
            End If
        End If

        Dim mes = DatFecha.Value.ToString("MM")
        Dim anho = DatFecha.Value.ToString("yyyy")
        gsError = CONTABILIDADBL.SaveRow(LibroDiario, mes, anho, flagAccion)

        If gsError = "OK" Then
            Dim dtRegCont As New DataTable
            dtRegCont = CONTABILIDADBL.BuscarRegCont(LibroDiario)
            If dtRegCont.Rows.Count > 0 Then
                LibroDiario.REG_NRO = dtRegCont.Rows(0).ItemArray(0).ToString
            End If

            Try
                For i = 0 To DgvDetLibro.Rows.Count - 1
                    DetLibroDiario = DatosDetLibroDiario(i)
                    DetLibroDiario.REG_NRO = LibroDiario.REG_NRO
                    gsError2 = CONTABILIDADBL.SaveRowDet(DetLibroDiario, mes, anho, "N")
                Next

                'MsgBox("Datos Grabados Correctamente")
                'gsError2 = CONTABILIDADBL.AsientoLD(anho, mes, "007", CmbTDocumento.SelectedValue, Txt_serie.Text, Txt_numero.Text, Txt_CodProveedor.Text,
                '                                        DatFecha.Value.ToString("dd/MM/yyyy"), Txt_Concepto.Text, Txt_RegContable.Text)
                Try
                    For i = 0 To DgvDetLibro.Rows.Count - 1
                        DetLibroDiario = DatosDetLibroDiario(i)
                        DetLibroDiario.REG_NRO = LibroDiario.REG_NRO
                        CONTABILIDADBL.AsientoLD(LibroDiario, DetLibroDiario, mes, anho)

                        If Not DetLibroDiario.CUENTA_DEST = "" Then
                            DetLibroDiario.CUENTA = DetLibroDiario.CUENTA_DEST
                            CONTABILIDADBL.AsientoLD(LibroDiario, DetLibroDiario, mes, anho)

                            Dim dtcuentaDestimo As New DataTable
                            dtcuentaDestimo = CONTABILIDADBL.BuscarCuentaDestino(DetLibroDiario.CUENTA, anho)

                            If dtcuentaDestimo.Rows.Count > 0 Then
                                DetLibroDiario.CUENTA = dtcuentaDestimo.Rows(0).Item(0).ToString
                                If Not DetLibroDiario.CUENTA = "" Then

                                    If DetLibroDiario.SIGNO = "+" Then
                                        DetLibroDiario.SIGNO = "-"
                                    Else
                                        DetLibroDiario.SIGNO = "+"
                                    End If
                                    CONTABILIDADBL.AsientoLD(LibroDiario, DetLibroDiario, mes, anho)
                                End If
                            End If

                        End If


                    Next
                Catch ex As Exception

                End Try

                If gsError2 = "OK" Then
                    ' actualizarTablaMOVCT(LibroDiario, sMes, sAño)
                    MsgBox("Asiento Creado", MsgBoxStyle.Information)
                    lblEstado.Text = "PROCESADO"
                    lblEstado.ForeColor = Color.Blue
                    Txt_RegContable.Text = DetLibroDiario.REG_NRO
                Else
                    FormMain.LblError.Text = gsError2
                    MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
                End If
                'tsbGrabar.Enabled = False
            Catch ex As Exception

            End Try
            'Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    'Public Sub actualizarTablaMOVCT(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mmes As String, ByVal manho As String)
    '    Dim dtMovCT As New DataTable
    '    dtMovCT = CONTABILIDADBL.actualizarTablaMOVCT(LibroDiario, mmes, manho)
    'End Sub

    Public Function DatosLibroDiario() As LIBRO_DIARIOBE
        Dim LibroDiario As New LIBRO_DIARIOBE

        'Tipo Registro
        Select Case cmbTipReg.SelectedIndex
            Case 1
                LibroDiario.T_REGISTRO = "APE"
            Case 2
                LibroDiario.T_REGISTRO = "CIE"
            Case 3
                LibroDiario.T_REGISTRO = "COS"
            Case 4
                LibroDiario.T_REGISTRO = "MOV"
        End Select

        'Tipo Operacion 0
        If CmbTOperacion.SelectedIndex = 1 Then
            LibroDiario.T_OPE = "007"
        ElseIf CmbTOperacion.SelectedIndex = 2 Then
            LibroDiario.T_OPE = "009"
        Else
            MsgBox("Selecciones Tipo de Operacion")
            Exit Function
        End If

        'Tipo Documento 1
        LibroDiario.T_DOC_REF = CmbTDocumento.SelectedValue

        'Serie Documento 2
        LibroDiario.SER_DOC_REF = Txt_serie.Text

        ' Nro. Documento 3
        LibroDiario.NRO_DOC_REF = Txt_numero.Text

        ' Fecha 4
        LibroDiario.FEC_GENE = DatFecha.Value.ToString("dd/MM/yyyy")

        'Tipo Cambio 6
        LibroDiario.T_CAMB = Txt_Tcambio.Text

        'Estado 7
        Select Case CmbEstado.SelectedIndex
            Case 1
                LibroDiario.EST = "H"
            Case 2
                LibroDiario.EST = "A"
            Case 3
                LibroDiario.EST = "R"
            Case 4
                LibroDiario.EST = "T"
        End Select

        'Banco 8
        LibroDiario.CBCO_COD = CmbBanco.SelectedValue

        'Observacion 9
        LibroDiario.OBSERVA = Txt_Concepto.Text

        'Cobranza 10
        Select Case CmbCobranza.SelectedIndex
            Case 0
                LibroDiario.COBRANZA = "C"
            Case 1
                LibroDiario.COBRANZA = "N"
        End Select

        'Forma de Pago Cod  20
        LibroDiario.F_PAGO_ENT = Txt_CodFpago.Text

        'Fecha Vencimiento 15
        LibroDiario.FEC_PAGO = DatVencimiento.Value.ToString("dd/MM/yyyy")

        'Moneda 5
        LibroDiario.MONEDA = CmbMoneda.SelectedValue

        'Centro de Costo   13
        LibroDiario.CCO_COD = Txt_CodCosto.Text

        'Proveedor/Cliente  11
        LibroDiario.PROVEEDOR = Txt_CodProveedor.Text

        'Tipo Cambio 2    2
        LibroDiario.T_CAMBIO = Txt_Tcambio2.Text

        'Total Dolares  17
        LibroDiario.TPRECIO_DCOMPRA = Txt_Dolares.Text

        'Total Soles   16
        LibroDiario.TPRECIO_COMPRA = Txt_Soles.Text

        'Registro COntable   14
        LibroDiario.REG_NRO = Txt_RegContable.Text

        'Usuario        18 
        LibroDiario.USUARIO = gsUser

        'Fecha Dia  19
        LibroDiario.FEC_DIA = System.DateTime.Now

        'Prov PAgo 20
        LibroDiario.PROV_PAGO = IIf(chkpago.Checked, "1", "0")


        Return LibroDiario

    End Function

    Public Function DatosDetLibroDiario(ByVal i As String) As DET_LIBRO_DIARIOBE
        Dim DetLibroDiario As New DET_LIBRO_DIARIOBE

        'Tipo Registro
        Select Case cmbTipReg.SelectedIndex
            Case 1
                DetLibroDiario.T_REGISTRO = "APE"
            Case 2
                DetLibroDiario.T_REGISTRO = "CIE"
            Case 3
                DetLibroDiario.T_REGISTRO = "COS"
            Case 4
                DetLibroDiario.T_REGISTRO = "MOV"
        End Select

        'Tipo Documento
        DetLibroDiario.T_DOC_REF = CmbTDocumento.SelectedValue

        'Serie DOcumento
        DetLibroDiario.SER_DOC_REF = Txt_serie.Text

        'Numero Documento
        DetLibroDiario.NRO_DOC_REF = Txt_numero.Text

        'Tipo Documento Ref
        DetLibroDiario.T_DOC_REF1 = DgvDetLibro.Rows(i).Cells("Documento").Value

        'Serie Documento Ref
        DetLibroDiario.SER_DOC_REF1 = DgvDetLibro.Rows(i).Cells("Serie").Value

        'Nro. Documento Ref
        DetLibroDiario.NRO_DOC_REF1 = DgvDetLibro.Rows(i).Cells("Nro").Value

        'Estado
        If DgvDetLibro.Rows(i).Cells("Afecto").Value = "Afecto" Then
            DetLibroDiario.STATUS = "S"
        Else
            DetLibroDiario.STATUS = "N"
        End If

        'Centro de Costo
        If IsDBNull(DgvDetLibro.Rows(i).Cells("Ccosto").Value) Or DgvDetLibro.Rows(i).Cells("Ccosto").Value = "" Then
            DetLibroDiario.CCO_COD = ""
        Else
            DetLibroDiario.CCO_COD = DgvDetLibro.Rows(i).Cells("Ccosto").Value.ToString.Substring(0, 3)
        End If

        'Cuenta
        DetLibroDiario.CUENTA = DgvDetLibro.Rows(i).Cells("Cuenta").Value

        'Cuenta DEstino
        If IsDBNull(DgvDetLibro.Rows(i).Cells("CtaDes").Value) Then
            DetLibroDiario.CUENTA_DEST = ""
        Else
            DetLibroDiario.CUENTA_DEST = DgvDetLibro.Rows(i).Cells("CtaDes").Value
        End If


        'Signo
        DetLibroDiario.SIGNO = DgvDetLibro.Rows(i).Cells("Signo").Value

        'Fecha General
        DetLibroDiario.FEC_GENE = DgvDetLibro.Rows(i).Cells("Fecha").Value

        'Tipo Cambio
        DetLibroDiario.T_CAMB = DgvDetLibro.Rows(i).Cells("tcambio").Value

        'Precio Soles
        DetLibroDiario.TPRECIO_COMPRA = DgvDetLibro.Rows(i).Cells("tsoles").Value

        'Precio Dolares
        DetLibroDiario.TPRECIO_DCOMPRA = DgvDetLibro.Rows(i).Cells("tdolares").Value


        'Moneda
        If DgvDetLibro.Rows(i).Cells("mon").Value = "SOLES" Then
            DetLibroDiario.MONEDA = "00"
        Else
            DetLibroDiario.MONEDA = "01"
        End If

        'Documento 
        If IsDBNull(DgvDetLibro.Rows(i).Cells("comp").Value) Then
            DetLibroDiario.NRO_DOCU1 = ""
        Else
            DetLibroDiario.NRO_DOCU1 = DgvDetLibro.Rows(i).Cells("comp").Value
        End If

        'Observacion
        If IsDBNull(DgvDetLibro.Rows(i).Cells("obs").Value) Then
            DetLibroDiario.OBSERVA = ""
        Else
            DetLibroDiario.OBSERVA = DgvDetLibro.Rows(i).Cells("obs").Value
        End If

        'COD Proveedor Detalle
        DetLibroDiario.CTCT_COD = DgvDetLibro.Rows(i).Cells("CODPROVEEDOR").Value

        'COD Proveedor Cabecera
        DetLibroDiario.PROVEEDOR = Txt_CodProveedor.Text

        'X_RET
        DetLibroDiario.X_RET = "N"

        'Reg Contable
        DetLibroDiario.REG_NRO = Txt_RegContable.Text

        'T_Ope_Cod
        If CmbTOperacion.SelectedIndex = 1 Then
            DetLibroDiario.T_OPE_COD = "007"
        ElseIf CmbTOperacion.SelectedIndex = 2 Then
            DetLibroDiario.T_OPE_COD = "009"
        Else
            DetLibroDiario.T_OPE_COD = "099"
        End If

        ' Art. Cod
        If IsDBNull(DgvDetLibro.Rows(i).Cells("CODART").Value) Or DgvDetLibro.Rows(i).Cells("CODART").Value = "" Then
            DetLibroDiario.CODART = ""
        Else
            DetLibroDiario.CODART = DgvDetLibro.Rows(i).Cells("CODART").Value
        End If

        'Nuevo
        DetLibroDiario.NUEVO = ""

        'Cuentita
        DetLibroDiario.CUENTITA = ""

        'SEQ
        DetLibroDiario.I = i

        'PROV PAGO
        DetLibroDiario.PROV_PAGO = IIf(chkpago.Checked, "1", "0")
        '
        'FEC VENC
        ' MsgBox(DgvDetLibro.Rows(i).Cells(17).Value)
        'If IsDBNull(DgvDetLibro.Rows(i).Cells(17).Value) Or DgvDetLibro.Rows(i).Cells(17).Value = "" Then
        '    DetLibroDiario.FEC_VENC = ""
        'Else
        '    DetLibroDiario.FEC_VENC = DgvDetLibro.Rows(i).Cells("FECVEN").Value
        'End If

        Try
            If IsDBNull(DgvDetLibro.Rows(i).Cells(17).Value) Or DgvDetLibro.Rows(i).Cells(17).Value = "" Or DgvDetLibro.Rows(i).Cells(17).Value.ToString = "" Or DgvDetLibro.Rows(i).Cells(17).Value Is Nothing Then
                DetLibroDiario.FEC_VENC = ""
            Else
                DetLibroDiario.FEC_VENC = DgvDetLibro.Rows(i).Cells("FECVEN").Value
            End If
        Catch ex As Exception

        End Try

        Try
            If DgvDetLibro.Rows(i).Cells("Reparar").EditedFormattedValue = True Then
                DetLibroDiario.REPARAR = "1"
            Else
                DetLibroDiario.REPARAR = "0"
            End If
        Catch ex As Exception
            DetLibroDiario.REPARAR = "0"
        End Try


        Return DetLibroDiario
    End Function

    Private Sub Txt_CodFpago_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_CodFpago.KeyDown
        If e.KeyValue = Keys.F9 Then
            'LIBRO DIARIO - BUSCAR PAGO
            sBusAlm = "38"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                Txt_CodFpago.Text = gLinea
                Txt_NomFpago.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Txt_CodCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_CodCosto.KeyDown
        If e.KeyValue = Keys.F9 Then
            'LIBRO DIARIO - CENTRO COSTO
            sBusAlm = "39"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                Txt_CodCosto.Text = gLinea
                Txt_NomCosto.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Txt_CodProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_CodProveedor.KeyDown
        If e.KeyValue = Keys.F9 Then
            'PROVEEDOR
            sBusAlm = "40"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                Txt_CodProveedor.Text = gLinea
                Txt_NomProveedor.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    'Private Sub DgvDetLibro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DgvDetLibro.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.Chr(Keys.F9) And DgvDetLibro.CurrentRow.Cells("Documento").Selected = True Then
    '        MsgBox("OK")
    '    End If0503
    'End Sub

    Private Sub DgvDetLibro_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvDetLibro.KeyDown

        If DgvDetLibro.CurrentRow.Cells("Documento").Selected = True And e.KeyValue = Keys.F9 Then
            Dim fila = DgvDetLibro.CurrentRow.Index
            sBusAlm = "41"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(0).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(1).Value = gSubLinea
                DgvDetLibro.CurrentRow.Cells(1).Selected = False
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            Exit Sub
        End If

        'NRO DOCUMENTO
        If DgvDetLibro.CurrentRow.Cells("Nro").Selected = True And e.KeyValue = Keys.Enter Then
            Dim fila = DgvDetLibro.CurrentRow.Index
            sTDoc = DgvDetLibro.CurrentRow.Cells("Documento").Value
            lsNrodOC = DgvDetLibro.CurrentRow.Cells("Nro").Value
            ldANHO = DatFecha.Value.ToString("yyyy")
            sBusAlm = "45"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If ldSERIE <> Nothing And ldNUMERO <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item("Documento").Value = ldTDoc
                DgvDetLibro.Rows(fila).Cells.Item("Serie").Value = ldSERIE
                DgvDetLibro.Rows(fila).Cells.Item("Nro").Value = ldNUMERO
                DgvDetLibro.Rows(fila).Cells.Item("Cuenta").Value = ldCUENTA
                DgvDetLibro.Rows(fila).Cells.Item(7).Value = ldCUENTADEST
                If ldSIGNO = "+" Then
                    DgvDetLibro.Rows(fila).Cells.Item("Signo").Value = "-"
                Else
                    DgvDetLibro.Rows(fila).Cells.Item("Signo").Value = "+"
                End If

                DgvDetLibro.Rows(fila).Cells.Item("Fecha").Value = ldFECHA
                If estadoTC = 0 Then
                Else
                    DgvDetLibro.Rows(fila).Cells.Item(11).Value = ldTCAMB
                End If

                If ldIMPORTE = "" Or ldDIMPORTE = "" Then
                    estadoTextoVariable = 0
                Else
                    estadoTextoVariable = 1
                    If estadoTC = 0 Then

                    Else
                        DgvDetLibro.Rows(fila).Cells.Item(12).Value = ldIMPORTE
                        DgvDetLibro.Rows(fila).Cells.Item(13).Value = ldDIMPORTE

                    End If
                    EstadoEspecial = 1
                    estadoTextoVariable = 0
                    estadoCargar = 1
                End If
                DgvDetLibro.Rows(fila).Cells.Item(12).Value = ldIMPORTE
                DgvDetLibro.Rows(fila).Cells.Item(13).Value = ldDIMPORTE
                DgvDetLibro.Rows(fila).Cells.Item("Mon").Value = ldMONEDA
                DgvDetLibro.Rows(fila).Cells.Item("CODPROVEEDOR").Value = ldPROVEEDOR
                DgvDetLibro.Rows(fila).Cells.Item(8).Value = ldNomProveedor
                limpiarDatosLD()
            End If
            Exit Sub
        End If

        If DgvDetLibro.CurrentRow.Cells(5).Selected = True And e.KeyValue = Keys.F9 Then
            Dim fila = DgvDetLibro.CurrentRow.Index
            sBusAlm = "42"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                'DgvDetLibro.Rows(fila).Cells.Item(colum).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(5).Value = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            Exit Sub
        End If

        If DgvDetLibro.CurrentRow.Cells(6).Selected = True And e.KeyValue = Keys.F9 Then
            Dim fila = DgvDetLibro.CurrentRow.Index
            sBusAlm = "43"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If (gLinea <> Nothing And gSubLinea <> Nothing) Or gLinea2 <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(6).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(7).Value = gLinea2

                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            End If
            DgvDetLibro.Rows(fila).Cells.Item(8).Selected = True
        End If

        If DgvDetLibro.CurrentRow.Cells(8).Selected = True And e.KeyValue = Keys.F9 Then
            Dim fila = DgvDetLibro.CurrentRow.Index
            sBusAlm = "44"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                DgvDetLibro.Rows(fila).Cells.Item(19).Value = gLinea
                DgvDetLibro.Rows(fila).Cells.Item(8).Value = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            DgvDetLibro.Rows(fila).Cells.Item(9).Selected = True
        End If

        If DgvDetLibro.CurrentRow.Cells(6).Selected And e.KeyValue = Keys.Enter Then
            Dim cuenta = DgvDetLibro.CurrentRow.Cells(6).Value
            Dim dtCuentaDest As New DataTable
            dtCuentaDest = CONTABILIDADBL.BuscarCuentaDestino(cuenta, DatFecha.Value.ToString("yyyy"))
            If dtCuentaDest.Rows.Count > 0 Then
                DgvDetLibro.CurrentRow.Cells(7).Value = dtCuentaDest.Rows(0).Item(0).ToString
                DgvDetLibro.CurrentRow.Cells(8).Selected = True
            Else
                DgvDetLibro.CurrentRow.Cells(8).Selected = True
            End If
        End If

        'If DgvDetLibro.CurrentRow.Cells("Nro").Selected And (e.KeyValue = Keys.F9 Or e.KeyValue = Keys.Enter) Then
        '    sBusAlm = "45" 'NRO.DOCUMENTO
        '    sTDoc = DgvDetLibro.CurrentRow.Cells(0).Value
        '    ldANHO = DgvDetLibro.CurrentRow.Cells("Nro").Value
        '    Dim fila = DgvDetLibro.CurrentRow.Index
        '    Dim FRM As New BusquedaPersonal
        '    FRM.ShowDialog()
        '    If ldSERIE <> Nothing And ldNUMERO <> Nothing Then
        '        DgvDetLibro.Rows(fila).Cells.Item("Serie").Value = ldSERIE
        '        DgvDetLibro.Rows(fila).Cells.Item("Nro").Value = ldNUMERO
        '        DgvDetLibro.Rows(fila).Cells.Item("Cuenta").Value = ldCUENTA
        '        DgvDetLibro.Rows(fila).Cells.Item(7).Value = ldCUENTADEST
        '        DgvDetLibro.Rows(fila).Cells.Item("Signo").Value = ldSIGNO
        '        DgvDetLibro.Rows(fila).Cells.Item("Fecha").Value = ldFECHA
        '        DgvDetLibro.Rows(fila).Cells.Item(11).Value = ldTCAMB
        '        If ldIMPORTE = "" Or ldDIMPORTE = "" Then
        '            estadoTextoVariable = 0
        '        Else
        '            estadoTextoVariable = 1
        '            DgvDetLibro.Rows(fila).Cells.Item(12).Value = ldIMPORTE
        '            DgvDetLibro.Rows(fila).Cells.Item(13).Value = ldDIMPORTE
        '        End If
        '        DgvDetLibro.Rows(fila).Cells.Item(12).Value = ldIMPORTE
        '        DgvDetLibro.Rows(fila).Cells.Item(13).Value = ldDIMPORTE
        '        DgvDetLibro.Rows(fila).Cells.Item("Mon").Value = ldMONEDA
        '        DgvDetLibro.Rows(fila).Cells.Item("CODPROVEEDOR").Value = ldPROVEEDOR
        '    End If
        'End If
 _
        For i = 0 To DgvDetLibro.Columns.Count - 1
            DgvDetLibro.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub limpiarDatosLD()
        ldTDoc = Nothing
        ldSERIE = Nothing
        ldNUMERO = Nothing
        ldCUENTA = Nothing
        ldCUENTADEST = Nothing
        ldFECHA = Nothing
        ldPROVEEDOR = Nothing
        ldRegContable = Nothing
        ldSIGNO = Nothing
        ldTCAMB = Nothing
        ldIMPORTE = Nothing
        ldDIMPORTE = Nothing
        ldMONEDA = Nothing
        ldNomProveedor = Nothing
    End Sub
    Private Sub CmbTOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTOperacion.SelectedIndexChanged

        Dim dtNumeroDoc As New DataTable
        Dim tipOpe = ""
        If CmbTOperacion.SelectedIndex = 1 Then
            tipOpe = "007"
        ElseIf CmbTOperacion.SelectedIndex = 2 Then
            tipOpe = "009"
        End If

        Dim mes = DatFecha.Value.ToString("MM")
        Dim anho = DatFecha.Value.ToString("yyyy")

        dtNumeroDoc = CONTABILIDADBL.VerificarNumeroContable(tipOpe, mes, anho)
        If dtNumeroDoc.Rows.Count > 0 Then
            If dtNumeroDoc.Rows(0).Item(0).ToString <> "" Then
                Txt_numero.Text = dtNumeroDoc.Rows(0).Item(0).ToString
            Else
                If tipOpe = "007" Then
                    Txt_numero.Text = DatFecha.Value.ToString("yyyy") & DatFecha.Value.ToString("MM") & "0001"
                Else
                    Txt_numero.Text = DatFecha.Value.ToString("yyyy") & DatFecha.Value.ToString("MM") & "0001"
                End If
            End If
        End If
    End Sub

    Private Sub FormLibroDiario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub DeleteData()
        Dim tipOpe = "000"
        Dim mes = DatFecha.Value.ToString("MM")
        Dim anho = DatFecha.Value.ToString("yyyy")
        Dim resp = MsgBox("Desea anular Documento: " & Txt_numero.Text, MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If
        Dim LIBRODIARIO As New LIBRO_DIARIOBE
        LIBRODIARIO.NRO_DOC_REF = sNDoc
        LIBRODIARIO.T_DOC_REF = sTDoc
        LIBRODIARIO.SER_DOC_REF = sSDoc
        LIBRODIARIO.REG_NRO = Txt_RegContable.Text
        If CmbTOperacion.SelectedIndex = 1 Then
            tipOpe = "007"
        ElseIf CmbTOperacion.SelectedIndex = 2 Then
            tipOpe = "009"
        Else
            tipOpe = "099"
        End If
        LIBRODIARIO.T_OPE = tipOpe
        flagAccion = "E"
        gsError = CONTABILIDADBL.SaveRow(LIBRODIARIO, mes, anho, flagAccion)
        If gsError = "OK" Then
            MsgBox("Documento Anulado Correctamente")
        Else
            Exit Sub
        End If
        Dispose()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim ope As String
    '    If CmbTOperacion.SelectedIndex = 1 Then
    '        ope = "007"
    '    Else
    '        ope = "009"
    '    End If
    '    Dim dtAsientoCOntables As New DataTable
    '    dtAsientoCOntables = ELPAGO_DOCUMENTOBL.ContarMovctTemporal(ope)
    '    If dtAsientoCOntables.Rows(0).ItemArray(0) > 0 Then
    '        ELPAGO_DOCUMENTOBL.ProcesarMovctTemporal(ope)
    '        reporte = 1
    '        lblEstado.Text = "PROCESADO"
    '        lblEstado.ForeColor = Color.Blue
    '        MsgBox("Se procesaron los asientos contables", MsgBoxStyle.Exclamation)
    '    Else
    '        MsgBox("NO hay Asientos Contables para procesar", MsgBoxStyle.Exclamation)
    '    End If
    'End Sub

    Private Sub ImprimirRegistroContable()

        Dim rpt As New FormReportes
        Dim regCont = Txt_RegContable.Text
        Dim mes = DatFecha.Value.ToString("MM")
        Dim Anho = DatFecha.Value.ToString("yyyy")
        Dim ope = "000"

        Select Case CmbTOperacion.SelectedIndex
            Case 1
                ope = "007"
            Case 2
                ope = "009"
        End Select

        ReDim gsRptArgs(4)
        gsRptArgs(0) = regCont
        gsRptArgs(1) = mes
        gsRptArgs(2) = Anho
        gsRptArgs(3) = ope

        If CmbMoneda.SelectedIndex = 0 Then
            gsRptArgs(4) = "01"
        Else
            gsRptArgs(4) = "00"
        End If

        'If reporte = 1 Then
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_VOUCHER.rpt"
        'Else
        '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_VOUCHER_T.rpt"
        'End If
        gsRptPath = gsPathRpt
        rpt.Show()
    End Sub

    Private Sub btnDupRegistro_Click(sender As Object, e As EventArgs) Handles btnDupRegistro.Click
        Dim resp = MsgBox("Duplicar documento para el presente mes?", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If



        DatFecha.Value = Date.Now.AddDays(-Now.Day + 1).AddMonths(0).AddDays(-1)
        DatVencimiento.Value = Date.Now.AddDays(-Now.Day + 1).AddMonths(0).AddDays(-1)
        Txt_RegContable.Text = ""
        Dim dtNumeroDoc As New DataTable
        Dim tipOpe = ""
        flagAccion = "N"
        If CmbTOperacion.SelectedIndex = 1 Then
            tipOpe = "007"
        ElseIf CmbTOperacion.SelectedIndex = 2 Then
            tipOpe = "009"
        End If

        Dim mes = DatFecha.Value.ToString("MM")
        Dim anho = DatFecha.Value.ToString("yyyy")

        dtNumeroDoc = CONTABILIDADBL.VerificarNumeroContable(tipOpe, mes, anho)
        If dtNumeroDoc.Rows.Count > 0 Then
            If dtNumeroDoc.Rows(0).Item(0).ToString <> "" Then
                Txt_numero.Text = dtNumeroDoc.Rows(0).Item(0).ToString
            Else
                If tipOpe = "007" Then
                    Txt_numero.Text = DatFecha.Value.ToString("yyyy") & DatFecha.Value.ToString("MM") & "0001"
                Else
                    Txt_numero.Text = DatFecha.Value.ToString("yyyy") & DatFecha.Value.ToString("MM") & "0001"
                End If
            End If
        End If

        For i = 0 To DgvDetLibro.Rows.Count - 1
            DgvDetLibro.Rows(i).Cells("FECHA").Value = Date.Now.AddDays(-Now.Day + 1).AddMonths(0).AddDays(-1).ToString("dd/MM/yyyy")
        Next

    End Sub
End Class
