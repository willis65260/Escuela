<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listemp = New System.Windows.Forms.ListBox()
        Me.bgtnbuscaremp = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lberror = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbvespertino = New System.Windows.Forms.RadioButton()
        Me.rbmatutino = New System.Windows.Forms.RadioButton()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtAM = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Visulaizarempleados = New System.Windows.Forms.Button()
        Me.Registarempleado = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtsid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsturno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtstel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsap = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnbuscarnombre = New System.Windows.Forms.Button()
        Me.txtbuscarnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscarid = New System.Windows.Forms.Button()
        Me.txtbuscarid = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnok)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.listemp)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(19, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 462)
        Me.Panel2.TabIndex = 4
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
        Me.Label2.Size = New System.Drawing.Size(356, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleados Registrados"
        '
        'listemp
        '
        Me.listemp.FormattingEnabled = True
        Me.listemp.Location = New System.Drawing.Point(39, 65)
        Me.listemp.Name = "listemp"
        Me.listemp.Size = New System.Drawing.Size(603, 303)
        Me.listemp.TabIndex = 0
        '
        'bgtnbuscaremp
        '
        Me.bgtnbuscaremp.BackColor = System.Drawing.Color.Transparent
        Me.bgtnbuscaremp.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Buscar_emplados
        Me.bgtnbuscaremp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bgtnbuscaremp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bgtnbuscaremp.Location = New System.Drawing.Point(224, 12)
        Me.bgtnbuscaremp.Name = "bgtnbuscaremp"
        Me.bgtnbuscaremp.Size = New System.Drawing.Size(182, 63)
        Me.bgtnbuscaremp.TabIndex = 5
        Me.bgtnbuscaremp.UseVisualStyleBackColor = False
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
        Me.btnhome.TabIndex = 3
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Registroempleado
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lberror)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnregistrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rbvespertino)
        Me.Panel1.Controls.Add(Me.rbmatutino)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.txtAM)
        Me.Panel1.Controls.Add(Me.txtAp)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Location = New System.Drawing.Point(38, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 451)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registrar Empleados"
        '
        'rbvespertino
        '
        Me.rbvespertino.AutoSize = True
        Me.rbvespertino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rbvespertino.Location = New System.Drawing.Point(485, 307)
        Me.rbvespertino.Name = "rbvespertino"
        Me.rbvespertino.Size = New System.Drawing.Size(124, 29)
        Me.rbvespertino.TabIndex = 5
        Me.rbvespertino.Text = "Vespertino"
        Me.rbvespertino.UseVisualStyleBackColor = True
        '
        'rbmatutino
        '
        Me.rbmatutino.AutoSize = True
        Me.rbmatutino.Checked = True
        Me.rbmatutino.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbmatutino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rbmatutino.Location = New System.Drawing.Point(315, 307)
        Me.rbmatutino.Name = "rbmatutino"
        Me.rbmatutino.Size = New System.Drawing.Size(105, 29)
        Me.rbmatutino.TabIndex = 4
        Me.rbmatutino.TabStop = True
        Me.rbmatutino.Text = "Matutino"
        Me.rbmatutino.UseVisualStyleBackColor = True
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(315, 263)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(294, 20)
        Me.txttel.TabIndex = 3
        '
        'txtAM
        '
        Me.txtAM.Location = New System.Drawing.Point(315, 219)
        Me.txtAM.Name = "txtAM"
        Me.txtAM.Size = New System.Drawing.Size(294, 20)
        Me.txtAM.TabIndex = 2
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(315, 174)
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(294, 20)
        Me.txtAp.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(315, 127)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(294, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Visulaizarempleados
        '
        Me.Visulaizarempleados.BackColor = System.Drawing.Color.Transparent
        Me.Visulaizarempleados.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.visualizarproductos
        Me.Visulaizarempleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Visulaizarempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Visulaizarempleados.Location = New System.Drawing.Point(436, 12)
        Me.Visulaizarempleados.Name = "Visulaizarempleados"
        Me.Visulaizarempleados.Size = New System.Drawing.Size(182, 63)
        Me.Visulaizarempleados.TabIndex = 1
        Me.Visulaizarempleados.UseVisualStyleBackColor = False
        '
        'Registarempleado
        '
        Me.Registarempleado.BackColor = System.Drawing.Color.Transparent
        Me.Registarempleado.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.agregarempleados
        Me.Registarempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Registarempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registarempleado.Location = New System.Drawing.Point(12, 12)
        Me.Registarempleado.Name = "Registarempleado"
        Me.Registarempleado.Size = New System.Drawing.Size(182, 63)
        Me.Registarempleado.TabIndex = 0
        Me.Registarempleado.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.busquedaproductos
        Me.Panel3.Controls.Add(Me.txtbuscarid)
        Me.Panel3.Controls.Add(Me.txtsid)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtsturno)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtstel)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtsam)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtsap)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtsname)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnbuscarnombre)
        Me.Panel3.Controls.Add(Me.txtbuscarnombre)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnbuscarid)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(35, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 451)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Visible = False
        '
        'txtsid
        '
        Me.txtsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsid.Location = New System.Drawing.Point(328, 132)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(157, 31)
        Me.txtsid.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(157, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Clave Empleado:"
        '
        'txtsturno
        '
        Me.txtsturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsturno.Location = New System.Drawing.Point(272, 350)
        Me.txtsturno.Name = "txtsturno"
        Me.txtsturno.Size = New System.Drawing.Size(213, 31)
        Me.txtsturno.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(157, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Turno:"
        '
        'txtstel
        '
        Me.txtstel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstel.Location = New System.Drawing.Point(272, 306)
        Me.txtstel.Name = "txtstel"
        Me.txtstel.Size = New System.Drawing.Size(213, 31)
        Me.txtstel.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(157, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Telefono:"
        '
        'txtsam
        '
        Me.txtsam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsam.Location = New System.Drawing.Point(272, 262)
        Me.txtsam.Name = "txtsam"
        Me.txtsam.Size = New System.Drawing.Size(213, 31)
        Me.txtsam.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(157, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Apellido M:"
        '
        'txtsap
        '
        Me.txtsap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsap.Location = New System.Drawing.Point(272, 215)
        Me.txtsap.Name = "txtsap"
        Me.txtsap.Size = New System.Drawing.Size(213, 31)
        Me.txtsap.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(157, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Apellido P:"
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(248, 169)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(237, 31)
        Me.txtsname.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Buscar por Nombre:"
        '
        'btnbuscarnombre
        '
        Me.btnbuscarnombre.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarnombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarnombre.Location = New System.Drawing.Point(638, 33)
        Me.btnbuscarnombre.Name = "btnbuscarnombre"
        Me.btnbuscarnombre.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarnombre.TabIndex = 9
        Me.btnbuscarnombre.UseVisualStyleBackColor = True
        '
        'txtbuscarnombre
        '
        Me.txtbuscarnombre.Location = New System.Drawing.Point(397, 44)
        Me.txtbuscarnombre.Name = "txtbuscarnombre"
        Me.txtbuscarnombre.Size = New System.Drawing.Size(226, 20)
        Me.txtbuscarnombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Buscar por Clave:"
        '
        'btnbuscarid
        '
        Me.btnbuscarid.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.magnifying_glass_2275080_960_720
        Me.btnbuscarid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarid.Location = New System.Drawing.Point(278, 33)
        Me.btnbuscarid.Name = "btnbuscarid"
        Me.btnbuscarid.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscarid.TabIndex = 6
        Me.btnbuscarid.UseVisualStyleBackColor = True
        '
        'txtbuscarid
        '
        Me.txtbuscarid.FormattingEnabled = True
        Me.txtbuscarid.Location = New System.Drawing.Point(24, 44)
        Me.txtbuscarid.Name = "txtbuscarid"
        Me.txtbuscarid.Size = New System.Drawing.Size(235, 21)
        Me.txtbuscarid.TabIndex = 31
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bgtnbuscaremp)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Visulaizarempleados)
        Me.Controls.Add(Me.Registarempleado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Registarempleado As Button
    Friend WithEvents Visulaizarempleados As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents rbvespertino As RadioButton
    Friend WithEvents rbmatutino As RadioButton
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtAM As TextBox
    Friend WithEvents txtAp As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents lberror As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents listemp As ListBox
    Friend WithEvents btnok As Button
    Friend WithEvents bgtnbuscaremp As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbuscarnombre As Button
    Friend WithEvents txtbuscarnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscarid As Button
    Friend WithEvents txtsid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsturno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtstel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsam As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtsap As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbuscarid As ComboBox
End Class
