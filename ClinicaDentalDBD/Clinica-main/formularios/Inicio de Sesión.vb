Public Class Form2

    'Esta es una etiqueta para ver que información va a gregar el usuario cuando no este seleccio '
    Private Sub TxtUsuario_GotFocus(sender As Object, e As EventArgs) Handles TxtUsuario.GotFocus
        If TxtUsuario.Text = "Nombre de Usuario" Then
            TxtUsuario.Text = ""
            TxtUsuario.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtUsuario_LostFocus(sender As Object, e As EventArgs) Handles TxtUsuario.LostFocus
        If TxtUsuario.Text = "" Then
            TxtUsuario.Text = "Nombre de Usuario"
            TxtUsuario.ForeColor = Color.DarkGray


        End If
    End Sub

    Private Sub TxtContraseña_GotFocus(sender As Object, e As EventArgs) Handles TxtContraseña.GotFocus
        If TxtContraseña.Text = "Contraseña" Then
            TxtContraseña.Text = ""
            TxtContraseña.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtContraseña_LostFocus(sender As Object, e As EventArgs) Handles TxtContraseña.LostFocus
        If TxtContraseña.Text = "" Then
            TxtContraseña.Text = "Contraseña"
            TxtContraseña.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Text = "Nombre de Usuario"
        TxtUsuario.ForeColor = Color.DarkGray
        TxtContraseña.Text = "Contraseña"
        TxtContraseña.ForeColor = Color.DarkGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class



