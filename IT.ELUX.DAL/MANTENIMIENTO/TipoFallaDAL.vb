Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.BE
Imports IT.ELUX.Connect

Public Class TipoFallaDAL
    Inherits BaseDatosORACLE
    Implements IBaseDAL(Of TipoFallaBE)

    Public Function LastCodigo(Argumentos As Object) As Object Implements IBaseDAL(Of TipoFallaBE).LastCodigo
        Throw New NotImplementedException()
    End Function

    Public Function Insert(Argumentos As TipoFallaBE) As Object Implements IBaseDAL(Of TipoFallaBE).Insert
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllDt(ParamArray Argumentos() As Object) As DataTable Implements IBaseDAL(Of TipoFallaBE).SelectAllDt
        'Dim dt As DataTable
        'Try
        '    Using ds As DataSet = Me.GetDataSet("PKG_MANTENIMIENTO.SP_SelecionarTipoFalla", Argumentos)
        '        dt = ds.Tables(0)
        '    End Using
        '    Return dt
        'Catch ex As Exception
        '    Throw ex
        'End Try
        Dim cmd As New OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReaderNew("PKG_MANTENIMIENTO.SP_TipoFallaSelectAll",
                                                           {
                                                           New OracleParameter("@INT_ESTCOD_", Argumentos(0))
                                                           })
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectByCodigoDt(ParamArray Argumentos() As Object) As DataTable Implements IBaseDAL(Of TipoFallaBE).SelectByCodigoDt
        Throw New NotImplementedException()
    End Function

    Public Function Update(Argumentos As TipoFallaBE) As Integer Implements IBaseDAL(Of TipoFallaBE).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(ParamArray Argumentos() As Object) As Integer Implements IBaseDAL(Of TipoFallaBE).Delete
        Throw New NotImplementedException()
    End Function
End Class
