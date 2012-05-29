Public Class FormMedico

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtbusca.Text = ""
        txtcodMed.Text = ""
        txtcrmv.Text = ""
        txtespecialidade.Text = ""
        txtnomeMed.Text = ""
        txttelefone.Text = ""

    End Sub

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodMed.Text = "" Then
                cod = 0
            Else
                cod = txtcodMed.Text

            End If

            Dim result As Integer
            Dim sql As String
            sql = "Select inserir_medvet('" & txtnomeMed.Text & "','" & txtespecialidade.Text & "','" & txtcrmv.Text & "','" & txttelefone.Text & "')"

            result = objpac.executasql(sql)
            txtcodMed.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)

            Else
                MsgBox("Erro!")

            End If
            DataGridView1.DataSource = objpac.executasql("Select * from medico_veterinario")
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        '      txtcodigo.Text = 12
        If txtcodMed.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_medvet(" & txtcodMed.Text & ")") >= 1 Then
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

    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        Dim obj As New Sisvet.ClassBanco
        MessageBox.Show("Ainda não foi implementado")
        Try
            obj = New Sisvet.ClassBanco
 

                If String.IsNullOrEmpty(txtbusca.Text) Then
                    '       DataGridView1.DataSource = obj.lista()
                Else
                    '      DataGridView1.DataSource = obj.lista("codigo_medico_vet_pk = " & txtbusca.Text)
                    '  carregaobjeto()

                End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class