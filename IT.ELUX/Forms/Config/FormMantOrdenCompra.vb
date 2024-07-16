Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Imports System
Imports System.Text.RegularExpressions
Imports vb = Microsoft.VisualBasic
Public Class FormMantOrdenCompra
    Private gpCaption As String
    Private gpCodUsu As String
    Private gcodcor As String = ""
    Private nNode As Integer = 0
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private PERBL As New PERBL
    Private PARCIALBL As New PARCIALBL
    Private ARTICULOBL As New ARTICULOBL
    Private CTCTBL As New CTCTBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private catalogo As String = ""
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private FLAComparacion As String
    Private MenuBL As New MenuBL
    Private cant1 As Integer = "0"
    Private pre_cs As String
    Private cant2 As String = "0"
    Private cant3 As String = "0"
    'Formulario para la creacion de ordenes de compra
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        'If bPrimero = False Then
        cmb.DataSource = dtSelect
        'If (cmbdir.Items.Count > 0) Then
        cmb.DisplayMember = sDescri

        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
        '    End If
        'End If


    End Function
#End Region

#Region "Correo"
    Function cargar_matrix()
        Dim creacion As String
        Dim dtArticulo As DataTable
        catalogo = ORDENCOMPRABL.SelectCatalogo(sArt_Cod)
        If catalogo <> Nothing Then
            dtArticulo = ARTICULOBL.getListdgv(catalogo, sArt_Cod)
            For Each row As DataRow In dtArticulo.Rows
                creacion = creacion & "<tr> <td>" & IIf(IsDBNull(row("CAR_DESCRI")), "", row("CAR_DESCRI")) & "</td>
                        <td>" & IIf(IsDBNull(row("ESP_DATO")), "", row("ESP_DATO")) & "</td>
                        </tr>"
            Next
            Return creacion
        End If
    End Function

    Function precio()
        Dim creacion As String
        Dim dtArticulo As DataTable
        'For Each row As DataRow In dtArticulo.Rows
        If txtmon.Text = "00" Then
            creacion = creacion & "<tr> <td> Total Orden:</td>
                        <td>" & cmbmon.Text & " " & dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value.ToString & "</td>
                        </tr>"
        Else
            creacion = creacion & "<tr> <td> Total Orden: </td>
                        <td>" & cmbmon.Text & " " & dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value.ToString & "</td>
                        </tr>"
        End If

        'Next
        Return creacion

    End Function

    Function precio_total()
        Dim creacion As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        If txtmon.Text = "00" Then
            creacion = creacion & "<tr> <td>Total Sin IGV:</td>
                        <td>" & cmbmon.Text & " " & DAcumula & "</td>
                        </tr>"
            If DAcumula = cant1 Then
                pre_cs = ""
            Else
                pre_cs = "<tr> <td>Total Sin IGV:</td> <td>" & cmbmon.Text & " " & cant1 & "</td> <td>" & cmbmon.Text & " " & DAcumula & "</td> </tr>"
            End If
        Else
            creacion = creacion & "<tr> <td> Total Sin IGV: </td>
                        <td>" & cmbmon.Text & " " & DAcumula1 & "</td>
                        </tr>"
            If DAcumula1 = cant1 Then
                pre_cs = ""
            Else
                pre_cs = "<tr> <td>Total Sin IGV:</td> <td>" & cmbmon.Text & " " & cant1 & "</td> <td>" & cmbmon.Text & " " & DAcumula1 & "</td> </tr>"
            End If
        End If
        Return creacion

    End Function

    Function Art_Venta()
        Dim creacion As String = ""
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim data As String
        For i = 0 To dgvt_doc.Rows.Count - 1
            'DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            'DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            'DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            'DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            'DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            'DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
            If txtmon.Text = "00" Then
                creacion = creacion & "<tr> <td> Articulo Venta (Sin IGV.) " & i + 1 & ":</td>
                        <td>" & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                        CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) &
                        "<br>P. UNIT.:" & Val(dgvt_doc.Rows(i).Cells("UPRECIO_VENTA").Value) &
                        "<br>IMPORTE:" & Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) & "</td>
                        </tr>"
                data = (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value)).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("UPRECIO_VENTA").Value)).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value)).ToString
                Dim regex As Regex = New Regex(",")
                Dim vectoraux() As String
                Dim c As Integer = 0
                vectoraux = regex.Split(cant2)
                For Each item As String In vectoraux
                    If item <> data Then
                        If vb.Left(item, 8) = vb.Left(data, 8) Then
                            cant3 = "<tr> <td>  Articulo Venta (Sin IGV.) " & i + 1 & ":</td>"
                            Dim regex1 As Regex = New Regex("[+]")
                            Dim vectoraux1() As String
                            vectoraux1 = regex1.Split(item)
                            For Each item1 As String In vectoraux1
                                c = c + 1
                                Select Case c
                                    Case 1
                                        cant3 = cant3 + "<td>" & item1 & " <br>"
                                    Case 2
                                        cant3 = cant3 + "CANTIDAD:" & item1 & " <br>"
                                    Case 3
                                        cant3 = cant3 + "P. UNIT.:" & item1 & " <br>"
                                    Case 4
                                        cant3 = cant3 + "IMPORTE:" & item1 & " </td>"
                                End Select
                            Next
                            cant3 = cant3 + "<td>" & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                                             CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) &
                                             "<br>P. UNIT.:" & Val(dgvt_doc.Rows(i).Cells("UPRECIO_VENTA").Value) &
                                             "<br>IMPORTE:" & Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) & "</td></tr>"
                        End If
                    End If
                Next
            Else
                creacion = creacion & "<tr> <td>  Articulo Venta (Sin IGV.) " & i + 1 & ":</td>
                        <td>" & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                        CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) &
                        "<br>P. UNIT.:" & Val(dgvt_doc.Rows(i).Cells("UPRECIO_DVENTA").Value) &
                        "<br>IMPORTE:" & Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) & "</td>
                        </tr>"
                data = (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value)).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("UPRECIO_DVENTA").Value)).ToString + "+" + (Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value)).ToString
                Dim regex As Regex = New Regex(",")
                Dim vectoraux() As String
                Dim c As Integer = 0

                vectoraux = regex.Split(cant2)
                For Each item As String In vectoraux
                    If item <> data Then
                        If vb.Left(item, 8) = vb.Left(data, 8) Then
                            cant3 = "<tr> <td>  Articulo Venta (Sin IGV.) " & i + 1 & ":</td>"
                            Dim regex1 As Regex = New Regex("[+]")
                            Dim vectoraux1() As String
                            vectoraux1 = regex1.Split(item)
                            For Each item1 As String In vectoraux1
                                c = c + 1
                                Select Case c
                                    Case 1
                                        cant3 = cant3 + "<td>" & item1 & " <br>"
                                    Case 2
                                        cant3 = cant3 + "CANTIDAD:" & item1 & " <br>"
                                    Case 3
                                        cant3 = cant3 + "P. UNIT.:" & item1 & " <br>"
                                    Case 4
                                        cant3 = cant3 + "IMPORTE:" & item1 & " </td>"
                                End Select
                            Next
                            cant3 = cant3 + "<td>" & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                                             CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) &
                                             "<br>P. UNIT.:" & Val(dgvt_doc.Rows(i).Cells("UPRECIO_DVENTA").Value) &
                                             "<br>IMPORTE:" & Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) & "</td>
                        </tr>"
                        End If
                    End If
                Next
            End If
        Next
        Return creacion

    End Function

    Function cargar_fec_despacho()
        Dim creacion As String
        Dim dtArticulo As DataTable
        Dim cont As Integer = 0
        dtArticulo = PARCIALBL.getListdgv("82", cmb_serdoc.Text, txtnumero.Text, dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value)
        For Each row As DataRow In dtArticulo.Rows
            cont = cont + 1
            creacion = creacion & "<tr> <td>Cantidad " + cont.ToString + ":</td> <td>" &
                                    IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")) & "</td> </tr>
                                    <tr> <td>Fecha Entrega " + cont.ToString + ":</td> <td>" &
                                    IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")) & "</td> </tr>"
        Next
        Return creacion
    End Function

    Sub enviarCorreo()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim creacion2 As String = ""
        Dim precio1 As String
        If flagAccion = "N" Then
            tipo = " ah creado la siguiente Orden:" '+ sArt_Cod
            creacion = "Creacion de Orden para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
        ElseIf flagAccion = "M" Then
            tipo = " ah modificado la siguente Orden"
            creacion = "Modificacion de Orden para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
        End If
        creacion2 = cargar_fec_despacho()
        precio1 = precio()
        If creacion2 <> Nothing Then
            Try
                Dim borde As String = "2"
                Dim size As String = "12"
                correos.To.Clear()
                correos.Body = ""
                correos.Subject = ""
                correos.To.Clear()
                correos.SubjectEncoding = System.Text.Encoding.UTF8
                creacion1 = cargar_matrix()
                correos.Body = " Estimados Señores:<br/>
                El usuario " + gsUser + tipo + "<br/>
             <table border= '" + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
                </tr>
                <tr>
                    <td>Orden de Trabajo:</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Observacion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td>
                </tr>
                <tr>
                    <td>O.C. Cliente:</td>
                    <td>" + txtoc.Text + "</td>
                </tr>
                <tr>
                    <td>Vendedor:</td>
                    <td>" + cmbvendedor.Text + "</td>
                </tr>
                <tr>
                    <td>Tipo de Venta:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>
                <tr>
                    <td>Codigo:</td>
                    <td>" + CStr(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value) + "</td>
                </tr>
                <tr>
                    <td>Descripcion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value + "</td>
                </tr>" & creacion2 & precio1 &
                "</table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
                correos.Subject = creacion
                correos.IsBodyHtml = True
                correos.BodyEncoding = System.Text.Encoding.UTF8
                For i = 0 To lstValor.Items.Count - 1
                    correos.To.Add(lstValor.Items(i).ToString)
                Next
                correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))

                correos.From = New MailAddress("sistemas@envaseslux.com.pe")
                envios.Credentials = New NetworkCredential("sistemas@envaseslux.com.pe", "Envaseslux2024.,")

                'Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.office365.com"
                envios.Port = 587
                envios.EnableSsl = True

                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else

            Try
                Dim borde As String = "2"
                Dim size As String = "12"
                correos.To.Clear()
                correos.Body = ""
                correos.Subject = ""
                correos.SubjectEncoding = System.Text.Encoding.UTF8
                creacion1 = cargar_matrix()
                correos.Body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
              <table border= " + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
                </tr>
                <tr>
                    <td>Orden de Trabajo</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Observacion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td>
                </tr>
                <tr>
                    <td>O.C. Cliente:</td>
                    <td>" + txtoc.Text + "</td>
                </tr>
                <tr>
                    <td>Vendedor:</td>
                    <td>" + cmbvendedor.Text + "</td>
                </tr>
                <tr>
                    <td>Tipo de Venta:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>
                <tr>
                    <td>Codigo:</td>
                    <td>" + CStr(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value) + "</td>
                </tr>
                <tr>
                    <td>Descripcion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value + "</td>
                </tr>
                <tr>
                    <td>Cantidad:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Cantidad").Value.ToString + "</td>
                </tr>
                <tr>
                    <td>Fecha Entrega:</td>
                    <td>" + dtpfec_prov.Value + "</td>
                </tr>" & precio1 & "</table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
                correos.Subject = creacion
                correos.IsBodyHtml = True
                correos.BodyEncoding = System.Text.Encoding.UTF8
                For i = 0 To lstValor.Items.Count - 1
                    correos.To.Add(lstValor.Items(i).ToString)
                Next
                'correos.To.Add("jalama@envaseslux.com")
                correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))
                correos.From = New MailAddress("sistemas@envaseslux.com.pe")
                envios.Credentials = New NetworkCredential("sistemas@envaseslux.com.pe", "Envaseslux2024.,")

                'Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.office365.com"
                envios.Port = 587
                envios.EnableSsl = True

                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Sub enviarCorreo1()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim creacion2 As String = ""
        'If flagAccion = "N" Then
        tipo = " ah creado un NUEVO articulo y orden"
        creacion = "Creacion de Orden para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
        'ElseIf flagAccion = "M" Then
        '    tipo = " ah MODIFICADO el siguiente articulo"
        '    creacion = "Modificacion de Articulo"
        'End If
        creacion2 = cargar_fec_despacho()
        If creacion2 <> Nothing Then
            Try
                Dim borde As String = "2"
                Dim size As String = "12"
                correos.To.Clear()
                correos.Body = ""
                correos.To.Clear()
                correos.Subject = ""
                correos.SubjectEncoding = System.Text.Encoding.UTF8
                creacion1 = cargar_matrix()
                correos.Body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
               Empresa: CENTRALPACK CORP. <br/>
             <table border= '" + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
                </tr>
                <tr>
                    <td>Orden de Trabajo</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Observacion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td>
                </tr>
                <tr>
                    <td>O.C. Cliente:</td>
                    <td>" + txtoc.Text + "</td>
                </tr>
                <tr>
                    <td>Vendedor:</td>
                    <td>" + cmbvendedor.Text + "</td>
                </tr>
                <tr>
                    <td>Tipo de Venta:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>
                <tr>
                    <td>Codigo:</td>
                    <td>" + CStr(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value) + "</td>
                </tr>
                <tr>
                    <td>Descripcion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value + "</td>
                </tr>" + creacion2 + creacion1 +
                "</table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
                correos.Subject = creacion
                correos.IsBodyHtml = True
                correos.BodyEncoding = System.Text.Encoding.UTF8
                For i = 0 To lstValor.Items.Count - 1
                    correos.To.Add(lstValor.Items(i).ToString)
                Next
                'correos.To.Add("jalama@envaseslux.com")
                correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))
                'correos.Bcc.Add("rconislla@envaseslux.com.pe")
                correos.From = New MailAddress("sistemas@envaseslux.com.pe")
                envios.Credentials = New NetworkCredential("sistemas@envaseslux.com.pe", "Envaseslux2024.,")

                'Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.office365.com"
                envios.Port = 587
                envios.EnableSsl = True

                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else

            Try
                Dim borde As String = "2"
                Dim size As String = "12"
                correos.To.Clear()
                correos.Body = ""
                correos.Subject = ""
                correos.SubjectEncoding = System.Text.Encoding.UTF8
                creacion1 = cargar_matrix()
                correos.Body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
               Empresa: CENTRALPACK CORP. <br/>
              <table border= " + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
                </tr>
                <tr>
                    <td>Orden de Trabajo</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Observacion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td>
                </tr>
                <tr>
                    <td>O.C. Cliente:</td>
                    <td>" + txtoc.Text + "</td>
                </tr>
                <tr>
                    <td>Vendedor:</td>
                    <td>" + cmbvendedor.Text + "</td>
                </tr>
                <tr>
                    <td>Tipo de Venta:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>
                <tr>
                    <td>Codigo:</td>
                    <td>" + CStr(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value) + "</td>
                </tr>
                <tr>
                    <td>Descripcion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value + "</td>
                </tr>
                <tr>
                    <td>Cantidad:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("Cantidad").Value.ToString + "</td>
                </tr>
                <tr>
                    <td>Fecha Entrega:</td>
                    <td>" + dtpfec_prov.Value + "</td>
                </tr>" + creacion1 +
                "</table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
                correos.Subject = creacion
                correos.IsBodyHtml = True
                correos.BodyEncoding = System.Text.Encoding.UTF8
                For i = 0 To lstValor.Items.Count - 1
                    correos.To.Add(lstValor.Items(i).ToString)
                Next
                'If creacion1.Length > 0 Then

                'Else
                'correos.To.Add("jalama@envaseslux.com")
                'End If

                correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))
                correos.From = New MailAddress("sistemas@envaseslux.com.pe")
                envios.Credentials = New NetworkCredential("sistemas@envaseslux.com.pe", "Envaseslux2024.,")

                'Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.office365.com"
                envios.Port = 587
                envios.EnableSsl = True

                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Sub enviarCorreo2()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim creacion2 As String = ""
        Dim creacion3 As String = ""
        Dim body As String = ""
        Dim body1 As String = ""
        If flagAccion = "N" Then
            tipo = " ah creado una nueva orden"
        Else
            tipo = " ah modificado una orden"
        End If
        If flagAccion = "N" Then
            creacion = cmbt_movinv.Text + "- Creacion de Orden para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
        Else
            creacion = cmbt_movinv.Text + "- Modificacion de Orden para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
        End If

        'ElseIf flagAccion = "M" Then
        '    tipo = " ah MODIFICADO el siguiente articulo"
        '    creacion = "Modificacion de Articulo"
        'End If
        'creacion2 = cargar_fec_despacho()
        creacion1 = precio_total()

        creacion3 = Art_Venta()

        'If creacion2 <> Nothing Then 
        Try
            Dim borde As String = "2"
            Dim size As String = "12"
            correos.To.Clear()
            correos.Body = ""
            correos.To.Clear()
            correos.Subject = ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            'creacion1 = cargar_matrix()
            body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
               Empresa: CENTRALPACK CORP.<br/>
             <table border= '" + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
                </tr>
                <tr>
                    <td>Orden de Trabajo</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Observacion:</td>
                    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td>
                </tr>
                <tr>
                    <td>O.C. Cliente:</td>
                    <td>" + txtoc.Text + "</td>
                </tr>
                <tr>
                    <td>Vendedor:</td>
                    <td>" + cmbvendedor.Text + "</td>
                </tr>
                <tr>
                    <td>Tipo de Venta:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>
                <tr>
                    <td>Forma de Pago:</td>
                    <td>" + cmbt_pago.Text + "</td>
                </tr>" + creacion1 + creacion3 + "
                </table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            If flagAccion = "M" Then
                Dim pt As Integer = 0
                Dim c As Integer = 0
                Dim regex As Regex = New Regex(",")
                Dim vectoraux() As String
                vectoraux = regex.Split(FLAComparacion)
                body1 = " <br/> <table border= '" + borde + "' style='font-size:" + size + "px'>"
                For Each item As String In vectoraux
                    c = c + 1
                    Select Case c
                        Case 1
                            If item <> (txtctct_cod.Text & "-" & cmbctct_cod.Text).ToString Then
                                body1 = body1 + "<tr> <td>Razon Social</td> <td>" + item + "</td> <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 2
                            If item <> (cmb_serdoc.Text & "-" & txtnumero.Text) Then
                                body1 = body1 + "<tr> <td>Orden de Trabajo</td> <td>" + item + "</td> <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 3
                            If item <> (dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value) Then
                                body1 = body1 + "<tr> <td>Observacion</td> <td>" + item + "</td> <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 4
                            If item <> (txtoc.Text) Then
                                body1 = body1 + "<tr> <td>O.C. Cliente:</td> <td>" + item + "</td> <td>" + txtoc.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 5
                            If item <> (cmbvendedor.Text) Then
                                body1 = body1 + "<tr> <td>Vendedor:</td> <td>" + item + "</td> <td>" + cmbvendedor.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 6
                            If item <> (cmbt_movinv.Text) Then
                                body1 = body1 + "<tr> <td>Tipo de Venta:</td> <td>" + item + "</td> <td>" + cmbt_movinv.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                        Case 7
                            If item <> (cmbt_pago.Text) Then
                                body1 = body1 + "<tr> <td>Forma de Pago:</td> <td>" + item + "</td> <td>" + cmbt_pago.Text + "</td> </tr>"
                                pt = pt + 1
                            End If
                    End Select
                Next
                If pre_cs <> "" Then
                    body1 = body1 + pre_cs
                    pt = pt + 1
                    pre_cs = ""
                End If

                If cant3 <> "" Then
                    body1 = body1 + cant3
                    pt = pt + 1
                    cant3 = ""
                End If
                If pt = 0 Then
                    body1 = ""
                Else
                    body1 = body1 + "</table>"
                End If
            End If
            correos.Body = body + body1
            body1 = ""
            '<tr>
            '    <td>Descripcion:</td>
            '    <td>" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value + "</td>
            '</tr>" + creacion2 + creacion1 +

            correos.Subject = creacion
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
            'If flagAccion = "N" Then
            '    correos.Bcc.Add("rconislla@envaseslux.com.pe")
            'End If

            'correos.To.Add("jalama@envaseslux.com")
            'correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))
            correos.From = New MailAddress("sistemas@envaseslux.com.pe")
            envios.Credentials = New NetworkCredential("sistemas@envaseslux.com.pe", "Envaseslux2024.,")

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.office365.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

    Private Sub CleanVar()

        txtt_doc.Clear()
        cmb_serdoc.SelectedIndex = -1
        txtnumero.Clear()
        cmbestado.SelectedIndex = -1
        'txtc_costo.Clear()
        'cmbc_costo.SelectedIndex = -1
        dtpfanul.Checked = False
        txtnumero.Clear()

    End Sub

    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        btnborrar.Enabled = est
    End Sub

    Private Function OkData() As Boolean

        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtt_doc.Text = "" Then
            MsgBox("Ingrese descripcion el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If flagAccion = "N" Then
            If txtoc.Text = "" Then
                MsgBox("Ingrese el numero de Orden de Compra del cliente", MsgBoxStyle.Exclamation)
                txtoc.Focus()
                Return False
            Else
                Dim a As String = ORDENCOMPRABL.SelectOC(txtctct_cod.Text, txtoc.Text)
                If a.Length > 0 Then
                    MsgBox("Este numero de Orden de Cliente ya esta siendo usado por la orden: " & a & " favor ponga uno disponible", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If
        End If

        If txtt_pago.Text = "" Or cmbt_pago.SelectedIndex = -1 Then
            MsgBox("Ingrese la Forma de Pago", MsgBoxStyle.Exclamation)
            cmbt_pago.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim nro As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ORDENCOMPRABE As New ORDENCOMPRABE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        If flagAccion = "N" Then
            nro = ORDENCOMPRABL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            txtnumero.Text = nro.PadLeft(7, "0")
        End If

        ORDENCOMPRABE.T_DOC_REF = RTrim(txtt_doc.Text)
        ORDENCOMPRABE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        ORDENCOMPRABE.NRO_DOC_REF = RTrim(txtnumero.Text)
        ORDENCOMPRABE.ART_COD = "07010003"
        ORDENCOMPRABE.FEC_GENE = RTrim(dtpfecha.Value)
        ORDENCOMPRABE.NOM_CTCT = cmbctct_cod.Text
        If cmbestado.SelectedIndex = 0 Then
            ORDENCOMPRABE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            ORDENCOMPRABE.EST = "A"
        ElseIf cmbestado.SelectedIndex = 2 Then
            ORDENCOMPRABE.EST = "P"
        ElseIf cmbestado.SelectedIndex = 3 Then
            ORDENCOMPRABE.EST = "T"
        ElseIf cmbestado.SelectedIndex = 4 Then
            ORDENCOMPRABE.EST = "S"
        ElseIf cmbestado.SelectedIndex = 5 Then
            ORDENCOMPRABE.EST = "V"
        End If
        If dtpfanul.Checked Then
            ORDENCOMPRABE.FEC_ANU = dtpfanul.Value
        Else
            ORDENCOMPRABE.FEC_ANU = Nothing
        End If
        ORDENCOMPRABE.SIGNO = "-"
        ORDENCOMPRABE.OBSERVA = RTrim(txtobservacion.Text)
        ORDENCOMPRABE.MONEDA = txtmon.Text
        ORDENCOMPRABE.DIR_COD = RTrim(txtdir.Text)
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        ORDENCOMPRABE.TPRECIO_VENTA = DAcumula
        ORDENCOMPRABE.TPRECIO_DVENTA = DAcumula1
        ORDENCOMPRABE.T_DCTO = DAcumula2
        ORDENCOMPRABE.T_DCTO_DOLAR = DAcumula3
        ORDENCOMPRABE.T_IGV = DAcumula4
        ORDENCOMPRABE.T_IGV_DOLAR = DAcumula5
        ORDENCOMPRABE.PROVEEDOR = "20100279348"
        ORDENCOMPRABE.CTCT_COD = RTrim(txtctct_cod.Text)
        ORDENCOMPRABE.FEC_DIA = RTrim(DateTime.Now)
        ORDENCOMPRABE.FEC_PROV = dtpfec_prov.Value
        ORDENCOMPRABE.NUMPEDIDO = txtoc.Text
        ORDENCOMPRABE.USUARIO = RTrim(gsUser)
        ORDENCOMPRABE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        ORDENCOMPRABE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
        ORDENCOMPRABE.T_MOVINV = txtt_movinv.Text
        ORDENCOMPRABE.VENDEDOR = txtvendedor.Text
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ORDENCOMPRABL.SaveRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()
            'If flagAccion = "N" Then
            lstValor.Items.Clear()
            ELTBGRUPCORVALBL.SelectRow("0005", lstValor)
            gcodcor = "0005"
            enviarCorreo2()
            'End If

            For Each row As DataGridViewRow In dgvt_doc.Rows
                If ARTICULOBL.SelectContar(IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value)), txtctct_cod.Text) = 0 Then
                    If MessageBox.Show("¿Desea enviar el correo " + sArticulo + " ?",
                 gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        sArt_Cod = ""
                        Exit Sub
                    End If
                    lstValor.Items.Clear()
                    sArt_Cod = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                    ELTBGRUPCORVALBL.SelectRow("0001", lstValor)
                    gcodcor = "0001"
                    enviarCorreo1()
                End If
            Next
            Temp()
            Temp1()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub Temp1()
        Dim pre As Integer = 0
        Dim cnt1 As String = ""
        For i = 0 To dgvt_doc.Rows.Count - 1
            If txtmon.Text = "00" Then
                pre = pre + dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value
                If cnt1 = "" Then
                    cnt1 = (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("UPRECIO_VENTA").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value).ToString
                Else
                    cnt1 = cnt1 + "," + (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("UPRECIO_VENTA").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value).ToString
                End If
            Else
                pre = pre + dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value
                If cnt1 = "" Then
                    cnt1 = (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("UPRECIO_DVENTA").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value).ToString
                Else
                    cnt1 = cnt1 + "," + (dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("CANTIDAD").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("UPRECIO_DVENTA").Value).ToString + "+" + (dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value).ToString
                End If
            End If

        Next
        cant1 = pre
        cant2 = cnt1
    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If

        Select Case sFunc

            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmb_serdoc.Text
                gsRptArgs(1) = txtnumero.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ORDEN82.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ORDENCOMPRABE As New ORDENCOMPRABE
                Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                ORDENCOMPRABE.T_DOC_REF = txtt_doc.Text
                ORDENCOMPRABE.SER_DOC_REF = cmb_serdoc.Text
                ORDENCOMPRABE.NRO_DOC_REF = txtnumero.Text
                Dim Data As DataTable

                Data = ORDENCOMPRABL.SelectNroAnu("82", sSDoc, sNDoc)
                For Each row As DataRow In Data.Rows
                    If IIf(IsDBNull(row("ESTADO")), "", row("ESTADO")) <> "A" Then
                        MessageBox.Show("No se puede anular el documento, comunicarse con producción para la anulación de los registros")
                        Exit Sub
                    End If
                Next
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ORDENCOMPRABL.SaveRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)


                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    cmb_serdoc.Enabled = False
                    'sEstAlmac = cmbalmac.SelectedValue
                    Me.btnborrar.Enabled = False
                    Me.btndocu.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 45
                        dgvt_doc.Columns(i).ReadOnly = True
                    Next
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If



                Exit Sub
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ORDENCOMPRABL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            'dtpfanul.Checked = IIf(IsDBNull(Registro("FEC_ANU")), False, True)
            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
                Case "P"
                    cmbestado.SelectedIndex = 2
                Case "T"
                    cmbestado.SelectedIndex = 3
                Case "S"
                    cmbestado.SelectedIndex = 4
                Case "V"
                    cmbestado.SelectedIndex = 5
            End Select
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            dtpfec_prov.Text = IIf(IsDBNull(Registro("FEC_PROV")), "", Registro("FEC_PROV"))
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            txtoc.Text = IIf(IsDBNull(Registro("NUMPEDIDO")), "", Registro("NUMPEDIDO"))
            txtt_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV")), "", Registro("T_MOVINV"))
            cmbt_movinv.SelectedValue = txtt_movinv.Text
            txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            cmbt_pago.SelectedValue = txtt_pago.Text
            txtfor_ent.Text = IIf(IsDBNull(Registro("FOR_ENT_COD")), "", Registro("FOR_ENT_COD"))
            cmbfor_ent.SelectedValue = txtfor_ent.Text
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            cmbmon.SelectedValue = txtmon.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            txtemail.Text = CTCTBL.SelectEmail(txtctct_cod.Text)
            'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            'cmbvendedor.SelectedValue = txtvendedor.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("VENDEDOR")), "", Registro("VENDEDOR"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            'Carga la direccion de acuerdo al cliente
            Dim dt As DataTable
            dt = ORDENCOMPRABL.SelectDir(txtctct_cod.Text)
            Try
                GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            Catch ex As Exception

            End Try
            cmbctct_cod.SelectedValue = txtctct_cod.Text
            txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            cmbdir.SelectedValue = txtdir.Text
            'Carga el Vendedor

            'Carga el Email
            'cmbturno.Text = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txttprecio_compra.Text = IIf(IsDBNull(Registro("tprecio_venta")), "", Registro("tprecio_venta"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("tprecio_dventa")), "", Registro("tprecio_dventa"))
            txtt_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), 0, Registro("T_DCTO"))
            txtt_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), 0, Registro("T_DCTO_DOLAR"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
            If txttprecio_compra.TextLength > 0 And txtt_igv.TextLength > 0 And txtt_dcto.TextLength > 0 Then
                txttcompras.Text = CDbl(txttprecio_compra.Text) + CDbl(txtt_igv.Text) - CDbl(txtt_dcto.Text)
                txttcomprad.Text = CDbl(txttprecio_dcompra.Text) + CDbl(txtt_igv_dolar.Text) - CDbl(txtt_dcto_dolar.Text)
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
            End If
        Next
        Temp()
    End Sub
    Private Sub Temp()
        FLAComparacion = ""
        FLAComparacion = txtctct_cod.Text + "-" + cmbctct_cod.Text + "," + cmb_serdoc.Text + "-" + txtnumero.Text + "," + txtobservacion.Text + "," + txtoc.Text + "," + cmbvendedor.Text + "," + cmbt_movinv.Text + "," + cmbt_pago.Text
    End Sub
    Private Sub FormOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Orden de Trabajo"
        Me.Text = gpCaption
        Me.txtemail.ReadOnly = True
        Me.txtvendedor.ReadOnly = True
        Dim pre As Integer = 0
        Dim cnt1 As String
        'Cargar los combos
        Dim dt As DataTable = ORDENCOMPRABL.SelectT_DOC("82")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = ORDENCOMPRABL.SelectT_MOVINV()
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = ORDENCOMPRABL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = ORDENCOMPRABL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = ORDENCOMPRABL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = ORDENCOMPRABL.SelectVendedor
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = ORDENCOMPRABL.SelectCliente
        GetCmb("cod", "nom", dt, cmbctct_cod)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '6
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '7
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '8
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '9
        dgvt_doc.Columns.Add("MEDIDA", "Medida") '10
        dgvt_doc.Columns.Add("UNIDAD", "Und.") '11
        dgvt_doc.Columns.Add("FEC_ENT", "Hora") '12
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '13
        dgvt_doc.Columns.Add("FEC_LLEG", "Fec.Vcto") '14
        dgvt_doc.Columns.Add("PART_ACT", "P. Act.") '15
        dgvt_doc.Columns.Add("ALM_COD", "Alm") '16
        dgvt_doc.Columns.Add("SIGNO", "Signo") '17
        dgvt_doc.Columns.Add("OBSERVA", "Observa") '18
        dgvt_doc.Columns.Add("T_MOVINV", "T. Mov.") '19
        dgvt_doc.Columns.Add("TPRECIO_VENTA", "P. Venta") '20
        dgvt_doc.Columns.Add("TPRECIO_DVENTA", "P. Venta. D.") '21
        dgvt_doc.Columns.Add("IGV", "Igv") '22
        dgvt_doc.Columns.Add("IGV_IMPOR", "Cant. IGV") '23
        dgvt_doc.Columns.Add("T_CAMB", "Camb.") '24
        dgvt_doc.Columns.Add("UPRECIO_VENTA", "Pre. Venta") '25
        dgvt_doc.Columns.Add("UPRECIO_DVENTA", "Pre. D. Venta") '26
        dgvt_doc.Columns.Add("IGV_DIMPOR", "Cant. IGV D.") '27
        dgvt_doc.Columns.Add("MONEDA", "Moneda") '28
        dgvt_doc.Columns.Add("FEC_GENE", "F. Gene") '29
        dgvt_doc.Columns.Add("USUARIO", "Usuario") '30
        dgvt_doc.Columns.Add("UNIDAD", "Und") '31
        dgvt_doc.Columns.Add("F_PAGO_ENT", "F. Pago") '32
        dgvt_doc.Columns.Add("FOR_ENT_COD", "F. Cod. Ent") '33
        dgvt_doc.Columns.Add("FEC_DIA", "F. Dia") '34
        dgvt_doc.Columns.Add("PROVEEDOR", "Prov.") '35
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo") '36
        dgvt_doc.Columns.Add("CANTIDAD", "Cant.") '37
        dgvt_doc.Columns.Add("LOTE", "Lote") '38
        dgvt_doc.Columns.Add("PER_COD", "Cod. Per") '39
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro. Docu") '40
        dgvt_doc.Columns.Add("MARCA", "Marca") '41
        dgvt_doc.Columns.Add("DSCTO", "Dscto. %") '42
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "Dscto. S.") '43
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "Dscto D.") '44
        dgvt_doc.Columns.Add("EST", "Est.") '45
        dgvt_doc.Columns.Add("CIERRE", "CIERRE") '46



        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                Me.txtt_doc.Text = "82"
                Me.txtt_movinv.Text = "S02"
                cmbt_doc.SelectedValue = txtt_doc.Text
                cmbt_movinv.SelectedValue = Me.txtt_movinv.Text
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
                'txtt_pago.Text = "08"
                'cmbt_pago.SelectedValue = txtt_pago.Text
                txtfor_ent.Text = "09"
                cmbfor_ent.SelectedValue = txtfor_ent.Text
                Button1.Select()
                txtmon.Text = "01"
                cmbmon.SelectedValue = txtmon.Text
                'Me.txtnumero.Text = "0750000"
                'cmblinea.Enabled = True
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                dgvt_doc.Columns(4).Visible = False
                dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.Columns(29).Visible = False
                dgvt_doc.Columns(30).Visible = False
                dgvt_doc.Columns(31).Visible = False
                dgvt_doc.Columns(32).Visible = False
                dgvt_doc.Columns(33).Visible = False
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(39).Visible = False
                dgvt_doc.Columns(40).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
            Case 1
                flagAccion = "M"
                GetData("82", sSDoc, sNDoc)
                bCuarto = "1"
                'habilitar(True)
                btnparcial.Enabled = True
                'cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = ORDENCOMPRABL.getListdgv("82", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),'6
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'7
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'8
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'9
                                      IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), '10
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), '11
                                      IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'12
                                      IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'13
                                      IIf(IsDBNull(row("FEC_LLEG")), "", row("FEC_LLEG")),'14
                                      IIf(IsDBNull(row("PART_ACT")), "", row("PART_ACT")),'15
                                      IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'16
                                      IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'17
                                      IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'18
                                      IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),'19
                                      IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA")),'20
                                      IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA")),'21
                                      IIf(IsDBNull(row("IGV")), "", row("IGV")),'22
                                      IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),'23
                                      IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),'24
                                      IIf(IsDBNull(row("UPRECIO_VENTA")), "", row("UPRECIO_VENTA")),'25
                                      IIf(IsDBNull(row("UPRECIO_DVENTA")), "", row("UPRECIO_DVENTA")),'26
                                      IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),'27
                                      IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'28
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'29
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'30
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'31
                                      IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'32
                                      IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),'33
                                      IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),'34
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'35
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'36
                                      IIf(IsDBNull(row("CANTIDAD1")), "", row("CANTIDAD1")),'37
                                      IIf(IsDBNull(row("LOTE")), "", row("LOTE")),'38
                                      IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'39
                                      IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),'40
                                      IIf(IsDBNull(row("MARCA")), "", row("MARCA")),'41
                                      IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),'42
                                      IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),'43
                                      IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),'44
                                      IIf(IsDBNull(row("EST")), "", row("EST")),
                                      IIf(IsDBNull(row("CIERRE")), "", row("CIERRE"))) '45

                    If txtmon.Text = "00" Then
                        pre = pre + IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA"))
                        If cnt1 = "" Then
                            cnt1 = (IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) & "-" & IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART"))).ToString + "+" + (IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD"))).ToString + "+" + (IIf(IsDBNull(row("UPRECIO_VENTA")), "", row("UPRECIO_VENTA"))).ToString + "+" + (IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA"))).ToString
                        Else
                            cnt1 = cnt1 + "," + (IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) & "-" & IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART"))).ToString + "+" + (IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD"))).ToString + "+" + (IIf(IsDBNull(row("UPRECIO_VENTA")), "", row("UPRECIO_VENTA"))).ToString + "+" + (IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA"))).ToString
                        End If
                    Else
                        pre = pre + IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA"))
                        If cnt1 = "" Then
                            cnt1 = (IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) & "-" & IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART"))).ToString + "+" + (IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD"))).ToString + "+" + (IIf(IsDBNull(row("UPRECIO_DVENTA")), "", row("UPRECIO_DVENTA"))).ToString + "+" + (IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA"))).ToString
                        Else
                            cnt1 = cnt1 + "," + (IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")) & "-" & IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART"))).ToString + "+" + (IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD"))).ToString + "+" + (IIf(IsDBNull(row("UPRECIO_DVENTA")), "", row("UPRECIO_DVENTA"))).ToString + "+" + (IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA"))).ToString
                        End If
                    End If

                Next
                cant1 = pre
                cant2 = cnt1
                Dim i As Integer
                For i = 0 To 45
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(7)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                Me.btnborrar.Enabled = False
                Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                dgvt_doc.Columns(4).Visible = False
                dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.Columns(29).Visible = False
                dgvt_doc.Columns(30).Visible = False
                dgvt_doc.Columns(31).Visible = False
                dgvt_doc.Columns(32).Visible = False
                dgvt_doc.Columns(33).Visible = False
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(39).Visible = False
                dgvt_doc.Columns(40).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
                'dgvt_doc.Columns(46).Visible = False
                Dim btn As New DataGridViewButtonColumn
                If dgvt_doc.Columns(0).Name = "btnAprobar" Then
                Else
                    btn.HeaderText = "Enviar Correo"
                    btn.Text = "Enviar Correo"
                    btn.Name = "btnEnviar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                    dgvt_doc.Columns.Insert(0, btn)
                    btn = New DataGridViewButtonColumn
                    btn.HeaderText = "Cerrar"
                    btn.Text = "Cerrar"
                    btn.Name = "btnCerrar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    dgvt_doc.Columns.Insert(1, btn)
                End If
                For i = 0 To dgvt_doc.Rows.Count - 1  ' count++
                    If dgvt_doc.Rows(i).Cells("CIERRE").Value = "CERRADO" Then
                        dgvt_doc.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    End If
                Next
        End Select
        bPrimero = False
    End Sub

    Private Sub FormOrdenCompra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

#Region "Valor Cmb"


    Private Sub cmbt_doc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_doc.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_doc.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_doc.Text = cmbt_doc.SelectedValue
    End Sub

    Private Sub cmbt_movinv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_movinv.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_movinv.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_movinv.Text = cmbt_movinv.SelectedValue

    End Sub

    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_pago.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_pago.Text = cmbt_pago.SelectedValue
    End Sub

    Private Sub cmbfor_ent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfor_ent.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbfor_ent.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtfor_ent.Text = cmbfor_ent.SelectedValue
    End Sub

    Private Sub cmbmon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmon.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbmon.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtmon.Text = cmbmon.SelectedValue
    End Sub

    Private Sub cmbvendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvendedor.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbvendedor.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtvendedor.Text = cmbvendedor.SelectedValue

    End Sub

    Private Sub cmbdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdir.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdir.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmbdir.SelectedIndex <> -1 Then
            txtdir.Text = cmbdir.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        If bTercero = "0" Then
            Exit Sub
        End If
        Dim nro As String
        'txtnumero.Enabled = False
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = ORDENCOMPRABL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)

            txtnumero.Text = nro.PadLeft(7, "0")

        End If
    End Sub
    Private Sub cmbctct_cod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbctct_cod.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbctct_cod.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmbctct_cod.SelectedIndex <> -1 Then
            txtctct_cod.Text = cmbctct_cod.SelectedValue.ToString
        End If
        Dim dt As DataTable
        dt = ORDENCOMPRABL.SelectDir(txtctct_cod.Text)
        Try
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
            txtemail.Text = CTCTBL.SelectEmail(txtctct_cod.Text)
            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text
        Catch ex As Exception

        End Try
        If flagAccion = "N" Then
            habilitar(True)
        End If
    End Sub

#End Region

#Region "Botones"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        sBusAlm = "4"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtmon.Text = "" Or txtt_movinv.Text = "" Then
            MsgBox("Ingrese la moneda")
            Exit Sub
        End If
        gContador = 1
        Dim dt As DataTable
        If txtctct_cod.Text = "" Then
            MsgBox("Por favor seleccione un Cliente")
            Exit Sub
        End If
        gCliente = txtctct_cod.Text
        dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
        Dim frm As New FormMantDetOrdenCompra
        For Each Registro In dt.Rows
            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        If txtmon.Text = "00" Then
            frm.npduprecio_dventa.Enabled = False
            frm.npduprecio_venta.Enabled = True
        ElseIf txtmon.Text = "01" Then
            frm.npduprecio_venta.Enabled = False
            frm.npduprecio_dventa.Enabled = True
        End If
        frm.txtigv.Text = 18
        frm.lblcliente.Text = txtctct_cod.Text
        frm.lblmoneda.Text = txtmon.Text
        frm.ShowDialog()
        gCliente = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnparcial.Click
        If flagAccion = "M" Then
            If dgvt_doc.Rows.Count > 0 Then
                Dim frm As New FormMantELTBParcial
                frm.txtt_doc.Text = Me.txtt_doc.Text & "-" & Me.cmbt_doc.Text
                frm.cmb_serdoc.Text = Me.cmb_serdoc.Text
                frm.txtnumero.Text = Me.txtnumero.Text
                frm.txtart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
                frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value
                frm.Label8.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
                frm.ShowDialog()
            Else
                MsgBox("No hay articulos para agregar Parcial")
            End If
        End If


    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetOrdenCompra
            gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
            sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
            'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
            frm.npduprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value)
            frm.npduprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value)
            frm.txttprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_VENTA").Value)
            frm.txttprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DVENTA").Value)
            frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
            frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
            frm.txtigvimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value)
            frm.txtigv_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value)
            frm.txtdscto_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
            frm.txtdscto_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_DIMPOR").Value)
            frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
            If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
                frm.txtigv.Text = 18
            End If
            If frm.npduprecio_venta.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = (frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text
                frm.txttcomprad.Text = ((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text
            End If
            If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
            End If
            gCliente = txtctct_cod.Text
            If flagAccion = "M" Then
                'frm.btnagregar.Enabled = False
            ElseIf flagAccion = "N" Then
                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
                frm.txtigv.Text = 18
            End If
            If txtmon.Text = "00" Then
                frm.npduprecio_dventa.Enabled = False
                frm.npduprecio_venta.Enabled = True
            ElseIf txtmon.Text = "01" Then
                frm.npduprecio_venta.Enabled = False
                frm.npduprecio_dventa.Enabled = True
            End If
            gContador = 0
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If

    End Sub
#End Region

    Private Sub txtt_doc_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc.LostFocus
        'If txtt_doc.Text = "" Then
        '    cmbt_doc.SelectedValue = ""
        '    Exit Sub
        'End If
        'cmbt_doc.SelectedValue = txtt_doc.Text
        'If cmbt_doc.SelectedValue Is Nothing Then
        '    MsgBox("Tipo de documento no existe", MsgBoxStyle.Exclamation)
        '    txtt_doc.Text = ""
        'Else
        '    If flagAccion = "N" Then
        '        cmb_serdoc.SelectedIndex = 0
        '        cmbestado.SelectedIndex = 0
        '        'cmbt_movinv.SelectedIndex = 2
        '        txtt_pago.Text = "08"
        '        txtfor_ent.Text = "09"
        '        'txtnumero.Text = ARTICULOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
        '    End If

        'End If
    End Sub


    Private Sub txtt_movinv_LostFocus(sender As Object, e As EventArgs) Handles txtt_movinv.LostFocus
        If txtt_movinv.Text = "" Then
            cmbt_movinv.SelectedValue = ""
            Exit Sub
        End If
        cmbt_movinv.SelectedValue = txtt_movinv.Text
        If cmbt_movinv.SelectedValue Is Nothing Then
            MsgBox("Tipo de Movimiento no existe", MsgBoxStyle.Exclamation)
            txtt_movinv.Text = ""
        End If
    End Sub

    Private Sub txtt_pago_LostFocus(sender As Object, e As EventArgs) Handles txtt_pago.LostFocus
        If txtt_pago.Text = "" Then
            cmbt_pago.SelectedValue = ""
            Exit Sub
        End If
        cmbt_pago.SelectedValue = txtt_pago.Text

        If cmbt_pago.SelectedValue Is Nothing Then
            MsgBox("Tipo de pago no existe", MsgBoxStyle.Exclamation)
            txtt_pago.Text = ""
        End If
    End Sub

    Private Sub txtfor_ent_LostFocus(sender As Object, e As EventArgs) Handles txtfor_ent.LostFocus
        If txtfor_ent.Text = "" Then
            cmbfor_ent.SelectedValue = ""
            Exit Sub
        End If
        cmbfor_ent.SelectedValue = txtfor_ent.Text
        If cmbfor_ent.SelectedValue Is Nothing Then
            MsgBox("Tipo de entrega no existe", MsgBoxStyle.Exclamation)
            txtfor_ent.Text = ""
        End If
    End Sub

    Private Sub txtmon_LostFocus(sender As Object, e As EventArgs) Handles txtmon.LostFocus
        If txtmon.Text = "" Then
            cmbmon.SelectedValue = ""
            Exit Sub
        End If
        cmbmon.SelectedValue = txtmon.Text
        If cmbmon.SelectedValue Is Nothing Then
            MsgBox("Tipo de Moneda no existe", MsgBoxStyle.Exclamation)
            txtmon.Text = ""
        End If
    End Sub

    Private Sub txtctct_cod_LostFocus(sender As Object, e As EventArgs) Handles txtctct_cod.LostFocus
        Dim dt As DataTable
        If txtctct_cod.Text <> "" Then
            cmbctct_cod.SelectedValue = txtctct_cod.Text
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
            txtemail.Text = CTCTBL.SelectEmail(txtctct_cod.Text)
            If txtctct_cod.Text <> "20100279348" Then
                txtt_pago.Text = ORDENCOMPRABL.SelectF_PAGO_ENT_Ult(txtctct_cod.Text)
                cmbt_pago.SelectedValue = txtt_pago.Text
            End If
            If txtctct_cod.Text = "20100279348" Then
                cmbdir.SelectedValue = "1"
            End If

            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text
        End If

    End Sub
    Private Sub txtctct_codr_TextChanged(sender As Object, e As EventArgs) Handles txtctct_cod.TextChanged
        Dim dt As DataTable
        If cmbctct_cod.SelectedIndex <> -1 Then
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "38"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        txtctct_cod.Select()
        Dim dt As DataTable
        Try
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
            txtemail.Text = CTCTBL.SelectEmail(txtctct_cod.Text)
            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text
            If txtctct_cod.Text <> "20100279348" Then
                txtt_pago.Text = ORDENCOMPRABL.SelectF_PAGO_ENT_Ult(txtctct_cod.Text)
                cmbt_pago.SelectedValue = txtt_pago.Text
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvt_doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt_doc.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            sArticulo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value

            'TODO - Button Clicked - Execute Code Here
            If e.ColumnIndex = 0 Then
                If MessageBox.Show("¿Esta seguro de enviar el correo " + sArticulo + " ?",
                  gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                lstValor.Items.Clear()
                ELTBGRUPCORVALBL.SelectRow("0002", lstValor)
                gcodcor = "0002"
                enviarCorreo()

            End If

            If e.ColumnIndex = 1 Then
                If MessageBox.Show("¿Esta seguro de cerrar el articulo " + sArticulo + " de la orden ?",
                  gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                'ELTBGRUPCORVALBL.SelectRow("0002", lstValor)
                'enviarCorreo()
                Dim ORDENCOMPRABE As New ORDENCOMPRABE
                Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                ORDENCOMPRABE.T_DOC_REF = txtt_doc.Text
                ORDENCOMPRABE.SER_DOC_REF = cmb_serdoc.Text
                ORDENCOMPRABE.NRO_DOC_REF = txtnumero.Text
                ORDENCOMPRABE.ART_COD1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value

                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ORDENCOMPRABL.SaveRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, "C", dgvt_doc)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    cmb_serdoc.Enabled = False
                    'sEstAlmac = cmbalmac.SelectedValue
                    Me.btnborrar.Enabled = False
                    Me.btndocu.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 45
                        dgvt_doc.Columns(i).ReadOnly = True
                    Next
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If


        End If

    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub chkobs2_CheckedChanged(sender As Object, e As EventArgs) Handles chkobs2.CheckedChanged
        If chkobs2.Checked = True Then
            'sObsOp = ""
            Me.btnobs2.Visible = True
            Dim frm As New FormObsOrdenCompra
            frm.ShowDialog()
        Else
            If MessageBox.Show("¿Esta seguro de borrar la observacion 2?",
                  gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

            End If
        End If
    End Sub

    Private Sub txtoc_LostFocus(sender As Object, e As EventArgs) Handles txtoc.LostFocus
        Dim a As String = ORDENCOMPRABL.SelectOC(txtctct_cod.Text, txtoc.Text)
        If a.Length > 0 Then
            MsgBox("Este numero de Orden de CLiente ya esta siendo usado por la orden: " & a & " favor ponga uno disponible", MsgBoxStyle.Exclamation)
            'Return False
        End If
    End Sub

    Private Sub btncorreo_Click(sender As Object, e As EventArgs) Handles btncorreo.Click
        gsCode13 = "OC"
        Dim frm As New FormMantEltbgrupcorval
        frm.ShowDialog()
        gsCode13 = ""
    End Sub
End Class