Public Class Producto
    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Panel1.Show()
        Panel1.Enabled = True
        Panel2.Hide()
        Panel2.Enabled = False
        Panel3.Hide()
        Panel3.Enabled = False
    End Sub

    Private Sub Btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Inicio.Show()
        Inicio.Enabled = True
        Me.Hide()
        Me.Enabled = False

    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Panel2.Show()
        Panel2.Enabled = True
        Panel1.Hide()
        Panel1.Enabled = False
        Panel3.Hide()
        Panel3.Enabled = False
    End Sub

    Private Sub Btnvisualizar_Click(sender As Object, e As EventArgs) Handles btnvisualizar.Click
        Panel3.Show()
        Panel3.Enabled = True
        Panel1.Hide()
        Panel1.Enabled = False
        Panel2.Hide()
        Panel2.Enabled = False
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = New ADODB.Recordset
        consulta = conexion.Execute("Select cveproductos from productos order by cveproductos")

        While Not consulta.EOF
            txtbuscarid.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
        txtsid.Enabled = False
        txtname.Enabled = True
        txtsname.Enabled = False
        txtscadu.Enabled = False
        txtsdis.Enabled = False
        txtspc.Enabled = False
        txtspv.Enabled = False

    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs)
        ban = New ADODB.Parameter
        Dim clave As Integer
        Dim fecha As String
        fecha = DateTimePicker1.Value

        clave = 0
        comando = New ADODB.Command
        With comando
            .CommandText = "PAInserproductos"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(txtidprod.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 33, txtname.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, , Microsoft.VisualBasic.Left(fecha, 10)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(3).Value
        End With
        If ban.Value = 1 Then
            MsgBox("La clave no puede estar Vacia")
        Else
            If ban.Value = 2 Then
                MsgBox("el nombre de producto no puede estar vacio")
            Else
                If ban.Value = 3 Then
                    MsgBox("La fecha de producto no puede estar vacio")
                Else
                    If ban.Value = 4 Then
                        MsgBox("El nombre del producto no puede tener mas de 30 caracteres")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("La clave del producto ya a sido registrada")
                        Else
                            consql = ("Select cveproductos from productos where cveproductos=" & txtidprod.Text)
                            consulta1 = New ADODB.Recordset
                            consulta1 = conexion.Execute(consql)
                            If Not consulta1.EOF Then
                                clave = consulta1.Fields(0).Value
                            End If

                            MsgBox("La clave del provedor es: " & clave & " Insercion correcta")
                            txtidprod.Text = ""
                            txtname.Text = " "
                            clave = 0

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btnregistrar_Click_1(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ban = New ADODB.Parameter
        Dim clave As Integer
        Dim fecha As String
        fecha = DateTimePicker1.Value

        clave = 0
        comando = New ADODB.Command
        With comando
            .CommandText = "PAInserproductos"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(txtidprod.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 33, txtname.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , Microsoft.VisualBasic.Left(fecha, 10)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(3).Value
        End With
        If ban.Value = 1 Then
            MsgBox("La clave no puede estar Vacia")
        Else
            If ban.Value = 2 Then
                MsgBox("el nombre de producto no puede estar vacio")
            Else
                If ban.Value = 3 Then
                    MsgBox("La fecha de producto no puede estar vacio")
                Else
                    If ban.Value = 4 Then
                        MsgBox("El nombre del producto no puede tener mas de 30 caracteres")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("La clave del producto ya a sido registrada")
                        Else
                            consql = ("Select cveproductos from productos where cveproductos=" & txtidprod.Text)
                            consulta1 = New ADODB.Recordset
                            consulta1 = conexion.Execute(consql)
                            If Not consulta1.EOF Then
                                clave = consulta1.Fields(0).Value
                            End If

                            MsgBox("La clave del provedor es: " & clave & " Insercion correcta")
                            txtidprod.Text = ""
                            txtname.Text = " "
                            clave = 0

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btnbuscarid_Click(sender As Object, e As EventArgs) Handles btnbuscarid.Click
        consulta2 = New ADODB.Recordset
        If txtbuscarid.Text = "" Then
            MsgBox("La Clave del producto no existe o esta dada de baja")
        Else
            consulta2 = conexion.Execute("select * from productos where cveproductos=" & txtbuscarid.Text)



            If Not consulta2.EOF Then
                txtsid.Text = consulta2.Fields(0).Value
                txtsname.Text = consulta2.Fields(1).Value
                txtsdis.Text = consulta2.Fields(4).Value
                txtspc.Text = consulta2.Fields(2).Value
                txtspv.Text = consulta2.Fields(5).Value
                txtscadu.Text = consulta2.Fields(3).Value
            Else
                MsgBox("La Clave del producto no existe o esta dada de baja")
            End If
        End If
    End Sub

    Private Sub Txtsid_TextChanged(sender As Object, e As EventArgs) Handles txtsid.TextChanged

    End Sub
End Class