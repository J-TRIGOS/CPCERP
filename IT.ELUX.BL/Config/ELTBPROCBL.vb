Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBPROCBL
    Private ELTBPROCDAL As New ELTBPROCDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBPROCDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBPROCDAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBPROCDAL.SelectRow(sCode)

    End Function


    Public Function SelectDescripcion() As DataTable

        Return ELTBPROCDAL.LISTCMB()

    End Function

    Public Function SelectAllLines() As DataTable
        Return ELTBPROCDAL.SelectAllLines()
    End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function DeleteMenu(ByVal sql As String) As DataTable


        ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    End Function

    Public Function SaveRow(ByVal ELTBPROCBE As ELTBPROCBE, ByVal flagAccion As String) As String

        Return ELTBPROCDAL.SaveRow(ELTBPROCBE, flagAccion)

    End Function

#End Region

End Class
