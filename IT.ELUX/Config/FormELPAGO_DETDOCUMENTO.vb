FILE0  "^�     m. 8  h                �            `           H      :��Jc���Q
c���Q
c�:��Jc�                                      0   �          h     7     :��Jc�:��Jc�:��Jc�:��Jc�                         F o r m D o c u R e f C o n . r e s x �   H                        @               B      B      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      BAADBIOBL.SelectRow(DateTime.Now.ToString("dd/MM/yyyy"))
        If dtUsuario.Rows.Count > 0 Then
            For Each Registro In dtUsuario.Rows
                lbltcambio.Text = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
            Next
        Else
            MsgBox("No hay Tipo de Cambio para este dia", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If OkData() = False Then
            Exit Sub
        Else

            If flagAccion1 = "N" Then
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows.Add(txtt_doc.Text, txtserie.Text, txtnumero.Text,
                         cmbafecto.SelectedItem, txtcuenta.Text, lbldestino.Text, FormELPAGO_DOCUMENTO.txtproveedor.Text, FormELPAGO_DOCUMENTO.lblproveedor.Text,
                         lblsigno.Text, dtpcom_fech.Value, lbltcambio.Text, txtmon.Text, lblmon.Text, txtsoles.Text,
                         txtdolar.Text, txtsoles.Text, txtdolar.Text)
 FILE0  H_�     sg 8  h                �            `           H      ���Jc�J��Q
c�J��Q
c����Jc�                                      0   �          d     7     ���Jc����Jc����Jc����Jc� @                       F o r m D o c u R e f C o n . v b     �   H                        @        @      >      >      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      BAADAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("Moneda").Value = lblmon.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_Soles").Value = txtsoles.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("T_dolares").Value = txtdolar.Text
                FormELPAGO_DOCUMENTO.dgvt_doc.Rows(gsCode5).Cells("signo").Value = lblsigno.Text

                dgvt_docdet.Rows(gsCode5).Cells("T_DOC_REF").Value = txtt_doc.Text
                dgvt_docdet.Rows(gsCode5).Cells("SERIE_DOC_REF").Value = txtserie.Text
                dgvt_docdet.Rows(gsCode5).Cells("NRO_DOC").Value = txtnumero.Text
                dgvt_docdet.Rows(gsCode5).Cells("AFECTO").Value = cmbafecto.SelectedItem
                dgvt_docdet.Rows(gsCode5).Cells("CUENTA2").Value = txtcuenta.Text
                dgvt_docdet.Rows(gsCode5).Cells("CTA_DES").Value = lbldestino.Text
                dgvt_docdet.Rows(gsCode5).Cells("FECHA").Value = dtpcom_fech.Value
                dgvt_docdet.Rows(gsCode5).Cells("T_cambio").FILE0  �`�     io 8  �                �            `           H      �G��Jc���Q
c���Q
c��G��Jc�                                      0   �          ~     7     �G��Jc��G��Jc��G��Jc��G��Jc� @                       F o r m D o c u R e f C o n t a f f . D e s i g n e r . v b   �   H                        @        @      �=      �=      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              FILE0  �a�     o" 8  p                �            `           H      �(��Jc�)�Q
c�)�Q
c��(��Jc�                                      0   �          p     7     �(��Jc��(��Jc��(��Jc��(��Jc�                         F o r m D o c u R e f C o n t a f f . r e s x �   H                        @               B      B      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              FILE0  �b�     cc 8  p                �            `           H      e��Jc�{��Q
c�{��Q
c�e��Jc�                                      0   �          l     7     e��Jc�e��Jc�e��Jc�e��Jc� �                       F o r m D o c u R e f C o n t a f f . v b     �   H                        @        �      =�      =�      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              FILE0  d�     al 8  x                �            `           H      ����Jc�	��Q
c�	��Q
c�����Jc�                                      0   �          v     7     ����Jc�����Jc�����Jc�����Jc� 0                       F o r m D o c u R e f D e t . D e s i g n e r . v b   �   H                        @        0      �.      �.      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      FILE0  1e�     b
 8  h                �            `           H      ����Jc����Q
c����Q
c�����Jc�                                      0   �          h     7     ����Jc�����Jc�����Jc�����Jc�                         F o r m D o c u R e f D e t . r e s x �   H                        @               B      B      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      FILE0  zf�      E 8  h                �            `           H      ����Jc����Q
c����Q
c�����Jc�                                      0   �          d     7     ����Jc�����Jc�����Jc�����Jc�                         F o r m D o c u R e f D e t . v b     �   H                        @               �      �      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      FILE0  �g�        8  x                �            `           H      d��Jc����Q
c����Q
c�d��Jc�                                      0   �          v     7     d��Jc�d��Jc�d��Jc�d��Jc� 0                       F o r m D o c u R e f E v a . D e s i g n e r . v b   �   H                        @        0      f       f       1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      FILE0  �h�     ey 8  h                �            `           H      ���Jc�^��Q
c�^��Q
c����Jc�                                      0   �          h     7     ���Jc����Jc����Jc����Jc�                         F o r m D o c u R e f E v a . r e s x �   H                        @               B      B      1�� �������yG                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      FILE0  j�        8  h                �            `           H      Ï��Jc�5}�Q
c�5}�Q
c�Ï��Jc�                                      0   �          d     7     Ï��Jc�Ï��Jc�Ï��Jc�Ï��Jc� 0                       F o r m D o c u R e f E v a . v b     