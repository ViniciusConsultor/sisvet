Public Class FormMedicacao

    Private Sub FormMedicacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' FormTratamento.Show()
        FormTratamento.WindowState = FormWindowState.Normal

        combopaciente.Text = FormTratamento.ComboPaciente.Text
        combopaciente.ValueMember = FormTratamento.ComboPaciente.SelectedValue

        ComboTratamento.Text = "COD:" & FormTratamento.txtcodigo.Text & "       Medicação"
        ComboTratamento.ValueMember = FormTratamento.txtcodigo.Text

        Comboremedio.Text = FormTratamento.combodescricao.Text
        Comboremedio.ValueMember = FormTratamento.combodescricao.ValueMember
        Comboremedio.SelectedValue = FormTratamento.combodescricao.SelectedValue

        TextBox1.Text = FormTratamento.ComboPaciente.SelectedValue
    End Sub

    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao() AS ( CODIGO INTEGER, PACIENTE VARCHAR, TRATAMENTO INTEGER, REMEDIO VARCHAR, QTD_ESTOQUE VARCHAR(20), RESPONSAVEL VARCHAR, VALOR NUMERIC)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao('" & cod & "') AS ( NOMETRAT TEXT, NOMEREM integer, TRATAMENTO INTEGER, QTD_ESTOQUE VARCHAR(20), RESPONSAVEL VARCHAR, VALOR NUMERIC)")

    End Sub
    Private Sub PreencheGrid2(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao2('" & cod & "') AS ( CODIGO INTEGER, PACIENTE VARCHAR, TRATAMENTO INTEGER, REMEDIO VARCHAR, QTD_ESTOQUE VARCHAR(20), RESPONSAVEL VARCHAR, VALOR NUMERIC)")

    End Sub
    'Private Sub PreencheGrid(cod As String, cod2 As String)
    '    Dim obj As New Sisvet.ClassBanco

    '    DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao('" & cod & "','" & cod2 & "') AS ( NOMETRAT TEXT, NOMEREM integer, QTD_ESTOQUE VARCHAR(20), RESPONSAVEL VARCHAR, VALOR NUMERIC)")

    'End Sub
    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodigo.Text = "" Then
                cod = 0
            Else
                cod = txtcodigo.Text

            End If
            Dim obj As New Sisvet.ClassBanco

            Dim idTrat As Integer
            idTrat = FormTratamento.txtcodigo.Text


            Dim idMed As Integer
            idMed = FormTratamento.combodescricao.SelectedValue


            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadosmedicacao(" & idTrat & "," & idMed & ",'" & txtquantidade.Text & "','" & ComboResponsavel.Text & "'," & txtvalor.Text & "," & cod & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True
                PreencheGrid()
            Else
                MsgBox("Erro!")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub


    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_medicacao(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
            PreencheGrid()

        End If

    End Sub


    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Text = ""
        txtcodigo.Visible = False
        txtbusca.Text = ""
        txtquantidade.Text = ""
        txtvalor.Text = ""
        ' Carregacombo()
    End Sub

    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        txtcodigo.Visible = False
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


    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        CarregaCampos()
    End Sub
    Private Sub CarregaCampos()

        If (DataGridView1.Rows.Count > 0) Then

            Dim obj As New Sisvet.ClassBanco
            Dim id As String
            ' Dim id2 As String

            id = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
            ' id2 = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            ' PreencheGrid(id, id2)

            txtcodigo.Visible = True
            txtcodigo.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            combopaciente.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            ComboTratamento.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value

            '  Comboremedio.DataSource = obj.retornaDataTable(" select * FROM  carregacomboremedio(" & DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value & ")")
            Comboremedio.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value

            txtquantidade.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            ComboResponsavel.Text = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
            txtvalor.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value

        End If
    End Sub

    Private Sub combopaciente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combopaciente.SelectedIndexChanged
        PreencheGrid(combopaciente.SelectedValue)
    End Sub
   
End Class