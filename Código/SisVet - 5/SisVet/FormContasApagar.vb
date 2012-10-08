Public Class FormContasApagar
    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click
        Try
            Dim objpac As New Sisvet.ClassBanco
            Dim cod As Integer
            If txtcodAux.Text = "" Then
                cod = 0
            Else
                cod = txtcodAux.Text
            End If
            Dim idCli As Integer
            combocliente.DisplayMember = "NOME"
            combocliente.ValueMember = "CODIGO"
            idCli = combocliente.SelectedValue
            Dim IDTRAT As String
           
            ' CarregacomboCONS(idCli)
            IDTRAT = Format(CDate(Comboconsulta.Text), "MM/dd/yyyy")



            ComboBox1.DataSource = objpac.retornaDataTable("Select ret(" & IDTRAT & ")")
            Dim idCons As Integer

            idCons = ComboBox1.ValueMember 

            Dim result As Integer
            Dim sql As String
            sql = "Select receber_dadoscustos(" & cod & "," & idCli & "," & idCons & ",'" & txtdata.Text & "'," & txtvalor.Text & ")"

            result = objpac.executasql(sql)
            txtcodAux.Text = result
            If result >= 0 Then
                MessageBox.Show("Cadastro Salvo com Sucesso!", "", MessageBoxButtons.OK)
                txtcodAux.Visible = True
            Else
                MsgBox("Erro!")
            End If
            PreencheGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        combocliente.DisplayMember = "NOME"
        combocliente.ValueMember = "CODIGO"
        combocliente.DataSource = obj.retornaDataTable(" select * FROM  retornacli() AS (CODIGO INTEGER, NOME VARCHAR, DATA_NASCIMENTO date, ENDERECO VARCHAR, RG VARCHAR, TELEFONE CHAR(13), ORGAO_EXP CHAR(5), MUNICIPIO VARCHAR, CPF CHAR(14))")
        CarregacomboCONS(combocliente.SelectedValue)

    End Sub

    Private Sub FormContasApagar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreencheGrid()
        Carregacombo()

    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco
        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornacustos() AS (CODIGO INTEGER, NOME_CLIENTE VARCHAR,DATA date, VALOR NUMERIC,DATA_PAGO DATE)")

    End Sub
    Private Sub PreencheGrid(cod As String)
        Dim obj As New Sisvet.ClassBanco
        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  retornacustos(" & cod & ") AS (CODIGO INTEGER, NOME_CLIENTE VARCHAR,DATA date, VALOR NUMERIC,DATA_PAGO DATE)")

    End Sub
    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        txtcodAux.Visible = False
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
    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
        txtcodAux.Visible = False
        txtcodAux.Text = ""
        txtdata.Text = ""
        txtvalor.Text = ""

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        Carregacampos()

    End Sub
    Private Sub CarregaCampos()

        If (DataGridView1.Rows.Count > 0) Then

            Dim obj As New Sisvet.ClassBanco

            Dim id As Integer

            id = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value

            PreencheGrid(id)

            txtcodAux.Visible = True
            txtcodAux.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            combocliente.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            Comboconsulta.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            txtdata.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            txtvalor.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value

        End If

    End Sub

    Private Sub combocliente_Click(sender As Object, e As System.EventArgs) Handles combocliente.Click
        CarregacomboCONS(combocliente.SelectedValue)
    End Sub

    Private Sub CarregacomboCONS(cod As Integer)
        Dim obj As New Sisvet.ClassBanco
        Comboconsulta.DisplayMember = "DATA"
        Comboconsulta.ValueMember = "CODIGOCON"
        Comboconsulta.DataSource = obj.retornaDataTable(" select * FROM  retornaconsultaConta(" & cod & ") AS(CODIGOCOM INTEGER, DATA DATE)")
        'ComboBox1.DisplayMember = "cur"
        'ComboBox1.DataSource = obj.retornaDataTable("select * from testa_cursor() as (cur record)")
    End Sub

End Class