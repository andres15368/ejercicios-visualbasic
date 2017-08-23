Public Class FORMULARIO
    Private Sub ctDato_TextChanged(sender As Object, e As EventArgs) Handles ctDato.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAñadir.Click
        If (ctDato.Text <> "") Then IsLista.Items.Add(ctDato.Text)
    End Sub

    Private Sub CVcursiva_CheckedChanged(sender As Object, e As EventArgs) Handles CVcursiva.CheckedChanged
        If (CVcursiva.Checked) Then ' si cursiva esta señalada

            ctDato.Font = New Font("microsoft sans serif", 8.25, FontStyle.Italic)

        Else ' si CVcursiva no esta señalada

            ctDato.Font = New Font("microsoft sans serif", 8.25, FontStyle.Regular)

        End If
    End Sub

    Private Sub bolectura_CheckedChanged(sender As Object, e As EventArgs) Handles bolectura.CheckedChanged

        If (bolectura.Checked) Then ctDato.ReadOnly = False
        If (BoEscritura.Checked) Then ctDato.ReadOnly = True


    End Sub

    Private Sub bdhColorTexto_Scroll(sender As Object, e As ScrollEventArgs) Handles bdhColorTexto.Scroll
        ctDato.ForeColor = Color.FromArgb(bdhColorTexto.Value, bdhColorTexto.Value, bdhColorTexto.Value)
    End Sub

    Private Sub IsLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsLista.SelectedIndexChanged
        ctDato.Text = IsLista.SelectedItem
    End Sub

    Private Sub itOPcionesSalir_Click(sender As Object, e As EventArgs) Handles itOPcionesSalir.Click
        Close()

    End Sub

    Private Sub itOpcionesColor_Click(sender As Object, e As EventArgs) Handles itOpcionesColor.Click
        'establecer el color actual de la caja de texto como inicial
        dlgColor.Color = ctDato.BackColor
        'mostrar el dialogo dglcolor
        If (dlgColor.ShowDialog() = DialogResult.OK) Then
            'si se pulso aceptar, establecer el color de fondo de la caja de texto
            ctDato.BackColor = dlgColor.Color

        End If

    End Sub

    Private Sub itAyudaAcercaDe_Click(sender As Object, e As EventArgs) Handles itAyudaAcercaDe.Click
        MessageBox.Show("Aplicacion Saludo. Version 1.0" + Environment.NewLine + "Copyrigth(c) Ruben Dario Morales Ruiz, 2017", "acerca de el saludo", MessageBoxButtons.OK)
    End Sub
End Class
