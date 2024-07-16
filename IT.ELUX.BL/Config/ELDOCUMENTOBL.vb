Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELDOCUMENTOBL
    Private ELDOCUMENTODAL As New ELDOCUMENTODAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELDOCUMENTODAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal flagaccion As String) As String
        Return ELDOCUMENTODAL.SaveRow(ELDOCUMENTOBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELDOCUMENTODAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELDOCUMENTODAL.SelectRow(sTDoc, sSDoc, sNDoc)
    End Function

    Public Function BuscarBanco(ByVal bcoCod As String) As DataTable
        Return ELDOCUMENTODAL.BuscarBanco(bcoCod)
    End Function

    Public Function BuscarMoneda(ByVal monCod As String) As DataTable
        Return ELDOCUMENTODAL.BuscarMoneda(monCod)
    End Function

    Public Function BuscarActFlujo(ByVal actFlujo As String) As DataTable
        Return ELDOCUMENTODAL.BuscarActFlujo(actFlujo)
    End Function

    Public Function BuscarActFlujoCaja(ByVal actFlujo As String, ByVal actCaja As String, ByVal ope As String) As DataTable
        Return ELDOCUMENTODAL.BuscarActFlujoCaja(actFlujo, actCaja, ope)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELDOCUMENTODAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELDOCUMENTODAL.SelectAll(anho, mes)
    End Function
    Public Function BuscarDatosActFlujo(ByVal codFlujo As String, ByVal codCaja As String, ByVal ope As String) As DataTable
        Return ELDOCUMENTODAL.BuscarDatosActFlujo(codFlujo, codCaja, ope)
    End Function
    Public Function SelectTipodoc() As DataTable
        Return ELDOCUMENTODAL.SelectTipodoc()
    End Function
    Public Function SelectTMOV() As DataTable
        Return ELDOCUMENTODAL.SelectTMOV()
    End Function
    Public Function SelectChofer() As DataTable
        Return ELDOCUMENTODAL.SelectChofer()
    End Function
    Public Function SelectMoneda() As DataTable
        Return ELDOCUMENTODAL.SelectMoneda()
    End Function
    Public Function SelectProveedor() As DataTable
        Return ELDOCUMENTODAL.SelectProveedor()
    End Function
    Public Function SelectCliente() As DataTable
        Return ELDOCUMENTODAL.SelectCliente()
    End Function
    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Return ELDOCUMENTODAL.SelectTipodocCOD(codigo)
    End Function
    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Return ELDOCUMENTODAL.SelectMonCOD(codigo)
    End Function
    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Return ELDOCUMENTODAL.SelectProveedorCOD(codigo)
    End Function
    Public Function SelectCuentaCOD(ByVal codigo As String) As DataTable
        Return ELDOCUMENTODAL.SelectCuentaCOD(codigo)
    End Function
    Public Function SelectTipoCuenta(ByVal tipo As String) As DataTable
        Return ELDOCUMENTODAL.SelectTipoCuenta(tipo)
    End Function
End Class
