Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ALMACENBL
    Private ALMACENDAL As New ALMACENDAL
    Public Function SelectAlmacen() As DataTable
        Return ALMACENDAL.SelectAlmacen()
    End Function
End Class
