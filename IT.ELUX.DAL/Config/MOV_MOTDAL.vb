Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class MOV_MOTDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelectMot(ByVal sT_doc As String, ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_MOV_MOT_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc", sT_doc),
                                                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count = 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
End Class
