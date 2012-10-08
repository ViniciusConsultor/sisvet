Public Class FormTratamento


    Private Sub FormTratamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Normal
        PreencheGrid()

        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco


        comboMedico.DisplayMember = "NOME"
        comboMedico.ValueMember = "CODIGO"
        comboMedico.DataSource = obj.retornaDataTable(" select * FROM  retornamed() AS (CODIGO INTEGER, NOME VARCHAR(50),ESPECIALIDADE VARCHAR(50), CRMV VARCHAR(10), TELEFONE VARCHAR(13))")


        ComboPaciente.DisplayMember = "NOMEpac"
        ComboPaciente.ValueMember = "CODIGOpac"
        ComboPaciente.DataSource = obj.retornaDataTable(" select * FROM  retornapac() AS (CODIGOpac INTEGER, NOMEpac VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(11), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")


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
    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        Try
            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodigo.Text = "" Then
                cod = 0
            Else
                cod = txtcodigo.Text
            End If

            Dim id As Integer
            comboMedico.DisplayMember = "NOME"
            comboMedico.ValueMember = "CODIGO"
            id = comboMedico.SelectedValue

            Dim idPAC As Integer
            ComboPaciente.DisplayMember = "NOMEpac"
            ComboPaciente.ValueMember = "CODIGOpac"
            idPAC = ComboPaciente.SelectedValue

            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadostratamento('" & combodescricao.Text & "'," & idPAC & "," & id & "," & cod & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then
                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

                If rbcirurgia.Checked = True Then
                    '    txttipo.Text = "CIRURGIA"
                    abrecirurgia()
                ElseIf rbexame.Checked = True Then
                    '  txttipo.Text = "EXAME"
                    abreexame()
                ElseIf rbmedicaçao.Checked = True Then
                    '  txttipo.Text = "MEDICAÇÃO"
                    abremedicacao()
                End If
            Else
                MsgBox("Erro!")
            End If
            PreencheGrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''Close()
    End Sub
    Private Sub abreexame()
        FormExameLaboratorial.Show()

    End Sub
    Private Sub abremedicacao()
        FormMedicacao.Show()

    End Sub
    Private Sub abrecirurgia()
        FormCirurgiaInternacao.Show()

    End Sub


    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco


            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_tratamento(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
        End If

    End Sub

    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornatratamento() AS (CODIGO INTEGER, NOME TEXT, PAC VARCHAR, MEDICO VARCHAR)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornatratamento(" & cod & ") AS (CODIGO INTEGER, NOME TEXT, PAC VARCHAR, MEDICO VARCHAR)")

    End Sub


    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Visible = False
        txtcodigo.Text = ""
        combodescricao.Text = ""

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
            combodescricao.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            ComboPaciente.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            comboMedico.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            combodescricao.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
        End If

    End Sub

    Private Sub rbexame_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbexame.CheckedChanged, rbmedicaçao.CheckedChanged, rbcirurgia.CheckedChanged
        Dim obj As New Sisvet.ClassBanco

        combodescricao.DisplayMember = "NOME"
        combodescricao.ValueMember = "CODIGO"
        If rbexame.Checked = True Then

            combodescricao.DataSource = obj.retornaDataTable(" select * FROM  retornaexame() AS (  CODIGO INTEGER, NOME TEXT, LABORATORIO VARCHAR)")

        ElseIf rbcirurgia.Checked = True Then
            combodescricao.DataSource = obj.retornaDataTable(" select * FROM  retornacirurgia() AS (CODIGO INTEGER, NOME VARCHAR, MEDICO VARCHAR)")


        ElseIf rbmedicaçao.Checked = True Then
            combodescricao.DataSource = obj.retornaDataTable(" select * FROM  retornamedicacao() AS ( CODIGO INTEGER, PACIENTE VARCHAR, TRATAMENTO INTEGER, NOME VARCHAR, QTD_ESTOQUE VARCHAR(20), RESPONSAVEL VARCHAR, VALOR NUMERIC)")

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class