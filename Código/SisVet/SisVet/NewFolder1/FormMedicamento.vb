Public Class FormMedicamento


    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        Dim cod As String
        If txtcodigo.Visible = False Then
            cod = 0

        Else
            cod = txtcodigo.Text

        End If
        Dim obj As New Sisvet.ClassBanco
        Try

            Dim result As Integer
            Dim sql As String
            sql = obj.executasql(" Select receber_dadosmedicamento('" & txtnome.Text & "'," & txtvalor.Text & "," & txtestoque.Text & ",'" & txttipo.Text & "'," & cod & ")")

            result = obj.executasql(sql)
            txtcodigo.Text = result
            If result > 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If
            DataGridView1.DataSource = obj.executasql("Select * from medicamento")
            DataGridView1.Refresh()

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
                If obj.executasql("Select deletar_remedio(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
   
        End If
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



    Private Sub FormMedicamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Preenchegrid()

    End Sub
    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Visible = False
        txtcodigo.Text = ""
        txtnome.Text = ""
        txtvalor.Text = ""
        txtestoque.Text = ""
        txttipo.Text = ""
     
    End Sub

    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornarem() AS (CODIGO INTEGER, NOME VARCHAR, VALOR NUMERIC, QTD_ESTOQUE INTEGER, CATEGORIA VARCHAR)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornaREM(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, VALOR NUMERIC, QTD_ESTOQUE INTEGER, CATEGORIA VARCHAR)")

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
            txtnome.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            txtvalor.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtestoque.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            txttipo.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
          

        End If
    End Sub


End Class