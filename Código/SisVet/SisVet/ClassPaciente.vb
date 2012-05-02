Namespace Sisvet

    Public Class ClassPaciente
        Inherits Sisvet.classBanco 'herança
        Private pid As String
        Private pnome As String
        Private pdatanascimento As String
        Private pespecie As String
        Private praca As String
        Private prghv As String
        Private ppelagem As String
        Private psexo As String
        Private pcadastro As String
       


        Public Enum tipoAcao
            insere
            atualiza
        End Enum

        Dim acao As tipoAcao


        Public Function deleta() As Integer 'Boolean
            Dim result As Integer

            Dim sql As String = "Delete from paciente where cod_paciente = '" & pid & "'"
            result = executasql(sql)

            Return result

        End Function

        Public Function salva() As Integer
            Dim sql As String
            Dim result As Integer
            If acao = tipoAcao.insere Then
                sql = "insert into paciente values('" & prghv & "','" & pnome & "','" & pespecie & "'," & praca & ",'" & pdatanascimento & "','" & ppelagem & "'," & psexo & ",'" & pcadastro & "');select @@identity"
            Else

                sql = "update paciente set rghv_paciente ='" & prghv & "',nome_pacinente ='" & pnome & "',especie_paciente ='" & pespecie & "',raca_paciente =" & praca & ",nascimento_paciente ='" & pdatanascimento & "',pelagem_paciente ='" & ppelagem & "',sexo_paciente =" & psexo & ",cadastro_paciente ='" & pcadastro & "'where cod_paciente =" & pid & ""

            End If
            result = executasql(sql)
            Return result
        End Function

        Public Sub recupera()
            Dim sql As String
            sql = "select *from paciente where cod_paciente =" & pid & ""
            Dim dr As DataRow = retornaDataTable(sql).Rows(0)
            With dr
                prghv = .Item("salario")
                pnome = .Item("nome")
                pespecie = .Item("parentesco")
                praca = .Item("trabalho")
                pdatanascimento = .Item("idade")
                ppelagem = .Item("escolaridade")
                psexo = .Item("religiao")
                pcadastro = .Item("estuda")


            End With

        End Sub
        Public Function lista(Optional ByVal cond As String = "1 = 1") As DataTable
            Dim sql As String
            sql = "select d.cod_paciente as 'Codigo',d.rghv_paciente as 'RGHV',d.nome_paciente as 'Paciente',d.especie_paciente as 'Espécie',c.raca_paciente as 'Raça',d.nascimento_paciente as 'Data Nascimento',d.pelagem_paciente as 'Pelagem',d.sexo_paciente as 'Sexo',d.cadastro_paciente as 'Cadastro' from paciente d inner join cliente c on c.cod_cliente = d.cod_cliente_fk where " & cond
            Dim dt As DataTable = retornaDataTable(sql)
            Return dt

        End Function

        Public Function listaNome(ByVal cond As String) As String

            Dim sql As String

            sql = "select nome from paciente where nome_paciente ='" & cond & "'"

            Dim dt As DataTable = retornaDataTable(sql)

            Return dt.Rows(0).Item("nome_paciente")
        End Function


        Sub New(Optional ByVal id As String = "")
            If String.IsNullOrEmpty(id) Then
                acao = tipoAcao.insere
            Else
                acao = tipoAcao.atualiza
                pid = id
            End If

        End Sub



        Public Property id() As String
            Get
                Return pid
            End Get
            Set(ByVal value As String)
                pid = value
            End Set
        End Property

        Public Property nome() As String
            Get
                Return pnome
            End Get
            Set(ByVal value As String)
                pnome = value
            End Set
        End Property

        Public Property datanasc() As String
            Get
                Return pdatanascimento

            End Get
            Set(ByVal value As String)
                pdatanascimento = value
            End Set
        End Property


        Public Property especie() As String
            Get
                Return pespecie
            End Get
            Set(ByVal value As String)
                pespecie = value
            End Set
        End Property

        Public Property raça() As String
            Get
                Return praca
            End Get
            Set(ByVal value As String)
                praca = value
            End Set
        End Property

        Public Property rghv() As String
            Get
                Return prghv
            End Get
            Set(ByVal value As String)
                prghv = value
            End Set
        End Property

        Public Property pelagem() As String
            Get
                Return ppelagem
            End Get
            Set(ByVal value As String)
                ppelagem = value
            End Set
        End Property

        Public Property sexo() As String
            Get
                Return psexo
            End Get
            Set(ByVal value As String)
                psexo = value
            End Set
        End Property

        Public Property cadastro() As String
            Get
                Return pcadastro
            End Get
            Set(ByVal value As String)
                pcadastro = value
            End Set
        End Property

      
    End Class

End Namespace

