Public Class FormLaboratorio

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
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
            sql = " Select receber_dadoslaboratorio('" & txtnome.Text & "','" & txttelefone.Text & "','" & txtendereco.Text & "','" & txtmunicipio.Text & "'," & cod & ")"

            result = obj.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If


        Catch ex As Exception
            '  MsgBox(ex.Message)
            PreencheGrid()
        End Try
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco

            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_laboratorio(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
   
        End If
    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        txtcodigo.Visible = False

        txtbusca.Text = ""
        txtcodigo.Text = ""
        txtmunicipio.Text = ""
        txtendereco.Text = ""
        txtnome.Text = ""
        txttelefone.Text = ""

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
            txttelefone.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtendereco.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            txtmunicipio.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value

        End If
    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornalab() AS (CODIGO INTEGER, NOME VARCHAR, TELEFONE CHAR(13), ENDERECO VARCHAR, MUNICIPIO VARCHAR)")

    End Sub

    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornalab(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, TELEFONE CHAR(13), ENDERECO VARCHAR, MUNICIPIO VARCHAR)")

    End Sub
    Private Sub PreencheGrid(cod As Integer)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornalab(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, TELEFONE CHAR(13), ENDERECO VARCHAR, MUNICIPIO VARCHAR)")

    End Sub

    Private Sub FormLaboratorio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()

    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        CarregaCampos()
    End Sub
End Class