<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtmunicipio = New System.Windows.Forms.TextBox()
        Me.txtorgaoExpeditor = New System.Windows.Forms.TextBox()
        Me.txtrg = New System.Windows.Forms.TextBox()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btpaciente = New System.Windows.Forms.Button()
        Me.masckDatanascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txttelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtcpf_cliente = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodcli
        '
        Me.txtcodcli.Location = New System.Drawing.Point(162, 16)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(59, 20)
        Me.txtcodcli.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Código:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 372)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 74
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Location = New System.Drawing.Point(162, 275)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(246, 20)
        Me.txtmunicipio.TabIndex = 73
        '
        'txtorgaoExpeditor
        '
        Me.txtorgaoExpeditor.Location = New System.Drawing.Point(162, 208)
        Me.txtorgaoExpeditor.Name = "txtorgaoExpeditor"
        Me.txtorgaoExpeditor.Size = New System.Drawing.Size(59, 20)
        Me.txtorgaoExpeditor.TabIndex = 71
        '
        'txtrg
        '
        Me.txtrg.Location = New System.Drawing.Point(162, 172)
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(100, 20)
        Me.txtrg.TabIndex = 70
        '
        'txtendereco
        '
        Me.txtendereco.Location = New System.Drawing.Point(162, 107)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(246, 20)
        Me.txtendereco.TabIndex = 68
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(162, 46)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(246, 20)
        Me.txtnome.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Município:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "CPF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Orgão Espeditor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "RG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Telefone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Endereço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Data Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Nome:"
        '
        'Button1
        '
        Me.Button1.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.Button1.Location = New System.Drawing.Point(302, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Excluir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.Button2.Location = New System.Drawing.Point(182, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Salvar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.Button3.Location = New System.Drawing.Point(427, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 66)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Novo"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btpaciente
        '
        Me.btpaciente.Image = Global.SisVet.My.Resources.Resources.cattle
        Me.btpaciente.Location = New System.Drawing.Point(516, 145)
        Me.btpaciente.Name = "btpaciente"
        Me.btpaciente.Size = New System.Drawing.Size(75, 77)
        Me.btpaciente.TabIndex = 75
        Me.btpaciente.Text = "Paciente"
        Me.btpaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btpaciente.UseVisualStyleBackColor = True
        '
        'masckDatanascimento
        '
        Me.masckDatanascimento.Location = New System.Drawing.Point(162, 81)
        Me.masckDatanascimento.Mask = "00/00/0000"
        Me.masckDatanascimento.Name = "masckDatanascimento"
        Me.masckDatanascimento.Size = New System.Drawing.Size(68, 20)
        Me.masckDatanascimento.TabIndex = 81
        Me.masckDatanascimento.ValidatingType = GetType(Date)
        '
        'txttelefone
        '
        Me.txttelefone.Location = New System.Drawing.Point(162, 138)
        Me.txttelefone.Mask = "(00)0000-0000"
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(75, 20)
        Me.txttelefone.TabIndex = 82
        '
        'txtcpf_cliente
        '
        Me.txtcpf_cliente.Location = New System.Drawing.Point(162, 242)
        Me.txtcpf_cliente.Mask = "000 000 000-00"
        Me.txtcpf_cliente.Name = "txtcpf_cliente"
        Me.txtcpf_cliente.Size = New System.Drawing.Size(84, 20)
        Me.txtcpf_cliente.TabIndex = 83
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 538)
        Me.Controls.Add(Me.txtcpf_cliente)
        Me.Controls.Add(Me.txttelefone)
        Me.Controls.Add(Me.masckDatanascimento)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtcodcli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btpaciente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtmunicipio)
        Me.Controls.Add(Me.txtorgaoExpeditor)
        Me.Controls.Add(Me.txtrg)
        Me.Controls.Add(Me.txtendereco)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCliente"
        Me.Text = "SisVet - Cadastro de Clientes:"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btpaciente As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmunicipio As System.Windows.Forms.TextBox
    Friend WithEvents txtorgaoExpeditor As System.Windows.Forms.TextBox
    Friend WithEvents txtrg As System.Windows.Forms.TextBox
    Friend WithEvents txtendereco As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents masckDatanascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcpf_cliente As System.Windows.Forms.MaskedTextBox
End Class
