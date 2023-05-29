Imports Clinica.My
Imports System.Data.SqlClient
Imports System.Data


Public Class Consulta

    Private connectionString As String = "Data Source=PC\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=True"

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT idConsulta,idPac, fecha, servicio, estado FROM Consultas"
        Using Connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, Connection)
            Dim dataset As New DataSet()
            adapter.Fill(dataset, "Consultas")
            DataGridView2.DataSource = dataset.Tables("Consultas")



        End Using



    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmOpciones.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_factura.Click
        Me.Hide()
        Factura.Show()


    End Sub
    'Guarda los datos de las consultas'
    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click, Button2.Click
        Dim fecha As DateTime = DateTime.Now
        Dim query As String = "INSERT INTO Consultas(idConsulta,idPac,fecha,servicio,estado) VALUES (@idConsulta, @idPac, @fecha, @servicio, @estado)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idConsulta", TxtIdConsulta.Text)
                command.Parameters.AddWithValue("@idPac", TxtPaciente.Text)
                command.Parameters.AddWithValue("@fecha", fecha)
                command.Parameters.AddWithValue("@servicio", TxtServicio.Text)
                command.Parameters.AddWithValue("@estado", TxtEstado.Text)
                connection.Open()
                command.ExecuteNonQuery()

            End Using

        End Using

        TxtIdConsulta.Text = String.Empty
        TxtPaciente.Text = String.Empty
        Txt_fecha.Text = String.Empty
        TxtServicio.Text = String.Empty
        TxtServicio.Text = String.Empty
        TxtEstado.Text = String.Empty


        Consulta_Load(Nothing, Nothing)




    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click, Button3.Click

        Dim confirmacion As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el dato", "Confimar eliminación ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then


        End If

        If DataGridView2.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para eliminar ")
            Return

        End If


        Dim id As Integer = CInt(DataGridView2.SelectedRows(0).Cells("idConsulta").Value)

        Dim querydelete As String = "DELETE FROM Consultas WHERE idConsulta = @idConsulta "
        'Peticion para borrar un camp en la tablas'

        Using connection As New SqlConnection(connectionString)
            Using commandDelete As New SqlCommand(querydelete, connection)
                commandDelete.Parameters.AddWithValue("@idConsulta", id)
                connection.Open()
                commandDelete.ExecuteNonQuery()

            End Using


        End Using

        Consulta_Load(Nothing, Nothing)







    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txb_buscar.TextChanged

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmOpciones.Show()
    End Sub
End Class