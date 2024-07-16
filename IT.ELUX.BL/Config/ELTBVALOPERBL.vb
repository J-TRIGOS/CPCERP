Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBVALOPERBL
    Private ELTBVALOPERDAL As New ELTBVALOPERDAL
#Region "Lectura de Datos"

    Public Sub SelectRow(ByVal sCode As String, ByVal lv As ListBox)

        ELTBVALOPERDAL.SelectRow(sCode, lv)

    End Sub

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBVALOPERBE As ELTBVALOPERBE, ByVal flagAccion As String, ByVal lv As ListBox) As String

        Return ELTBVALOPERDAL.SaveRow(ELTBVALOPERBE, flagAccion, lv)

    End Function

#End Region

End Class
