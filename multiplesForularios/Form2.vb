Public Class Form2

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        datoCaracter1 = TextBox1.Text()
        datoCaracter2 = TextBox2.Text()
        datoCaracter3 = TextBox3.Text()

        Label7.Text() = datoCaracter1
        Label8.Text() = datoCaracter2
        Label9.Text() = datoCaracter3


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
