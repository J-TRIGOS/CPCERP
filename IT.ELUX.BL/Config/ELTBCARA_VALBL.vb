Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCARA_VALBL
    Private ELTBCARA_VALDAL As New ELTBCARA_VALDAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"


    Public Sub SelectRow(ByVal sCode As String, ByVal lv As ListBox)

        ELTBCARA_VALDAL.SelectRow(sCode, lv)

    End Sub


#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBCARA_VALBE As ELTBCARA_VALBE, ByVal flagAccion As String, ByVal lv As ListBox) As String

        Return ELTBCARA_VALDAL.SaveRow(ELTBCARA_VALBE, flagAccion, lv)

    End Function

#End Region

End Class
