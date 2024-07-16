

Imports System.ComponentModel
    Imports System.Globalization
    Imports System.Runtime.InteropServices
    Imports System.Threading.Thread
    Imports System.Windows.Forms

'Public Class TextBoxNumericEx
Public Class ccInhLoginText3

    Inherits TextBox

#Region "Campos privados y protegidos de la clase."

    Private m_allowClear As Boolean = True
    Private m_allowClearSelection As Boolean = True
    Private m_allowCopy As Boolean = True
    Private m_allowCut As Boolean = True
    Private m_allowNullValue As Boolean = True
    Private m_allowPaste As Boolean = True
    Private m_allowSelectAll As Boolean = True
    Private m_allowUndo As Boolean = True
    Private m_backColor As Color = Color.White
    Private m_decimalPlaces As Int32 = 2
    Private m_decimalSeparator As Char = ","c
    Private m_decimalValue As Decimal = 0D
    Private m_formatNumber As Boolean = True
    Private m_groupSeparator As Char = "."c     ' Separador de miles
    Private m_mask As String = "#,##0.00"
    Private m_negativeSign As Char = "-"c
    Private m_positiveSign As Char = "+"c

    Private m_mi As MenuItem = Nothing
    Private m_cm As ContextMenu

    Protected Const EM_UNDO As Int32 = &HC7     ' Es el mensaje Deshacer para los controles TextBox de una única línea.
    Protected Const WM_CLEAR As Int32 = &H303
    Protected Const WM_COPY As Int32 = &H301
    Protected Const WM_CUT As Int32 = &H300
    Protected Const WM_PASTE As Int32 = &H302
    Protected Const WM_UNDO As Int32 = &H304    ' Es el mensaje Deshacer para los controles TextBox multilínea.

#End Region

#Region "Eventos de la clase."

    Public Event AllClearChanged As EventHandler
    Public Event AllClearSelectionChanged As EventHandler
    Public Event AllowCopyChanged As EventHandler
    Public Event AllowCutChanged As EventHandler
    Public Event AllowNullValueChanged As EventHandler
    Public Event AllowPasteChanged As EventHandler
    Public Event AllowSelectAllChanged As EventHandler
    Public Event AllowUndoChanged As EventHandler
    Public Event DecimalPlacesChanged As EventHandler
    Public Event DecimalValueChanged As EventHandler
    Public Event FormatNumberChanged As EventHandler

#End Region

#Region "Delegados de la clase."

    Private Delegate Sub DecimalValueHandler(value As String)

#End Region

#Region "Constructor predeterminado."

    Public Sub New()

        MyBase.New()
        MyBase.BackColor = m_backColor

        CreateMenu()

        ' Por defecto, el valor del texto estará alineado a la derecha.
        '
        MyBase.TextAlign = HorizontalAlignment.Right

        ' Obtengo el carácter separador decimal existente
        ' actualmente en la configuración regional de Windows. 
        ' 
        ' NOTA: como en teoría, los distintos separadores existentes en la configuración regional de Windows,
        ' pueden tener más de un carácter, me inclino por declarar las distintas variables con el tipo de dato
        ' Char, y seleccionar el primer carácter de los valores alfanuméricos devueltos por las distintas
        ' propiedades del objeto NumberFormatInfo.
        '
        Dim numberFormatInfo As NumberFormatInfo = CurrentThread.CurrentCulture.NumberFormat

        m_decimalSeparator = numberFormatInfo.NumberDecimalSeparator.Chars(0)
        m_groupSeparator = numberFormatInfo.NumberGroupSeparator.Chars(0)
        m_negativeSign = numberFormatInfo.NegativeSign.Chars(0)
        m_positiveSign = numberFormatInfo.PositiveSign.Chars(0)

    End Sub

#End Region

#Region "Propiedades públicas de la clase."

    ''' <summary>
    ''' Indica que no se creará una nueva línea al pulsar la tecla Intro
    ''' en un control multilínea.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property AcceptsReturn() As Boolean
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Indica que no se escribirá un carácter TAB cuando se pulse la tecla de tabulación
    ''' en un control multilínea.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property AcceptsTab() As Boolean
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Indica si el control admite valores NULL.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Indica si el control admite valores NULL."), Category("Behavior"), DefaultValue(True)>
    Public Property AllowNullValue() As Boolean
        Get
            Return m_allowNullValue
        End Get
        Set(value As Boolean)

            If (m_allowNullValue = value) Then Return

            m_allowNullValue = value

            ' Primero opto por modificar la propiedad Text.
            '
            SetText(MyBase.Text)

            ' Y después desencadeno el evento AllowNullValueChanged
            '
            RaiseEvent AllowNullValueChanged(Me, EventArgs.Empty)

        End Set
    End Property

    ''' <summary>
    ''' Indica si se puede o no eliminar todo el texto existente en el control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se puede o no eliminar todo el texto existente en el control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowClear As Boolean
        Get
            Return m_allowClear
        End Get
        Set(value As Boolean)
            If (m_allowClear <> value) Then
                m_allowClear = value
                RaiseEvent AllClearChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Indica si se puede o no eliminar el texto seleccionado en el control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se puede o no eliminar el texto seleccionado en el control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowClearSelection() As Boolean
        Get
            Return m_allowClearSelection
        End Get
        Set(value As Boolean)
            If (m_allowClearSelection <> value) Then
                m_allowClearSelection = value
                RaiseEvent AllClearSelectionChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Indica si se puede o no copiar el texto del control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se puede o no copiar el texto del control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowCopy() As Boolean
        Get
            Return m_allowCopy
        End Get
        Set(value As Boolean)
            If (m_allowCopy = value) Then Return

            m_allowCopy = value
            RaiseEvent AllowCopyChanged(Me, EventArgs.Empty)

            Static permitirCortar As Boolean

            If Not (m_allowCopy) Then
                ' Primero guardo el estado del campo m_allowCut.
                permitirCortar = m_allowCut

                ' Si no se permite Copiar, tampoco se permite Cortar.
                AllowCut = False

            ElseIf (permitirCortar) Then
                AllowCut = True

            End If

        End Set
    End Property

    ''' <summary>
    ''' Indica si se puede o no cortar el texto del control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se puede o no cortar el texto del control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowCut() As Boolean
        Get
            Return m_allowCut
        End Get
        Set(value As Boolean)
            If (m_allowCut <> value) Then
                m_allowCut = value
                RaiseEvent AllowCutChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Indica si se puede o no pegar texto en el control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se puede o no pegar texto en el control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowPaste() As Boolean
        Get
            Return m_allowPaste
        End Get
        Set(value As Boolean)
            If (m_allowPaste <> value) Then
                m_allowPaste = value
                RaiseEvent AllowPasteChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Indica si el control seleccionará todo el texto cuando obtenga el foco.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Indica si el control seleccionará todo el texto cuando obtenga el foco."),
    Category("Behavior"), DefaultValue(True)>
    Public Property AllowSelectAll() As Boolean
        Get
            Return (m_allowSelectAll)
        End Get
        Set(value As Boolean)
            If (m_allowSelectAll <> value) Then
                m_allowSelectAll = value
                If ((Not (m_allowSelectAll)) AndAlso (SelectionLength > 0)) Then SelectionLength = 0
                RaiseEvent AllowSelectAllChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Indica si se permite o no la operación de deshacer en el control.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Description("Indica si se permite o no la operación de deshacer en el control."), DefaultValue(True), Category("Behavior")>
    Public Property AllowUndo() As Boolean
        Get
            Return m_allowUndo
        End Get
        Set(value As Boolean)
            If (m_allowUndo <> value) Then
                m_allowUndo = value

                If Not (m_allowUndo) Then
                    ' Elimino la información del buffer de deshacer.
                    ClearUndo()

                    ' Const EM_EMPTYUNDOBUFFER As Integer = &HCD
                End If

                RaiseEvent AllowUndoChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

#Region "BackColor"

    ''' <summary>
    ''' Obtiene o establece el color de fondo del control.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Property BackColor() As Color
        <Diagnostics.DebuggerNonUserCode()>
        Get
            Return m_backColor
        End Get
        Set(value As Color)

            ' Desencadeno el evento BackColorChanged, para notificar
            ' el cambio de color a la clase base. Si no llamo al
            ' evento, tendría que establecer el valor en la 
            ' propiedad BackColor de la clase base.
            ' 
            If Not (m_backColor.Equals(value)) Then
                ' Siempre que el valor sea distinto al color
                ' actualmente establecido.
                m_backColor = value
                Me.OnBackColorChanged(EventArgs.Empty)
            End If

        End Set
    End Property

    <EditorBrowsable(EditorBrowsableState.Never)>
    Friend Function ShouldSerializeBackColor() As Boolean
        Return Not (Me.BackColor.Equals(Color.White))
    End Function

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Sub ResetBackColor()
        Me.BackColor = Color.White
    End Sub

#End Region

    ''' <summary>
    ''' Especifica el uso de caracteres normales en el control.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property CharacterCasing() As CharacterCasing
        ' Únicamente sombreo la propiedad para que no aparezca
        ' en el Cuadro de Herramientas.
        Get
            Return Windows.Forms.CharacterCasing.Normal
        End Get
    End Property

    ''' <summary>
    ''' Obtiene y devuelve el número de decimales que se muestran en el valor del control."
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <DefaultValue(2), Description("Indica el número de decimales que se muestran."), Category("Data")>
    Public Property DecimalPlaces() As Int32
        Get
            Return m_decimalPlaces
        End Get
        Set(value As Int32)

            If (value < 0) OrElse (value > 28) Then
                Throw New ArgumentOutOfRangeException("value", "El rango de valores permitidos tiene que estar entre 0 y 28.")
            End If

            If (m_decimalPlaces = value) Then Return

            m_decimalPlaces = value
            m_mask = "#,##0." & New String("0"c, value)

            ' Primero opto por desencadenar el evento DecimalPlacesChanged
            '
            RaiseEvent DecimalPlacesChanged(Me, EventArgs.Empty)

            ' Y después, modifico la propiedad Text.
            '
            SetText(MyBase.Text)

        End Set
    End Property

    ''' <summary>
    ''' Obtiene un tipo de dato Decimal con el valor real del número escrito.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public ReadOnly Property DecimalValue() As Decimal
        Get
            Return m_decimalValue
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece un valor que indicará si el número se tiene que
    ''' formatear con la máscara especificada cuando el control pierda el foco.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Indica si se formateará el número al perder el control el foco."), Category("Behavior"), DefaultValue(True)>
    Public Property FormatNumber() As Boolean
        Get
            Return m_formatNumber
        End Get
        Set(value As Boolean)
            If (m_formatNumber = value) Then Return

            m_formatNumber = value

            ' Primero opto por desencadenar el evento FormatNumberChanged
            '
            RaiseEvent FormatNumberChanged(Me, EventArgs.Empty)

            ' Y después, modifico la propiedad Text.
            '
            SetText(MyBase.Text)
        End Set
    End Property

    ''' <summary>
    ''' La propiedad no tiene ningún efecto en el control.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property HideSelection As Boolean
        Get
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Obtiene la línea de texto existente en el control.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property Lines() As String
        Get
            Return Text
        End Get
    End Property

    ''' <summary>
    ''' Indica que el control no admite múltiples líneas.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Overrides Property MultiLine As Boolean
        Get
            Return False
        End Get
        Set(value As Boolean)
            MyBase.Multiline = False
        End Set
    End Property

    ''' <summary>
    ''' Indica que se han habilitado las teclas de acceso directo definidos.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shadows ReadOnly Property ShortcutsEnabled() As Boolean
        ' La propiedad ShortcutsEnabled de la clase base tiene
        ' que estar establecida en True para que se acepten
        ' las distintas combinaciones de teclas de Cortar,
        ' Copiar, etc.
        Get
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Obtiene y establece el texto actual del control NumericTextBox.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            SetText(value)
        End Set
    End Property

    ''' <summary>
    ''' Indica que el control no ajustará las palabras de forma automática al principio de la línea siguiente.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)>
    Public Shared Shadows ReadOnly Property WordWrap() As Boolean
        Get
            Return False
        End Get
    End Property

#End Region

#Region "Métodos sobrecargados y reemplazados de la clase base."

    ''' <summary>
    ''' Borra todo el texto del control de cuadro de texto.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Clear()

        ' Al establecer el valor Nothing, automáticamente se
        ' establece a False el valor de la propiedad Modified.
        '
        If (m_allowClear) Then Text = Nothing

    End Sub

    ''' <summary>
    ''' Borra todo el texto seleccionado en el control TextBox.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearSelection()

        ' El método de la clase base, se limita a enviar el mensaje EM_EMPTYUNDOBUFFER 
        ' a la función SendMessage de la API de Windows, para borrar el búfer Deshacer.

        If ((m_allowClearSelection) And (SelectionLength > 0)) Then

            ' Procesamos el mensaje WM_CLEAR.
            '
            Dim m As Message

            ' Eliminar el texto seleccionado.
            '
            m.Msg = WM_CLEAR
            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

        End If

    End Sub

    ''' <summary>
    ''' Copia la selección actual del cuadro de texto en el Portapapeles.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Copy()

        ' El método de la clase base, se limita a enviar el mensaje WM_COPY
        ' a la función SendMessage de la API de Windows, para copiar en el
        ' portapapeles el texto seleccionado actualmente en el control.

        If ((m_allowCopy) And (SelectionLength > 0)) Then

            ' Procesamos el mensaje WM_COPY.
            '
            Dim m As Message

            ' Copiar
            m.Msg = WM_COPY
            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

        End If

    End Sub

    ''' <summary>
    ''' Mueve la selección actual del cuadro de texto al Portapapeles.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Cut()

        ' El método de la clase base, se limita a enviar el mensaje WM_CUT
        ' a la función SendMessage de la API de Windows, para cortar en el
        ' portapapeles el texto seleccionado actualmente en el control,
        ' eliminándolo del mismo.

        ' Si no se permite Copiar, tampoco se permite Cortar.
        '
        If ((m_allowCopy) AndAlso ((m_allowCut) And (SelectionLength > 0))) Then

            ' Procesamos el mensaje WM_CUT.
            '
            Dim m As Message

            ' Cortar
            m.Msg = WM_CUT
            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

        End If

    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)

        ' Al entrar en el control, vuelvo a mostrar el texto sin formato.
        '
        If ((m_allowNullValue) AndAlso (m_decimalValue = 0D)) Then
            MyBase.Text = String.Empty

        Else
            MyBase.Text = CStr(m_decimalValue)

        End If

        If (m_allowSelectAll) Then
            SelectAll()

        Else
            MyBase.Select(SelectionStart, 0)

        End If

        MyBase.OnEnter(e)

    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)

        ' Primero llamo al mismo método de la clase base.
        '
        MyBase.OnKeyDown(e)

        If (e Is Nothing) Then Return

        ' Si en el evento KeyDown cliente se ha cancelado el evento,
        ' o se ha decidido no pasar la tecla al control subyacente,
        ' abandono el procedimiento.
        '
        If ((e.Control) And (Not (e.Alt))) Then
            ' En éste clase, sólo me interesan las siguientes
            ' combinaciones de teclas pulsadas solamente junto
            ' con la tecla Ctrl, pero no con la tecla Alt.
            '
            Select Case e.KeyCode
                Case Keys.A, Keys.E
                    ' Seleccionar todo. La combinación Ctrl + A sólo selecciona
                    ' el texto completo si el control TextBox no es multilínea,
                    ' y la combinación Ctrl + E si es multilínea.
                    '
                    If (m_allowSelectAll) Then SelectAll()

                    ' La tecla no la envío al control.
                    '
                    e.Handled = True

                Case Keys.X
                    ' Es la tecla para cortar el texto seleccionado. Pero si no 
                    ' hay texto seleccionado, se produce el clásico pitido.
                    '
                    e.Handled = (SelectionLength = 0)

                Case Keys.Return
                    ' Si el control no es multilínea, evito la pulsación Ctrl+Enter.
                    '
                    e.Handled = ((e.KeyCode) = Keys.Return) AndAlso (Not (MultiLine))

                Case Keys.Back
                    ' Al pulsar Ctrl+Back, se escribe un cuadrado en el control.
                    '
                    e.Handled = True

                Case Else
                    ' No envío al control las teclas de éste apartado, y 
                    ' de ésta manera evito el pitido que se produce
                    ' al pulsarlas.
                    '
                    ' Éstas teclas son algunas de las que habilita/inhabilita
                    ' la propiedad ShortcutsEnabled de la clase TextBoxBase,
                    ' de la que hereda el control TextBox, concretamente
                    ' la L, R, Y, Back.
                    '
                    Dim teclasNoPermitidas() As Char = {"B"c, "D"c, "F"c, "G"c, "I"c, "J"c, "K"c, "L"c, "M"c, "N"c,
                                                        "O"c, "P"c, "Q"c, "R"c, "S"c, "T"c, "U"c, "W"c, "Y"c}

                    Dim key As Char = Convert.ToChar(e.KeyCode)

                    Dim var As IEnumerable(Of Char) = From tecla As Char In teclasNoPermitidas
                                                      Where tecla = key
                                                      Select tecla
                    e.Handled = (var.Count = 1)

                    ' Las combinaciones de teclas que permito junto con la tecla Ctrl son:
                    '
                    ' Ctrl + C: copiar.
                    ' Ctrl + V: pegar.
                    ' Ctrl + H: elimina el carácter situado a la izquierda del cursor.
                    ' Ctrl + Z: deshacer.

            End Select

        ElseIf (e.KeyCode = Keys.Return) Then
            ' Si la tecla pulsada es la tecla Intro, evito el pitido que se
            ' produce en los controles TextBox no multilíne, no pasando el
            ' evento al control subyacente, (e.SupressKeyPress = True),  de
            ' ésta manera no tengo que cancelar el evento KeyPress: .NET 2.0 o superior.
            '
            e.Handled = True
            SetFocusNextControl()

        End If

        If (e.Control) Then
            Select Case e.KeyCode
                Case Keys.Tab
                    ' Se ha pulsado Ctrl+Tab, lo que hará que se inserte
                    ' una tabulación en un cuadro de texto multilínea.
                    '
                    ' Esta combinación de teclas no desencadena el evento
                    ' KeyPress, por lo que no la envío al control subyacente, 
                    '
                    If (MultiLine) Then e.Handled = True

            End Select

        End If

        ' Si se ha cancelado el evento, abandono el procedimiento.
        '
        If (e.Handled) Then Return

        ' Compruebo si es una tecla que debo permitir.
        '
        e.SuppressKeyPress = (Not (ValidateCharacter(e)))

    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)

        ' Primero llamo al método KeyPress de la clase base.
        '
        MyBase.OnKeyPress(e)

        ' NOTA: al ser un método visible externamente, se aconseja
        ' validar el parámetro 'e' antes de usarlo.
        '
        If (e Is Nothing) Then Return

        ' Como el menú contextual del control permite
        ' combinaciones de teclas (Ctrl+C, Ctrl+V, Ctrl+X),
        ' no puedo ejecutar la siguiente sentencia:
        '
        ' e.Handled = Not Char.IsNumber(e.KeyChar)

        ' Hay que comprobar la tecla seleccionada de la siguiente manera.
        '
        ' No se permiten letras.
        If (Char.IsLetter(e.KeyChar)) Then e.Handled = True

        ' No se permiten espacios en blanco.
        If (Char.IsWhiteSpace(e.KeyChar)) Then e.Handled = True

        ' No se permiten lo símbolos: +, $, €, |, =
        If (Char.IsSymbol(e.KeyChar)) Then e.Handled = True

        ' No se permiten los signos: - & ( ) % ¡ ! * { } [ ] / \ . ,
        If (Char.IsPunctuation(e.KeyChar)) Then e.Handled = True

        Dim ch As String = e.KeyChar

        Select Case ch
            Case m_decimalSeparator, m_groupSeparator   ' Separadores decimal y de miles.

                If (ch = m_groupSeparator) Then
                    ' Convierto el separador de miles en el separador decimal.
                    ' Como en teoría el separador decimal puede estar formado
                    ' por varios caracteres, selecciono el primero
                    e.KeyChar = m_decimalSeparator
                End If

                ' En la clase base no se admite el separador decimal.
                '
                e.Handled = ((SelectionStart = 0) And ((Text.Contains(m_negativeSign)) OrElse (Text.Contains(m_positiveSign))))

            Case m_positiveSign, m_negativeSign         ' Signos positivo y negativo
                ' En la clase base no se permiten los carácteres de signo (+ -).
                '
                e.Handled = False

                ' Establezco el punto de inserción para escribir
                ' el signo en la primera posición.
                '
                SelectionStart = 0

            Case Else

                If (Char.IsDigit(e.KeyChar)) Then

                    ' Índice de la posición del separador decimal.
                    '
                    Dim positionDecimalSeparator As Integer = Text.IndexOf(m_decimalSeparator)

                    If (positionDecimalSeparator > 0) Then

                        ' Números decimales que se han escrito.
                        '
                        Dim decimales As Integer = Text.Length - positionDecimalSeparator

                        ' Si la posición actual del punto de inserción (SelectionStart)
                        ' es superior a la posición donde se encuentra el carácter
                        ' separador decimal (positionDecimalSeparator), y además, el
                        ' número de decimales escritos (decimales) es superior al número de
                        ' decimales permitidos (m_decimalPlaces), cancelamos la pulsación
                        ' de la tecla.
                        '
                        e.Handled = ((SelectionStart > positionDecimalSeparator) AndAlso (decimales > m_decimalPlaces))

                    End If

                End If

        End Select

    End Sub

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)

        ' Primero llamo al mismo método de la clase base.
        '
        MyBase.OnKeyUp(e)

        ' NOTA: al ser un método visible externamente, se aconseja
        ' validar el parámetro 'e' antes de usarlo.
        '
        If (e Is Nothing) Then Return

        Select Case e.KeyCode
            Case Keys.Oemplus, Keys.Add, Keys.OemMinus, Keys.Subtract
                ' Una vez escrito el signo, envío el punto de
                ' inserción al final del texto.
                '
                SelectionStart = TextLength
        End Select

    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)

        ' Al abandonar el control formateo el texto, lo que hará
        ' que se modifique el valor de la propiedad Modified.
        '
        SetText(MyBase.Text)

        MyBase.OnLeave(e)

    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)

        ' Para evitar que se seleccione el texto en las operaciones de deshacer, cuando no se permita.
        '
        If Not (m_allowSelectAll) Then

            If Not (MultiLine) Then
                ' Lo siguiente sólo funciona cuando el cuadro de texto no es multilínea,
                ' ya que no reconoce la propiedad SelectionLength cuando el control
                ' es multilínea.
                '
                If (SelectionLength > 0) Then SelectionStart = TextLength

            Else
                ' NOTA IMPORTANTE: El cuadro es multilínea. Hasta que no encuentre
                ' otra solución, no me va a quedar más remedio que impedir las
                ' operaciones de deshacer.
                '
                ClearUndo()

            End If

        End If

        ' Desencadeno el evento DecimalValueChanged.
        '
        OnDecimalValueChanged()

        MyBase.OnTextChanged(e)

    End Sub

    ''' <summary>
    ''' Mueve la selección actual del cuadro de texto al Portapapeles.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Paste()

        ' El método de la clase base, se limita a enviar el mensaje WM_PASTE
        ' a la función SendMessage de la API de Windows, para pegar en el
        ' control el texto existente en el portapapeles.

        If (m_allowPaste) Then

            ' Procesamos el mensaje WM_PASTE
            '
            Dim m As Message

            ' Pegar
            m.Msg = WM_PASTE
            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

            Application.DoEvents()

        End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Select Case (keyData And Keys.KeyCode)
            Case Keys.PageUp, Keys.PageDown, Keys.End, Keys.Home, Keys.Left, Keys.Up, Keys.Right, Keys.Down

                If (((keyData And Keys.Shift) = Keys.Shift) AndAlso (Not (m_allowSelectAll))) Then
                    ' No permito seleccionar texto con las teclas de dirección.
                    keyData = Keys.None
                    Return True
                End If

        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    ''' <summary>
    ''' Deshace la última operación de edición del cuadro de texto.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Undo()

        ' El método de la clase base, se limita a enviar el mensaje EM_UNDO 
        ' a la función SendMessage de la API de Windows, para deshace la
        ' última operación de edición en el cuadro de texto.

        If (m_allowUndo) Then

            ' Procesamos el mensaje WM_UNDO o EM_UNDO, dependiendo
            ' que el control sea o no multilínea, respectivamente.
            '
            Dim m As Message

            ' Deshacer
            If Not (MultiLine) Then
                m.Msg = EM_UNDO

            Else
                m.Msg = WM_UNDO

            End If

            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

        End If

    End Sub

    <Diagnostics.DebuggerStepThrough()>
    Protected Overrides Sub WndProc(ByRef m As Message)

        Const WM_LBUTTONDBLCLK As Integer = &H203  ' Evento DoubleClick
        Const WM_MOUSEMOVE As Integer = &H200      ' Evento MouseMove

        Select Case m.Msg
            Case WM_LBUTTONDBLCLK, WM_MOUSEMOVE
                If Not (m_allowSelectAll) Then Return

            Case WM_CLEAR
                If Not (m_allowClearSelection) Then Return

            Case WM_COPY
                If Not (m_allowCopy) Then Return

            Case WM_CUT
                If Not (m_allowCut) Then Return

            Case WM_PASTE
                If Not (m_allowPaste) Then Return
                If Not (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) Then Return

                ' Comprobamos si el contenido del portapapeles es numérico.
                If Not (ValidateClipboardText()) Then Return

            Case EM_UNDO, WM_UNDO
                If Not (m_allowUndo) Then Return

            Case Else

        End Select

        ' Procesamos los restantes mensajes
        MyBase.WndProc(m)

    End Sub

#End Region

#Region "Métodos reemplazables de la clase."

    Protected Overridable Sub ContextMenuOnPopup(sender As Object, e As EventArgs)

        ' ¿Se puede Deshacer?
        '
        m_cm.MenuItems(0).Enabled = ((m_allowUndo) AndAlso (Me.CanUndo))                    ' Deshacer

        ' ¿Hay texto seleccionado?
        '
        m_cm.MenuItems(2).Enabled = ((m_allowCut) And (SelectionLength > 0)) AndAlso
                                    ((m_allowCopy) And (SelectionLength > 0))               ' Cortar

        m_cm.MenuItems(3).Enabled = ((m_allowCopy) And (SelectionLength > 0))               ' Copiar
        m_cm.MenuItems(5).Enabled = ((m_allowClearSelection) And (SelectionLength > 0))     ' Eliminar

        ' Pegar
        '
        ' ¿El contenido del portapapeles tiene el formato numérico?
        '
        m_cm.MenuItems(4).Enabled = ((m_allowPaste) And (ValidateClipboardText()))

        ' ¿Hay algún texto escrito?
        '
        m_cm.MenuItems(7).Enabled = ((AllowSelectAll) And (Text.Length > 0))                ' Seleccionar todo

    End Sub

    Protected Overridable Sub MenuItemOnClick(sender As Object, e As EventArgs)

        Dim item As MenuItem = DirectCast(sender, MenuItem)
        Dim m As Message

        Select Case item.Index
            Case 0 ' Deshacer
                m.Msg = EM_UNDO

            Case 2 ' Cortar
                m.Msg = WM_CUT

            Case 3 ' Copiar
                m.Msg = WM_COPY

            Case 4 ' Pegar
                m.Msg = WM_PASTE

            Case 5 ' Eliminar
                m.Msg = WM_CLEAR

            Case 7 ' Seleccionar todo
                If (AllowSelectAll) Then SelectAll()
                Return

            Case Else
                Return

        End Select

        m.HWnd = New IntPtr(Me.Handle.ToInt64)

        Me.WndProc(m)

    End Sub

    Protected Overridable Sub SetFocusNextControl()

        ' Desplazar el foco entre los distintos controles mediante la tecla Return.
        '
        ' Contenedor del control, que normalmente será un objeto Form.
        '
        Dim container As Control = Me.Parent

        Dim ctrl As Control = Me

        Do
            ' Obtener el siguiente control hacia delante en el
            ' orden de tabulación.
            '
            ctrl = container.GetNextControl(ctrl, True)

            If (Not (ctrl Is Nothing) AndAlso (ctrl.CanFocus) AndAlso (ctrl.TabStop)) Then
                ' Si el control puede recibir el foco, se lo doy.
                ctrl.Focus()
                Exit Do
            End If
        Loop

    End Sub

#End Region

#Region "Métodos privados de la clase."

    ''' <summary>
    ''' Impide que se pueda escribir a la izquierda de un signo.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AllowDigit() As Boolean

        Dim value As String = Text

        ' Impido que se pueda escribir a la izquierda del signo.
        '
        If ((Me.SelectionStart = 0) AndAlso ((value.Contains(m_negativeSign)) OrElse (value.Contains(m_positiveSign)))) Then
            ' NOTA: decido no enviar el punto de inserción al final del texto.
            ' Me.SelectionStart = value.Length
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' Verifica si se puede escribir el separador decimal.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AllowSeparatorDecimal() As Boolean

        Dim value As String = Text
        Dim valueLength As Integer = value.Length

        ' Si el texto ya contiene un separador decimal, 
        ' evito desencadenar el evento KeyPress. 
        ' 
        If ((value.Contains(m_decimalSeparator)) OrElse
            (value.Contains(m_groupSeparator))) Then Return False

        ' Si el primer carácter que se teclea es el separador decimal,
        ' o si bien, existe un signo en el primer carácter, envío la
        ' combinación '0,'.
        '
        If (((valueLength = 0) OrElse (SelectionLength = valueLength)) OrElse
            ((valueLength = 1) AndAlso ((value.Contains(m_negativeSign)) OrElse
                                       (value.Contains(m_positiveSign))))) Then

            'If ((valueLength = 0) OrElse ((valueLength = 1) AndAlso ((value.Contains(m_negativeSign)) OrElse (value.Contains(m_positiveSign))))) Then

            ' NOTA: Envío la combinación "0," mediante el método Send,
            ' para que en el código cliente se desencadenen los
            ' eventos de teclado.
            '
            SendKeys.Send("{0}")
            SendKeys.Send("{" & m_decimalSeparator & "}")
            Return False

        End If

        ' Es un separador decimal válido.
        '
        Return True

    End Function

    ''' <summary>
    ''' Comprueba si existe un signo escrito.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AllowSign() As Boolean

        Dim value As String = Text

        ' Si ya existe un signo, evito pasar la tecla al evento KeyPress.
        '
        Return Not ((value.Contains(m_negativeSign)) OrElse (value.Contains(m_positiveSign)))

    End Function

    Private Sub CreateMenu()

        m_cm = New ContextMenu()
        AddHandler m_cm.Popup, AddressOf ContextMenuOnPopup

        m_mi = New MenuItem()
        m_mi.Index = 0
        m_mi.Text = "Deshacer"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 1
        m_mi.Text = "-"
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 2
        m_mi.Text = "Cortar"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 3
        m_mi.Text = "Copiar"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 4
        m_mi.Text = "Pegar"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 5
        m_mi.Text = "Eliminar"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 6
        m_mi.Text = "-"
        m_cm.MenuItems.Add(m_mi)

        m_mi = New MenuItem()
        m_mi.Index = 7
        m_mi.Text = "Seleccionar todo"
        AddHandler m_mi.Click, AddressOf MenuItemOnClick
        m_cm.MenuItems.Add(m_mi)

        MyBase.ContextMenu = m_cm

    End Sub

    ''' <summary>
    ''' Si procede, la función devolverá formateado el texto especificado.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FormatText(value As String) As String

        Dim number As Decimal

        If (value Is Nothing) Then value = String.Empty

        Dim bln As Boolean = GetDecimal(value, number)

        If (bln) Then
            ' La conversión ha resultado satisfactoria.
            '
            If (m_formatNumber) Then
                ' Formateo el número con la máscara especificada.
                '
                value = String.Format(CultureInfo.CurrentCulture, "{0:" & m_mask & "}", number)

            Else
                ' Formateo el número sin máscara.
                '
                If (number - Decimal.Ceiling(number) < 0) Then
                    ' El número contiene valores decimales, los
                    ' cuales tengo que conservarlos.
                    '
                    value = String.Format(CultureInfo.CurrentCulture, "{0:F" & m_decimalPlaces & "}", number)

                Else
                    ' El número es entero; elimino los ceros decimales.
                    '
                    value = String.Format(CultureInfo.CurrentCulture, "{0:F0}", number)
                End If

            End If

        Else
            ' No se ha efectuado la conversión.
            '
            If (m_allowNullValue) Then
                value = String.Empty

            ElseIf (m_formatNumber) Then
                value = String.Format(CultureInfo.CurrentCulture, "{0:" & m_mask & "}", number)

            Else
                value = CStr(number)

            End If

        End If

        Return value

    End Function

    Private Function GetDecimal(value As String, ByRef number As Decimal) As Boolean

        ' Siempre que el valor se pueda pasar a Decimal,
        ' se tratará de un número válido. Si el valor
        ' alfanumérico no se puede convertir a Decimal,
        ' la función devolverá False.
        '
        Return Decimal.TryParse(value, number)

    End Function

    Private Overloads Sub OnDecimalValueChanged()

        ' Creo una nueva instancia del delegado.
        Dim handler As New DecimalValueHandler(AddressOf OnDecimalValueChanged)
        If (Not handler Is Nothing) Then
            ' Ejecuto el método OnDecimalValueChanged, pasándole
            ' el valor actual de la propiedad Text.
            handler.Invoke(MyBase.Text)
        End If
    End Sub

    Private Overloads Sub OnDecimalValueChanged(value As String)

        Dim number As Decimal = 0D
        Dim bln As Boolean = GetDecimal(value, number)

        ' Si el valor es distinto, desencadeno el evento DecimalValueChanged.
        '
        If (number <> m_decimalValue) Then
            m_decimalValue = number
            RaiseEvent DecimalValueChanged(Me, EventArgs.Empty)
        End If

    End Sub

    ''' <summary>
    ''' Establece el formato y valor de la propiedad Text.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetText(value As String)

        ' NOTA: no quitar el bloque Try ... End Try a fin
        ' de detectar todas las excepciones que se puedan
        ' producir.
        '
        Try
            ' Formateo el valor.
            '
            value = FormatText(value)

            ' Asigno el valor a la propiedad Text de la clase base.
            '
            SetWindowText(New HandleRef(Me, Me.Handle), value)

        Catch ex As Exception
            m_decimalValue = 0D
            OnDecimalValueChanged()

            SetWindowText(New HandleRef(Me, Me.Handle), String.Empty)

            If (DesignMode) Then
                MessageBox.Show(ex.Message, "NumericDecimalTextBox")
            End If

        End Try

    End Sub

    Private Function ValidateCharacter(kea As KeyEventArgs) As Boolean

        ' Compruebo si es una tecla que debo permitir.
        '
        Select Case kea.KeyCode
            Case Keys.Oemcomma, Keys.OemPeriod, Keys.Decimal
                ' Se ha pulsado el punto o la coma.
                '
                ' Si no se permiten números decimales, evito
                ' desencadenar el evento KeyPress.
                '
                If (m_decimalPlaces = 0) Then Return False

                ' Elimino todo el texto si hay alguna parte seleccionada.
                '
                If (SelectionLength > 0) Then ClearSelection()

                Return AllowSeparatorDecimal()

            Case Keys.Oemplus, Keys.Add, Keys.OemMinus, Keys.Subtract
                ' Se ha pulsado el signo + o el signo -.
                '
                ' Elimino todo el texto si hay alguna parte seleccionada.
                '
                If (SelectionLength > 0) Then ClearSelection()

                Return AllowSign()

            Case Keys.NumPad0 To Keys.NumPad9, Keys.D0 To Keys.D9
                ' Elimino todo el texto si hay alguna parte seleccionada.
                '
                If (SelectionLength > 0) Then ClearSelection()

                Return AllowDigit()

        End Select

        Return True

    End Function

    Protected Overridable Function ValidateClipboardText() As Boolean

        ' La función comprobará el contenido del Portapapeles de Windows
        ' para verificar si su contenido es o no numérico.
        '
        If (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) Then

            Dim value As String = Clipboard.GetText(TextDataFormat.Text)

            ' Devolveremos True si el valor se puede convertir a Decimal.
            '
            Return ValidateText(value)

        Else
            Return False

        End If

    End Function

    Protected Overridable Function ValidateText(value As String) As Boolean

        ' Devolveremos True si el valor se puede convertir a Decimal.
        '
        Dim number As Decimal = 0D
        Return GetDecimal(value, number)

    End Function

#End Region

#Region "Funciones de la API de Windows."

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SetWindowText(hWnd As HandleRef, [text] As String) As Boolean
    End Function

#End Region

End Class
