Public Class FormConsulta
    '

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        Dim obj As New Sisvet.ClassBanco
        Dim data As String = txtdata.Text
        Dim hora As String = txthora.Text
        Dim medico As String = ComboMedico.SelectedValue.ToString
        Dim cod As String = txtcodConsulta.Text
        Dim paciente As String = comboPaciente.SelectedValue.ToString
        Dim prontuario As String = txtprontuario.Text

        Dim agendamento As String = " "
        If radioSim.Checked = True Then
            agendamento = "S"

        ElseIf radioNao.Checked = True Then
            agendamento = "N"
        End If

        Dim sql As String
        'sql = obj.executasql("Select inserir_cliente(" & cod & ",'" & data & "','" & hora & "'," & medico & "," & cod & ",'" & agendamento & "'," & paciente & ",'" & txtprontuario.Text & "')")
        sql = obj.executasql("Select inserir_consulta('" & data & "','" & hora & "'," & medico & "," & cod & ",'" & agendamento & "'," & paciente & ",'" & txtprontuario.Text & "')")

    End Sub

    Private Sub FormConsulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco


        '  DataGridView1.DataSource = obj.lista
        DataGridView1.Refresh()
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
End Class