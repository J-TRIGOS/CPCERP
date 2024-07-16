Imports System.ComponentModel
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDetElect
    Private ELTBDETRACCIONBL As New ELTBDETRACCIONBL
    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormDetElect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        txttexto.Text = ELTBDETRACCIONBL.getTxtDet(FormELTBDETRACCION.txtt_doc.Text, FormELTBDETRACCION.cmb_serdoc.Text, FormELTBDETRACCION.txtnumero.Text)
        'Variables para abrir el archivo en modo de escritura
        'Dim strStreamW As Stream
        'Dim strStreamWriter As StreamWriter
        'Try
        '    Dim ds As New DataSet
        '    Dim FilePath As String = "C:nombreArchivo.txt"
        '    'Se abre el archivo y si este no existe se crea
        '    strStreamW = File.OpenWrite(FilePath)
        '    strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.UTF8)
        '    'Se traen los datos que necesitamos para el archivo
        '    'TraerDatosArchivo retorna un dataset pero perfectamente
        '    'podria ser cualquier otro tipo de objeto
        '    'ds = Negocios.TraerDatosArchivo()
        '    'Dim dr As DataRow
        '    'Dim Nombre As String = ""
        '    'Dim Apellido As String = ""
        '    'Dim Email As String = ""
        '    'For Each dr In ds.Tables(0).Rows
        '    '    'Obtenemos los datos del dataset
        '    '    Nombre = CStr(dr("Nombre"))
        '    '    Apellido = CStr(dr("Apellido"))
        '    '    Email = CStr(dr("Email"))
        '    '    'Escribimos la línea en el achivo de texto
        '    strStreamWriter.WriteLine(txttexto.Text)
        '    'Next
        '    strStreamWriter.Close()
        '    MsgBox("El archivo se generó con éxito")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub btnvirtual_Click(sender As Object, e As EventArgs) Handles btnvirtual.Click
        txttexto.Text = ELTBDETRACCIONBL.getTxtDet1(FormELTBDETRACCION.txtt_doc.Text, FormELTBDETRACCION.cmb_serdoc.Text, FormELTBDETRACCION.txtnumero.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim RutaTxt As String = "\\192.168.1.5\sistema\Detraccion\D20100279348" & Mid(FormELTBDETRACCION.cmb_serdoc.Text, 3, 2) & Mid(FormELTBDETRACCION.txtnumero.Text, 4, 7) & ".txt"
        IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
        MsgBox("Se genero El texto")
    End Sub
End Class