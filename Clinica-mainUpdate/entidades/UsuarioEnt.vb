Public Class UsuarioEnt

    Private idUsuario As Integer
    Private nombreUsuario As String
    Private contraseña As String

    Public Sub New()

    End Sub
    Public Sub New(idUsuario As Integer, nombreUsuario As String, contraseña As String)
        Me.idUsuario = idUsuario
        Me.nombreUsuario = nombreUsuario
        Me.contraseña = contraseña
    End Sub

    Public Property IdUsuario1 As Integer
        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property

    Public Property NombreUsuario1 As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property Contraseña1 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property
End Class
