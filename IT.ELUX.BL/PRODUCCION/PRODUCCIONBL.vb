Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class PRODUCCIONBL
    Private PRODUCCIONDAL As New PRODUCCIONDAL

    Public Function SelectCC() As DataTable
        Return PRODUCCIONDAL.SelectCC()
    End Function

    Public Function BuscarDatosPersonalLinea(ByVal cc As String) As DataTable
        Return PRODUCCIONDAL.BuscarDatosPersonalLinea(cc)
    End Function

    Public Function BuscarOrdenProduccion() As DataTable
        Return PRODUCCIONDAL.BuscarOrdenProduccion()
    End Function

    Public Function BuscarProcXArticulo(ByVal codigo As String) As DataTable
        Return PRODUCCIONDAL.BuscarProcXArticulo(codigo)
    End Function

    Public Function BuscarOperacionxProceso(ByVal codigo As String) As DataTable
        Return PRODUCCIONDAL.BuscarOperacionxProceso(codigo)
    End Function

    Public Function BuscarListadoOP() As DataTable
        Return PRODUCCIONDAL.BuscarListadoOP()
    End Function

    Public Function BuscarSanciones() As DataTable
        Return PRODUCCIONDAL.BuscarSanciones()
    End Function

    Public Function SaveRow(ByVal BONOPRODUCCION As BONOPRODBE, ByVal flagaccion As String) As String
        Return PRODUCCIONDAL.SaveRow(BONOPRODUCCION, flagaccion)
    End Function

    Public Function ListadoBonoProduccion(ByVal anho As String, ByVal mes As String) As DataTable
        Return PRODUCCIONDAL.BuscarOperacionxProceso(anho, mes)
    End Function

    Public Function SelectAllBPJefe(ByVal anho As String, ByVal mes As String) As DataTable
        Return PRODUCCIONDAL.SelectAllBPJefe(anho, mes)
    End Function
    Public Function SelectAllBPPlanta(ByVal anho As String, ByVal mes As String) As DataTable
        Return PRODUCCIONDAL.SelectAllBPPlanta(anho, mes)
    End Function

    Public Function SelectAllBPrrhh(ByVal anho As String, ByVal mes As String) As DataTable
        Return PRODUCCIONDAL.SelectAllBPRRHH(anho, mes)
    End Function

    Public Function BuscarLineaPersona(ByVal codigo As String) As DataTable
        Return PRODUCCIONDAL.BuscarLineaPersona(codigo)
    End Function

    Public Sub ActualizarProcesos(ByVal codOperacion As String, ByVal codProceso As String, ByVal cantidad As String)
        PRODUCCIONDAL.ActualizadProcesos(codOperacion, codProceso, cantidad)
    End Sub

    Public Sub ActualizarBonosProduccion(ByVal dt As DataTable)
        PRODUCCIONDAL.ActualizarBonosProduccion(dt)
    End Sub

    Public Function ActualizarEstBP(ByVal tipo As String, ByVal perCod As String, ByVal ordProd As String, ByVal fecha As String, ByVal proceso As String) As String
        Return PRODUCCIONDAL.ActualizarEstBP(tipo, perCod, ordProd, fecha, proceso)
    End Function
End Class
