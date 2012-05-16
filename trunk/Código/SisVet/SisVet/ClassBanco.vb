Namespace Sisvet


    Public Class ClassBanco
        'String de conexão 
        Dim connectionString As String = "Dsn=PostgreSQL35W;database=C.H.V;server=127.0.0.1;port=5433;uid=postgres;pwd=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1"

        ' função que retorna dataSet
        Public Function retornaDataTable(ByVal sqlComando As String) As System.Data.DataTable

            'crar um objeto de ligação entre o banc e o conjunto de dados
            ' Dim da As New System.Data.SqlClient.SqlDataAdapter(sqlComando, connectionString)
            Dim da As New System.Data.Odbc.OdbcDataAdapter(sqlComando, connectionString)
            'criar um objeto conjunto de dados(dataSet)
            Dim ds As New System.Data.DataSet

            'preencher o conjunto de dados(dataSet) com os dados do banco
            da.Fill(ds)

            Return ds.Tables(0)


        End Function

        Public Function executasql(ByVal sqlcomando As String) As Integer
            Dim conn As New System.Data.Odbc.OdbcConnection(connectionString)


            Dim cmd As New System.Data.Odbc.OdbcCommand(sqlcomando, conn)

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
