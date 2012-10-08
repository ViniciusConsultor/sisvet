Public Class FormConsulta
    '

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        

        Dim cod As Integer
        If txtcodConsulta.Visible = False Then
            cod = 0

        Else
            cod = txtcodConsulta.Text

        End If
        Dim obj As New Sisvet.ClassBanco
        Try

            Dim agendamento As String = " "
            If radioSim.Checked = True Then
                agendamento = "S"

            ElseIf radioNao.Checked = True Then
                agendamento = "N"
            End If



            Dim result As Integer
            Dim sql As String
            sql = " Select receber_dadosConsulta(" & cod & ",'" & txtdata.Text & "','" & txthora.Text & "'," & ComboMedico.SelectedValue & "," & ComboTipoConsulta.SelectedValue & ",'" & agendamento & "'," & comboPaciente.SelectedValue & ",'" & txtprontuario.Text & "')"

            result = obj.executasql(sql)
            txtcodConsulta.Text = result
            If result > 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodConsulta.Visible = True

            Else
                MsgBox("Erro!")

            End If
         Catch ex As Exception
            ' MsgBox(ex.Message)



        End Try
        PreencheGrid()
    End Sub

    Private Sub FormConsulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco

        PreencheGrid()
        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        ComboMedico.DisplayMember = "NOME"
        ComboMedico.ValueMember = "CODIGO"
        ComboMedico.DataSource = obj.retornaDataTable(" select * FROM  retornamed() AS (CODIGO INTEGER, NOME VARCHAR(50),ESPECIALIDADE VARCHAR(50), CRMV VARCHAR(10), TELEFONE VARCHAR(13))")


        comboPaciente.DisplayMember = "NOMEpac"
        comboPaciente.ValueMember = "CODIGOpac"
        comboPaciente.DataSource = obj.retornaDataTable(" select * FROM  retornapac() AS (CODIGOpac INTEGER, NOMEpac VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(11), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")



        ComboTipoConsulta.DisplayMember = "NOMEtc"
        ComboTipoConsulta.ValueMember = "CODIGOtc"
        ComboTipoConsulta.DataSource = obj.retornaDataTable(" select * FROM  retornatipo() AS (CODIGOtc INTEGER,VALOR NUMERIC, NOMEtc VARCHAR)")

    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        Dim obj As New Sisvet.ClassBanco

        Dim sql As String
        If Not String.IsNullOrEmpty(txtcodConsulta.Text) Then


            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                sql = obj.executasql("Select deletar_consulta(" & txtcodConsulta.Text & ")")
                MessageBox.Show(sql)

                If (sql <= 1) Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else
            End If



        Else
            MessageBox.Show("Não Há Nenhum Código Selecionado para Excluir")
        End If



    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtbusca.Text = ""
        txtcodConsulta.Text = ""
        txtcodConsulta.Visible = False
        txtdata.Text = ""
        txtprontuario.Text = ""
        txthora.Text = ""

    End Sub
 
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaconsulta() AS (CODIGO INTEGER, DATA DATE, HORA TIME, VETERINARIO VARCHAR, TIPO_CONSULTA VARCHAR, AGENDADO CHAR,PACIENTE VARCHAR, PRONTUARIO TEXT)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaconsulta(" & cod & ") AS(CODIGO INTEGER, DATA DATE, HORA TIME, VETERINARIO VARCHAR, TIPO_CONSULTA VARCHAR, AGENDADO CHAR,PACIENTE VARCHAR, PRONTUARIO TEXT)")
    End Sub
 
    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click

        txtcodConsulta.Visible = False
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

            txtcodConsulta.Visible = True
            txtcodConsulta.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txtdata.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            txthora.Text = Convert.ToString(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value)
            ComboMedico.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            ComboTipoConsulta.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value

            If DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = "N" Then
                radioNao.Checked = True
                radioSim.Checked = False

            Else
                radioSim.Checked = True
                radioNao.Checked = False

            End If

            comboPaciente.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value
            txtprontuario.Text = DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value

        End If

    End Sub

End Class