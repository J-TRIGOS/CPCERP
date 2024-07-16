Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL


Public Class FormRegistroDetBindCard
    Private DETBINDCARDBE As New DETBINDCARDBE
    Private ARTICULOBL As New ARTICULOBL
    Private BINDCARDBE As New BINDCARDBE
    Private DETBINDCARDBL As New DETBINDCARDBL
    Private BINDCARDBL As New BINDCARDBL
    Private KARDEXBCBL As New KARDEXBCBL
    Dim consumo As Decimal = 0

    Private Sub FormRegistroDetBindCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser = "JTRIGOS" Then
            txt_nomartop.Enabled = True
            txt_codartop.Enabled = True
            cmb_estado.Enabled = True
            btn_actualizar.Enabled = True
        End If
        Dim dtCC As New DataTable
        dtCC = ARTICULOBL.ListadoCC()
        GetCmb("COD", "NOM", dtCC, cmbCentro)

        txt_ope.Enabled = True
        If bcESTADO = "ATENDIDO" Then
            dgv_detbindcard.ReadOnly = True
            datFec.Enabled = False
            txt_ope.Enabled = False
            txt_descr.Enabled = False
            txt_consumo.Enabled = False
            txt_merma.Enabled = False
            txt_reingreso.Enabled = False
            txt_maquina.Enabled = False
            btn_buscar.Enabled = False
            txt_rendimiento.Enabled = False
            btn_actualizar.Enabled = False
            btn_procesar.Enabled = False
            cmb_estado.Enabled = False
            btn_registrar.Enabled = False
            btn_anular.Enabled = True
            txtLote.Enabled = False
        End If

        If bcESTADO = "ANULADO" Then
            dgv_detbindcard.ReadOnly = True
            datFec.Enabled = False
            txt_ope.Enabled = False
            txt_descr.Enabled = False
            txt_consumo.Enabled = False
            txt_merma.Enabled = False
            txt_reingreso.Enabled = False
            txt_maquina.Enabled = False
            btn_buscar.Enabled = False
            txt_rendimiento.Enabled = False
            btn_actualizar.Enabled = False
            btn_procesar.Enabled = False
            cmb_estado.Enabled = False
            btn_registrar.Enabled = False
            btn_anular.Enabled = False
            btnRptBindCard.Enabled = False
            btnBuscarOP.Enabled = False
            txtLote.Enabled = False
        End If

        Me.Text = "Registro Detalle BIND CARD"
        txt_serie.Text = bcSERIE
        txt_numero.Text = bcNUMERO
        txt_codart.Text = bcCODART
        txt_cantidad.Text = bcCANTIDAD
        txt_articulo.Text = bcARTICULO
        txt_kardex.Text = bcKARDEX
        datFecGene.Value = bcFECGENE
        txtLote.Text = bcLOTE
        If bcFECGENE.Substring(3, 7) = "04/2022" And bcESTADO = "GENERADO" Then
            datFecGene.Enabled = True
        Else
            datFecGene.Enabled = False
        End If
        txt_serie.Enabled = False
        txt_numero.Enabled = False
        txt_codart.Enabled = False
        txt_cantidad.Enabled = False
        txt_articulo.Enabled = False
        txt_kardex.Enabled = False
        Select Case bcESTADO
            Case "GENERADO"
                cmb_estado.SelectedIndex = 1
            Case "ATENDIDO"
                cmb_estado.SelectedIndex = 2
            Case "PENDIENTE"
                cmb_estado.SelectedIndex = 3
            Case "ANULADO"
                cmb_estado.SelectedIndex = 4
        End Select

        Dim dtDetBindCard As New DataTable
        dtDetBindCard = DETBINDCARDBL.BuscarDetalleBindCard(bcSERIE, bcNUMERO, bcCODART)
        dgv_detbindcard.DataSource = dtDetBindCard

        For i = 0 To dgv_detbindcard.Columns.Count - 1
            dgv_detbindcard.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        If gnOpcion = 0 Then
            dgv_detbindcard.ReadOnly = True
        Else
            dgv_detbindcard.ReadOnly = False
        End If

        If txt_codart.Text.Substring(0, 4) = "0502" Or txt_codart.Text.Substring(0, 4) = "0542" Or txt_codart.Text.Substring(0, 4) = "0532" Or txt_codart.Text.Substring(0, 4) = "0521" _
            Or txt_codart.Text.Substring(0, 4) = "0588" Or txt_codart.Text.Substring(0, 4) = "0599" And txtLote.Text = "" Then
            txtLote.Enabled = True
        Else
            txtLote.Enabled = False
        End If

        Dim contador As Decimal = 0
        If dgv_detbindcard.Rows.Count > 0 Then
            For i = 0 To dgv_detbindcard.Rows.Count - 1
                contador = contador + dgv_detbindcard.Rows(i).Cells("CONSUMO").Value
            Next
            cantConsumo.Text = contador
        End If

        Dim dtUser As New DataTable
        dtUser = BINDCARDBL.VerificarUsuario(gsUser)
        If gsUser = "JTRIGOS" Or gsUser = "SISTEMAS" Or gsUser = "JVALVERDE" Or gsUser = "CHOYOS" Or gsUser = "COSTOS" Then

            Exit Sub
        End If
        If dtUser.Rows.Count > 0 Then
            If dtUser.Rows(0).Item(0) = "111" Then
                dgv_detbindcard.ReadOnly = True
                Select Case cmb_estado.Text
                    Case "ATENDIDO"
                        btn_procesar.Enabled = False
                        btn_registrar.Enabled = False
                        btn_actualizar.Enabled = False
                        btn_anular.Enabled = True
                    Case "GENERADO", "PENDIENTE"
                        btn_procesar.Enabled = True
                        btn_registrar.Enabled = False
                        btn_actualizar.Enabled = False
                        btn_anular.Enabled = False
                End Select

            Else
                Select Case cmb_estado.Text
                    Case "ATENDIDO"
                        btn_procesar.Enabled = False
                        btn_registrar.Enabled = False
                        btn_actualizar.Enabled = False
                        btn_anular.Enabled = False
                    Case "GENERADO", "PENDIENTE"
                        btn_procesar.Enabled = False
                        btn_registrar.Enabled = True
                        btn_actualizar.Enabled = True
                        btn_anular.Enabled = False
                End Select
            End If
        End If

    End Sub


    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

        Dim dia
        Dim mes
        Dim anho

        dia = datFec.Value.Day
        mes = datFec.Value.Month
        anho = datFec.Value.Year

        If cmbCentro.SelectedIndex = -1 Then
            MsgBox("Seleccione Centro de Costo")
            Exit Sub
        End If
        If txt_codart.Text.Substring(0, 4) = "0502" Or txt_codart.Text.Substring(0, 4) = "0542" Or txt_codart.Text.Substring(0, 4) = "0532" Or txt_codart.Text.Substring(0, 4) = "0521" _
            Or txt_codart.Text.Substring(0, 4) = "0588" Or txt_codart.Text.Substring(0, 4) = "0599" Then
            If txtLote.Text = "" Then
                MsgBox("Ingresar Numero de Lote")
                Exit Sub
            End If
        End If
        If txt_ope.Text = "" Then
            MsgBox("Ingresar Numero OP")
            Exit Sub
        End If

        If Not txt_ope.Text.Contains(anho & "-0000") Then
            MsgBox("Ingresar formato correcto de OP")
            Exit Sub
        End If

        flagAccion = "N"
        DETBINDCARDBE.CODARTOP = txt_codartop.Text
        DETBINDCARDBE.CCOCOD = cmbCentro.Text.Substring(0, 3)
        DETBINDCARDBE.SERIE_REF = txt_serie.Text
        DETBINDCARDBE.NRO_DOC_REF = txt_numero.Text
        DETBINDCARDBE.ART_COD = txt_codart.Text
        DETBINDCARDBE.DESC_ART = txt_articulo.Text
        DETBINDCARDBE.ITEM = dgv_detbindcard.Rows.Count + 1

        DETBINDCARDBE.FEC_CONSUMO = dia & "/" & mes & "/" & anho
        'DETBINDCARDBE.FEC_CONSUMO = datFec.Value.ToString("dd/MM/yyyy")

        If gsUser = "JTRIGOS" Then

        ElseIf Not datFec.Value.ToString("MM/yyyy") = datFecGene.Value.ToString("MM/yyyy") Then
            MsgBox("Fecha de Consumo distinto al BindCard")
            Exit Sub
        End If

        DETBINDCARDBE.NRO_DOC_OP = txt_ope.Text
        DETBINDCARDBE.DESCRIPCION = txt_descr.Text
        DETBINDCARDBE.CONSUMO = txt_consumo.Text
        DETBINDCARDBE.MERMA = txt_merma.Text
        DETBINDCARDBE.REINGRESO = txt_reingreso.Text
        DETBINDCARDBE.MAQUINA = txt_maquina.Text
        DETBINDCARDBE.OPERARIO = txt_operario.Text
        DETBINDCARDBE.RENDIMIENTO = txt_rendimiento.Text
        DETBINDCARDBE.NOMARTOP = txt_nomartop.Text
        If DETBINDCARDBE.CONSUMO = 0 Then
            DETBINDCARDBE.CODTRA = "E17"
        Else
            DETBINDCARDBE.CODTRA = "S23"
        End If

        gsError = DETBINDCARDBL.SaveRow(DETBINDCARDBE, flagAccion, txtLote.Text)

        If gsError = "OK" Then
            BorrarDatos()
            cargarDatosDet()
            Dim contador As Decimal = 0
            If dgv_detbindcard.Rows.Count > 0 Then
                For i = 0 To dgv_detbindcard.Rows.Count - 1
                    contador = contador + dgv_detbindcard.Rows(i).Cells("CONSUMO").Value
                Next
                cantConsumo.Text = contador
            End If
            MsgBox("Registro Grabado Correctamente")
            Dim dtUser As New DataTable
            dtUser = BINDCARDBL.VerificarUsuario(gsUser)
            If gsUser = "JTRIGOS" Or gsUser = "SISTEMAS" Or gsUser = "JVALVERDE" Or gsUser = "CHOYOS" Or gsUser = "COSTOS" Then
                Exit Sub
            End If
            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows(0).Item(0) = "111" Then
                    dgv_detbindcard.ReadOnly = True
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = True
                        Case "GENERADO", "PENDIENTE"
                            btn_procesar.Enabled = True
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                    End Select

                Else
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                        Case "GENERADO", "PENDIENTE"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = True
                            btn_actualizar.Enabled = True
                            btn_anular.Enabled = False
                    End Select
                End If
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

        If Not cmb_estado.SelectedIndex = 2 Or Not cmb_estado.SelectedIndex = 4 Then
            If dgv_detbindcard.Rows.Count = 0 Then
                cmb_estado.SelectedIndex = 3
            Else
                cmb_estado.SelectedIndex = 1
            End If
        End If

    End Sub

    Private Sub BorrarDatos()
        txt_ope.Text = ""
        txt_descr.Text = ""
        txt_consumo.Text = "0"
        txt_reingreso.Text = "0"
        txt_merma.Text = "0"
        txt_maquina.Text = ""
        txt_operario.Text = ""
        txt_rendimiento.Text = ""
    End Sub

    Private Sub cargarDatosDet()
        dgv_detbindcard.DataSource = ""
        Dim dtDetBindCard As New DataTable
        dtDetBindCard = DETBINDCARDBL.BuscarDetalleBindCard(bcSERIE, bcNUMERO, bcCODART)
        dgv_detbindcard.DataSource = dtDetBindCard
        For i = 0 To dgv_detbindcard.Columns.Count - 1
            dgv_detbindcard.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub txt_operario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_operario.KeyDown
        If e.KeyValue = Keys.F9 Then

            sBusAlm = "3720"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_operario.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If cmb_estado.SelectedIndex = 4 Then
            Dim dtVetificarBC As New DataTable
            dtVetificarBC = BINDCARDBL.VerificarEstBindCard(datFecGene.Value.ToString("MM"), datFecGene.Value.ToString("yyyy"))
            If dtVetificarBC.Rows.Count > 0 Then
                If dtVetificarBC.Rows(0).ItemArray(0) = 1 Then
                    MsgBox("Mes Cerrado, No se puede anular BindCard")
                    Exit Sub
                End If
            End If
        End If
        If dgv_detbindcard.Rows.Count > 0 Then
            ordenarGrid()
            If gsUser = "JTRIGOS" Then

            Else
                Dim mes = datFecGene.Value.ToString("MM")
                For i = 0 To dgv_detbindcard.Rows.Count - 1
                    dgv_detbindcard.Rows(i).Cells("FECHA").Value.ToString.Substring(4, 5)
                    If mes <> dgv_detbindcard.Rows(i).Cells("FECHA").Value.ToString.Substring(3, 2) Then
                        MsgBox("Consumo en Fila " & i + 1 & " tiene Mes distinto al BindCard")
                        Exit Sub
                    End If
                Next
            End If
        End If
        flagAccion = "M"
        Dim BINDCARDBE As New BINDCARDBE
        BINDCARDBE.SER_DOC_REF = txt_serie.Text
        BINDCARDBE.NRO_DOC_REF = txt_numero.Text
        BINDCARDBE.ART_COD = txt_codart.Text
        BINDCARDBE.FEC_GENE = datFecGene.Value.ToString("dd/MM/yyyy")
        Select Case cmb_estado.SelectedIndex
            Case 0
                MsgBox("Seleccione un Estado Correcto")
                Exit Sub
            Case 1
                BINDCARDBE.EST = "G"
            Case 2
                BINDCARDBE.EST = "A"
            Case 3
                BINDCARDBE.EST = "P"
            Case 4
                BINDCARDBE.EST = "X"
        End Select
        Try
            actualizarBindCard(BINDCARDBE)
            Dim contador As Decimal = 0
            If dgv_detbindcard.Rows.Count > 0 Then
                For i = 0 To dgv_detbindcard.Rows.Count - 1
                    contador = contador + dgv_detbindcard.Rows(i).Cells("CONSUMO").Value
                Next
                cantConsumo.Text = contador
            Else
                cantConsumo.Text = 0
            End If
            MsgBox("Registro Actualizado")
            cargarDatosDet()
            Dim dtUser As New DataTable
            dtUser = BINDCARDBL.VerificarUsuario(gsUser)
            If gsUser = "JTRIGOS" Or gsUser = "SISTEMAS" Or gsUser = "JVALVERDE" Or gsUser = "CHOYOS" Or gsUser = "COSTOS" Then
                Exit Sub
            End If
            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows(0).Item(0) = "111" Then
                    dgv_detbindcard.ReadOnly = True
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = True
                        Case "GENERADO", "PENDIENTE"
                            btn_procesar.Enabled = True
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                    End Select

                Else
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                        Case "GENERADO", "PENDIENTE"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = True
                            btn_actualizar.Enabled = True
                            btn_anular.Enabled = False
                    End Select
                End If
            End If
            If Not cmb_estado.SelectedIndex = 2 Or Not cmb_estado.SelectedIndex = 4 Then
                If dgv_detbindcard.Rows.Count = 0 Then
                    cmb_estado.SelectedIndex = 3
                Else
                    cmb_estado.SelectedIndex = 1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub actualizarBindCard(ByVal BINDCARDBE As BINDCARDBE)
        flagAccion = "M"
        Dim DETBINDCARD As New DETBINDCARDBE
        Try
            gsError = BINDCARDBL.ActualizarBindCard(BINDCARDBE, flagAccion)
        Catch ex As Exception

        End Try


        If gsError = "OK" Then
            If dgv_detbindcard.Rows.Count > 0 Then
                Dim filas = dgv_detbindcard.Rows.Count - 1

                For i = 0 To filas
                    flagAccion = "N"
                    DETBINDCARDBE.SERIE_REF = txt_serie.Text
                    DETBINDCARDBE.NRO_DOC_REF = txt_numero.Text
                    DETBINDCARDBE.ART_COD = txt_codart.Text
                    DETBINDCARDBE.DESC_ART = txt_articulo.Text
                    DETBINDCARDBE.ITEM = dgv_detbindcard.Rows(i).Cells("ITEM").Value
                    DETBINDCARDBE.FEC_CONSUMO = dgv_detbindcard.Rows(i).Cells("FECHA").Value

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("N° O/P").Value) Then
                        DETBINDCARDBE.NRO_DOC_OP = dgv_detbindcard.Rows(i).Cells("N° O/P").Value
                    Else
                        DETBINDCARDBE.NRO_DOC_OP = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("DESCRIPCION").Value) Then
                        DETBINDCARDBE.DESCRIPCION = dgv_detbindcard.Rows(i).Cells("DESCRIPCION").Value
                    Else
                        DETBINDCARDBE.DESCRIPCION = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("MERMA").Value) Then
                        DETBINDCARDBE.MERMA = dgv_detbindcard.Rows(i).Cells("MERMA").Value
                    Else
                        DETBINDCARDBE.MERMA = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("CONSUMO").Value) Then
                        DETBINDCARDBE.CONSUMO = dgv_detbindcard.Rows(i).Cells("CONSUMO").Value
                    Else
                        DETBINDCARDBE.CONSUMO = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("MAQUINA").Value) Then
                        DETBINDCARDBE.MAQUINA = dgv_detbindcard.Rows(i).Cells("MAQUINA").Value
                    Else
                        DETBINDCARDBE.MAQUINA = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("REINGRESO").Value) Then
                        DETBINDCARDBE.REINGRESO = dgv_detbindcard.Rows(i).Cells("REINGRESO").Value
                    Else
                        DETBINDCARDBE.REINGRESO = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("OPERARIO").Value) Then
                        DETBINDCARDBE.OPERARIO = dgv_detbindcard.Rows(i).Cells("OPERARIO").Value
                    Else
                        DETBINDCARDBE.OPERARIO = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("RENDIMIENTO").Value) Then
                        DETBINDCARDBE.RENDIMIENTO = dgv_detbindcard.Rows(i).Cells("RENDIMIENTO").Value
                    Else
                        DETBINDCARDBE.RENDIMIENTO = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("CENTRO COSTO").Value) Then
                        DETBINDCARDBE.CCOCOD = dgv_detbindcard.Rows(i).Cells("CENTRO COSTO").Value
                    Else
                        DETBINDCARDBE.CCOCOD = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("COD ART OP").Value) Then
                        DETBINDCARDBE.CODARTOP = dgv_detbindcard.Rows(i).Cells("COD ART OP").Value
                    Else
                        DETBINDCARDBE.CODARTOP = ""
                    End If

                    If Not IsDBNull(dgv_detbindcard.Rows(i).Cells("ART OP").Value) Then
                        DETBINDCARDBE.NOMARTOP = dgv_detbindcard.Rows(i).Cells("ART OP").Value
                    Else
                        DETBINDCARDBE.NOMARTOP = ""
                    End If
                    gsError = DETBINDCARDBL.SaveRow(DETBINDCARDBE, flagAccion, txtLote.Text)
                Next
            End If

            cargarDatosDet()
            For i = 0 To dgv_detbindcard.Columns.Count - 1
                dgv_detbindcard.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            ' MsgBox("BINDCARD Actualizado")
        Else
            MsgBox("Error al Actualizar")
        End If
        For i = 0 To dgv_detbindcard.Columns.Count - 1
            dgv_detbindcard.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub ordenarGrid()
        Dim filas = dgv_detbindcard.Rows.Count
        For i = 0 To filas - 1
            dgv_detbindcard.Rows(i).Cells("ITEM").Value = i + 1
        Next
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        sBusAlm = "3720"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txt_operario.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub FormRegistroDetBindCard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        Dim dtguia As New DataTable
        dtguia = BINDCARDBL.VerificarEstadoGuia(bcGUIA, txt_codart.Text)
        If dtguia.Rows.Count > 0 Then
            If dtguia.Rows(0).Item(0) = "A" Then
                MsgBox("Guia " & bcGUIA & " esta anulada")
                Exit Sub
            End If
            'Dim mes = datFecGene.Value.ToString("MM")
            'For i = 0 To dgv_detbindcard.Rows.Count - 1
            '    dgv_detbindcard.Rows(i).Cells("FECHA").Value.ToString.Substring(4, 5)
            '    If mes <> dgv_detbindcard.Rows(i).Cells("FECHA").Value.ToString.Substring(3, 2) Then
            '        MsgBox("Consumo en Fila " & i + 1 & " tiene Mes distinto al BindCard")
            '        Exit Sub
            '    End If
            'Next
        End If

        If Not Val(cantConsumo.Text) = Val(txt_kardex.Text) Then
            MsgBox("Cantidad Consumo distinta a la del Kardex", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim resp = MsgBox("Desea Procesar BINDCARD? Este documento reemplazara al KARDEX", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If

        flagAccion = "N"
        Dim tipDoc = "SOLM"
        Dim serDoc = txt_serie.Text
        Dim numDoc = txt_numero.Text
        Dim codArt = txt_codart.Text
        Dim cantidad = Val(cantConsumo.Text)
        Dim almacen = gsCodAlm
        Dim KARDEXBCBE As New KARDEXBINDCARDBE

        Dim dtVerificarKardex As New DataTable
        dtVerificarKardex = DETBINDCARDBL.VerificarKardex(tipDoc, serDoc, numDoc, codArt, cantidad, almacen)
        If dtVerificarKardex.Rows.Count > 0 Then
            For i = 0 To dgv_detbindcard.Rows.Count - 1
                KARDEXBCBE.MOV_T_DOC_REF = "SABC"
                KARDEXBCBE.MOV_SER_DOC_REF = txt_serie.Text
                KARDEXBCBE.MOV_NRO_DOC_REF = txt_numero.Text & "-" & dgv_detbindcard.Rows(i).Cells("ITEM").Value
                KARDEXBCBE.MOV_TIPO_TRANS = "S"
                KARDEXBCBE.CANTIDAD = Val(cantConsumo.Text)
                KARDEXBCBE.MOV_CODALM = gsCodAlm
                KARDEXBCBE.MOV_FECEMI = dgv_detbindcard.Rows(i).Cells("FECHA").Value
                KARDEXBCBE.NUMOP = dgv_detbindcard.Rows(i).Cells("N° O/P").Value
                KARDEXBCBE.MOV_CODART = txt_codart.Text
                KARDEXBCBE.MOV_CODUM = bcMEDIDA
                KARDEXBCBE.MOV_CODTRA = "S23"
                If dgv_detbindcard.Rows(i).Cells("CONSUMO").Value = 0 Then
                    KARDEXBCBE.MOV_CANTID = dgv_detbindcard.Rows(i).Cells("REINGRESO").Value
                    KARDEXBCBE.MOV_CODTRA = "E17"
                    KARDEXBCBE.MOV_TIPO_TRANS = "E"
                    'ElseIf dgv_detbindcard.Rows(i).Cells("MERMA").Value = 0 Then
                    '    KARDEXBCBE.MOV_CANTID = dgv_detbindcard.Rows(i).Cells("REINGRESO").Value
                    '    KARDEXBCBE.MOV_NRO_DOC_REF = KARDEXBCBE.MOV_NRO_DOC_REF & "-R"
                    '    KARDEXBCBE.MOV_TIPO_TRANS = "E"
                    '    KARDEXBCBE.MOV_CODTRA = "E27"
                Else
                    KARDEXBCBE.MOV_CANTID = dgv_detbindcard.Rows(i).Cells("CONSUMO").Value
                End If
                KARDEXBCBE.MOV_ESTADO = "H"
                KARDEXBCBE.MOV_CODUSR = gsUser
                KARDEXBCBE.CCO_COD = dgv_detbindcard.Rows(i).Cells("CENTRO COSTO").Value
                KARDEXBCBE.MOV_NRO_DOC_REF1 = txt_numero.Text
                KARDEXBCBE.MOV_SER_DOC_REF1 = txt_serie.Text
                KARDEXBCBE.MOV_T_DOC_REF1 = "SOLM"
                gsError = KARDEXBCBL.SaveRow(KARDEXBCBE, flagAccion)
                If Not gsError = "OK" Then
                    Exit Sub
                End If
            Next
            MsgBox("BINDCARD registrado correctamente.")
            cmb_estado.SelectedIndex = 2
            btn_anular.Enabled = True
            btn_procesar.Enabled = False
            btn_actualizar.Enabled = False
            btn_registrar.Enabled = False
        Else
            MsgBox("Verificar Documento Kardex a reemplazar")
        End If
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        Dim dtVetificarBC As New DataTable
        dtVetificarBC = BINDCARDBL.VerificarEstBindCard(datFecGene.Value.ToString("MM"), datFecGene.Value.ToString("yyyy"))
        If gsUser <> "JTRIGOS" And gsUser <> "SISTEMAS" And gsUser <> "JVALVERDE" Then
            If dtVetificarBC.Rows.Count > 0 Then
                If dtVetificarBC.Rows(0).ItemArray(0) = 1 Then
                    MsgBox("Mes Cerrado, No se puede anular BindCard")
                    Exit Sub
                End If
            End If
        End If


        Dim resp = MsgBox("Desea Anular BINDCARD?", MsgBoxStyle.YesNo)
        If resp = 7 Then
            Exit Sub
        End If

        flagAccion = "A"
        Dim serDoc = txt_serie.Text
        Dim numDoc = txt_numero.Text
        Dim codArt = txt_codart.Text
        Dim cantidad = Val(txt_kardex.Text)
        Dim almacen = gsCodAlm
        Dim KARDEXBCBE As New KARDEXBINDCARDBE
        With KARDEXBCBE
            .MOV_SER_DOC_REF1 = serDoc
            .MOV_NRO_DOC_REF1 = numDoc
            .MOV_CODART = codArt
            .MOV_CODALM = gsCodAlm
            .MOV_CANTID = cantidad
        End With
        gsError = KARDEXBCBL.SaveRow(KARDEXBCBE, flagAccion)
        If gsError = "OK" Then
            dgv_detbindcard.ReadOnly = False
            'btn_actualizar.Enabled = False
            datFec.Enabled = True
            txt_ope.Enabled = True
            txt_descr.Enabled = True
            txt_consumo.Enabled = True
            txt_merma.Enabled = True
            txt_reingreso.Enabled = True
            txt_maquina.Enabled = True
            btn_buscar.Enabled = True
            btn_registrar.Enabled = True
            txt_rendimiento.Enabled = True
            btn_actualizar.Enabled = True
            btn_procesar.Enabled = True
            btn_anular.Enabled = False
            cmb_estado.Enabled = False
            cmb_estado.SelectedIndex = 1
            MsgBox("BIND CARD ANULADO CORRECTAMENTE")
            Dim dtUser As New DataTable
            dtUser = BINDCARDBL.VerificarUsuario(gsUser)
            If gsUser = "JTRIGOS" Or gsUser = "SISTEMAS" Or gsUser = "JVALVERDE" Or gsUser = "CHOYOS" Or gsUser = "COSTOS" Then
                Exit Sub
            End If
            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows(0).Item(0) = "111" Then
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = True
                        Case "GENERADO"
                            btn_procesar.Enabled = True
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                    End Select

                Else
                    Select Case cmb_estado.Text
                        Case "ATENDIDO"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = False
                            btn_actualizar.Enabled = False
                            btn_anular.Enabled = False
                        Case "GENERADO", "PENDIENTE"
                            btn_procesar.Enabled = False
                            btn_registrar.Enabled = True
                            btn_actualizar.Enabled = True
                            btn_anular.Enabled = False
                    End Select
                End If
            End If
        Else
            MsgBox("ErrOr al Anular Bind Card")
            Exit Sub
        End If
    End Sub

    Private Sub btnRptBindCard_Click(sender As Object, e As EventArgs) Handles btnRptBindCard.Click
        If cmb_estado.Text = "ATENDIDO" Or cmb_estado.Text = "GENERADO" Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = txt_serie.Text
            gsRptArgs(1) = txt_numero.Text
            gsRptArgs(2) = txt_codart.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BINCARD_REPORTE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(2)
            gsRptArgs(0) = txt_serie.Text
            gsRptArgs(1) = txt_numero.Text
            gsRptArgs(2) = txt_codart.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BINCARD.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub btnBuscarOP_Click(sender As Object, e As EventArgs) Handles btnBuscarOP.Click
        sBusAlm = "BUSCAROP"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gLinea2 <> Nothing Then

            Dim dtOPSUB As New DataTable
            Dim artOP = gSubLinea
            Dim artCons = txt_codart.Text
            dtOPSUB = BINDCARDBL.VerificarOPSubLinea(artOP, artCons)
            If dtOPSUB.Rows(0).Item(0) = 0 Then
                MsgBox("Articulo " & artCons & " no puede consumirse con el Articulo de La OP " & txt_ope.Text)
                btn_registrar.Enabled = False
                txt_codartop.Text = ""
                txt_ope.Text = ""
                txt_ope.Select()
                txt_nomartop.Text = ""
                Exit Sub
            Else
                btn_registrar.Enabled = True
            End If

            txt_ope.Text = gLinea
            txt_codartop.Text = gSubLinea
            txt_nomartop.Text = gLinea2
            gLinea = Nothing
            gSubLinea = Nothing
            gLinea2 = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gLinea2 = Nothing
        End If
    End Sub

    Private Sub txt_ope_LostFocus(sender As Object, e As EventArgs) Handles txt_ope.LostFocus
        Dim dtOP As New DataTable
        Dim mes = datFecGene.Value.ToString("MM")
        Dim anho = datFecGene.Value.ToString("yyyy")
        Dim anhoAct = datFec.Value.Year

        If txt_ope.TextLength = 0 Then
            txt_ope.Text = ""
        Else
            txt_ope.Text = anhoAct & "-" & txt_ope.Text.PadLeft(9, "0")
            dtOP = BINDCARDBL.BuscarDatosOP(txt_ope.Text)
            If dtOP.Rows.Count > 0 Then

                If gsUser = "JTRIGOS" Then

                Else
                    If dtOP.Rows(0).ItemArray(3) <> mes Or dtOP.Rows(0).ItemArray(4) <> anho Then
                        MsgBox(txt_ope.Text & " con fecha distinta a BindCard")
                        txt_ope.Text = ""
                        cmbCentro.SelectedIndex = -1
                        txt_codartop.Text = ""
                        txt_nomartop.Text = ""
                        txt_ope.Focus()
                        Exit Sub
                    End If
                End If

                Dim dtOPSUB As New DataTable
                Dim artOP = dtOP.Rows(0).ItemArray(0)
                Dim artCons = txt_codart.Text
                dtOPSUB = BINDCARDBL.VerificarOPSubLinea(artOP, artCons)
                If dtOPSUB.Rows(0).Item(0) = 0 Then
                    MsgBox("Articulo " & artCons & " no puede consumirse en el Artículo " & dtOP.Rows(0).ItemArray(1) & " de La OP " & txt_ope.Text)
                    btn_registrar.Enabled = False
                    txt_ope.Text = ""
                    txt_ope.Select()
                    Exit Sub
                Else
                    btn_registrar.Enabled = True
                End If

                txt_codartop.Text = dtOP.Rows(0).ItemArray(0)
                txt_nomartop.Text = dtOP.Rows(0).ItemArray(1)
                If dtOP.Rows(0).ItemArray(2) <> "-" Then
                    cmbCentro.Text = dtOP.Rows(0).ItemArray(2)
                Else
                    cmbCentro.SelectedIndex = -1
                End If

            Else
                MsgBox("OP sin datos")
                txt_ope.Text = ""
            End If
            ' cmbCentro.Select()
        End If

    End Sub

    Private Sub btnMovArt_Click(sender As Object, e As EventArgs) Handles btnMovArt.Click


        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_MOVIM_CODART.rpt"

        Dim dDate1 As Date = Nothing
        Dim dDate2 As Date = Nothing



        dDate1 = "01/01/" + Year(Date.Now).ToString
        dDate2 = Today

        ReDim gsRptArgs(4)
        gsRptArgs(0) = dDate1.ToString("yyyy")

        gsRptArgs(1) = txt_codart.Text

        gsRptArgs(2) = dDate1
        gsRptArgs(3) = dDate2
        gsRptArgs(4) = gsCodAlm


        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub FormRegistroDetBindCard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class