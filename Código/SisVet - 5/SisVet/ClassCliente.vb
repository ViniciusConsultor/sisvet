Namespace Sisvet

    Public Class ClassCliente


        Inherits Sisvet.ClassBanco 'herança
        Private pid As String
        Private pidCli As String
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


    End Class

End Namespace