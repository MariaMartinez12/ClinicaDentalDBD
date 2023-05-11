Public Class FormPrincipal


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_registro.Columns.Add("id", "ID")
        dg_registro.Columns.Add("nombres", "Nombres")
        dg_registro.Columns.Add("apellidos", "Apellidos")
        dg_registro.Columns.Add("telefono", "Telefono")
        dg_registro.Columns.Add("sexo", "Sexo")
        dg_registro.Columns.Add("cedula", "Cedula")



    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        dg_registro.Rows.Add(Txt_id.Text, txt_nombres.Text, txt_apellidos.Text, Txt_telefono.Text, Txt_sexo.Text, Txt_cedula.Text)

        Txt_id.Text = ""
        txt_apellidos.Text = ""
        txt_nombres.Text = String.Empty
        Txt_telefono.Text = ""
        Txt_sexo.Text = ""
        Txt_cedula.Text = ""

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        Form2.Show()


    End Sub

    Public fila As Integer


    Private Sub dg_registro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_registro.CellContentClick
        fila = 0
        fila = dg_registro.CurrentCell.RowIndex.ToString()


    End Sub


    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_registro.Rows.RemoveAt(fila)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Factura.Show()


    End Sub
End Class
