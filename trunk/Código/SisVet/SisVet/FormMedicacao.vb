Public Class FormMedicacao

    Private Sub FormMedicacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()
        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco


        Comboremedio.DisplayMember = "NOME"
        Comboremedio.ValueMember = "CODIGO"
        Comboremedio.DataSource = obj.retornaDataTable(" select * FROM  retornarem() AS (CODIGO INTEGER, NOME VARCHAR, VALOR NUMERIC, QTD_ESTOQUE INTEGER, CATEGORIA VARCHAR)")


        ComboTratamento.DisplayMember = "NOMEtrat"
        ComboTratamento.ValueMember = "CODIGOtrat"
        ComboTratamento.DataSource = obj.retornaDataTable(" select * FROM  retornatratamento() AS (CODIGOtrat INTEGER, NOMEtrat VARCHAR, PAC VARCHAR, MEDICO VARCHAR)")


        'ComboResponsavel.DisplayMember = "NOMEmed"
        'ComboResponsavel.ValueMember = "CODIGOmed"
        'ComboResponsavel.DataSource = obj.retornaDataTable(" select * FROM  retornamed() AS (CODIGOmed INTEGER, NOMEmed VARCHAR(50),ESPECIALIDADE VARCHAR(50), CRMV VARCHAR(10), TELEFONE VARCHAR(13))")

    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao() AS ( NOMETRAT TEXT, NOMEREM TEXT, QTD_ESTOQUE VARCHAR, RESPONSAVEL VARCHAR, VALOR NUMERIC)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao(" & cod & ") AS ( NOMETRAT, NOMEREM TEXT, QTD_ESTOQUE VARCHAR, RESPONSAVEL VARCHAR, VALOR NUMERIC)")

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

            Dim idTrat As Integer
            ComboTratamento.DisplayMember = "NOMEtrat"
            ComboTratamento.ValueMember = "CODIGOtrat"
            idTrat = ComboTratamento.SelectedValue

            Dim idRem As Integer
            Comboremedio.DisplayMember = "NOME"
            Comboremedio.ValueMember = "CODIGO"
            idRem = Comboremedio.SelectedValue

            'Dim id As Integer
            'ComboResponsavel.DisplayMember = "NOME"
            'ComboResponsavel.ValueMember = "CODIGO"
            'id = ComboResponsavel.SelectedValue

           


            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadosmedicacao(" & idTrat & "," & idRem & ",'" & txtquantidade.Text & "','" & ComboResponsavel.Text & "'," & txtvalor.Text & "," & cod & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()

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
        Carregacombo()
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
            Dim id As Integer

            id = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value


            PreencheGrid(id)

            txtcodigo.Visible = True
            txtcodigo.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            ComboTratamento.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            Comboremedio.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtquantidade.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            ComboResponsavel.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            txtvalor.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value

        End If
    End Sub

End Class