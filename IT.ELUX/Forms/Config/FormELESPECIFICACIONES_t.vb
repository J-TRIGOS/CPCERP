Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net


Public Class FormELESPECIFICACIONES_t

    Private ARTICULOBL As New ARTICULOBL
    Private ELESPECI_TBL As New ELESPECI_TBL

    Private Sub FormELESPECIFICACIONES_t_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                'Limpiar()

            Case 1
                flagAccion = "M"
                GetData(gsCode)

        End Select
    End Sub
    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELESPECI_TBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows

            txtcod_art.Text = IIf(IsDBNull(Registro("COD_ARTICULO")), "", Registro("COD_ARTICULO"))
            lblcod_art.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtaltcuerpo.Text = IIf(IsDBNull(Registro("ALTURA_CUERPO")), "", Registro("ALTURA_CUERPO"))
            txto1.Text = IIf(IsDBNull(Registro("AC1")), "", Registro("AC1"))
            txtm1.Text = IIf(IsDBNull(Registro("AC2")), "", Registro("AC2"))
            txtp1.Text = IIf(IsDBNull(Registro("AC3")), "", Registro("AC3"))
            txtalturaenv.Text = IIf(IsDBNull(Registro("ALTURA_ENV_TAPA")), "", Registro("ALTURA_ENV_TAPA"))
            txto2.Text = IIf(IsDBNull(Registro("AET1")), "", Registro("AET1"))
            txtm2.Text = IIf(IsDBNull(Registro("AET2")), "", Registro("AET2"))
            txtp2.Text = IIf(IsDBNull(Registro("AET3")), "", Registro("AET3"))
            txtdiainterno.Text = IIf(IsDBNull(Registro("DIAMETRO_INTERNO")), "", Registro("DIAMETRO_INTERNO"))
            txto3.Text = IIf(IsDBNull(Registro("DI1")), "", Registro("DI1"))
            txtm3.Text = IIf(IsDBNull(Registro("DI2")), "", Registro("DI2"))
            txtp3.Text = IIf(IsDBNull(Registro("DI3")), "", Registro("DI3"))
            txtdexterno.Text = IIf(IsDBNull(Registro("DIAMETRO_EXTERNO")), "", Registro("DIAMETRO_EXTERNO"))
            txto4.Text = IIf(IsDBNull(Registro("DE1")), "", Registro("DE1"))
            txtm4.Text = IIf(IsDBNull(Registro("DE2")), "", Registro("DE2"))
            txtp4.Text = IIf(IsDBNull(Registro("DE3")), "", Registro("DE3"))
            txtanchenv.Text = IIf(IsDBNull(Registro("ANCHO_ENVASE")), "", Registro("ANCHO_ENVASE"))
            txto5.Text = IIf(IsDBNull(Registro("AE1")), "", Registro("AE1"))
            txtm5.Text = IIf(IsDBNull(Registro("AE2")), "", Registro("AE2"))
            txtp5.Text = IIf(IsDBNull(Registro("AE3")), "", Registro("AE3"))
            txtlargenv.Text = IIf(IsDBNull(Registro("LARGO_ENVASE")), "", Registro("LARGO_ENVASE"))
            txto6.Text = IIf(IsDBNull(Registro("LE1")), "", Registro("LE1"))
            txtm6.Text = IIf(IsDBNull(Registro("LE2")), "", Registro("LE2"))
            txtp6.Text = IIf(IsDBNull(Registro("LE3")), "", Registro("LE3"))
            txtalttapa.Text = IIf(IsDBNull(Registro("ALTURA_TAPA")), "", Registro("ALTURA_TAPA"))
            txto7.Text = IIf(IsDBNull(Registro("ATA1")), "", Registro("ATA1"))
            txtm7.Text = IIf(IsDBNull(Registro("ATA2")), "", Registro("ATA2"))
            txtp7.Text = IIf(IsDBNull(Registro("ATA3")), "", Registro("ATA3"))
            txtpesoenv.Text = IIf(IsDBNull(Registro("PESO_ENVASE")), "", Registro("PESO_ENVASE"))
            txto8.Text = IIf(IsDBNull(Registro("PE1")), "", Registro("PE1"))
            txtm8.Text = IIf(IsDBNull(Registro("PE2")), "", Registro("PE2"))
            txtp8.Text = IIf(IsDBNull(Registro("PE3")), "", Registro("PE3"))
            txtalt_asa.Text = IIf(IsDBNull(Registro("ALTURA_ASA")), "", Registro("ALTURA_ASA"))
            txto9.Text = IIf(IsDBNull(Registro("AA1")), "", Registro("AA1"))
            txtm9.Text = IIf(IsDBNull(Registro("AA2")), "", Registro("AA2"))
            txtp9.Text = IIf(IsDBNull(Registro("AA3")), "", Registro("AA3"))

            txtes6.Text = IIf(IsDBNull(Registro("ESPESOR_HOLAJATA")), "", Registro("ESPESOR_HOLAJATA"))
            txtes7.Text = IIf(IsDBNull(Registro("TEMPLE_HOJALATA")), "", Registro("TEMPLE_HOJALATA"))

            txtes1.Text = IIf(IsDBNull(Registro("ACABADO_F_ENVASE")), "", Registro("ACABADO_F_ENVASE"))
            txtes2.Text = IIf(IsDBNull(Registro("EMBAJALE_PRIMARIO")), "", Registro("EMBAJALE_PRIMARIO"))
            txtes3.Text = IIf(IsDBNull(Registro("EMBALAJE_SECUNDARIO")), "", Registro("EMBALAJE_SECUNDARIO"))
            txtes4.Text = IIf(IsDBNull(Registro("SEPARADORES")), "", Registro("SEPARADORES"))
            txtes5.Text = IIf(IsDBNull(Registro("NRO_ENVASE")), "", Registro("NRO_ENVASE"))

        Next
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELESPECI_TBE As New ELESPECI_TBE

                ELESPECI_TBE.cod_articulo = txtcod_art.Text
                ELESPECI_TBE.altura_cuerpo = txtaltcuerpo.Text
                ELESPECI_TBE.ac1 = txto1.Text
                ELESPECI_TBE.ac2 = txtm1.Text
                ELESPECI_TBE.ac3 = txtp1.Text
                ELESPECI_TBE.altura_env_tapa = txtalturaenv.Text
                ELESPECI_TBE.aet1 = txto2.Text
                ELESPECI_TBE.aet2 = txtm2.Text
                ELESPECI_TBE.aet3 = txtp2.Text
                ELESPECI_TBE.diametro_interno = txtdiainterno.Text
                ELESPECI_TBE.Di1 = txto3.Text
                ELESPECI_TBE.Di2 = txtm3.Text
                ELESPECI_TBE.Di3 = txtp3.Text
                ELESPECI_TBE.diametro_externo = txtdexterno.Text
                ELESPECI_TBE.De1 = txto4.Text
                ELESPECI_TBE.De2 = txtm4.Text
                ELESPECI_TBE.De3 = txtp4.Text
                ELESPECI_TBE.ancho_envase = txtanchenv.Text
                ELESPECI_TBE.ae1 = txto5.Text
                ELESPECI_TBE.ae2 = txtm5.Text
                ELESPECI_TBE.ae3 = txtp5.Text
                ELESPECI_TBE.largo_envase = txtlargenv.Text
                ELESPECI_TBE.le1 = txto6.Text
                ELESPECI_TBE.le2 = txtm6.Text
                ELESPECI_TBE.le3 = txtp6.Text
                ELESPECI_TBE.altura_tapa = txtalttapa.Text
                ELESPECI_TBE.ata1 = txto7.Text
                ELESPECI_TBE.ata2 = txtm7.Text
                ELESPECI_TBE.ata3 = txtp7.Text
                ELESPECI_TBE.peso_envase = txtpesoenv.Text
                ELESPECI_TBE.pe1 = txto8.Text
                ELESPECI_TBE.pe2 = txtm8.Text
                ELESPECI_TBE.pe3 = txtp8.Text
                ELESPECI_TBE.altura_asa = txtalt_asa.Text
                ELESPECI_TBE.aa1 = txto9.Text
                ELESPECI_TBE.aa2 = txtm9.Text
                ELESPECI_TBE.aa3 = txtp9.Text

                ELESPECI_TBE.acabado_F_envase = txtes1.Text
                ELESPECI_TBE.embalaje_primario = txtes2.Text
                ELESPECI_TBE.embalaje_secundario = txtes3.Text
                ELESPECI_TBE.separadores = txtes4.Text
                ELESPECI_TBE.nro_envase = txtes5.Text

                ELESPECI_TBE.espesor_hojalata = txtes6.Text
                ELESPECI_TBE.temple_hojalata = txtes7.Text

                gsError = ELESPECI_TBL.SaveRow(ELESPECI_TBE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Private Function OkData() As Boolean

        If txtcod_art.Text = "" Then
            MsgBox("Ingrese el Articulo", MsgBoxStyle.Exclamation)
            txtcod_art.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            If ELESPECI_TBL.VerificarRepetido(txtcod_art.Text) = True Then
                MsgBox("Ya Existe el codigo registrado", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)
        End If
        Select Case sFunc

            Case "save"
                SaveData()
                Exit Sub
            Case "delete"
                'DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub txtcod_art_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod_art.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "94"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcod_art.Text = gLinea
                lblcod_art.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcod_art.LostFocus
        If (txtcod_art.Text = "") Then
            lblcod_art.Text = ""
        Else
            Dim dt As DataTable
            dt = ELESPECI_TBL.SelectArt4(txtcod_art.Text)
            If dt.Rows.Count > 0 Then
                txtcod_art.Text = dt.Rows(0).Item(0).ToString
                lblcod_art.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcod_art.Text = ""
                lblcod_art.Text = ""
            End If
        End If
    End Sub

    Private Sub txto1_LostFocus(sender As Object, e As EventArgs) Handles txto1.LostFocus, txtm1.LostFocus
        If (txto1.Text = "") And txtm1.Text <> "" Then
            txtp1.Text = txtm1.Text
        ElseIf (txtm1.Text = "") And txto1.Text <> "" Then
            txtp1.Text = txto1.Text
        ElseIf (txtm1.Text = "") And txto1.Text = "" Then
            txtp1.Text = ""
        Else
            txtp1.Text = FormatNumber((CDbl(txtm1.Text) + CDbl(txto1.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto2_LostFocus(sender As Object, e As EventArgs) Handles txto2.LostFocus, txtm2.LostFocus
        If (txto2.Text = "") And txtm2.Text <> "" Then
            txtp2.Text = txtm2.Text
        ElseIf (txtm2.Text = "") And txto2.Text <> "" Then
            txtp2.Text = txto2.Text
        ElseIf (txtm2.Text = "") And txto2.Text = "" Then
            txtp2.Text = ""
        Else
            txtp2.Text = FormatNumber((CDbl(txtm2.Text) + CDbl(txto2.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto3_LostFocus(sender As Object, e As EventArgs) Handles txto3.LostFocus, txtm3.LostFocus
        If (txto3.Text = "") And txtm3.Text <> "" Then
            txtp3.Text = txtm3.Text
        ElseIf (txtm3.Text = "") And txto3.Text <> "" Then
            txtp3.Text = txto3.Text
        ElseIf (txtm3.Text = "") And txto3.Text = "" Then
            txtp3.Text = ""
        Else
            txtp3.Text = FormatNumber((CDbl(txtm3.Text) + CDbl(txto3.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto4_LostFocus(sender As Object, e As EventArgs) Handles txto4.LostFocus, txtm4.LostFocus
        If (txto4.Text = "") And txtm4.Text <> "" Then
            txtp4.Text = txtm4.Text
        ElseIf (txtm4.Text = "") And txto4.Text <> "" Then
            txtp4.Text = txto4.Text
        ElseIf (txtm4.Text = "") And txto4.Text = "" Then
            txtp4.Text = ""
        Else
            txtp4.Text = FormatNumber((CDbl(txtm4.Text) + CDbl(txto4.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto5_LostFocus(sender As Object, e As EventArgs) Handles txto5.LostFocus, txtm5.LostFocus
        If (txto5.Text = "") And txtm5.Text <> "" Then
            txtp5.Text = txtm5.Text
        ElseIf (txtm5.Text = "") And txto5.Text <> "" Then
            txtp5.Text = txto5.Text
        ElseIf (txtm5.Text = "") And txto5.Text = "" Then
            txtp5.Text = ""
        Else
            txtp5.Text = FormatNumber((CDbl(txtm5.Text) + CDbl(txto5.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto6_LostFocus(sender As Object, e As EventArgs) Handles txto6.LostFocus, txtm6.LostFocus
        If (txto6.Text = "") And txtm6.Text <> "" Then
            txtp6.Text = txtm6.Text
        ElseIf (txtm6.Text = "") And txto6.Text <> "" Then
            txtp6.Text = txto6.Text
        ElseIf (txtm6.Text = "") And txto6.Text = "" Then
            txtp6.Text = ""
        Else
            txtp6.Text = FormatNumber((CDbl(txtm6.Text) + CDbl(txto6.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto7_LostFocus(sender As Object, e As EventArgs) Handles txto7.LostFocus, txtm7.LostFocus
        If (txto7.Text = "") And txtm7.Text <> "" Then
            txtp7.Text = txtm7.Text
        ElseIf (txtm7.Text = "") And txto7.Text <> "" Then
            txtp7.Text = txto7.Text
        ElseIf (txtm7.Text = "") And txto7.Text = "" Then
            txtp7.Text = ""
        Else
            txtp7.Text = FormatNumber((CDbl(txtm7.Text) + CDbl(txto7.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto8_LostFocus(sender As Object, e As EventArgs) Handles txto8.LostFocus, txtm8.LostFocus
        If (txto8.Text = "") And txtm8.Text <> "" Then
            txtp8.Text = txtm8.Text
        ElseIf (txtm8.Text = "") And txto8.Text <> "" Then
            txtp8.Text = txto8.Text
        ElseIf (txtm8.Text = "") And txto8.Text = "" Then
            txtp8.Text = ""
        Else
            txtp8.Text = FormatNumber((CDbl(txtm8.Text) + CDbl(txto8.Text)) / 2, 2)
        End If
    End Sub
    Private Sub txto9_LostFocus(sender As Object, e As EventArgs) Handles txto9.LostFocus, txtm9.LostFocus
        If (txto9.Text = "") And txtm9.Text <> "" Then
            txtp9.Text = txtm9.Text
        ElseIf (txtm9.Text = "") And txto9.Text <> "" Then
            txtp9.Text = txto9.Text
        ElseIf (txtm9.Text = "") And txto9.Text = "" Then
            txtp9.Text = ""
        Else
            txtp9.Text = FormatNumber((CDbl(txtm9.Text) + CDbl(txto9.Text)) / 2, 2)
        End If
    End Sub

    Private Sub FormELESPECIFICACIONES_t_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class