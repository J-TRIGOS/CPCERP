Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBPROVEEDORESDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVEEDORES_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectVendedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_VENDEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActi_Serv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVEEDORES_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVEEDORESGRID_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", sOpcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectUbigeo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_UBIGEO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Private Sub InsertRow(ByVal ELTBPROVEEDORESBE As ELTBPROVEEDORESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgdir As DataGridView, ByVal dgcor As DataGridView, ByVal dgtel As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROVEEDORES_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ruc
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.nom
        cmd.Parameters.Add("@dni", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dni
        cmd.Parameters.Add("@dir", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dir
        cmd.Parameters.Add("@dist", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dist
        cmd.Parameters.Add("@ciudad", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ciudad
        cmd.Parameters.Add("@telef", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.telef
        cmd.Parameters.Add("@vend_resp", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.vend_resp
        cmd.Parameters.Add("@pais", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.pais
        cmd.Parameters.Add("@ubigeo", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ubigeo
        cmd.Parameters.Add("@x_cli", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_cli
        cmd.Parameters.Add("@x_ext", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_ext
        cmd.Parameters.Add("@x_prov", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_prov
        cmd.Parameters.Add("@efic_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.efic_cod
        cmd.Parameters.Add("@nego_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.nego_cod
        cmd.Parameters.Add("@ciiu_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ciiu_cod
        cmd.Parameters.Add("@fec_cred", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.Fec_cred
        cmd.Parameters.Add("@x_ret", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_ret
        cmd.Parameters.Add("@x_per", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_per
        cmd.Parameters.Add("@cta", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cta
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = ELTBPROVEEDORESBE.porc
        cmd.Parameters.Add("@coddet", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.coddet
        cmd.Parameters.Add("@digverif", OracleDbType.Int32).Value = ELTBPROVEEDORESBE.Digverif
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AGREGAR DIRECCIONES
        Dim Dir_cod, nom, distrito, ciudad, pais, prov, tip_zona_cod, tip_via_cod, dpto, estado, ubigeo, x_cont As String
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dgdir.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDORESdir_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cont = cont + 1
            Dir_cod = CStr(cont).PadLeft(2, "0")
            nom = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            distrito = IIf(IsDBNull(RTrim(row.Cells("DISTRITO").Value)), "", RTrim(row.Cells("DISTRITO").Value))
            ciudad = IIf(IsDBNull(RTrim(row.Cells("DPTO").Value)), "", RTrim(row.Cells("DPTO").Value))
            pais = ELTBPROVEEDORESBE.pais
            prov = IIf(IsDBNull(RTrim(row.Cells("PROV").Value)), "", RTrim(row.Cells("PROV").Value))
            tip_zona_cod = ""
            tip_via_cod = ""
            dpto = IIf(IsDBNull(RTrim(row.Cells("DPTO").Value)), "", RTrim(row.Cells("DPTO").Value))
            ubigeo = IIf(IsDBNull(RTrim(row.Cells("UBIGEO").Value)), "", RTrim(row.Cells("UBIGEO").Value))
            estado = "H"
            x_cont = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = Dir_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nom
            cmd.Parameters.Add("@distrito", OracleDbType.Varchar2).Value = distrito
            cmd.Parameters.Add("@ciudad", OracleDbType.Varchar2).Value = ciudad
            cmd.Parameters.Add("@pais", OracleDbType.Varchar2).Value = pais
            cmd.Parameters.Add("@prov", OracleDbType.Varchar2).Value = prov
            cmd.Parameters.Add("@tip_zona_cod", OracleDbType.Varchar2).Value = tip_zona_cod
            cmd.Parameters.Add("@tip_via_cod", OracleDbType.Varchar2).Value = tip_via_cod
            cmd.Parameters.Add("@dpto", OracleDbType.Varchar2).Value = dpto
            cmd.Parameters.Add("@ubigeo,", OracleDbType.Varchar2).Value = ubigeo
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = estado
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AGREGAR CORREOS
        Dim cor_cod, nomcor, contacto, cargo, telefono, estadocor, x_cont_cor As String
        cont = 0
        For Each row As DataGridViewRow In dgcor.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDOREScor_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cont = cont + 1
            cor_cod = cont
            nomcor = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            contacto = IIf(IsDBNull(RTrim(row.Cells("CONTACTO").Value)), "", RTrim(row.Cells("CONTACTO").Value))
            cargo = IIf(IsDBNull(RTrim(row.Cells("CARGO").Value)), "", RTrim(row.Cells("CARGO").Value))
            telefono = IIf(String.IsNullOrEmpty(RTrim(row.Cells("TELEFONO").Value)), "0", RTrim(row.Cells("TELEFONO").Value))
            estadocor = "H"
            x_cont_cor = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@cor_cod", OracleDbType.Double).Value = cor_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nomcor
            cmd.Parameters.Add("@contacto", OracleDbType.Varchar2).Value = contacto
            cmd.Parameters.Add("@cargo", OracleDbType.Varchar2).Value = cargo
            cmd.Parameters.Add("@telefono", OracleDbType.Double).Value = telefono
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = estadocor
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont_cor
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AGREGAR TELEFONOS
        Dim tel_cod, nomtel, contactotel, estadotel, x_cont_tel As String
        cont = 0
        For Each row As DataGridViewRow In dgtel.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDOREStel_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cont = cont + 1
            tel_cod = cont
            nomtel = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            contactotel = IIf(IsDBNull(RTrim(row.Cells("CONTACTO").Value)), "", RTrim(row.Cells("CONTACTO").Value))
            estadotel = "H"
            x_cont_tel = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@tel_cod", OracleDbType.Double).Value = tel_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nomtel
            cmd.Parameters.Add("@contacto", OracleDbType.Varchar2).Value = contactotel
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = estadotel
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont_tel
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBPROVEEDORESBE.Dia4  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro el PROVEEDORES : " + ELTBPROVEEDORESBE.cod + "-" + ELTBPROVEEDORESBE.nom
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBPROVEEDORESBE As ELTBPROVEEDORESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgdir As DataGridView, ByVal dgcor As DataGridView, ByVal dgtel As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROVEEDORES_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ruc
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.nom
        cmd.Parameters.Add("@dni", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dni
        cmd.Parameters.Add("@dir", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dir
        cmd.Parameters.Add("@dist", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.dist
        cmd.Parameters.Add("@ciudad", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ciudad
        cmd.Parameters.Add("@telef", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.telef
        cmd.Parameters.Add("@vend_resp", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.vend_resp
        cmd.Parameters.Add("@pais", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.pais
        cmd.Parameters.Add("@ubigeo", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ubigeo
        cmd.Parameters.Add("@x_cli", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_cli
        cmd.Parameters.Add("@x_ext", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_ext
        cmd.Parameters.Add("@x_prov", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_prov
        cmd.Parameters.Add("@efic_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.efic_cod
        cmd.Parameters.Add("@nego_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.nego_cod
        cmd.Parameters.Add("@ciiu_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.ciiu_cod
        cmd.Parameters.Add("@x_ret", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_ret
        cmd.Parameters.Add("@x_per", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.x_per
        cmd.Parameters.Add("@cta", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cta
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = ELTBPROVEEDORESBE.porc
        cmd.Parameters.Add("@coddet", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.coddet
        cmd.Parameters.Add("@digverif", OracleDbType.Int32).Value = ELTBPROVEEDORESBE.Digverif
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DIRECCION CORREO Y TELEFONO SEGUN CODIGO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROVEEDORES_DEL_DIRCORTEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AGREGAR DIRECCIONES
        Dim Dir_cod, nom, distrito, ciudad, pais, prov, tip_zona_cod, tip_via_cod, dpto, ubigeo, x_cont As String
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dgdir.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDORESdir_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cont = cont + 1
            Dir_cod = CStr(cont).PadLeft(2, "0")
            nom = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            distrito = IIf(IsDBNull(RTrim(row.Cells("DISTRITO").Value)), "", RTrim(row.Cells("DISTRITO").Value))
            ciudad = IIf(IsDBNull(RTrim(row.Cells("DPTO").Value)), "", RTrim(row.Cells("DPTO").Value))
            pais = ELTBPROVEEDORESBE.pais
            prov = IIf(IsDBNull(RTrim(row.Cells("PROV").Value)), "", RTrim(row.Cells("PROV").Value))
            tip_zona_cod = ""
            tip_via_cod = ""
            dpto = IIf(IsDBNull(RTrim(row.Cells("DPTO").Value)), "", RTrim(row.Cells("DPTO").Value))
            ubigeo = IIf(IsDBNull(RTrim(row.Cells("UBIGEO").Value)), "", RTrim(row.Cells("UBIGEO").Value))
            x_cont = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = Dir_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nom
            cmd.Parameters.Add("@distrito", OracleDbType.Varchar2).Value = distrito
            cmd.Parameters.Add("@ciudad", OracleDbType.Varchar2).Value = ciudad
            cmd.Parameters.Add("@pais", OracleDbType.Varchar2).Value = pais
            cmd.Parameters.Add("@prov", OracleDbType.Varchar2).Value = prov
            cmd.Parameters.Add("@tip_zona_cod", OracleDbType.Varchar2).Value = tip_zona_cod
            cmd.Parameters.Add("@tip_via_cod", OracleDbType.Varchar2).Value = tip_via_cod
            cmd.Parameters.Add("@dpto", OracleDbType.Varchar2).Value = dpto
            cmd.Parameters.Add("@ubigeo,", OracleDbType.Varchar2).Value = ubigeo
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AGREGAR CORREOS
        Dim cor_cod, nomcor, contacto, cargo, telefono, x_cont_cor As String
        cont = 0
        For Each row As DataGridViewRow In dgcor.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDOREScor_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cont = cont + 1
            cor_cod = cont
            nomcor = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            contacto = IIf(IsDBNull(RTrim(row.Cells("CONTACTO").Value)), "", RTrim(row.Cells("CONTACTO").Value))
            cargo = IIf(IsDBNull(RTrim(row.Cells("CARGO").Value)), "", RTrim(row.Cells("CARGO").Value))
            telefono = IIf(String.IsNullOrEmpty(RTrim(row.Cells("TELEFONO").Value)), "0", RTrim(row.Cells("TELEFONO").Value))
            x_cont_cor = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@cor_cod", OracleDbType.Double).Value = cor_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nomcor
            cmd.Parameters.Add("@contacto", OracleDbType.Varchar2).Value = contacto
            cmd.Parameters.Add("@cargo", OracleDbType.Varchar2).Value = cargo
            cmd.Parameters.Add("@telefono", OracleDbType.Double).Value = telefono
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont_cor
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AGREGAR TELEFONOS
        Dim tel_cod, nomtel, contactotel, x_cont_tel As String
        cont = 0
        For Each row As DataGridViewRow In dgtel.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVEEDOREStel_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cont = cont + 1
            tel_cod = cont
            nomtel = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            contactotel = IIf(IsDBNull(RTrim(row.Cells("CONTACTO").Value)), "", RTrim(row.Cells("CONTACTO").Value))
            x_cont_tel = IIf(RTrim(row.Cells("X_CONT").Value = "NO"), "0", "1")
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBPROVEEDORESBE.cod
            cmd.Parameters.Add("@tel_cod", OracleDbType.Double).Value = tel_cod
            cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = nomtel
            cmd.Parameters.Add("@contacto", OracleDbType.Varchar2).Value = contactotel
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = x_cont_tel
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBPROVEEDORESBE.Dia4  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el PROVEEDORES : " + ELTBPROVEEDORESBE.cod + "-" + ELTBPROVEEDORESBE.nom
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBPROVEEDORESBE As ELTBPROVEEDORESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROVEEDORES_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBPROVEEDORESBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBPROVEEDORESBE As ELTBPROVEEDORESBE, ByVal flagAccion As String, ByVal dgdir As DataGridView, ByVal dgcor As DataGridView, ByVal dgtel As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(ELTBPROVEEDORESBE, cn, sqlTrans, dgdir, dgcor, dgtel)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBPROVEEDORESBE, cn, sqlTrans, dgdir, dgcor, dgtel)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBPROVEEDORESBE, cn, sqlTrans)
            End If

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
End Class
