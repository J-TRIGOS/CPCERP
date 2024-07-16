Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELCUENTA_ARTBL
    Private ELCUENTA_ARTDAL As New ELCUENTA_ARTDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELCUENTA_ARTDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELCUENTA_ARTBE As ELCUENTA_ARTBE, ByVal flagaccion As String) As String
        Return ELCUENTA_ARTDAL.SaveRow(ELCUENTA_ARTBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELCUENTA_ARTDAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELCUENTA_ARTDAL.SelectRow(sTdoc, sSDoc, sNDoc)
    End Function
    Public Function VerificarRepetido(ByVal anho As String, ByVal art_cod As String) As Boolean
        Return ELCUENTA_ARTDAL.VerificarRepetido(anho, art_cod)
    End Function
    Public Function SelectAll(ByVal anho As String) As DataTable
        Return ELCUENTA_ARTDAL.SelectAll(anho)
    End Function
    Public Function SelectArticuloCuenta() As DataTable
        Return ELCUENTA_ARTDAL.SelectArticuloCuenta()
    End Function
    Public Function SelectAllOrden(ByVal anho As String, ByVal mes As String, ByVal estado As String) As DataTable
        Return ELCUENTA_ARTDAL.SelectAllOrden(anho, mes, estado)
    End Function
    Public Function SelectAllOREQ(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELCUENTA_ARTDAL.SelectAllOREQ(anho, mes)
    End Function

End Class
