Public Class FormCirurgia

    Private Sub FormCirurgia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco


        '  DataGridView1.DataSource = obj.lista
        DataGridView1.Refresh()
        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco


        comboMedico.DisplayMember = "nome_medico_veterinario"
        comboMedico.ValueMember = "codigo_medico_vet_pk"
        comboMedico.DataSource = obj.retornaDataTable("Select *from medico_veterinario")

    End Sub

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodigo.Text = "" Then
                cod = 0
            Else
                cod = txtcodigo.Text

            End If

            Dim result As Integer
            ' Dim sql As String
            ' sql = "Select inserir_cirurgia('" & txtnomeMed.Text & "','" & txtespecialidade.Text & "','" & txtcrmv.Text & "','" & txttelefone.Text & "')"

            '  result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)

            Else
                MsgBox("Erro!")

            End If
            DataGridView1.DataSource = objpac.executasql("Select * from cirurgia")
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        '      txtcodigo.Text = 12
        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_cirurgia(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
            '   limpaobjeto()
            ' DataGridView1.DataSource = obj.lista
            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
    
    End Sub
End Class