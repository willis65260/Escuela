Public Class Inicio
    Private Sub Empleado_Click(sender As Object, e As EventArgs) Handles Empleado.Click
        Empleados.Show()
        Empleados.Enabled = True
        Me.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Provedores_Click(sender As Object, e As EventArgs) Handles Provedores.Click
        Provedor.Show()
        Provedor.Enabled = True
        Me.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Producto.Show()
        Producto.Enabled = True
        Me.Show()
        Me.Enabled = False
    End Sub

    Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click
        Validaremp.Show()
        Validaremp.Enabled = True

    End Sub

    Private Sub Compra_Click(sender As Object, e As EventArgs) Handles Compra.Click
        Compras.Show()
        Compras.Enabled = True

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
        conexion.Close()
    End Sub
End Class