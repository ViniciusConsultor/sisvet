Public Class FormCirurgiaInternacao

    Private Sub FormCirurgiaInternacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' FormTratamento.Show()
        FormTratamento.WindowState = FormWindowState.Normal


        combopaciente.Text = FormTratamento.ComboPaciente.Text
        combopaciente.ValueMember = FormTratamento.ComboPaciente.SelectedValue

        Combotratamento.Text = "COD:" & FormTratamento.TextBox1.Text & "       Cirurgia"
        Combotratamento.ValueMember = FormTratamento.txtcodigo.Text

        Combocirurgia.Text = FormTratamento.combodescricao.Text
        Combocirurgia.ValueMember = FormTratamento.combodescricao.ValueMember
        Combocirurgia.SelectedValue = FormTratamento.combodescricao.SelectedValue
        TextBox1.Text = FormTratamento.ComboPaciente.SelectedValue
   
    End Sub
    'Public Sub Carregacombo()
    '    Dim obj As New Sisvet.ClassBanco
    '    combopaciente.DisplayMember = "NOMEpac"
    '    combopaciente.ValueMember = "CODIGOpac"
    '    combopaciente.DataSource = obj.retornaDataTable(" select * FROM  retornapac() AS (CODIGOpac INTEGER, NOMEpac VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(11), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")


    '    Combotratamento.DisplayMember = "NOME"
    '    Combotratamento.ValueMember = "CODIGO"
    '    Combotratamento.DataSource = obj.retornaDataTable(" select * FROM retornatratamento() AS (CODIGO INTEGER, NOME TEXT, PAC VARCHAR, MEDICO VARCHAR)")

    '    Combocirurgia.DisplayMember = "NOMEcirur"
    '    Combocirurgia.ValueMember = "CODIGOcirur"
    '    Combocirurgia.DataSource = obj.retornaDataTable(" select * FROM  retornacirurgia() AS (CODIGOcirur INTEGER, NOMEcirur VARCHAR, MEDICO VARCHAR)")

    '    PreencheGrid2(combopaciente.SelectedValue)
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
            idTrat = FormTratamento.txtcodigo.Text

            Dim idCir As Integer
            idCir = FormTratamento.combodescricao.SelectedValue

            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dados_cirurgiainternacao(" & cod & "," & idTrat & "," & idCir & ",'" & txtddescricaon.Text & "','" & txtdata.Text & "','" & txthora.Text & "'," & txtvalor.Text & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CarregaCampos()

        PreencheGrid(combopaciente.SelectedValue)

    End Sub
    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco


            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_cirurgiaintern(" & txtcodigo.Text & ")") >= 1 Then
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

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaCirurgiaintern() AS (CODIGO INTEGER, NOME VARCHAR, MEDICO VARCHAR)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaCirurgiaintern(" & cod & ") AS (CODIGO INTEGER, PACIENTE VARCHAR, TIPO_EXAME TEXT, DESCRICAO TEXT,DATA DATE,HORA TIME,  VALOR NUMERIC)")

    End Sub
    Private Sub PreencheGrid2(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaCirurgiainternacao(" & cod & ") AS (CODIGO INTEGER, PACIENTE VARCHAR, TIPO_EXAME TEXT, DESCRICAO TEXT,DATA DATE,HORA TIME,  VALOR NUMERIC)")

    End Sub
    Private Sub combopaciente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combopaciente.SelectedIndexChanged
        PreencheGrid(combopaciente.SelectedValue)
    End Sub
    Private Sub CarregaCampos()

        If (DataGridView1.Rows.Count > 0) Then

            Dim obj As New Sisvet.ClassBanco
            Dim id As Integer

            id = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value

            PreencheGrid2(id)

            txtcodigo.Visible = True
            txtcodigo.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txtddescricaon.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            Combotratamento.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            Combocirurgia.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value

        End If

    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        CarregaCampos()

    End Sub
End Class