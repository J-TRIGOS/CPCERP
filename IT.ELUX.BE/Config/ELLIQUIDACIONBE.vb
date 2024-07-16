Public Class ELLIQUIDACIONBE
    'Campos de la entidad
    Private manho As String
    Private mcomision As Double
    Private mdias As Double
    Private mgratis As Double
    Private mhextras As Double
    Private minteres As Double
    Private mmes As String
    Private mmeses As Double
    Private mmonto As Double
    Private mmonto_cts As Double
    Private mnombre As String
    Private motros As Double
    Private mper_cod As String
    Private mprdo_pago As Double
    Private msubsidio As Double
    Private musuario As String
    Private mvacaciones As Double

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property comision As Double
        Get
            Return mcomision
        End Get
        Set(value As Double)
            mcomision = value
        End Set
    End Property

    Public Property dias As Double
        Get
            Return mdias
        End Get
        Set(value As Double)
            mdias = value
        End Set
    End Property

    Public Property gratis As Double
        Get
            Return mgratis
        End Get
        Set(value As Double)
            mgratis = value
        End Set
    End Property

    Public Property Hextras As Double
        Get
            Return mhextras
        End Get
        Set(value As Double)
            mhextras = value
        End Set
    End Property

    Public Property interes As Double
        Get
            Return minteres
        End Get
        Set(value As Double)
            minteres = value
        End Set
    End Property

    Public Property mes As String
        Get
            Return mmes
        End Get
        Set(value As String)
            mmes = value
        End Set
    End Property

    Public Property meses As Double
        Get
            Return mmeses
        End Get
        Set(value As Double)
            mmeses = value
        End Set
    End Property

    Public Property monto As Double
        Get
            Return mmonto
        End Get
        Set(value As Double)
            mmonto = value
        End Set
    End Property

    Public Property monto_cts As Double
        Get
            Return mmonto_cts
        End Get
        Set(value As Double)
            mmonto_cts = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return mnombre
        End Get
        Set(value As String)
            mnombre = value
        End Set
    End Property

    Public Property otros As Double
        Get
            Return motros
        End Get
        Set(value As Double)
            motros = value
        End Set
    End Property

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property prdo_pago As Double
        Get
            Return mprdo_pago
        End Get
        Set(value As Double)
            mprdo_pago = value
        End Set
    End Property

    Public Property subsidio As Double
        Get
            Return msubsidio
        End Get
        Set(value As Double)
            msubsidio = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return musuario
        End Get
        Set(value As String)
            musuario = value
        End Set
    End Property

    Public Property vacaciones As Double
        Get
            Return mvacaciones
        End Get
        Set(value As Double)
            mvacaciones = value
        End Set
    End Property
End Class
