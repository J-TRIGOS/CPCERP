Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormObsRecepDoc
    Private ELTBRECEPCOMPBL As New ELTBRECEPCOMPBL
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dt As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dt = ELTBRECEPCOMPBL.SelectRow2(sT_Ref, sS_Ref, sN_Ref, sCos)
        For Each Registro In dt.Rows
            txtfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            cmbobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            txtserie.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtproveedor.Text = IIf(IsDBNull(Registro("NOM_PROVEEDOR")), "", Registro("NOM_PROVEEDOR"))
            txtarticulo.Text = IIf(IsDBNull(Registro("NOM_ART")), "", Registro("NOM_ART"))
            Label7.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
            If IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "LA ORDEN NO TIENE FIRMA" And IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "EL DOCUMENTO ES UNA COPIA" And
                IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "NO TIENE GUIA DE REMISION" And IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "NUMERO DE FACTURA ERRONEO" And
                IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "NUMERO DE ORDEN DE COMPRA ERRONEO" And IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "FALTAN ARTICULOS" And
                IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA")) <> "NUMERO DE GUIA ERRONEO" Then
                cmbobserva.Text = "OTROS - ESPECIFICAR"
                txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            End If
        Next
    End Sub
    Private Sub FormObsRecepDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData(sTDoc, sSDoc, sNDoc)
    End Sub

    Private Sub FormObsRecepDoc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub SaveData()

        If MessageBox.Show("Desea observar la Recepcion",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBRECEPCOMPBE As New ELTBRECEPCOMPBE
        Dim ELTBDETRECEPCOMPBE As New ELTBDETRECEPCOMPBE
        Dim ELMVALMABE As New ELMVALMABE

        ELTBDETRECEPCOMPBE.T_DOC_REF = "RDOC"
        ELTBDETRECEPCOMPBE.NRO_DOC_REF = txtnumero.Text
        ELTBDETRECEPCOMPBE.SER_DOC_REF = txtserie.Text
        ELTBDETRECEPCOMPBE.USUARIO_OB = gsCodUsr
        ELTBDETRECEPCOMPBE.ART_COD = txtarticulo.Text
        If cmbobserva.Text = "OTROS - ESPECIFICAR" Then
            ELTBDETRECEPCOMPBE.OBSERVA = txtobserva.Text
        Else
            ELTBDETRECEPCOMPBE.OBSERVA = cmbobserva.Text
        End If

        ELMVLOGSBE.log_codusu = gsCodUsr
        Dim dt As DataGridView

        gsError = ELTBRECEPCOMPBL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, "DD", dt)
        'gsError2 = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CN", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'tsbGrabar.Enabled = False
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        SaveData()
    End Sub
End Class