Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class TipoFallaBL
    Implements IBaseBL(Of TipoFallaBE)

    Public Function LastCodigo(ParamArray Argumentos() As Object) As Object Implements IBaseBL(Of TipoFallaBE).LastCodigo
        Throw New NotImplementedException()
    End Function

    Public Function Insert(Argumentos As TipoFallaBE) As Object Implements IBaseBL(Of TipoFallaBE).Insert
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllDt(ParamArray Argumentos() As Object) As DataTable Implements IBaseBL(Of TipoFallaBE).SelectAllDt
        Dim oTipoFallaDAL As New TipoFallaDAL()
        Return oTipoFallaDAL.SelectAllDt(Argumentos)

    End Function

    Public Function SelectByCodigoDt(ParamArray Argumentos() As Object) As DataTable Implements IBaseBL(Of TipoFallaBE).SelectByCodigoDt
        Throw New NotImplementedException()
    End Function

    Public Function Update(Argumentos As TipoFallaBE) As Integer Implements IBaseBL(Of TipoFallaBE).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(ParamArray Argumentos() As Object) As Integer Implements IBaseBL(Of TipoFallaBE).Delete
        Throw New NotImplementedException()
    End Function
End Class
