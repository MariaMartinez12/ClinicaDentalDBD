Imports Clinica.My

Imports System.Data.SqlClient
Imports System.Data


Public Class Factura

    Private connectionString As String = "Data Source=PC\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=True"

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = " SELECT facturaID, idPac, fecha , Servicio, costo, nombre FROM Factura "
        Using Connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, Connection)
            Dim dataset As New DataSet()
            adapter.Fill(dataset, "Factura")
            dg_factura.DataSource = dataset.Tables("Factura")


        End Using


    End Sub



    Private Sub ImprimirFac(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel3.Width, Me.Panel3.Height)
        Panel3.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel3.Width, Me.Panel3.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub


    Private Sub btn_fac_Click(sender As Object, e As EventArgs) Handles btn_fac.Click

        PrintPreviewDialog1.ShowDialog()


        Dim fecha As DateTime = DateTime.Now
        Dim query As String = "INSERT INTO Factura(facturaID,idPac,fecha,Servicio,costo,nombre) VALUES (@facturaID, @idPac,@fecha, @Servicio, @costo, @nombre )"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@facturaID", txt_factura.Text)
                command.Parameters.AddWithValue("@fecha", fecha)
                command.Parameters.AddWithValue("@idPac", txt_idPac.Text)
                command.Parameters.AddWithValue("@costo", txt_precio.Text)
                command.Parameters.AddWithValue("@Servicio", txt_servicio.Text)
                command.Parameters.AddWithValue("@nombre", txt_nombre.Text)
                connection.Open()
                command.ExecuteNonQuery()



            End Using


        End Using


        txt_factura.Text = String.Empty
        txt_fec.Text = String.Empty
        txt_idPac.Text = String.Empty
        txt_precio.Text = String.Empty
        txt_servicio.Text = String.Empty
        txt_nombre.Text = String.Empty


        Factura_Load(Nothing, Nothing)


    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FrmOpciones.Show()

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este dato?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If confirmacion = DialogResult.Yes Then



        End If


        If dg_factura.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para eliminar")
            Return

        End If

        Dim id As Integer = CInt(dg_factura.SelectedRows(0).Cells("idPac").Value)

        Dim querydelet As String = "DELETE FROM Factura WHERE idPac = @idPac"
        ' Peticion para borrar un campo'

        Using connection As New SqlConnection(connectionString)
            Using commandDelete As New SqlCommand(querydelet, connection)
                commandDelete.Parameters.AddWithValue("@idPac", id)
                connection.Open()
                commandDelete.ExecuteNonQuery()

            End Using



        End Using

        Factura_Load(Nothing, Nothing)


    End Sub

    Private Sub txt_fecha_Click(sender As Object, e As EventArgs) Handles txt_fecha.Click

    End Sub

    Private Sub Apellidos_Click(sender As Object, e As EventArgs) Handles Apellidos.Click

    End Sub

    Private Sub dg_factura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_factura.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class