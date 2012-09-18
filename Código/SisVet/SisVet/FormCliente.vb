
Public Class FormCliente

    Private Sub btpaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPaciente.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cod As String
        If txtcodcli.Visible = False Then
            cod = 0

        Else
            cod = txtcodcli.Text

        End If
        Dim obj As New Sisvet.ClassBanco
        Try

            Dim result As Integer
            Dim sql As String
            sql = obj.executasql(" Select receber_dadosCliente('" & txtnome.Text & "','" & masckDatanascimento.Text & "','" & txtendereco.Text & "','" & txtrg.Text & "','" & txttelefone.Text & "','" & txtorgaoExpeditor.Text & "','" & txtmunicipio.Text & "','" & txtcpf_cliente.Text & "'," & cod & ")")

            result = obj.executasql(sql)
            txtcodcli.Text = result
            If result > 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodcli.Visible = True

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

      If txtcodcli.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco

            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_cliente(" & txtcodcli.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
        End If
    End Sub


    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        txtcodcli.Visible = False
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

    Private Sub FormCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()


    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodcli.Visible = False

        txtbusca.Text = ""
        txtcodcli.Text = ""
        txtcpf_cliente.Text = ""
        txtendereco.Text = ""
        txtmunicipio.Text = ""
        txtnome.Text = ""
        txtorgaoExpeditor.Text = ""
        txtrg.Text = ""
        txttelefone.Text = ""
        masckDatanascimento.Text = ""

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        CarregaCampos()
    End Sub
    Private Sub CarregaCampos()

        If (DataGridView1.Rows.Count > 0) Then

            Dim obj As New Sisvet.ClassBanco
            Dim id As Integer

            id = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value

            PreencheGrid(id)

            txtcodcli.Visible = True
            txtcodcli.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txtnome.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            masckDatanascimento.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtendereco.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            txtrg.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            txttelefone.Text = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
            txtorgaoExpeditor.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value
            txtmunicipio.Text = DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value
            txtcpf_cliente.Text = DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value

        End If
    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornacli() AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")

    End Sub

    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornacli(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")

    End Sub
    Private Sub PreencheGrid(cod As Integer)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornacli(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class