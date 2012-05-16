Public Class FormCliente

    Private Sub btpaciente_Click(sender As System.Object, e As System.EventArgs) Handles btpaciente.Click
        FormPaciente.Show()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cod As Integer
        If txtcodcli.Visible = False Then
            cod = 0

        Else
            cod = txtcodcli.Text

        End If
        Dim obj As New Sisvet.ClassBanco
        Dim sql As Integer
        ' sql = obj.executasql(" Select receber_dadosCliente('" & txtnome.Text & "','" & masckDatanascimento.Text & "','" & txtendereco.Text & "','" & txtrg.Text & "','" & txttelefone.Text & "','" & txtorgaoExpeditor.Text & "','" & txtmunicipio.Text & "','" & txtcpf_cliente.Text & "'," & cod & ")")
        sql = obj.executasql(" Select inserir_cliente('" & txtnome.Text & "','" & masckDatanascimento.Text & "','" & txtendereco.Text & "','" & txtrg.Text & "','" & txttelefone.Text & "','" & txtorgaoExpeditor.Text & "','" & txtmunicipio.Text & "','" & txtcpf_cliente.Text & "'," & cod & ")")

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
            If rbid.Checked = True Then


                If String.IsNullOrEmpty(txtbusca.Text) Then
                    '       DataGridView1.DataSource = obj.lista()
                Else
                    '      DataGridView1.DataSource = obj.lista("cod_cliente = " & txtbusca.Text)
                    '  carregaobjeto()

                End If


            ElseIf rbbuscaNome.Checked = True Then

                '    DataGridView1.DataSource = obj.lista("nome_cliente like '%" & txtbusca.Text & "%'")
                '  carregaobjeto()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FormCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco
        DataGridView1.DataSource = obj.executasql(("select *from cliente"))
        '  DataGridView1.DataSource = obj.executasql(("Select fngetcliente()"))
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

    End Sub
End Class