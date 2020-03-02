<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.txtp = New System.Windows.Forms.TextBox()
        Me.txtt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.btnbuxqueda = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnEliminaritem = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.tabla = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciou = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Panel()
        Me.txtvta = New System.Windows.Forms.Label()
        Me.txtempleado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabla.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtc)
        Me.Panel1.Controls.Add(Me.txtp)
        Me.Panel1.Controls.Add(Me.txtt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.btnfinalizar)
        Me.Panel1.Controls.Add(Me.btnbuxqueda)
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnEliminaritem)
        Me.Panel1.Location = New System.Drawing.Point(0, 530)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 136)
        Me.Panel1.TabIndex = 0
        '
        'txtc
        '
        Me.txtc.Enabled = False
        Me.txtc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtc.Location = New System.Drawing.Point(614, 98)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(93, 29)
        Me.txtc.TabIndex = 10
        '
        'txtp
        '
        Me.txtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtp.Location = New System.Drawing.Point(602, 63)
        Me.txtp.Name = "txtp"
        Me.txtp.Size = New System.Drawing.Size(105, 29)
        Me.txtp.TabIndex = 9
        '
        'txtt
        '
        Me.txtt.Enabled = False
        Me.txtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt.Location = New System.Drawing.Point(602, 30)
        Me.txtt.Name = "txtt"
        Me.txtt.Size = New System.Drawing.Size(105, 29)
        Me.txtt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(517, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cambio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pago:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(517, 33)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(66, 25)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.Text = "Total:"
        '
        'btnfinalizar
        '
        Me.btnfinalizar.Location = New System.Drawing.Point(359, 18)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(125, 101)
        Me.btnfinalizar.TabIndex = 4
        Me.btnfinalizar.Text = "Finalizar venta"
        Me.btnfinalizar.UseVisualStyleBackColor = True
        '
        'btnbuxqueda
        '
        Me.btnbuxqueda.Location = New System.Drawing.Point(168, 78)
        Me.btnbuxqueda.Name = "btnbuxqueda"
        Me.btnbuxqueda.Size = New System.Drawing.Size(122, 41)
        Me.btnbuxqueda.TabIndex = 3
        Me.btnbuxqueda.Text = "Busqueda Manual"
        Me.btnbuxqueda.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(168, 18)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(122, 41)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(12, 78)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(122, 41)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnEliminaritem
        '
        Me.btnEliminaritem.Location = New System.Drawing.Point(12, 18)
        Me.btnEliminaritem.Name = "btnEliminaritem"
        Me.btnEliminaritem.Size = New System.Drawing.Size(122, 41)
        Me.btnEliminaritem.TabIndex = 0
        Me.btnEliminaritem.Text = "Eliminar Item"
        Me.btnEliminaritem.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnagregar)
        Me.Panel2.Controls.Add(Me.txtid)
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 76)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Cantidad(Opcional):"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(591, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Clave de Producto:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(207, 34)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(226, 20)
        Me.txtid.TabIndex = 11
        '
        'tabla
        '
        Me.tabla.BackColor = System.Drawing.Color.White
        Me.tabla.Controls.Add(Me.DataGridView1)
        Me.tabla.Location = New System.Drawing.Point(0, 177)
        Me.tabla.Name = "tabla"
        Me.tabla.Size = New System.Drawing.Size(783, 353)
        Me.tabla.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Clave, Me.namet, Me.preciou, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(783, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'namet
        '
        Me.namet.HeaderText = "Nombre"
        Me.namet.Name = "namet"
        Me.namet.ReadOnly = True
        Me.namet.Width = 400
        '
        'preciou
        '
        Me.preciou.HeaderText = "Precio Unitario"
        Me.preciou.Name = "preciou"
        Me.preciou.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnagregar
        '
        Me.btnagregar.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources._3440911_add_bag_basket_cart_ecommerce_shopping_store_107529
        Me.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Location = New System.Drawing.Point(700, 8)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(63, 60)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackgroundImage = Global.PAbarrotesConsuelo.My.Resources.Resources.Header
        Me.header.Controls.Add(Me.txtvta)
        Me.header.Controls.Add(Me.txtempleado)
        Me.header.Location = New System.Drawing.Point(0, 1)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(783, 100)
        Me.header.TabIndex = 1
        '
        'txtvta
        '
        Me.txtvta.AutoSize = True
        Me.txtvta.BackColor = System.Drawing.Color.Transparent
        Me.txtvta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtvta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvta.Location = New System.Drawing.Point(562, 40)
        Me.txtvta.Name = "txtvta"
        Me.txtvta.Size = New System.Drawing.Size(44, 31)
        Me.txtvta.TabIndex = 1
        Me.txtvta.Text = "# :"
        '
        'txtempleado
        '
        Me.txtempleado.AutoSize = True
        Me.txtempleado.BackColor = System.Drawing.Color.Transparent
        Me.txtempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleado.Location = New System.Drawing.Point(99, 40)
        Me.txtempleado.Name = "txtempleado"
        Me.txtempleado.Size = New System.Drawing.Size(143, 31)
        Me.txtempleado.TabIndex = 0
        Me.txtempleado.Text = "Empleado:"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabla.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents header As Panel
    Friend WithEvents txtvta As Label
    Friend WithEvents txtempleado As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tabla As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtc As TextBox
    Friend WithEvents txtp As TextBox
    Friend WithEvents txtt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents btnfinalizar As Button
    Friend WithEvents btnbuxqueda As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnEliminaritem As Button
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents namet As DataGridViewTextBoxColumn
    Friend WithEvents preciou As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
