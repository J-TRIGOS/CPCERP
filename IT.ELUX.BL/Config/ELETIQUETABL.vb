Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELETIQUETABL
    Private ELETIQUETADAL As New ELETIQUETADAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELETIQUETADAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELETIQUETABE As ELETIQUETABE, ByVal flagaccion As String) As String
        Return ELETIQUETADAL.SaveRow(ELETIQUETABE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELETIQUETADAL.SelectMaxLibro()
    End Function
    Public Function SelectRow() As DataTable
        Return ELETIQUETADAL.SelectRow()
    End Function
    Public Function SelectClienteCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectclienteCOD(codigo)
    End Function
    Public Function SelectArticuloCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectArticuloCOD(codigo)
    End Function
    Public Function BuscarFamArt(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.BuscarFamArt(codigo)
    End Function
    Public Function SelectFamiliaCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectfamiliaCOD(codigo)
    End Function

    Public Function SelectRow_TWO(ByVal area As String) As DataTable
        Return ELETIQUETADAL.SelectRow_TWO(area)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELETIQUETADAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELETIQUETADAL.SelectAll(anho, mes)
    End Function
    Public Function SelectArticulo(ByVal opcion As String) As DataTable
        Return ELETIQUETADAL.SelectArticulo(opcion)
    End Function
    Public Function SelectArticuloPro() As DataTable
        Return ELETIQUETADAL.SelectArticuloPro()
    End Function
    Public Function SelectArticulotwo() As DataTable
        Return ELETIQUETADAL.SelectArticulotwo()
    End Function
    Public Function SelectMaxTransp() As String
        Return ELETIQUETADAL.SelectMaxTransp()
    End Function
    Public Function SelectMaxTranspTwo() As String
        Return ELETIQUETADAL.SelectMaxTranspTwo()
    End Function
    Public Function SelectMaxTranspEns() As String
        Return ELETIQUETADAL.SelectMaxTranspEns()
    End Function
    Public Function SelectUnidadm() As DataTable
        Return ELETIQUETADAL.SelectUnidadm()
    End Function
    Public Function SelectTipodoc() As DataTable
        Return ELETIQUETADAL.SelectTipodoc()
    End Function
    Public Function SelectMoneda() As DataTable
        Return ELETIQUETADAL.SelectMoneda()
    End Function
    Public Function SelectProveedor() As DataTable
        Return ELETIQUETADAL.SelectProveedor()
    End Function
    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectTipodocCOD(codigo)
    End Function
    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectMonCOD(codigo)
    End Function
    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectProveedorCOD(codigo)
    End Function
    Public Function SelectActivoCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectActivoCOD(codigo)
    End Function
    Public Function SelectUserCOD(ByVal codigo As String) As DataTable
        Return ELETIQUETADAL.SelectUserCOD(codigo)
    End Function
    Public Function SelectActivoPro() As DataTable
        Return ELETIQUETADAL.SelectActivoPro()
    End Function
    Public Function SelectUserPro() As DataTable
        Return ELETIQUETADAL.SelectUserPro()
    End Function
    Public Function SelectArtMes(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELETIQUETADAL.SelectArtMes(anho, mes)
    End Function
    Public Function SelectAllPacking(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELETIQUETADAL.SelectAllPacking(anho, mes)
    End Function

    Public Function BuscarDatosRotulo(ByVal numero As String, ByVal art As String) As DataTable
        Return ELETIQUETADAL.BuscarDatosRotulo(numero, art)
    End Function

    Public Function SaveRowEtiqueta(ByVal GUIASROTULOBE As GUIASROTULOBE, ByVal flagaccion As String) As String
        Return ELETIQUETADAL.SaveRowEtiqueta(GUIASROTULOBE, flagaccion)
    End Function

    Public Function VerificarRegistro(ByVal GUIASROTULOBE As GUIASROTULOBE) As DataTable
        Return ELETIQUETADAL.VerificarRegistro(GUIASROTULOBE)
    End Function

    Public Function BuscarRotulosGuia() As DataTable
        Return ELETIQUETADAL.BuscarRotulosGuia()
    End Function
End Class
