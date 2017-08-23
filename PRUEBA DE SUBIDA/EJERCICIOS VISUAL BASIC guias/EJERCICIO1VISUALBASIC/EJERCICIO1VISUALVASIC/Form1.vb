Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As String
        a = "Programacion"

        If TextBox1.Text = a Then

            MessageBox.Show("Hola Programacion")

        Else

            MessageBox.Show("Estas Equivocado")



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
