Public Class FormPaciente

    
    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodigo.Text = "" Then
                cod = 0
            Else
                cod = txtcodigo.Text

            End If

            Dim idCli As Integer
            ComboBox1.DisplayMember = "nome_cliente"
            ComboBox1.ValueMember = "cod_cliente"
            idCli = ComboBox1.SelectedValue

            Dim sexo As Char

            If Radiomasculino.Checked = True Then
                sexo = "M"
            ElseIf RadioFeminino.Checked = True Then

                sexo = "F"
            End If
            Dim castrado As Char
            If RadioSim.Checked = True Then
                castrado = "S"
            ElseIf RadioNao.Checked = True Then
                castrado = "N"
            End If


            Dim result As Integer
            Dim sql As String
            sql = "Select inserir_paciente(" & idCli & ",'" & txtrghv.Text & "','" & txtespecie.Text & "','" & txtraça.Text & "','" & masckDatanascimento.Text & "','" & txtpelagem.Text & "','" & sexo & "','" & castrado & "','" & txtnomepaciente.Text & "')"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)

            Else
                MsgBox("Erro!")

            End If
            DataGridView1.DataSource = objpac.executasql("Select * from paciente")
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FormPaciente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco
        DataGridView1.DataSource = obj.executasql(("select *from paciente"))
        '  DataGridView1.DataSource = obj.executasql(("Select fngetpaciente()"))
        DataGridView1.Refresh()
        Carregacombo()

      
    End Sub
    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        ComboBox1.DisplayMember = "nome_cliente"
        ComboBox1.ValueMember = "cod_cliente"
        ComboBox1.DataSource = obj.retornaDataTable("Select *from cliente")


    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        '      txtcodigo.Text = 12
        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_paciente(" & txtcodigo.Text & ")") >= 1 Then
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

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.executasql(("Select *from paciente"))
        DataGridView1.Refresh()

    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Text = ""
        txtespecie.Text = ""
        txtnomepaciente.Text = ""
        txtpelagem.Text = ""
        txtraça.Text = ""
        txtrghv.Text = ""
        masckDatanascimento.Text = ""
        Carregacombo()
    End Sub

    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        Dim obj As New Sisvet.ClassBanco
        MessageBox.Show("Ainda não foi implementado")
        Try
            obj = New Sisvet.ClassBanco
            If rbid.Checked = True Then


                If String.IsNullOrEmpty(txtbusca.Text) Then
                    '       DataGridView1.DataSource = obj.lista()
                Else
                    '      DataGridView1.DataSource = obj.lista("cod_paciente = " & txtbusca.Text)
                    '  carregaobjeto()

                End If


            ElseIf rbbuscaNome.Checked = True Then

                '    DataGridView1.DataSource = obj.lista("nome_paciente like '%" & txtbusca.Text & "%'")
                '  carregaobjeto()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    'Private Sub carregaobjeto()
    '    If DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value.Equals(DBNull.Value) Then

    '    Else
    '        Dim chave As Integer
    '        chave = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
    '        Dim obj As New Sisvet.ClassBanco(chave)
    '        Id_ClienteTextBox.Visible = True
    '        Id_ClienteTextBox.Enabled = False
    '        Id_ClienteTextBox.Text = obj.id
    '        obj.recupera()
    '        Nome_ClienteTextBox.Text = obj.nome
    '        masckDatanascimento.Text = obj.datanasc

    '        txtparentesco.Text = obj.parentesco
    '        txttrabalho.Text = obj.trabalho
    '        txtsalario.Text = obj.salario
    '        txtescolaridade.Text = obj.escolaridade
    '        txtreligiao.Text = obj.religiao
    '        txtestuda.Text = obj.estuda
    '        txtrg.Text = obj.rg
    '        masckcpfdependente.Text = obj.cpf
    '        txtctps.Text = obj.cpf
    '        txttitulo.Text = obj.titulo
    '        txtzona.Text = obj.zona
    '        txtsecao.Text = obj.secao

    '    End If
    ' End Sub
End Class