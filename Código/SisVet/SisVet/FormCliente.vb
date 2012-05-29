
Public Class FormCliente

    Private Sub btpaciente_Click(sender As System.Object, e As System.EventArgs) Handles btpaciente.Click
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
            DataGridView1.DataSource = obj.executasql("Select * from cliente")
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim obj As New Sisvet.ClassBanco
        Dim sql As String
        sql = obj.executasql(" Select deletar_cliente(" & txtcodcli.Text & ")")
    End Sub


    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click
        Dim obj As New Sisvet.ClassBanco
        MessageBox.Show("Ainda não foi implementado")
        Try
            obj = New Sisvet.ClassBanco

            If String.IsNullOrEmpty(txtbusca.Text) Then
                DataGridView1.DataSource = obj.retornaDataTable(" Select *from cliente")
            Else
                DataGridView1.DataSource = obj.retornaDataTable(" Select *from cliente where nome_cliente =" & txtbusca.Text)
                '  carregaobjeto()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FormCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco
         PreencheGrid()

        DataGridView1.Refresh()
    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click
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



            txtnome.Text = DataGridView1.CurrentRow.Index


            '         txtcodcli.Text = DataGridView1.CurrentRow.InheritedStyle

            '      Row[DataGridView1].CurrentRow.Index].Cells[posicao].Value.ToString();

            '  this.txtCPF.Text = GetValorColuna(2);
            '  this.txtRG.Text = GetValorColuna(3
            '  this.txtEndereco.Text = GetValorColuna(4);
            '}
        End If
    End Sub
    Private Sub PreencheGrid()
        Dim obj As New Sisvet.ClassBanco
        '        DataGridView1.DataSource = obj.executasql(("select *from cliente"))
        DataGridView1.DataSource = obj.retornaDataTable(" select * FROM  vw_cliente as cod_cliente;")
        ' DataGridView1.DataSource = obj.retornaDataTable(" Select carregargridcliente2() as  (cod_cliente integer  , varchar nome_cliente  ,date data_nascimeto_cliente,varchar endereco_cliente,varchar rg_cliente,char telefone_cliente,varchar exxpedidor_rg_cliente, varchar minicipio_cliente, varchar cpf_cliente)")

        '  obj.retornaDataTable("select *from cliente")
        '  DataGridView1.Rows.Clear()
        ' DataGridView1.Columns.Clear()


    End Sub
    '           private Sub  CarregarGrid(params string[] valores)
    '                clsUtil.TrazerDados(estoqueConnStr, "fnGetFuncionarios", ref this.Grid, valores);


    '    End Sub
    '            private string GetValorColuna(int posicao)
    '            {
    '                return this.Grid.Rows[Grid.CurrentRow.Index].Cells[posicao].Value.ToString();
    '            }
    '            private string GetValorColuna(string coluna)
    '    '        {
    '                return this.Grid.Rows[Grid.CurrentRow.Index].Cells[coluna].Value.ToString();
    '            }
    '#End Region
End Class