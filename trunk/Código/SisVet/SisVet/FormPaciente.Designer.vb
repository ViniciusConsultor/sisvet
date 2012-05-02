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
        Me.txtcadastro = New System.Windows.Forms.TextBox()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.txtpelagem = New System.Windows.Forms.TextBox()
        Me.txtrghv = New System.Windows.Forms.TextBox()
        Me.txtraça = New System.Windows.Forms.TextBox()
        Me.txtespecie = New System.Windows.Forms.TextBox()
        Me.txtdata_nascim_paciente = New System.Windows.Forms.TextBox()
        Me.txtnomepaciente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 367)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 40
        '
        'txtcadastro
        '
        Me.txtcadastro.Location = New System.Drawing.Point(133, 267)
        Me.txtcadastro.Name = "txtcadastro"
        Me.txtcadastro.Size = New System.Drawing.Size(100, 20)
        Me.txtcadastro.TabIndex = 36
        '
        'txtsexo
        '
        Me.txtsexo.Location = New System.Drawing.Point(133, 234)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(100, 20)
        Me.txtsexo.TabIndex = 35
        '
        'txtpelagem
        '
        Me.txtpelagem.Location = New System.Drawing.Point(133, 200)
        Me.txtpelagem.Name = "txtpelagem"
        Me.txtpelagem.Size = New System.Drawing.Size(100, 20)
        Me.txtpelagem.TabIndex = 34
        '
        'txtrghv
        '
        Me.txtrghv.Location = New System.Drawing.Point(133, 164)
        Me.txtrghv.Name = "txtrghv"
        Me.txtrghv.Size = New System.Drawing.Size(100, 20)
        Me.txtrghv.TabIndex = 33
        '
        'txtraça
        '
        Me.txtraça.Location = New System.Drawing.Point(133, 130)
        Me.txtraça.Name = "txtraça"
        Me.txtraça.Size = New System.Drawing.Size(100, 20)
        Me.txtraça.TabIndex = 32
        '
        'txtespecie
        '
        Me.txtespecie.Location = New System.Drawing.Point(133, 99)
        Me.txtespecie.Name = "txtespecie"
        Me.txtespecie.Size = New System.Drawing.Size(246, 20)
        Me.txtespecie.TabIndex = 31
        '
        'txtdata_nascim_paciente
        '
        Me.txtdata_nascim_paciente.Location = New System.Drawing.Point(133, 69)
        Me.txtdata_nascim_paciente.Name = "txtdata_nascim_paciente"
        Me.txtdata_nascim_paciente.Size = New System.Drawing.Size(100, 20)
        Me.txtdata_nascim_paciente.TabIndex = 30
        '
        'txtnomepaciente
        '
        Me.txtnomepaciente.Location = New System.Drawing.Point(133, 38)
        Me.txtnomepaciente.Name = "txtnomepaciente"
        Me.txtnomepaciente.Size = New System.Drawing.Size(246, 20)
        Me.txtnomepaciente.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cadastro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Pelagem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "RGHV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Raça:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Especie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nome do Paciente:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(133, 6)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 105
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Código:"
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(263, 292)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 102
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(143, 292)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 101
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(388, 292)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 103
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 529)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcadastro)
        Me.Controls.Add(Me.txtsexo)
        Me.Controls.Add(Me.txtpelagem)
        Me.Controls.Add(Me.txtrghv)
        Me.Controls.Add(Me.txtraça)
        Me.Controls.Add(Me.txtespecie)
        Me.Controls.Add(Me.txtdata_nascim_paciente)
        Me.Controls.Add(Me.txtnomepaciente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPaciente"
        Me.Text = "SisVet - Cadastro de Pacientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcadastro As System.Windows.Forms.TextBox
    Friend WithEvents txtsexo As System.Windows.Forms.TextBox
    Friend WithEvents txtpelagem As System.Windows.Forms.TextBox
    Friend WithEvents txtrghv As System.Windows.Forms.TextBox
    Friend WithEvents txtraça As System.Windows.Forms.TextBox
    Friend WithEvents txtespecie As System.Windows.Forms.TextBox
    Friend WithEvents txtdata_nascim_paciente As System.Windows.Forms.TextBox
    Friend WithEvents txtnomepaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
End Class
