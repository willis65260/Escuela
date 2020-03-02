<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.listtodos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbuscarid = New System.Windows.Forms.ComboBox()
        Me.txtsid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtscadu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtspv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtspc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsdis = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscarname = New System.Windows.Forms.TextBox()
        Me.btnbuscarname = New System.Windows.Forms.Button()
        Me.btnbuscarid = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnvisualizar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtidprod = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.listtodos)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(34, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 451)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Visible = False
        '
        'listtodos
        '
        Me.listtodos.FormattingEnabled = True
        Me.listtodos.Location = New System.Drawing.Point(20, 65)
        Me.listtodos.Name = "listtodos"
        Me.listtodos.Size = New System.Drawing.Size(670, 368)
        Me.listtodos.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Todos los Productos"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.busquedaproductos
        Me.Panel2.Controls.Add(Me.txtbuscarid)
        Me.Panel2.Controls.Add(Me.txtsid)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtscadu)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtspv)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtspc)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtsdis)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtsname)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtbuscarname)
        Me.Panel2.Controls.Add(Me.btnbuscarname)
        Me.Panel2.Controls.Add(Me.btnbuscarid)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(31, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 451)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'txtbuscarid
        '
        Me.txtbuscarid.FormattingEnabled = True
        Me.txtbuscarid.Location = New System.Drawing.Point(47, 45)
        Me.txtbuscarid.Name = "txtbuscarid"
        Me.txtbuscarid.Size = New System.Drawing.Size(224, 21)
        Me.txtbuscarid.TabIndex = 19
        '
        'txtsid
        '
        Me.txtsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsid.Location = New System.Drawing.Point(302, 113)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(167, 31)
        Me.txtsid.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(141, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Clave Producto:"
        '
        'txtscadu
        '
        Me.txtscadu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscadu.Location = New System.Drawing.Point(295, 331)
        Me.txtscadu.Name = "txtscadu"
        Me.txtscadu.Size = New System.Drawing.Size(174, 31)
        Me.txtscadu.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(141, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Caducidad:"
        '
        'txtspv
        '
        Me.txtspv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspv.Location = New System.Drawing.Point(295, 287)
        Me.txtspv.Name = "txtspv"
        Me.txtspv.Size = New System.Drawing.Size(174, 31)
        Me.txtspv.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio Venta:"
        '
        'txtspc
        '
        Me.txtspc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspc.Location = New System.Drawing.Point(295, 243)
        Me.txtspc.Name = "txtspc"
        Me.txtspc.Size = New System.Drawing.Size(174, 31)
        Me.txtspc.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Precio Compra:"
        '
        'txtsdis
        '
        Me.txtsdis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsdis.Location = New System.Drawing.Point(270, 196)
        Me.txtsdis.Name = "txtsdis"
        Me.txtsdis.Size = New System.Drawing.Size(199, 31)
        Me.txtsdis.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(141, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Disponibles:"
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(232, 150)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(237, 31)
        Me.txtsname.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Buscar por Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar por Clave:"
        '
        'txtbuscarname
        '
        Me.txtbuscarname.Location = New System.Drawing.Point(393, 46)
        Me.txtbuscarname.Name = "txtbuscarname"
        Me.txtbuscarname.Size = New System.Drawing.Size(226, 20)
        Me.txtbuscarname.TabIndex = 3
        '
        'btnbuscarname
        '
        Me.btnbuscarname.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarname.Location = New System.Drawing.Point(636, 35)
        Me.btnbuscarname.Name = "btnbuscarname"
        Me.btnbuscarname.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarname.TabIndex = 2
        Me.btnbuscarname.UseVisualStyleBackColor = True
        '
        'btnbuscarid
        '
        Me.btnbuscarid.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarid.Location = New System.Drawing.Point(285, 35)
        Me.btnbuscarid.Name = "btnbuscarid"
        Me.btnbuscarid.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarid.TabIndex = 1
        Me.btnbuscarid.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.home_button_icon_png_231
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Location = New System.Drawing.Point(665, 19)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(54, 48)
        Me.btnhome.TabIndex = 3
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'btnvisualizar
        '
        Me.btnvisualizar.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.visproducto
        Me.btnvisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvisualizar.Location = New System.Drawing.Point(436, 12)
        Me.btnvisualizar.Name = "btnvisualizar"
        Me.btnvisualizar.Size = New System.Drawing.Size(182, 63)
        Me.btnvisualizar.TabIndex = 2
        Me.btnvisualizar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.buscarproducto
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(224, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(182, 63)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.agregarpro
        Me.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregar.Location = New System.Drawing.Point(12, 12)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(182, 63)
        Me.btnagregar.TabIndex = 0
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Registroproducto
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnregistrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtidprod)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(49, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 451)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Visible = False
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(426, 377)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(93, 27)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(535, 377)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(93, 27)
        Me.btnregistrar.TabIndex = 4
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agregar Productos"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(308, 277)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(299, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(308, 216)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(299, 20)
        Me.txtname.TabIndex = 1
        '
        'txtidprod
        '
        Me.txtidprod.Location = New System.Drawing.Point(308, 151)
        Me.txtidprod.Name = "txtidprod"
        Me.txtidprod.Size = New System.Drawing.Size(299, 20)
        Me.txtidprod.TabIndex = 0
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnvisualizar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnagregar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnvisualizar As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtidprod As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnbuscarid As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbuscarname As TextBox
    Friend WithEvents btnbuscarname As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents listtodos As ListBox
    Friend WithEvents txtsid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtscadu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtspv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtspc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtsdis As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbuscarid As ComboBox
End Class
