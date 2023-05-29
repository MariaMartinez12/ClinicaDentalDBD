Imports System.Data.SqlClient
Public Class UsuarioDao

    Private strConn As String = My.Settings.StrConexion

    Public Function MostrarRegistro() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "Select * from Usuario order by nombreUsuario"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("error", ex.Message)
        End Try
        Return ds
    End Function

    Public Function VerificarUsuario(ByVal nombre As String, ByVal pw As String) As Boolean
        Dim b As Boolean = False
        Try
            Dim tsql As String = "Select * from Usuario where nombreUsuario = @userName and contraseña = @pw"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@userName", nombre)
            da.SelectCommand.Parameters.AddWithValue("@pw", pw)
            Dim ds As New DataSet
            da.Fill(ds)
            If (ds.Tables(0).Rows.Count > 0) Then

                b = True
            End If
        Catch ex As Exception
        End Try

        Return b
    End Function




End Class
