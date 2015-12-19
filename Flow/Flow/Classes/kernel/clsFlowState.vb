Option Explicit On
'Option Strict On

''' <summary>
''' Kernel class is used for changing the state of Flow, from Context to Launcher or 
''' vice versa. Flow state change affects the interface (the right-click contexmenu) as well as 
''' several other modules such as KeyRendering
''' </summary>


Public Class clsFlowState
    'Private Shared mxmlCulture As New Xml.XmlDocument
    'Private Shared miSelectedFlowKeyCode As Integer = 0 'Default 0 means no key is currently selected
    Private Shared msCurrentState As String
    'Private Shared mbCommandIsSelected As Boolean
    ' DS - moved to clsFlowGeneral

    'Public Shared Sub loadCulture()
    ' Dim cultureFilePath As String
    'Dim currentCulture As String = InputLanguage.CurrentInputLanguage.Culture.IetfLanguageTag
    '   cultureFilePath = Application.StartupPath & "\XML\KeyboardCultures\" & currentCulture & ".xml" '## Hardcoded path
    '  Try
    '     mxmlCulture.Load(cultureFilePath) '## Done! should have check: If culture file doesn't exist: chose en-us layout
    'Catch ex As Exception
    '    MessageBox.Show("Default layout loaded")
    'Default en-US.xml culture layout load
    '   mxmlCulture.Load(Application.StartupPath & "\XML\KeyboardCultures\en-US.xml")
    'Finally
    'End Try
    'End Sub



#Region " Constructors & Destructors "
    '########################

    ''' <summary>
    ''' Initialize resource data
    ''' </summary>
    Shared Sub New()
        'Can be "context" or "launcher" (the same as the name of the keyset parent nodes in keyset.xml)
        msCurrentState = "launcher"

    End Sub
#End Region


#Region " Exposed Properties "
    '#########################

    ''' <summary>
    ''' Contains a Flow global state 
    ''' 
    ''' </summary>

    Public Shared Property CurrentState() As String
        Get
            Return msCurrentState
        End Get
        Set(ByVal value As String)
            msCurrentState = value
        End Set
    End Property

#End Region

End Class
