Public Interface IBaseDAL(Of T)
    Function LastCodigo(ByVal Argumentos As System.Object) As Object

    Function Insert(ByVal Argumentos As T) As Object

    Function SelectAllDt(ByVal ParamArray Argumentos() As System.Object) As DataTable

    Function SelectByCodigoDt(ByVal ParamArray Argumentos() As System.Object) As DataTable

    Function Update(ByVal Argumentos As T) As Integer

    Function Delete(ByVal ParamArray Argumentos() As System.Object) As Integer
End Interface
