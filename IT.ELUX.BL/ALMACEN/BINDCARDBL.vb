Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class BINDCARDBL
    Private BINDCARDDAL As New BINDCARDDAL
    Private BINDCARDDAL2 As New BINDCARDDAL2

    Public Function SaveRow(ByVal BindCard As BINDCARDBE, ByVal flagaccion As String) As String
        Return BINDCARDDAL.SaveRow(BindCard, flagaccion)
    End Function

    Public Function VerificarRegistro(ByVal BindCard As BINDCARDBE) As DataTable
        Return BINDCARDDAL.VerificarRegistro(BindCard)
    End Function

    Public Function VerificarGuia(ByVal BindCard As BINDCARDBE) As DataTable
        Return BINDCARDDAL.VerificarGuia(BindCard)
    End Function

    Public Function SelBindCard(ByVal anho As String, ByVal mes As String, ByVal est As String) As DataTable
        Return BINDCARDDAL.SelBindCard(anho, mes, est)
    End Function

    Public Function ListadoOPAtendido(ByVal anho As String, ByVal mes As String) As DataTable
        Return BINDCARDDAL.ListadoOPAtendido(anho, mes)
    End Function

    Public Function ListadoConsDifFecha(ByVal anho As String, ByVal mes As String) As DataTable
        Return BINDCARDDAL.ListadoConsDifFecha(anho, mes)
    End Function

    Public Function ListadoReingresos(ByVal anho As String, ByVal mes As String) As DataTable
        Return BINDCARDDAL.ListadoReingresos(anho, mes)
    End Function

    Public Function ListadoFecMaxima(ByVal anho As String, ByVal mes As String) As DataTable
        Return BINDCARDDAL.ListadoFecMaxima(anho, mes)
    End Function

    Public Function ActualizarBindCard(ByVal bindcard As BINDCARDBE, ByVal flagAccion As String) As String
        Return BINDCARDDAL.SaveRow(bindcard, flagAccion)
    End Function

    Public Function BuscarCentroCosto(ByVal codigo As String) As DataTable
        Return BINDCARDDAL2.BuscarCentroCosto(codigo)
    End Function

    Public Function VerificarEstBindCard(ByVal mes As String, ByVal anho As String) As DataTable
        Return BINDCARDDAL.VerificarEstBindCard(mes, anho)
    End Function

    Public Function SelectBindCardNro(ByVal nro As String, ByVal mes As String, ByVal anho As String) As DataTable
        Return BINDCARDDAL.SelectBindCardNro(nro, mes, anho)
    End Function

    Public Function BuscarDatosOP(ByVal numOP As String) As DataTable
        Return BINDCARDDAL.BuscarDatosOP(numOP)
    End Function

    Public Function VerificarEstadoGuia(ByVal guia As String, ByVal articulo As String) As DataTable
        Return BINDCARDDAL.VerificarEstadoGuia(guia, articulo)
    End Function

    Public Function VerificarUsuario(ByVal usuario As String) As DataTable
        Return BINDCARDDAL.VerificarUsuario(usuario)
    End Function

    Public Function VerificarOPSubLinea(ByVal artOP As String, ByVal artCons As String) As DataTable
        Return BINDCARDDAL.VerificarOPSubLinea(artOP, artCons)
    End Function
End Class

