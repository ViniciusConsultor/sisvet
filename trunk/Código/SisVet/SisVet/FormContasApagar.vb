Public Class FormContasApagar

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodAux.Text = "" Then
                cod = 0
            Else
                cod = txtcodAux.Text

            End If

            Dim idCli As Integer
            combocliente.DisplayMember = "NOME"
            combocliente.ValueMember = "CODIGO"
            idCli = combocliente.SelectedValue


            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadosContas(" & idCli & ",'" & combocliente.Text & "','" & txtdata.Text & "','" & txtvalor.Text & "'," & cod & ")"

            result = objpac.executasql(sql)
            txtcodAux.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodAux.Visible = True

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


      
    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        combocliente.DisplayMember = "NOME"
        combocliente.ValueMember = "CODIGO"
        combocliente.DataSource = obj.retornaDataTable(" select * FROM  retornacli() AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")


    End Sub


    Private Sub FormContasApagar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()
        Carregacombo()

    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaconta() AS (CODIGO INTEGER, NOME_CLIENTE VARCHAR, DATA date, VALOR NUMERIC)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaconta(" & cod & ") AS (CODIGO INTEGER, NOME_CLIENTE VARCHAR, DATA date, VALOR NUMERIC)")

    End Sub
    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        txtcodAux.Visible = False
        Dim obj As New Sisvet.ClassBanco
        Try
            obj = New Sisvet.ClassBanco

            If String.IsNullOrEmpty(txtbusca.Text) Then
                PreencheGrid()
            Else

                PreencheGrid("'%" & txtbusca.Text & "%'")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class