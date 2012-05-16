<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaciente
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtpelagem = New System.Windows.Forms.TextBox()
        Me.txtrghv = New System.Windows.Forms.TextBox()
        Me.txtraça = New System.Windows.Forms.TextBox()
        Me.txtespecie = New System.Windows.Forms.TextBox()
        Me.txtnomepaciente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioNao = New System.Windows.Forms.RadioButton()
        Me.RadioSim = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioFeminino = New System.Windows.Forms.RadioButton()
        Me.Radiomasculino = New System.Windows.Forms.RadioButton()
        Me.masckDatanascimento = New System.Windows.Forms.MaskedTextBox()
        Me.btbusca = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rbbuscaNome = New System.Windows.Forms.RadioButton()
        Me.rbid = New System.Windows.Forms.RadioButton()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 381)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 136)
        Me.DataGridView1.TabIndex = 13
        '
        'txtpelagem
        '
        Me.txtpelagem.Location = New System.Drawing.Point(471, 91)
        Me.txtpelagem.Name = "txtpelagem"
        Me.txtpelagem.Size = New System.Drawing.Size(147, 20)
        Me.txtpelagem.TabIndex = 6
        '
        'txtrghv
        '
        Me.txtrghv.Location = New System.Drawing.Point(471, 55)
        Me.txtrghv.Name = "txtrghv"
        Me.txtrghv.Size = New System.Drawing.Size(147, 20)
        Me.txtrghv.TabIndex = 5
        '
        'txtraça
        '
        Me.txtraça.Location = New System.Drawing.Point(471, 128)
        Me.txtraça.Name = "txtraça"
        Me.txtraça.Size = New System.Drawing.Size(133, 20)
        Me.txtraça.TabIndex = 7
        '
        'txtespecie
        '
        Me.txtespecie.Location = New System.Drawing.Point(127, 121)
        Me.txtespecie.Name = "txtespecie"
        Me.txtespecie.Size = New System.Drawing.Size(133, 20)
        Me.txtespecie.TabIndex = 3
        '
        'txtnomepaciente
        '
        Me.txtnomepaciente.Location = New System.Drawing.Point(127, 60)
        Me.txtnomepaciente.Name = "txtnomepaciente"
        Me.txtnomepaciente.Size = New System.Drawing.Size(246, 20)
        Me.txtnomepaciente.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Pelagem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "RGHV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Raça:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Especie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nome do Paciente:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(127, 28)
        Me.txtcodigo.MaxLength = 32
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 0
        Me.txtcodigo.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Código:"
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(262, 255)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 11
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(142, 255)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 10
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(387, 255)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 12
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(246, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Nome do Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioNao)
        Me.GroupBox1.Controls.Add(Me.RadioSim)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 45)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Castrado?"
        '
        'RadioNao
        '
        Me.RadioNao.AutoSize = True
        Me.RadioNao.Location = New System.Drawing.Point(103, 19)
        Me.RadioNao.Name = "RadioNao"
        Me.RadioNao.Size = New System.Drawing.Size(45, 17)
        Me.RadioNao.TabIndex = 1
        Me.RadioNao.TabStop = True
        Me.RadioNao.Text = "Não"
        Me.RadioNao.UseVisualStyleBackColor = True
        '
        'RadioSim
        '
        Me.RadioSim.AutoSize = True
        Me.RadioSim.Location = New System.Drawing.Point(7, 22)
        Me.RadioSim.Name = "RadioSim"
        Me.RadioSim.Size = New System.Drawing.Size(42, 17)
        Me.RadioSim.TabIndex = 0
        Me.RadioSim.TabStop = True
        Me.RadioSim.Text = "Sim"
        Me.RadioSim.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioFeminino)
        Me.GroupBox2.Controls.Add(Me.Radiomasculino)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo:"
        '
        'RadioFeminino
        '
        Me.RadioFeminino.AutoSize = True
        Me.RadioFeminino.Location = New System.Drawing.Point(102, 19)
        Me.RadioFeminino.Name = "RadioFeminino"
        Me.RadioFeminino.Size = New System.Drawing.Size(67, 17)
        Me.RadioFeminino.TabIndex = 1
        Me.RadioFeminino.TabStop = True
        Me.RadioFeminino.Text = "Feminino"
        Me.RadioFeminino.UseVisualStyleBackColor = True
        '
        'Radiomasculino
        '
        Me.Radiomasculino.AutoSize = True
        Me.Radiomasculino.Location = New System.Drawing.Point(6, 19)
        Me.Radiomasculino.Name = "Radiomasculino"
        Me.Radiomasculino.Size = New System.Drawing.Size(73, 17)
        Me.Radiomasculino.TabIndex = 0
        Me.Radiomasculino.TabStop = True
        Me.Radiomasculino.Text = "Masculino"
        Me.Radiomasculino.UseVisualStyleBackColor = True
        '
        'masckDatanascimento
        '
        Me.masckDatanascimento.Location = New System.Drawing.Point(127, 91)
        Me.masckDatanascimento.Mask = "00/00/0000"
        Me.masckDatanascimento.Name = "masckDatanascimento"
        Me.masckDatanascimento.Size = New System.Drawing.Size(68, 20)
        Me.masckDatanascimento.TabIndex = 2
        Me.masckDatanascimento.ValidatingType = GetType(Date)
        '
        'btbusca
        '
        Me.btbusca.Location = New System.Drawing.Point(361, 12)
        Me.btbusca.Name = "btbusca"
        Me.btbusca.Size = New System.Drawing.Size(95, 23)
        Me.btbusca.TabIndex = 0
        Me.btbusca.Text = "Buscar"
        Me.btbusca.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.rbbuscaNome)
        Me.GroupBox10.Controls.Add(Me.rbid)
        Me.GroupBox10.Controls.Add(Me.txtbusca)
        Me.GroupBox10.Controls.Add(Me.btbusca)
        Me.GroupBox10.Location = New System.Drawing.Point(83, 335)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(467, 40)
        Me.GroupBox10.TabIndex = 108
        Me.GroupBox10.TabStop = False
        '
        'rbbuscaNome
        '
        Me.rbbuscaNome.AutoSize = True
        Me.rbbuscaNome.Location = New System.Drawing.Point(104, 15)
        Me.rbbuscaNome.Name = "rbbuscaNome"
        Me.rbbuscaNome.Size = New System.Drawing.Size(104, 17)
        Me.rbbuscaNome.TabIndex = 2
        Me.rbbuscaNome.TabStop = True
        Me.rbbuscaNome.Text = "Busca por Nome"
        Me.rbbuscaNome.UseVisualStyleBackColor = True
        '
        'rbid
        '
        Me.rbid.AutoSize = True
        Me.rbid.Location = New System.Drawing.Point(11, 15)
        Me.rbid.Name = "rbid"
        Me.rbid.Size = New System.Drawing.Size(87, 17)
        Me.rbid.TabIndex = 1
        Me.rbid.TabStop = True
        Me.rbid.Text = "Busca por ID"
        Me.rbid.UseVisualStyleBackColor = True
        '
        'txtbusca
        '
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusca.Location = New System.Drawing.Point(214, 12)
        Me.txtbusca.MaxLength = 7
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(125, 20)
        Me.txtbusca.TabIndex = 3
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 529)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.masckDatanascimento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtpelagem)
        Me.Controls.Add(Me.txtrghv)
        Me.Controls.Add(Me.txtraça)
        Me.Controls.Add(Me.txtespecie)
        Me.Controls.Add(Me.txtnomepaciente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPaciente"
        Me.Text = "SisVet - Cadastro de Pacientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtpelagem As System.Windows.Forms.TextBox
    Friend WithEvents txtrghv As System.Windows.Forms.TextBox
    Friend WithEvents txtraça As System.Windows.Forms.TextBox
    Friend WithEvents txtespecie As System.Windows.Forms.TextBox
    Friend WithEvents txtnomepaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioNao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSim As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents Radiomasculino As System.Windows.Forms.RadioButton
    Friend WithEvents masckDatanascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btbusca As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rbbuscaNome As System.Windows.Forms.RadioButton
    Friend WithEvents rbid As System.Windows.Forms.RadioButton
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
End Class
