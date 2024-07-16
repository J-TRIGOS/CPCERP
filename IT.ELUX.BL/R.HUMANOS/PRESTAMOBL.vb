Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class PRESTAMOBL
    Dim PRESTAMODAL As New PRESTAMODAL

    Public Function BuscarListadoPrestamos(ByVal ANHO As String, ByVal est As String, ByVal tipo As String) As DataTable
        Return PRESTAMODAL.BuscarListadoPrestamos(ANHO, est, tipo)
    End Function

    Public Function BuscarNomDocumento(ByVal tipo As String) As DataTable
        Return PRESTAMODAL.BuscarNomDocumento(tipo)
    End Function

    Public Function BuscarNumPrdo(ByVal prdo As String) As DataTable
        Return PRESTAMODAL.BuscarNumPrdo(prdo)
    End Function

    Public Function VerificarNumero(ByVal tipo As String, ByVal serie As String) As DataTable
        Return PRESTAMODAL.VerificarNumero(tipo, serie)
    End Function

    Public Function BuscarPeriodo(ByVal fecha As String) As DataTable
        Return PRESTAMODAL.BuscarPeriodo(fecha)
    End Function

    Public Function NuevoPeriodo(ByVal prdo As String, ByVal fecha As String) As DataTable
        Return PRESTAMODAL.NuevoPeriodo(prdo, fecha)
    End Function

    Public Function SaveRow(ByVal PRESTAMOBE As PRESTAMOBE, ByVal flagaccion As String, ByVal dg As DataGridView) As String
        Return PRESTAMODAL.SaveRow(PRESTAMOBE, flagaccion, dg)
    End Function

    Public Function GetData(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codigo As String) As DataTable
        Return PRESTAMODAL.GetData(tipo, serie, numero, codigo)
    End Function

    Public Function GetDetData(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codigo As String) As DataTable
        Return PRESTAMODAL.GetDetData(tipo, serie, numero, codigo)
    End Function

    Public Function ListadoCC(ByVal mes As String, ByVal anho As String) As DataTable
        Return PRESTAMODAL.ListadoCC(mes, anho)
    End Function
End Class
