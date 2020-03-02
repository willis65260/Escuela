Public Class Empleados
    Private Sub Registarempleado_Click(sender As Object, e As EventArgs) Handles Registarempleado.Click
        Panel1.Show()
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel2.Hide()
        Panel3.Hide()
        Panel3.Enabled = False
    End Sub

    Private Sub Btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Hide()
        Me.Enabled = False
        Inicio.Show()
        Inicio.Enabled = True

    End Sub

    Private Sub Visulaizarempleados_Click(sender As Object, e As EventArgs) Handles Visulaizarempleados.Click
        Panel1.Enabled = False
        Panel1.Hide()
        Panel3.Hide()
        Panel3.Enabled = False
        Panel2.Show()
        Panel2.Enabled = True

    End Sub

    Private Sub Bgtnbuscaremp_Click(sender As Object, e As EventArgs) Handles bgtnbuscaremp.Click
        Panel1.Enabled = False
        Panel1.Hide()
        Panel2.Enabled = False
        Panel2.Hide()
        Panel3.Enabled = True
        Panel3.Show()
        consulta = New ADODB.Recordset
        consulta = conexion.Execute("Select cveempleado From Empleados order by cveempleado")
        While Not consulta.EOF
            txtbuscarid.Items.Add(consulta.Fields(0).Value)
            consulta.MoveNext()
        End While
    End Sub

    Private Sub Btnbuscarid_Click(sender As Object, e As EventArgs) Handles btnbuscarid.Click
        consulta2 = New ADODB.Recordset
        If txtbuscarid.Text = "" Then
            MsgBox("La Clave del producto no existe o esta dada de baja")
        Else
            consulta2 = conexion.Execute("select * from empleados where cveempleado=" & txtbuscarid.Text)



            If Not consulta2.EOF Then
                txtsid.Text = consulta2.Fields(0).Value
                txtsname.Text = consulta2.Fields(1).Value
                txtsap.Text = consulta2.Fields(2).Value
                txtsam.Text = consulta2.Fields(3).Value
                txtstel.Text = consulta2.Fields(4).Value
                txtsturno.Text = consulta2.Fields(5).Value
            Else
                MsgBox("La Clave del producto no existe o esta dada de baja")
            End If
        End If
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsid.Enabled = False
        txtsname.Enabled = False
        txtsap.Enabled = False
        txtsam.Enabled = False
        txtstel.Enabled = False
        txtsturno.Enabled = False

        consulta = New ADODB.Recordset
        consulta = conexion.Execute("Select cveempleado From Empleados order by cveempleado")
        While Not consulta.EOF
            txtbuscarid.Items.Add(consulta.Fields(0).Value)
            consulta.MoveNext()
        End While


    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ban = New ADODB.Parameter
        Dim clave As Integer
        Dim Turno As String
        If rbvespertino.Checked Then
            Turno = rbvespertino.Text
        Else
            Turno = rbmatutino.Text

        End If
        clave = 0


        comando = New ADODB.Command
        With comando
            .CommandText = "PAInserempleaodos"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 21, txtnombre.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 16, txtAp.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 16, txtAM.Text))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 13, txttel.Text))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 11, Turno))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(5).Value
        End With
        If ban.Value = 1 Then
            MsgBox("NO debe dejar el nombre vacio")
        Else
            If ban.Value = 2 Then
                MsgBox("NO debe dejar el apellido paterno vacio")
            Else
                If ban.Value = 3 Then
                    MsgBox("NO debe dejar el apellido materno vacio")
                Else
                    If ban.Value = 4 Then
                        MsgBox("NO debe dejar el telefono vacio")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("NO debe dejar el turno vacio")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("La longitud del nombre no debe ser mayor a 20 caracteres")
                            Else
                                If ban.Value = 7 Then
                                    MsgBox("La longitud de los apellidos no debe se mayor a 15 caracteres")
                                Else
                                    If ban.Value = 8 Then
                                        MsgBox("La longitud del telefono no debe se mayor a 12 caracteres")
                                    Else
                                        If ban.Value = 9 Then
                                            MsgBox("La longitud del turno no debe se mayor a 10 caracteres")
                                        Else
                                            If ban.Value = 10 Then
                                                MsgBox("Este empleado ya esta insertado")
                                            Else
                                                consql = ("Select max(cveempleado) from empleados")
                                                consulta1 = New ADODB.Recordset
                                                consulta1 = conexion.Execute(consql)
                                                If Not consulta1.EOF Then
                                                    clave = consulta1.Fields(0).Value
                                                End If

                                                MsgBox("La clave del empleado es: " & clave & " Insercion correcta")
                                                txtnombre.Text = ""
                                                txtAp.Text = " "
                                                txtAM.Text = " "
                                                txttel.Text = " "

                                                clave = 0

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class