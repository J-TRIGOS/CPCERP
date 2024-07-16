Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormProcesarHora
    Public sTIPO As String
    Public sSERIE As String
    Public sNumero As String
    Public sFecha As Date
    Dim ELTBSTIEMBL As New ELTBSTIEMBL
    Dim ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnprocesar_Click(sender As Object, e As EventArgs) Handles btnprocesar.Click
        'If ELTBDETSTIEMBL.SelPrdo(dtpfecha.Value.Year & (dtpfecha.Value.Month).ToString.PadLeft(2, "0")) = "0" Then
        '    MsgBox("Debe agregar el periodo en la tabla de periodos")
        '    Exit Sub
        'Else
        SaveData()
        'End If

    End Sub

    Private Sub FormProcesarHora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ELTBDETSTIEMBL.SelPrdo(DateTime.Now.Year & (DateTime.Now.ToString("MM")).ToString.PadLeft(2, "0")) = "0" Then
            MsgBox("Debe agregar el periodo en la tabla de periodos")
            Dispose()
        Else
            txt_periodo.Text = ELTBDETSTIEMBL.SelPrdo(dtpfecha.Value.Year & (dtpfecha.Value.Month).ToString.PadLeft(2, "0"))
        End If
        Dim dt As DataTable
        dgvtiemper.Columns.Add("Codigo", "Codigo")
        dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
        dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
        dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
        dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
        dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
        dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
        dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
        dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
        dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
        dt = ELTBDETSTIEMBL.SelectRow(sTIPO, sSERIE, sNumero)
        'Recorre el data row para mostrar en el grid
        For Each row As DataRow In dt.Rows
            dgvtiemper.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")),
                                IIf(IsDBNull(row("Nombre")), "", row("Nombre")),
                                IIf(IsDBNull(row("ACT_REALIZAR")), "", row("ACT_REALIZAR")),
                                IIf(IsDBNull(row("Hora_Inicio")), "", row("Hora_Inicio")),
                                IIf(IsDBNull(row("HORA_TERMINO")), "", row("HORA_TERMINO")),
                                IIf(IsDBNull(row("USUARIO_RP")), "", row("USUARIO_RP")),
                                IIf(IsDBNull(row("NUM")), "", row("NUM")),
                                IIf(IsDBNull(row("NUM_DIF")), "", row("NUM_DIF")),
                                IIf(IsDBNull(row("FEC_INICIO")), "", row("FEC_INICIO")),
                                IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")))
            dtpfecha.Value = IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE"))
        Next
        'Borra la caracteristica de la base de datos
        dgvtiemper.Refresh()
    End Sub

    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim dtUsuario As DataTable
        ' Dim dt As DataTable
        Dim nro As String
        Dim peso As Double = 0
        Dim mesaño As String
        Dim m As String
        Dim ELTBSTIEMBE As New ELTBSTIEMBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE
        'Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        ELTBSTIEMBE.T_DOC_REF = sTIPO
        ELTBSTIEMBE.SER_DOC_REF = sSERIE
        ELTBSTIEMBE.NRO_DOC_REF = sNumero
        ELTBSTIEMBE.USUARIO = gsCodUsr
        ELTBSTIEMBE.FEC_GENE = dtpfecha.Value
        ELTBSTIEMBE.LINEA = txtlinea.Text
        ELTBSTIEMBE.PRDO = Trim(txt_periodo.Text)
        'If chkprocesar.Checked = True Then
        '    ELTBSTIEMBE.OP = "1"
        'Else
        '    ELTBSTIEMBE.OP = "0"
        'End If
        If dtpfecha.Value.DayOfWeek = 0 Then
            ELTBSTIEMBE.OP = "1"
        Else
            ELTBSTIEMBE.OP = "0"
        End If

        gsError = ELTBSTIEMBL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, "HEPROG", dgvtiemper)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo.Text = gLinea
                dtpfec_ini.Value = gArt
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
End Class