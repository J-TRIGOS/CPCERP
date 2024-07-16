Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormFactElect
    Private FACTURACIONBL As New FACTURACIONBL
    Private BOLETABL As New BOLETABL
    Private NOTACREDITOBL As New NOTACREDITOBL
    Private NOTADEBITOBL As New NOTADEBITOBL
    Public fac As String
    Public mov As String
    Public tipo As String
    Public estfac As String
    Public fecfact As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormFactElect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fac = "01" And mov = "S02" And tipo <> "09" Then
            If gsUser = "SISTEMA" Then
                txttexto.Text = FACTURACIONBL.getTxtFc(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac, FormMantFacturacion.txtctct_cod.Text)
            Else
                txttexto.Text = FACTURACIONBL.getTxtFc1(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac, FormMantFacturacion.txtctct_cod.Text)
            End If
                ElseIf fac = "01" And mov = "S02" And tipo = "09" Then
                txttexto.Text = FACTURACIONBL.getTxtFcGra(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
            ElseIf fac = "01" And mov = "S06" Then
                txttexto.Text = FACTURACIONBL.getTxtFcExp(FormMantFacturacion.txtt_doc.Text, FormMantFacturacion.cmb_serdoc.Text, FormMantFacturacion.txtnumero.Text, estfac)
            ElseIf fac = "03" Then
                txttexto.Text = BOLETABL.getTxtFc(FormMantBoleta.txtt_doc.Text, FormMantBoleta.cmb_serdoc.Text, FormMantBoleta.txtnumero.Text, estfac)
            ElseIf fac = "07" Then
                ' If gsUser = "SISTEMA" Then
                txttexto.Text = NOTACREDITOBL.getTxtFc1(FormMantNotaCredito.txtt_doc.Text, FormMantNotaCredito.cmb_serdoc.Text, FormMantNotaCredito.txtnumero.Text, estfac)
                'Else
                '    txttexto.Text = NOTACREDITOBL.getTxtFc(FormMantNotaCredito.txtt_doc.Text, FormMantNotaCredito.cmb_serdoc.Text, FormMantNotaCredito.txtnumero.Text, estfac)
                'End If
            ElseIf fac = "08" Then
                txttexto.Text = NOTADEBITOBL.getTxtFc(FormMantNotaDebito.txtt_doc.Text, FormMantNotaDebito.cmb_serdoc.Text, FormMantNotaDebito.txtnumero.Text, estfac)
        End If

        'MsgBox(fac)
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.Text = "Texto Facturacion Electronica"
        If estfac = "H" Then
            If fac = "01" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.5\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantFacturacion.cmb_serdoc.Text & "-" & FormMantFacturacion.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            ElseIf fac = "03" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.5\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantBoleta.cmb_serdoc.Text & "-" & FormMantBoleta.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            ElseIf fac = "07" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.5\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaCredito.cmb_serdoc.Text & "-" & FormMantNotaCredito.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            ElseIf fac = "08" Then
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.5\sistema\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaDebito.cmb_serdoc.Text & "-" & FormMantNotaDebito.txtnumero.Text & ".csv"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            End If
        Else
            'If fac = "01" Then
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            Dim RutaTxt As String = "\\192.168.1.5\sistema\Factura_Electronica\20100279348-RA-" & fecfact & "-" & Mid(txttexto.Text, 35, 4) & ".csv"
            IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            'ElseIf fac = "03" Then
            '    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            '    Dim RutaTxt As String = "\\LUXSERVER\Logi\Factura_Electronica\20100279348-" & fac & "-" & FormMantBoleta.cmb_serdoc.Text & "-" & FormMantBoleta.txtnumero.Text & ".csv"
            '    IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
            '    MsgBox("Se genero El texto")
            'ElseIf fac = "07" Then
            '    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            '    Dim RutaTxt As String = "\\LUXSERVER\Logi\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaCredito.cmb_serdoc.Text & "-" & FormMantNotaCredito.txtnumero.Text & ".csv"
            '    IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
            '    MsgBox("Se genero El texto")
            'ElseIf fac = "08" Then
            '    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            '    Dim RutaTxt As String = "\\LUXSERVER\Logi\Factura_Electronica\20100279348-" & fac & "-" & FormMantNotaDebito.cmb_serdoc.Text & "-" & FormMantNotaDebito.txtnumero.Text & ".csv"
            '    IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
            '    MsgBox("Se genero El texto")
            'End If
        End If


    End Sub

    Private Sub FormFactElect_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class