<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provedor
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listprov = New System.Windows.Forms.ListBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lberror = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtdire = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.verprov = New System.Windows.Forms.Button()
        Me.Registarprov = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscarid = New System.Windows.Forms.Button()
        Me.txtbuscarid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnbuscarnomabre = New System.Windows.Forms.Button()
        Me.txtbuscarnombre = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnok)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.listprov)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(27, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 462)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(567, 401)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provedores Registrados"
        '
        'listprov
        '
        Me.listprov.FormattingEnabled = True
        Me.listprov.Location = New System.Drawing.Point(39, 65)
        Me.listprov.Name = "listprov"
        Me.listprov.Size = New System.Drawing.Size(603, 303)
        Me.listprov.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.buscarprovedor
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Location = New System.Drawing.Point(223, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(182, 63)
        Me.btnbuscar.TabIndex = 7
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Registroprov
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lberror)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnregistrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.txtdire)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(30, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 451)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'lberror
        '
        Me.lberror.AutoSize = True
        Me.lberror.ForeColor = System.Drawing.Color.DarkRed
        Me.lberror.Location = New System.Drawing.Point(80, 357)
        Me.lberror.Name = "lberror"
        Me.lberror.Size = New System.Drawing.Size(0, 13)
        Me.lberror.TabIndex = 9
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(346, 378)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(122, 34)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(487, 378)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(122, 34)
        Me.btnregistrar.TabIndex = 7
        Me.btnregistrar.Text = "REGISTRAR"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(225, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registrar Provedores"
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(315, 216)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(294, 20)
        Me.txttel.TabIndex = 3
        '
        'txtdire
        '
        Me.txtdire.Location = New System.Drawing.Point(315, 281)
        Me.txtdire.Name = "txtdire"
        Me.txtdire.Size = New System.Drawing.Size(294, 20)
        Me.txtdire.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(315, 150)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(294, 20)
        Me.txtnombre.TabIndex = 0
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.home_button_icon_png_23
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Location = New System.Drawing.Point(665, 19)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(54, 48)
        Me.btnhome.TabIndex = 4
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'verprov
        '
        Me.verprov.BackColor = System.Drawing.Color.Transparent
        Me.verprov.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.verproductos
        Me.verprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.verprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verprov.Location = New System.Drawing.Point(436, 12)
        Me.verprov.Name = "verprov"
        Me.verprov.Size = New System.Drawing.Size(182, 63)
        Me.verprov.TabIndex = 2
        Me.verprov.UseVisualStyleBackColor = False
        '
        'Registarprov
        '
        Me.Registarprov.BackColor = System.Drawing.Color.Transparent
        Me.Registarprov.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Agregarprovedores
        Me.Registarprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Registarprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registarprov.Location = New System.Drawing.Point(12, 12)
        Me.Registarprov.Name = "Registarprov"
        Me.Registarprov.Size = New System.Drawing.Size(182, 63)
        Me.Registarprov.TabIndex = 1
        Me.Registarprov.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.busquedaproductos
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnbuscarnomabre)
        Me.Panel3.Controls.Add(Me.txtbuscarnombre)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnbuscarid)
        Me.Panel3.Controls.Add(Me.txtbuscarid)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(33, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 451)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar por Clave:"
        '
        'btnbuscarid
        '
        Me.btnbuscarid.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarid.Location = New System.Drawing.Point(274, 37)
        Me.btnbuscarid.Name = "btnbuscarid"
        Me.btnbuscarid.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarid.TabIndex = 9
        Me.btnbuscarid.UseVisualStyleBackColor = True
        '
        'txtbuscarid
        '
        Me.txtbuscarid.Location = New System.Drawing.Point(33, 48)
        Me.txtbuscarid.Name = "txtbuscarid"
        Me.txtbuscarid.Size = New System.Drawing.Size(226, 20)
        Me.txtbuscarid.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Buscar por Nombre:"
        '
        'btnbuscarnomabre
        '
        Me.btnbuscarnomabre.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarnomabre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarnomabre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarnomabre.Location = New System.Drawing.Point(633, 37)
        Me.btnbuscarnomabre.Name = "btnbuscarnomabre"
        Me.btnbuscarnomabre.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarnomabre.TabIndex = 12
        Me.btnbuscarnomabre.UseVisualStyleBackColor = True
        '
        'txtbuscarnombre
        '
        Me.txtbuscarnombre.Location = New System.Drawing.Point(392, 48)
        Me.txtbuscarnombre.Name = "txtbuscarnombre"
        Me.txtbuscarnombre.Size = New System.Drawing.Size(226, 20)
        Me.txtbuscarnombre.TabIndex = 11
        '
        'Provedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.verprov)
        Me.Controls.Add(Me.Registarprov)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "Provedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provedor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Registarprov As Button
    Friend WithEvents verprov As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnok As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents listprov As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lberror As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtdire As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbuscarnomabre As Button
    Friend WithEvents txtbuscarnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscarid As Button
    Friend WithEvents txtbuscarid As TextBox
End Class
