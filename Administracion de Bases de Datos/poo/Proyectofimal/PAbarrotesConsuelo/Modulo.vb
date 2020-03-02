Module Modulo
    Public consulta As Recordset
    Public consulta1 As Recordset
    Public consulta2 As Recordset
    Public consulta3 As Recordset
    Public consulta4 As Recordset
    Public ban As ADODB.Parameter
    Public comando As ADODB.Command
    Public conexion As ADODB.Connection
    Public consql As String

    Public Sub conectar()
        conexion = New ADODB.Connection
        With conexion
            .Provider = "sqloledb"
            .ConnectionString = "INITIAL CATALOG = ABARROTESCONSUELO;SERVER=LAPTOP-0KLS4PTO\SQLEXPRESS;INTEGRATED SECURITY=SSPI;PERSIST SECURITY INFO=TRUE"
            Try
                .Open()
                MessageBox.Show("Conexíon Correcta")
            Catch ex As Exception
                MessageBox.Show("Conexíon Fallida" + ex.ToString)
            End Try
        End With

    End Sub

End Module
