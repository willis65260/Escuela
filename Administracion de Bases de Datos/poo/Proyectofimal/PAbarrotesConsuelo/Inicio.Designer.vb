<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Empleado = New System.Windows.Forms.Button()
        Me.Provedores = New System.Windows.Forms.Button()
        Me.Productos = New System.Windows.Forms.Button()
        Me.Compra = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Empleado
        '
        Me.Empleado.BackColor = System.Drawing.Color.Transparent
        Me.Empleado.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.empleados
        Me.Empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Empleado.Location = New System.Drawing.Point(54, 141)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(130, 130)
        Me.Empleado.TabIndex = 0
        Me.Empleado.UseVisualStyleBackColor = False
        '
        'Provedores
        '
        Me.Provedores.BackColor = System.Drawing.Color.Transparent
        Me.Provedores.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Provedores
        Me.Provedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Provedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Provedores.Location = New System.Drawing.Point(278, 141)
        Me.Provedores.Name = "Provedores"
        Me.Provedores.Size = New System.Drawing.Size(130, 130)
        Me.Provedores.TabIndex = 1
        Me.Provedores.UseVisualStyleBackColor = False
        '
        'Productos
        '
        Me.Productos.BackColor = System.Drawing.Color.Transparent
        Me.Productos.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.productos
        Me.Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Productos.Location = New System.Drawing.Point(498, 141)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(130, 130)
        Me.Productos.TabIndex = 2
        Me.Productos.UseVisualStyleBackColor = False
        '
        'Compra
        '
        Me.Compra.BackColor = System.Drawing.Color.Transparent
        Me.Compra.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Compras
        Me.Compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Compra.Location = New System.Drawing.Point(164, 294)
        Me.Compra.Name = "Compra"
        Me.Compra.Size = New System.Drawing.Size(130, 130)
        Me.Compra.TabIndex = 3
        Me.Compra.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.Ventas.BackColor = System.Drawing.Color.Transparent
        Me.Ventas.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Ventas
        Me.Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ventas.Location = New System.Drawing.Point(391, 294)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(130, 130)
        Me.Ventas.TabIndex = 4
        Me.Ventas.UseVisualStyleBackColor = False
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.Transparent
        Me.btnopciones.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources._4e60fa416a33f12786f83f4a29c095e5_icono_de_llave_y_engranaje_by_vexels
        Me.btnopciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Location = New System.Drawing.Point(622, 385)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(45, 39)
        Me.btnopciones.TabIndex = 5
        Me.btnopciones.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cerrar.Location = New System.Drawing.Point(21, 385)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(75, 23)
        Me.cerrar.TabIndex = 6
        Me.cerrar.Text = "Salir"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 436)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.btnopciones)
        Me.Controls.Add(Me.Ventas)
        Me.Controls.Add(Me.Compra)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.Provedores)
        Me.Controls.Add(Me.Empleado)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.MinimumSize = New System.Drawing.Size(695, 475)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Empleado As Button
    Friend WithEvents Provedores As Button
    Friend WithEvents Productos As Button
    Friend WithEvents Compra As Button
    Friend WithEvents Ventas As Button
    Friend WithEvents btnopciones As Button
    Friend WithEvents cerrar As Button
End Class
