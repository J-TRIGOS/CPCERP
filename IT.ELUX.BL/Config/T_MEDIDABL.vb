Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class T_MEDIDABL
    Private T_MEDIDADAL As New T_MEDIDADAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"


    Public Function SelectAll() As DataTable
        Return T_MEDIDADAL.SelectAll()
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return T_MEDIDADAL.SelectRow(sCode)
    End Function

    Public Function LASTCODIGO() As String
        Return T_MEDIDADAL.LastCodigo()
    End Function

    Public Function SelMedidaAll() As DataTable
        Return T_MEDIDADAL.SelMedidaAll()
    End Function

    Public Function SelMedidaAllNew() As DataTable
        Return T_MEDIDADAL.SelMedidaAllNew()
    End Function

    Public Function SelectMedida() As DataTable
        Return T_MEDIDADAL.SelectMedida()
    End Function
    Public Function SelectMedida2() As DataTable
        Return T_MEDIDADAL.SelectMedida2()
    End Function
    Public Function SelectMedida1(ByVal sCode As String) As DataTable
        Return T_MEDIDADAL.SelectMedida1(sCode)
    End Function
    Public Function SelectNomMedida() As DataTable
        Return T_MEDIDADAL.SelectNomMedida()
    End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function DeleteMenu(ByVal sql As String) As DataTable


        ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    End Function

    Public Function SaveRow(ByVal T_MEDIDABE As T_MEDIDABE, ByVal flagAccion As String) As String

        Return T_MEDIDADAL.SaveRow(T_MEDIDABE, flagAccion)

    End Function

#End Region
End Class
