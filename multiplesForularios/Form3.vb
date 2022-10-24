Public Class Form3


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text() = dato1
        Label5.Text() = dato2
        Label7.Text() = dato3
        Label13.Text() = datoCaracter1
        Label11.Text() = datoCaracter2
        Label9.Text() = datoCaracter3

        Label16.Text() = resultado
        concatenado = datoCaracter1 & datoCaracter2 & datoCaracter3
        Label18.Text() = concatenado

    End Sub
End Class