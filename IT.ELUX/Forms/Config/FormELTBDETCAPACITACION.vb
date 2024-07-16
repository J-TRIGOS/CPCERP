Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.IO
Public Class FormELTBDETCAPACITACION
    Private PERBL As New PERBL
    Dim bPrimero As Boolean
    Public tipo As String
    Public ser As String
    Public nro As String
    Public nro1 As String
    Public img As String
    Public Direc As String
    Public nombreArchivo As String
    ' Public Property AxAcroPDF1 As Object
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormELTBDETCAPACITACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Me.Text = "Personal Capacitados"

        lbl1.Text = tipo
        lbl2.Text = ser
        lbl3.Text = nro

        Select Case gnOpcion
            Case 0
                flagAccion = "N"

                If sBusAlm = "FARDODETALMACEN" Then
                    nuevo("1")
                Else
                    nro1 = FormELTBCAPACITACION.dgvt_doc.Rows.Count + 1
                    If nro1.Length = 1 Then
                        nro1 = "000000" & nro1
                    ElseIf nro.Length = 2 Then
                        nro1 = "00000" & nro1
                    ElseIf nro1.Length = 3 Then
                        nro1 = "0000" & nro1
                    ElseIf nro1.Length = 4 Then
                        nro = "000" & nro1
                    ElseIf nro1.Length = 5 Then
                        nro1 = "00" & nro1
                    ElseIf nro1.Length = 6 Then
                        nro1 = "0" & nro1
                    ElseIf nro1.Length = 7 Then
                        nro1 = nro1
                    End If


                    For z = 0 To FormELTBCAPACITACION.dgvt_doc.Rows.Count - 1
                        If FormELTBCAPACITACION.dgvt_doc.Rows(z).Cells("NRO_DOC_REF1").Value >= nro1 Then
                            nro1 = FormELTBCAPACITACION.dgvt_doc.Rows(z).Cells("NRO_DOC_REF1").Value + 1
                            If nro1.Length = 1 Then
                                nro1 = "000000" & nro1
                            ElseIf nro.Length = 2 Then
                                nro1 = "00000" & nro1
                            ElseIf nro1.Length = 3 Then
                                nro1 = "0000" & nro1
                            ElseIf nro1.Length = 4 Then
                                nro = "000" & nro1
                            ElseIf nro1.Length = 5 Then
                                nro1 = "00" & nro1
                            ElseIf nro1.Length = 6 Then
                                nro1 = "0" & nro1
                            ElseIf nro1.Length = 7 Then
                                nro1 = nro1
                            End If
                        End If
                    Next
                End If
            Case 1
                flagAccion = "M"
                If sBusAlm = "FARDODETALMACEN" Then
                    modificar("1")
                Else
                    txtper_LostFocus(sender, e)
                    txtlinea_cod_LostFocus(sender, e)
                    nro1 = FormELTBCAPACITACION.dgvt_doc.Rows(FormELTBCAPACITACION.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                    If Len(lblPdf.Text) > 0 Then
                        Console.WriteLine(AxAcroPDF1.LoadFile(lblPdf.Text))
                        AxAcroPDF1.Visible = True
                        PictureBox2.Visible = False
                    End If
                End If
        End Select
        bPrimero = False
    End Sub
    Private Sub nuevo(ByVal Cod As String)
        If Cod = "1" Then
            Button8.Visible = False
            AxAcroPDF1.Visible = True
            GroupBox4.Visible = True
        End If
    End Sub
    Private Sub modificar(ByVal Cod As String)
        If Cod = "1" Then
            'txtper_LostFocus(sender, e)
            'txtlinea_cod_LostFocus(sender, e)
            ' nro1 = FormELTBCAPACITACION.dgvt_doc.Rows(FormELTBCAPACITACION.dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            If lblPdf.Text <> "ArchivoPDF" Then
                Console.WriteLine(AxAcroPDF1.LoadFile(lblPdf.Text))
                AxAcroPDF1.Visible = True
                PictureBox2.Visible = False
                Button8.Visible = False
                GroupBox4.Visible = True
            End If
        End If
    End Sub
    Private Sub txtper_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "5"
            Dim frm As New FormPerGrupo
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper.Text = gLinea
                txtnomper.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtper_LostFocus(sender As Object, e As EventArgs) Handles txtper.LostFocus
        If txtper.TextLength = 8 Then
            txtnomper.Text = PERBL.SelectApeNom(txtper.Text)
        Else
            txtnomper.Text = ""
        End If
    End Sub
    Private Sub txtlinea_cod_LostFocus(sender As Object, e As EventArgs) Handles txtlinea_cod.LostFocus
        If txtlinea_cod.Text <> "" Then
            txtnom_linea.Text = PERBL.SelectLineaNom(txtlinea_cod.Text)
        Else
            txtnom_linea.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "5"
        Dim frm As New FormPerGrupo
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtper.Text = gLinea
            txtnomper.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "71"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtlinea_cod.Text = gLinea
            txtnom_linea.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtlinea_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "71"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtlinea_cod.Text = gLinea
                txtnom_linea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub btncargararch_Click(sender As Object, e As EventArgs) Handles btncargararch.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg|PNG|*.png|PDF|*.pdf"
        If file.ShowDialog() = DialogResult.OK Then
            ' PictureBox1.Image = Image.FromFile(file.FileName)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If gContador <> 0 Then
            For z = 0 To FormELTBCAPACITACION.dgvt_doc.Rows.Count - 1
                If FormELTBCAPACITACION.dgvt_doc.Rows(z).Cells("PER_COD").Value = txtper.Text Then
                    MsgBox("Se repite los registros")
                    Exit Sub
                End If
            Next
        End If

        If txtper.Text = Nothing Or txtnomper.Text = Nothing Then
            MsgBox("Ingresar Personal")
            txtper.Select()
            Exit Sub
        End If

        If txtlinea_cod.Text = Nothing Or txtnom_linea.Text = Nothing And GroupBox1.Enabled = True Then
            MsgBox("Ingresar Area")
            txtlinea_cod.Select()
            Exit Sub
        End If

        If Me.PictureBox1.Image Is Nothing Then
            'MsgBox("Ingresar Imagen")
            'btncargararch.Select()
            'Exit Sub
        Else
            Dim folder As String
            ' Nombre de la carpeta
            ' folder = Path.Combine(Application.StartupPath, "CAPACITACION")
            folder = Path.Combine(gsIpserver & "\CAPACITACION\")
            '  ' Si no existe la carpeta, la creamos
            '  If (Not Directory.Exists(folder)) Then
            '      Directory.CreateDirectory(folder)
            '  End If
            Try
                ' Nombre del archivo.
                Dim fileName As String = Path.Combine(folder, tipo + ser + nro + txtper.Text + ".jpg")
                ' Guardamos en disco la imagen existente en el control PictureBox,
                ' sobrescribiendo sin previo aviso cualquier otro archivo existente
                ' con igual nombre.
                PictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
                ' Se ha producido un error.
                MessageBox.Show(ex.Message)
            End Try
        End If



        If flagAccion = "N" And gContador <> 0 Or gContador <> 0 Then
            FormELTBCAPACITACION.dgvt_doc.Rows.Add(FormELTBCAPACITACION.txtt_doc.Text, '0
                                                   FormELTBCAPACITACION.cmb_serdoc.Text,'1
                                                   FormELTBCAPACITACION.txtnumero.Text, '2
                                                   tipo, '3
                                                   ser,'4
                                                   nro1, '5
                                                   txtper.Text, '6
                                                   txtlinea_cod.Text) '8
            Dispose()
        ElseIf flagAccion = "M" Then
            FormELTBCAPACITACION.dgvt_doc.Rows(FormELTBCAPACITACION.dgvt_doc.CurrentRow.Index).Cells("PER_COD").Value = txtper.Text
            FormELTBCAPACITACION.dgvt_doc.Rows(FormELTBCAPACITACION.dgvt_doc.CurrentRow.Index).Cells("LINEA_COD").Value = txtlinea_cod.Text
            Dispose()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Abre imagen del Directorio creado en el debug
        PictureBox1.ImageLocation = Application.StartupPath & "\CAPACITACION\NuevaImagen1.jpg"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Direccion del Directorio en el debug
        Dim folder As String = Path.Combine(Application.StartupPath, "CAPACITACION")
        ' Filtra si Existe el Directorio
        If Directory.Exists(folder) Then
            'Elimna El Directorio y Contenido
            My.Computer.FileSystem.DeleteDirectory(folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Else
            MsgBox("Directorio no existe")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Mueve todo el contenido del Directorio a Otro
        Dim folder As String = Path.Combine(Application.StartupPath, "CAPACITACION")
        My.Computer.FileSystem.CopyDirectory(folder, gsIpserver & "\Reunion y Auditorias", True)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Abre imagen guardada en el Directorio del Servidor
        Me.PictureBox1.Image = Image.FromFile(gsIpserver & "\Reunion y Auditorias\NuevaImagen1.jpg")
    End Sub

    Private Sub FormELTBDETCAPACITACION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg|PNG|*.png"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(file.FileName)
        Else
            Exit Sub
        End If
        img = 1
        PictureBox2.Visible = True
        AxAcroPDF1.Visible = False

        '  OpenFileDialog1.Filter = "PDF | *.pdf"
        '  If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '      AxAcroPDF1.src = OpenFileDialog1.FileName
        '  End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If img = 1 Then
            If Me.PictureBox2.Image Is Nothing Then
                MsgBox("Ingresar Imagen")
                Exit Sub
            End If
        Else
            If Me.AxAcroPDF1.src Is Nothing Then
                MsgBox("Ingresar PDF")
                Exit Sub
            End If
        End If
        AgregarPDF()
        Dispose()
    End Sub
    Private Sub AgregarPDF()
        If sBusAlm = "FARDODETALMACEN" Then
            Dim folder As String
            folder = Path.Combine(gsIpserver & "\GestionHumanaPDF\")
            Try
                If flagAccion = "M" Then
                    If (folder + nombreArchivo) = (folder + lblPdf.Text) Then
                        MessageBox.Show("No se puede modificar el mismo documento.")
                        Exit Sub
                    Else
                        System.IO.File.Delete(Path.Combine(folder, lblPdf.Text))
                    End If
                Else
                    System.IO.File.Delete(Path.Combine(folder, nombreArchivo))
                End If
                Dim fileName As String = Path.Combine(folder, nombreArchivo)
                System.IO.File.Delete(fileName)
                System.IO.File.Copy(Direc, fileName)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            FormSistIntCalidad.lblNomPDF.Text = nombreArchivo 'Left(nombreArchivo, 4,1)
        Else
            Dim folder As String
            ' Nombre de la carpeta
            ' folder = Path.Combine(Application.StartupPath, "CAPACITACION")

            folder = Path.Combine(gsIpserver & "\CAPACITACION\")

            '  ' Si no existe la carpeta, la creamos
            '  If (Not Directory.Exists(folder)) Then
            '      Directory.CreateDirectory(folder)
            '  End If

            Try
                System.IO.File.Delete(Path.Combine(folder, tipo + ser + nro + ".pdf"))
                'Nombre del archivo.
                If img = 1 Then
                    Dim fileName As String = Path.Combine(folder, tipo + ser + nro + ".jpg")
                    ' Guardamos en disco la imagen existente en el control PictureBox,
                    ' sobrescribiendo sin previo aviso cualquier otro archivo existente
                    ' con igual nombre.
                    PictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Else
                    Dim fileName As String = Path.Combine(folder, tipo + ser + nro + ".pdf")
                    System.IO.File.Delete(fileName)
                    System.IO.File.Copy(Direc, fileName)
                End If

            Catch ex As Exception
                ' Se ha producido un error.
                MessageBox.Show(ex.Message)
            End Try
            FormELTBCAPACITACION.CheckBox1.Checked = True
        End If
    End Sub

    Private Sub txtper_TextChanged(sender As Object, e As EventArgs) Handles txtper.TextChanged
        txtnomper.Text = PERBL.SelectApeNom(txtper.Text)
        If txtnomper.Text <> Nothing Then

        End If
    End Sub

    Private Sub txtlinea_cod_TextChanged(sender As Object, e As EventArgs) Handles txtlinea_cod.TextChanged
        txtnom_linea.Text = PERBL.SelectLineaNom(txtlinea_cod.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '' 'MessageBox.Show("No Disponible")
        '' Dim file1 As New OpenFileDialog()
        ''
        ''
        '' file1.Filter = "PDF | *.pdf"
        ''
        '' ' If file1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '' '     AxAcroPDF1.src = file1.FileName
        '' ' End If


        Dim file As New OpenFileDialog()
        file.Filter = "PDF | *.pdf"
        If file.ShowDialog() = DialogResult.OK Then
            Console.WriteLine(AxAcroPDF1.LoadFile(file.FileName))
        Else
            Exit Sub
        End If
        img = 2
        Direc = file.FileName
        nombreArchivo = Path.GetFileName(file.FileName)
        PictureBox2.Visible = False
        AxAcroPDF1.Visible = True
    End Sub
End Class