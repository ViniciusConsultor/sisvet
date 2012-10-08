﻿Public Class FormExameLaboratorial

    Private Sub FormExame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco
        'Carregacombo()



        FormTratamento.WindowState = FormWindowState.Normal


        combopaciente.Text = FormTratamento.ComboPaciente.Text
        combopaciente.ValueMember = FormTratamento.ComboPaciente.SelectedValue

        ComboTratamento.Text = "COD:" & FormTratamento.txtcodigo.Text & "       Exame Laboratorial"
        ComboTratamento.ValueMember = FormTratamento.txtcodigo.Text

        ComboExame.Text = FormTratamento.combodescricao.Text
        ComboExame.ValueMember = FormTratamento.combodescricao.ValueMember
        ComboExame.SelectedValue = FormTratamento.combodescricao.SelectedValue

        Textexame.Text = FormTratamento.ComboPaciente.SelectedValue

    End Sub

    'Public Sub Carregacombo()
    '    Dim obj As New Sisvet.ClassBanco

    '    combopaciente.DisplayMember = "NOMEpac"
    '    combopaciente.ValueMember = "CODIGOpac"
    '    combopaciente.DataSource = obj.retornaDataTable(" select * FROM  retornapac() AS (CODIGOpac INTEGER, NOMEpac VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(11), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")

    '    ComboTratamento.DisplayMember = "NOME"
    '    ComboTratamento.ValueMember = "CODIGO"
    '    ComboTratamento.DataSource = obj.retornaDataTable(" select * FROM  retornatratamento() AS (CODIGO INTEGER, NOME TEXT, PAC VARCHAR, MEDICO VARCHAR)")

    '    ComboExame.DisplayMember = "NOME"
    '    ComboExame.ValueMember = "CODIGO"
    '    ComboExame.DataSource = obj.retornaDataTable(" select * FROM  retornaexame() AS (  CODIGO INTEGER, NOME TEXT, LABORATORIO VARCHAR)")
    '    PreencheGrid()

    '    ' PreencheGrid(combopaciente.SelectedValue)
    'End Sub

    Public Sub Carregacombotrat()
        Dim obj As New Sisvet.ClassBanco

        ComboTratamento.DisplayMember = "NOME"
        ComboTratamento.ValueMember = "CODIGO"
        ComboTratamento.DataSource = obj.retornaDataTable(" select * FROM  retornapactrat(" & combopaciente.SelectedValue & ") AS (CODIGO INTEGER, NOME TEXT)")

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
            ComboTratamento.DisplayMember = "NOME"
            ComboTratamento.ValueMember = "CODIGO"
            idTrat = ComboTratamento.SelectedValue

            Dim idEx As Integer
            ComboExame.DisplayMember = "NOME"
            ComboExame.ValueMember = "CODIGO"
            idEx = ComboExame.SelectedValue

            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadosexamelabo(" & idTrat & "," & idEx & ",'" & txtdescricao.Text & "','" & txtresponsavel.Text & "','" & txtvalor.Text & "'," & cod & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        PreencheGrid(combopaciente.SelectedValue)

    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco


            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_exameLabo(" & txtcodigo.Text & ")") >= 1 Then
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

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaexamelabo() AS(PACIENTE VARCHAR, CODIGOEXAM INTEGER, RESPONSAVEL VARCHAR, DESCRICAO VARCHAR, VALOR MONEY)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaexamelabo(" & cod & ") AS ( TRATAMENTO TEXT, TIPO_EXAME TEXT, DESCRICAO TEXT,RESPONSAVEL VARCHAR,  VALOR NUMERIC)")

    End Sub


    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Visible = False
        txtcodigo.Text = ""
        txtdescricao.Text = ""

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
            txtdescricao.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            ComboTratamento.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            ComboExame.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value

        End If

    End Sub


    Private Sub combopaciente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combopaciente.Click, combopaciente.SelectedIndexChanged
        PreencheGrid(combopaciente.SelectedValue)

    End Sub

End Class