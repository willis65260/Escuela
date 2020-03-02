Public Class Provedor
    Private Sub Registarprov_Click(sender As Object, e As EventArgs) Handles Registarprov.Click
        Panel1.Enabled = True
        Panel1.Show()
        Panel2.Hide()
        Panel2.Enabled = False
        Panel3.Hide()
        Panel3.Enabled = False

    End Sub

    Private Sub Verprov_Click(sender As Object, e As EventArgs) Handles verprov.Click
        Panel1.Enabled = False
        Panel1.Hide()
        Panel3.Hide()
        Panel3.Enabled = False
        Panel2.Show()
        Panel2.Enabled = True
    End Sub

    Private Sub Btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Enabled = False
        Me.Hide()
        Inicio.Show()
        Inicio.Enabled = True
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Panel1.Enabled = False
        Panel1.Hide()
        Panel2.Hide()
        Panel2.Enabled = False
        Panel3.Show()
        Panel3.Enabled = True
    End Sub
End Class