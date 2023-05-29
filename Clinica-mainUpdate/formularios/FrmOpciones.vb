Public Class FrmOpciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Inicio.Click
        Me.Hide()

        FrmInisioSesion.Show()





    End Sub

    Private Sub Btn_consultas_Click(sender As Object, e As EventArgs) Handles Btn_consultas.Click
        Me.Hide()
        Consulta.Show()



    End Sub

    Private Sub Btn_sistemas_Click(sender As Object, e As EventArgs) Handles Btn_Registro.Click
        Me.Hide()
        Form1.Show()





    End Sub

    Private Sub Btn_reportes_Click(sender As Object, e As EventArgs) Handles Btn_Factrura.Click
        Me.Hide()

        Factura.Show()

    End Sub
End Class