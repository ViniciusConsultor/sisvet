<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsulta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboMedico = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodConsulta = New System.Windows.Forms.TextBox()
        Me.ComboTipoConsulta = New System.Windows.Forms.ComboBox()
        Me.radioNao = New System.Windows.Forms.RadioButton()
        Me.radioSim = New System.Windows.Forms.RadioButton()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.comboPaciente = New System.Windows.Forms.ComboBox()
        Me.txtprontuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btbusca = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.txtdata = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Médico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data Consulta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora consulta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Agendado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de Consulta:"
        '
        'ComboMedico
        '
        Me.ComboMedico.FormattingEnabled = True
        Me.ComboMedico.Location = New System.Drawing.Point(395, 19)
        Me.ComboMedico.Name = "ComboMedico"
        Me.ComboMedico.Size = New System.Drawing.Size(274, 21)
        Me.ComboMedico.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Consulta:"
        '
        'txtcodConsulta
        '
        Me.txtcodConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodConsulta.Location = New System.Drawing.Point(130, 20)
        Me.txtcodConsulta.Name = "txtcodConsulta"
        Me.txtcodConsulta.Size = New System.Drawing.Size(65, 20)
        Me.txtcodConsulta.TabIndex = 0
        Me.txtcodConsulta.Visible = False
        '
        'ComboTipoConsulta
        '
        Me.ComboTipoConsulta.FormattingEnabled = True
        Me.ComboTipoConsulta.Location = New System.Drawing.Point(395, 88)
        Me.ComboTipoConsulta.Name = "ComboTipoConsulta"
        Me.ComboTipoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipoConsulta.TabIndex = 7
        '
        'radioNao
        '
        Me.radioNao.AutoSize = True
        Me.radioNao.Location = New System.Drawing.Point(218, 91)
        Me.radioNao.Name = "radioNao"
        Me.radioNao.Size = New System.Drawing.Size(45, 17)
        Me.radioNao.TabIndex = 3
        Me.radioNao.TabStop = True
        Me.radioNao.Text = "Não"
        Me.radioNao.UseVisualStyleBackColor = True
        '
        'radioSim
        '
        Me.radioSim.AutoSize = True
        Me.radioSim.Location = New System.Drawing.Point(130, 91)
        Me.radioSim.Name = "radioSim"
        Me.radioSim.Size = New System.Drawing.Size(42, 17)
        Me.radioSim.TabIndex = 2
        Me.radioSim.TabStop = True
        Me.radioSim.Text = "Sim"
        Me.radioSim.UseVisualStyleBackColor = True
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(284, 311)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 10
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(164, 311)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 9
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(409, 311)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 11
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'comboPaciente
        '
        Me.comboPaciente.FormattingEnabled = True
        Me.comboPaciente.Location = New System.Drawing.Point(130, 130)
        Me.comboPaciente.Name = "comboPaciente"
        Me.comboPaciente.Size = New System.Drawing.Size(121, 21)
        Me.comboPaciente.TabIndex = 4
        '
        'txtprontuario
        '
        Me.txtprontuario.Location = New System.Drawing.Point(96, 174)
        Me.txtprontuario.Multiline = True
        Me.txtprontuario.Name = "txtprontuario"
        Me.txtprontuario.Size = New System.Drawing.Size(482, 111)
        Me.txtprontuario.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Paciente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Protuario:"
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
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Controls.Add(Me.txtbusca)
        Me.GroupBox10.Controls.Add(Me.btbusca)
        Me.GroupBox10.Location = New System.Drawing.Point(96, 397)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(467, 40)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Busca Por Nome:"
        '
        'txtbusca
        '
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusca.Location = New System.Drawing.Point(214, 12)
        Me.txtbusca.MaxLength = 20
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(125, 20)
        Me.txtbusca.TabIndex = 3
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(395, 57)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(58, 20)
        Me.txthora.TabIndex = 111
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(130, 57)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(100, 20)
        Me.txtdata.TabIndex = 112
        '
        'FormConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 605)
        Me.Controls.Add(Me.txtdata)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtprontuario)
        Me.Controls.Add(Me.comboPaciente)
        Me.Controls.Add(Me.radioNao)
        Me.Controls.Add(Me.radioSim)
        Me.Controls.Add(Me.ComboTipoConsulta)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboMedico)
        Me.Controls.Add(Me.txtcodConsulta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConsulta"
        Me.Text = "SisVet -  Cadastro de Consultas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboMedico As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodConsulta As System.Windows.Forms.TextBox
    Friend WithEvents ComboTipoConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents radioNao As System.Windows.Forms.RadioButton
    Friend WithEvents radioSim As System.Windows.Forms.RadioButton
    Friend WithEvents comboPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents txtprontuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btbusca As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txthora As System.Windows.Forms.TextBox
    Friend WithEvents txtdata As System.Windows.Forms.TextBox
End Class
