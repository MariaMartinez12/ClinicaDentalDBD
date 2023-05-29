Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Text



Public Class Form1

    Private connectionString As String = "Data Source=PC\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=True"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM Pacientes"
        Using Connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, Connection)
            Dim dataset As New DataSet()
            adapter.Fill(dataset, "Pacientes")
            DataGridView1.DataSource = dataset.Tables("Pacientes")



        End Using



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Factura.Show()


    End Sub

    Private Sub Btn_opcionesb_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmOpciones.Show()

    End Sub




    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim query As String = "INSERT INTO Pacientes(idPac,nombres,apellidos,telefono,direccion,email) VALUES (@idPac, @nombres, @apellidos, @telefono, @direccion, @email) "
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idPac", Txt_id.Text)
                command.Parameters.AddWithValue("@nombres", txt_nombres.Text)
                command.Parameters.AddWithValue("@apellidos", Txt_apellidos.Text)
                command.Parameters.AddWithValue("@telefono", Txt_telefono.Text)
                command.Parameters.AddWithValue("@direccion", Txt_direccion.Text)
                command.Parameters.AddWithValue("@email", Txt_eml.Text)
                connection.Open()
                command.ExecuteNonQuery()


            End Using

        End Using

        Txt_id.Text = String.Empty
        txt_nombres.Text = String.Empty
        Txt_apellidos.Text = String.Empty
        Txt_telefono.Text = String.Empty
        Txt_direccion.Text = String.Empty
        Txt_eml.Text = String.Empty




        Form1_Load(Nothing, Nothing)

    End Sub


    'Funciones de Boton eliminar
    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        ' Verificar la respuesta del usuario

        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este dato?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If confirmacion = DialogResult.Yes Then



        End If


        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para eliminar")
            Return

        End If

        Dim id As Integer = CInt(DataGridView1.SelectedRows(0).Cells("idPac").Value)

        Dim querydelet As String = "DELETE FROM Pacientes WHERE idPac = @idPac"
        'Peticion para borrar un campo'

        Using connection As New SqlConnection(connectionString)
            Using commandDelete As New SqlCommand(querydelet, connection)
                commandDelete.Parameters.AddWithValue("@idPac", id)
                connection.Open()
                commandDelete.ExecuteNonQuery()

            End Using



        End Using

        Form1_Load(Nothing, Nothing)





    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim nombre As String = Txb_buscar.Text.Trim()


        Dim querySearch As String = "SELECT idPac, apellidos, telefono, direccion, email FROM Pacientes WHERE nombres = @Nombre"
        Using connection As New SqlConnection(connectionString)
            Using commandSearch As New SqlCommand(querySearch, connection)
                commandSearch.Parameters.AddWithValue("@Nombre", nombre)

                connection.Open()
                Dim reader As SqlDataReader = commandSearch.ExecuteReader()

                If reader.Read() Then
                    Dim idPac As Integer = reader.GetInt32(0)
                    Dim apellidos As String = reader.GetString(1)
                    Dim telefono As String = reader.GetString(2)
                    Dim direccion As String = reader.GetString(3)
                    Dim email As String = reader.GetString(4)

                    Dim mensaje As String = "Información del paciente:" & vbCrLf &
                    "ID del paciente: " & idPac.ToString() & vbCrLf &
                    "Nombre: " & nombre & vbCrLf &
                    "Apellidos: " & apellidos & vbCrLf &
                    "Teléfono: " & telefono & vbCrLf &
                    "Dirección: " & direccion & vbCrLf &
                    "Email: " & email

                    MessageBox.Show(mensaje)
                Else
                    MessageBox.Show("No se encontró ningún paciente con el nombre " & nombre)
                End If

                reader.Close()
                Txb_buscar.Clear()

            End Using
        End Using



    End Sub

    Private Sub Txt_eml_TextChanged(sender As Object, e As EventArgs) Handles Txt_eml.TextChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmOpciones.Show()
    End Sub
End Class
