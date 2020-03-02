Public Class Cargando
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            Label1.Text = "Cargando  Base de Datos " & ProgressBar1.Value & "% espere..."
        Else
            Me.Hide()
            Me.Enabled = False
            Inicio.Show()
            Timer1.Enabled = False
        End If
    End Sub

End Class


