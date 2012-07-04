Public Class FormMedico

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodMed.Visible = False
        txtbusca.Text = ""
        txtcodMed.Text = ""
        txtcrmv.Text = ""
        txtespecialidade.Text = ""
        txtnomeMed.Text = ""
        txttelefone.Text = ""

    End Sub

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodMed.Text = "" Then
                cod = 0
            Else
                cod = txtcodMed.Text

            End If

            Dim result As Integer
            Dim sql As String
            sql = "Select inserir_medvet('" & txtnomeMed.Text & "','" & txtespecialidade.Text & "','" & txtcrmv.Text & "','" & txttelefone.Text & "')"

            result = objpac.executasql(sql)
            txtcodMed.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamed(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR(50),ESPECIALIDADE VARCHAR(50), CRMV VARCHAR(10), TELEFONE VARCHAR(13))")

    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornamed() AS (CODIGO INTEGER, NOME VARCHAR(50),ESPECIALIDADE VARCHAR(50), CRMV VARCHAR(10), TELEFONE VARCHAR(13))")

    End Sub

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click
        If txtcodMed.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_medvet(" & txtcodMed.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If

        End If
    End Sub

    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        txtcodMed.Visible = False
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

    Private Sub FormMedico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()

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

            txtcodMed.Visible = True
            txtcodMed.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txtnomeMed.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            txtespecialidade.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtcrmv.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            txttelefone.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value

        End If

        End Sub
End Class