Public Class Validaremp
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Hide()
        Me.Enabled = False

    End Sub

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Ventas.Show()
        Ventas.Enabled = True
        Me.Hide()
        Me.Enabled = False

    End Sub
End Class