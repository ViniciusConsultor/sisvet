Namespace Sisvet


    Public Class ClassBanco
        'String de conexão 
        Dim connectionString As String = "Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=ong;Integrated Security=True"

        ' função que retorna dataSet
        Public Function retornaDataTable(ByVal sqlComando As String) As System.Data.DataTable

            'crar um objeto de ligação entre o banc e o conjunto de dados
            Dim da As New System.Data.SqlClient.SqlDataAdapter(sqlComando, connectionString)

            'criar um objeto conjunto de dados(dataSet)
            Dim ds As New System.Data.DataSet

            'preencher o conjunto de dados(dataSet) com os dados do banco
            da.Fill(ds)

            Return ds.Tables(0)


        End Function

        Public Function executasql(ByVal sqlcomando As String) As Integer
            Dim conn As New System.Data.SqlClient.SqlConnection(connectionString)


            Dim cmd As New System.Data.SqlClient.SqlCommand(sqlcomando, conn)

            conn.Open()

            Dim result As Integer
            If sqlcomando.Substring(0, 6).ToLower = "insert" Then

                result = cmd.ExecuteScalar()
            Else
                result = cmd.ExecuteNonQuery()
            End If

            conn.Close()

            Return result


        End Function



    End Class

End Namespace
