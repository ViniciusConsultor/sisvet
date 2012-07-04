Public Class FormPaciente

    
    Private Sub btsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalvar.Click

        Try

            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodigo.Text = "" Then
                cod = 0
            Else
                cod = txtcodigo.Text

            End If

            Dim idCli As Integer
            ComboBox1.DisplayMember = "NOME"
            ComboBox1.ValueMember = "CODIGO"
            idCli = ComboBox1.SelectedValue

            Dim sexo As Char

            If Radiomasculino.Checked = True Then
                sexo = "M"
            ElseIf RadioFeminino.Checked = True Then

                sexo = "F"
            End If
            Dim castrado As Char
            If RadioSim.Checked = True Then
                castrado = "S"
            ElseIf RadioNao.Checked = True Then
                castrado = "N"
            End If


            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadospaciente(" & idCli & ",'" & txtrghv.Text & "','" & txtespecie.Text & "','" & txtraça.Text & "','" & masckDatanascimento.Text & "','" & txtpelagem.Text & "','" & sexo & "','" & castrado & "','" & txtnomepaciente.Text & "'," & cod & ")"

            result = objpac.executasql(sql)
            txtcodigo.Text = result
            If result >= 0 Then

                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodigo.Visible = True

            Else
                MsgBox("Erro!")

            End If
            PreencheGrid()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FormPaciente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PreencheGrid()
        Carregacombo()

      
    End Sub
    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        ComboBox1.DisplayMember = "NOME"
        ComboBox1.ValueMember = "CODIGO"
        '  ComboBox1.DataSource = obj.retornaDataTable("Select *from cliente")
        ComboBox1.DataSource = obj.retornaDataTable(" select * FROM  retornacli() AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")


    End Sub
 

    Private Sub btexcluir_Click(sender As System.Object, e As System.EventArgs) Handles btexcluir.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("Não há Nenhum Id Selecionado Para Excluir")
        Else

            Dim obj As New Sisvet.ClassBanco



            If MsgBox("Tem Certeza Que Deseja Excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir") = MsgBoxResult.Yes Then
                If obj.executasql("Select deletar_paciente(" & txtcodigo.Text & ")") >= 1 Then
                    MessageBox.Show("Excluido com Sucesso")

                Else
                    MessageBox.Show("O Registro não Pode Ser Excluido")
                End If
            Else

            End If
            '   limpaobjeto()
            ' DataGridView1.DataSource = obj.lista
            DataGridView1.Refresh()
        End If
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Dim obj As New Sisvet.ClassBanco
    '    PreencheGrid()

    '    'DataGridView1.DataSource = obj.executasql(("Select *from paciente"))
    '    'DataGridView1.Refresh()

    'End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodigo.Visible = False
        txtcodigo.Text = ""
        txtespecie.Text = ""
        txtnomepaciente.Text = ""
        txtpelagem.Text = ""
        txtraça.Text = ""
        txtrghv.Text = ""
        masckDatanascimento.Text = ""
        Carregacombo()
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

    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornapac() AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(10), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco

        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornapac(" & cod & ") AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, RGHV VARCHAR(10), ESPECIE VARCHAR(50), RACA VARCHAR(25), PELAGEM VARCHAR, SEXO CHAR(1), CASTRADO CHAR(1), CLIENTE VARCHAR)")

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
            txtnomepaciente.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            masckDatanascimento.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtespecie.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            txtrghv.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            txtpelagem.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value
            txtraça.Text = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
            ComboBox1.Text = DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value


            If (DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = "F") Then
                RadioFeminino.Checked = True
                Radiomasculino.Checked = False
            Else
                Radiomasculino.Checked = True
                RadioFeminino.Checked = False

            End If

            If (DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = "S") Then
                RadioSim.Checked = True
                RadioNao.Checked = False
            Else
                RadioNao.Checked = True
                RadioSim.Checked = False

            End If

        End If
    End Sub

End Class