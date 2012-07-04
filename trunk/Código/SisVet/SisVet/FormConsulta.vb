Public Class FormConsulta
    '

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        'Dim obj As New Sisvet.ClassBanco
        'Dim data As String = txtdata.Text
        'Dim hora As String = txthora.Text
        'Dim medico As String = ComboMedico.SelectedValue.ToString
        'Dim cod As String = txtcodConsulta.Text
        'Dim paciente As String = comboPaciente.SelectedValue.ToString
        'Dim prontuario As String = txtprontuario.Text

        'Dim agendamento As String = " "
        'If radioSim.Checked = True Then
        '    agendamento = "S"

        'ElseIf radioNao.Checked = True Then
        '    agendamento = "N"
        'End If

        'Dim sql As String
        ''sql = obj.executasql("Select inserir_cliente(" & cod & ",'" & data & "','" & hora & "'," & medico & "," & cod & ",'" & agendamento & "'," & paciente & ",'" & txtprontuario.Text & "')")
        'sql = obj.executasql("Select inserir_consulta('" & data & "','" & hora & "'," & medico & "," & cod & ",'" & agendamento & "'," & paciente & ",'" & txtprontuario.Text & "')")


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
            sql = obj.executasql(" Select receber_dadosConsulta(" & cod & ",'" & txtdata.Text & "','" & txthora.Text & "'," & ComboMedico.SelectedValue & "," & ComboTipoConsulta.SelectedValue & ",'" & agendamento & "'," & comboPaciente.SelectedValue & ",'" & txtprontuario.Text & "')")

            result = obj.executasql(sql)
            txtcodConsulta.Text = result
            If result > 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodConsulta.Visible = True

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FormConsulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco

        PreencheGrid()
        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        ComboMedico.DisplayMember = "nome_medico_veterinario"
        ComboMedico.ValueMember = "codigo_medico_vet_pk"
        ComboMedico.DataSource = obj.retornaDataTable("Select *from medico_veterinario")


        comboPaciente.DisplayMember = "nome_paciente"
        comboPaciente.ValueMember = "cod_paciente"
        comboPaciente.DataSource = obj.retornaDataTable("Select *from paciente")



        ComboTipoConsulta.DisplayMember = "valor_consulta"
        ComboTipoConsulta.ValueMember = "cod_tipo_cnsulta"
        ComboTipoConsulta.DataSource = obj.retornaDataTable("Select *from tipo_consulta")

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
        txtdata.Text = ""
        txtprontuario.Text = ""
        txthora.Text = ""

    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.executasql("Select * from consulta")
        DataGridView1.Refresh()

    End Sub
    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click

    End Sub
End Class