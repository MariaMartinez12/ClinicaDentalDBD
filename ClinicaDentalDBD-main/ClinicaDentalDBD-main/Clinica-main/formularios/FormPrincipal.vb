Public Class FormPrincipal


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_registro.Columns.Add("id", "ID")
        dg_registro.Columns.Add("nombres", "Nombres")
        dg_registro.Columns.Add("apellidos", "Apellidos")

    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        dg_registro.Rows.Add(Txt_id.Text, txt_nombres.Text, txt_apellidos.Text)
        Txt_id.Text = ""
        txt_apellidos.Text = ""
        txt_nombres.Text = String.Empty

    End Sub


End Class
