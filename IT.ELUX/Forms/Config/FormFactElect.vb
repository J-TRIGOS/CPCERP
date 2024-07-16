Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports IT.ELUX.EjemploIntegraciondirectaCSharp

Public Class FormFactElect
    Private FACTURACIONBL As New FACTURACIONBL
    Private BOLETABL As New BOLETABL
    Private NOTACREDITOBL As New NOTACREDITOBL
    Private NOTADEBITOBL As New NOTADEBITOBL
    Public fac As String
    Public mov As String
    Public tipo As String
    Public estfac As String
    Public sucursal As String
    Public fecfact As String
    Private contador As Integer = 0
    Sub texto_factura()
        'contador = contador + 1
        If FormMantFacturacion.cmb_serdoc.Text = "001" Then
            sucursal = "0001"
        End If
        Dim st As String = ""
        If FormMantFacturacion.txtt_movinv.Text = "S02" Then
            st = "1"
        Else
            st = "2"
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormFactElect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fac = "01" And mov = "S02" And tipo <> "09" Then
            'If gsUser = "SISTEMA" Then
            texto_factura()
            'txttexto.Text = FACTURACIONBL.getTxtFc(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac, FormMantFacturacion.txtctct_cod.Text)
            'txttexto.Text = FACTURACIONBL.getTxtFcExp1(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
            'Else
            '    txttexto.Text = FACTURACIONBL.getTxtFc1(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac, FormMantFacturacion.txtctct_cod.Text)
            'End If
        ElseIf fac = "01" And mov = "S02" And tipo = "09" Then
            txttexto.Text = FACTURACIONBL.getTxtFcGra(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
        ElseIf fac = "01" And mov = "S06" Then
            'If gsUser = "SISTEMA" Then
            ' txttexto.Text = FACTURACIONBL.getTxtFcExp1(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
            'Else
            '    txttexto.Text = FACTURACIONBL.getTxtFcExp(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
            'End If

        ElseIf fac = "03" Then
            'If gsUser = "SISTEMA" Then
            txttexto.Text = BOLETABL.getTxtFc1(FormMantBoleta.txtt_doc.Text, FormMantBoleta.cmb_serdoc.Text, FormMantBoleta.txtnumero.Text, estfac)
            'Else
            '    txttexto.Text = BOLETABL.getTxtFc(FormMantBoleta.txtt_doc.Text, FormMantBoleta.cmb_serdoc.Text, FormMantBoleta.txtnumero.Text, estfac)
            'End If

        ElseIf fac = "07" Then
            'If gsUser = "SISTEMA" Then
            txttexto.Text = NOTACREDITOBL.getTxtFc(FormMantNotaCredito.txtt_doc.Text, FormMantNotaCredito.cmb_serdoc.Text, FormMantNotaCredito.txtnumero.Text, estfac)
            'Else
            '    txttexto.Text = NOTACREDITOBL.getTxtFc1(FormMantNotaCredito.txtt_doc.Text, FormMantNotaCredito.cmb_serdoc.Text, FormMantNotaCredito.txtnumero.Text, estfac)
            'End If
        ElseIf fac = "08" Then
            'If gsUser = "SISTEMA" Then
            txttexto.Text = NOTADEBITOBL.getTxtFc1(FormMantNotaDebito.txtt_doc.Text, FormMantNotaDebito.cmb_serdoc.Text, FormMantNotaDebito.txtnumero.Text, estfac)
            'Else
            '    txttexto.Text = NOTADEBITOBL.getTxtFc(FormMantNotaDebito.txtt_doc.Text, FormMantNotaDebito.cmb_serdoc.Text, FormMantNotaDebito.txtnumero.Text, estfac)
            'End If

        End If

        'MsgBox(fac)
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.Text = "Texto Facturacion Electronica"
        If estfac = "H" Then
            If fac = "01" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantFacturacion.cmb_serdoc.Text & "-" & FormMantFacturacion.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            ElseIf fac = "03" Then
                'If gsUser = "SISTEMA" Then
                '    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                '    Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-" & fac & "-0000172(PR).csv"
                '    IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                '    MsgBox("Se genero El texto")
                'Else
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantBoleta.cmb_serdoc.Text & "-" & FormMantBoleta.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
                'End If

            ElseIf fac = "07" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaCredito.cmb_serdoc.Text & "-" & FormMantNotaCredito.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            ElseIf fac = "08" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaDebito.cmb_serdoc.Text & "-" & FormMantNotaDebito.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            End If
        Else
            'If fac = "01" Then
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            Dim RutaTxt As String = "\\192.168.1.7\sistema\Factura_Electronica\20100279348-RA-" & fecfact & "-" & Mid(txttexto.Text, 35, 4) & ".csv"
            IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
            MsgBox("Se genero El texto")
        End If


    End Sub

    Private Sub FormFactElect_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnGenerarFE_Click(sender As Object, e As EventArgs) Handles btnGenerarFE.Click
        Dim sr As New DemoIntCSharpEBI

        If estfac = "H" Then
            If fac = "01" Then
                sr.xDoc = FormMantFacturacion.txtt_doc.Text
                sr.xNum = FormMantFacturacion.txtnumero.Text
                sr.xSer = FormMantFacturacion.cmb_serdoc.Text
                sr.xStf = estfac
                sr.xCtc = FormMantFacturacion.txtctct_cod.Text
                sr.Main()
            ElseIf fac = "03" Then

            ElseIf fac = "07" Then
                sr.xDoc = FormMantNotaCredito.txtt_doc.Text
                sr.xNum = FormMantNotaCredito.txtnumero.Text
                sr.xSer = FormMantNotaCredito.cmb_serdoc.Text
                sr.xStf = estfac
                sr.xCtc = FormMantNotaCredito.txtctct_cod.Text
                sr.Main()
            ElseIf fac = "08" Then
                sr.xDoc = FormMantNotaDebito.txtt_doc.Text
                sr.xNum = FormMantNotaDebito.txtnumero.Text
                sr.xSer = FormMantNotaDebito.cmb_serdoc.Text
                sr.xStf = estfac
                sr.xCtc = FormMantNotaDebito.txtctct_cod.Text
                sr.Main()

            End If
        Else
        End If

    End Sub
End Class