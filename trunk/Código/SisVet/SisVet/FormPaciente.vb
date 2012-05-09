Public Class FormPaciente

    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassPaciente

            If txtcodigo.Text = "" Then
                objpac = New Sisvet.ClassPaciente
            Else
                objpac = New Sisvet.ClassPaciente(txtcodigo.Text)

            End If
            With objpac
                If Not String.IsNullOrEmpty(txtcodigo.Text) Then
                    .id = txtcodigo.Text
                End If
                .nome = txtnomepaciente.Text
                .datanasc = masckDatanascimento.Text
                .especie = txtespecie.Text
                .raça = txtraça.Text
                .rghv = txtrghv.Text
                .pelagem = txtpelagem.Text
                If Radiomasculino.Checked = True Then
                    .sexo = "MASCUINO"
                ElseIf RadioFeminino.Checked = True Then

                    .sexo = "FEMININO"
                End If
                If RadioSim.Checked = True Then
                    .cadastro = "SIM"
                ElseIf RadioNao.Checked = True Then
                    .cadastro = "NÃO"
                End If

            End With


            Dim result As Integer

            result = objpac.salva()
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)

            Else
                MsgBox("Erro!")

            End If
            DataGridView1.DataSource = objpac.lista
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class