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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
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
        Me.btnovo = New System.Windows.Forms.Button()
        Me.btbusca = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        Me.masckDatanascimento = New System.Windows.Forms.TextBox()
        Me.txtcpf_cliente = New System.Windows.Forms.TextBox()
        Me.txttelefone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcodcli
        '
        Me.txtcodcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcli.Location = New System.Drawing.Point(125, 16)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(59, 22)
        Me.txtcodcli.TabIndex = 0
        Me.txtcodcli.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Código:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 280)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(849, 210)
        Me.DataGridView1.TabIndex = 13
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmunicipio.Location = New System.Drawing.Point(125, 152)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(342, 22)
        Me.txtmunicipio.TabIndex = 8
        '
        'txtorgaoExpeditor
        '
        Me.txtorgaoExpeditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorgaoExpeditor.Location = New System.Drawing.Point(569, 19)
        Me.txtorgaoExpeditor.Name = "txtorgaoExpeditor"
        Me.txtorgaoExpeditor.Size = New System.Drawing.Size(94, 22)
        Me.txtorgaoExpeditor.TabIndex = 2
        '
        'txtrg
        '
        Me.txtrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrg.Location = New System.Drawing.Point(280, 17)
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(152, 22)
        Me.txtrg.TabIndex = 1
        '
        'txtendereco
        '
        Me.txtendereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendereco.Location = New System.Drawing.Point(125, 107)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(246, 22)
        Me.txtendereco.TabIndex = 6
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(125, 46)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(266, 22)
        Me.txtnome.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Município:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(412, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "CPF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Orgão Espeditor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "RG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(402, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Telefone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Endereço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Data Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Nome:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.Button1.Location = New System.Drawing.Point(144, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Excluir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.Button2.Location = New System.Drawing.Point(24, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Salvar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.BackgroundImage = CType(resources.GetObject("btnovo.BackgroundImage"), System.Drawing.Image)
        Me.btnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(269, 197)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 11
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'btbusca
        '
        Me.btbusca.BackgroundImage = CType(resources.GetObject("btbusca.BackgroundImage"), System.Drawing.Image)
        Me.btbusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btbusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbusca.Location = New System.Drawing.Point(361, 12)
        Me.btbusca.Name = "btbusca"
        Me.btbusca.Size = New System.Drawing.Size(95, 23)
        Me.btbusca.TabIndex = 0
        Me.btbusca.Text = "Buscar"
        Me.btbusca.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Controls.Add(Me.txtbusca)
        Me.GroupBox10.Controls.Add(Me.btbusca)
        Me.GroupBox10.Location = New System.Drawing.Point(405, 221)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(467, 40)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Busca Por Nome:"
        '
        'txtbusca
        '
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusca.Location = New System.Drawing.Point(160, 12)
        Me.txtbusca.MaxLength = 50
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(182, 22)
        Me.txtbusca.TabIndex = 12
        '
        'masckDatanascimento
        '
        Me.masckDatanascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masckDatanascimento.Location = New System.Drawing.Point(161, 78)
        Me.masckDatanascimento.Name = "masckDatanascimento"
        Me.masckDatanascimento.Size = New System.Drawing.Size(126, 22)
        Me.masckDatanascimento.TabIndex = 5
        '
        'txtcpf_cliente
        '
        Me.txtcpf_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpf_cliente.Location = New System.Drawing.Point(463, 50)
        Me.txtcpf_cliente.Name = "txtcpf_cliente"
        Me.txtcpf_cliente.Size = New System.Drawing.Size(138, 22)
        Me.txtcpf_cliente.TabIndex = 4
        '
        'txttelefone
        '
        Me.txttelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefone.Location = New System.Drawing.Point(479, 108)
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(100, 22)
        Me.txttelefone.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(607, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "( xxx . xxx .xxx - xx )"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(585, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "[ (xx)xxxx-xxxx ]"
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(894, 507)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttelefone)
        Me.Controls.Add(Me.txtcpf_cliente)
        Me.Controls.Add(Me.masckDatanascimento)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.txtcodcli)
        Me.Controls.Add(Me.Label9)
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
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SisVet - Cadastro de Clientes:"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents btbusca As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents masckDatanascimento As System.Windows.Forms.TextBox
    Friend WithEvents txtcpf_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txttelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
