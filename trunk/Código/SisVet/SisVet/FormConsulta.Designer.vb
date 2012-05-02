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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtagendado = New System.Windows.Forms.TextBox()
        Me.ComboMedico = New System.Windows.Forms.ComboBox()
        Me.ComboMedicoAuxiliar = New System.Windows.Forms.ComboBox()
        Me.txtdata = New System.Windows.Forms.MaskedTextBox()
        Me.txthora = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodConsulta = New System.Windows.Forms.TextBox()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.ComboTipoConsulta = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Médico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data Consulta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora consulta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Medico Auxiliar:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Agendado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de Consulta:"
        '
        'txtagendado
        '
        Me.txtagendado.Location = New System.Drawing.Point(130, 185)
        Me.txtagendado.Name = "txtagendado"
        Me.txtagendado.Size = New System.Drawing.Size(65, 20)
        Me.txtagendado.TabIndex = 8
        '
        'ComboMedico
        '
        Me.ComboMedico.FormattingEnabled = True
        Me.ComboMedico.Location = New System.Drawing.Point(130, 50)
        Me.ComboMedico.Name = "ComboMedico"
        Me.ComboMedico.Size = New System.Drawing.Size(121, 21)
        Me.ComboMedico.TabIndex = 10
        '
        'ComboMedicoAuxiliar
        '
        Me.ComboMedicoAuxiliar.FormattingEnabled = True
        Me.ComboMedicoAuxiliar.Location = New System.Drawing.Point(130, 148)
        Me.ComboMedicoAuxiliar.Name = "ComboMedicoAuxiliar"
        Me.ComboMedicoAuxiliar.Size = New System.Drawing.Size(121, 21)
        Me.ComboMedicoAuxiliar.TabIndex = 11
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(130, 84)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(100, 20)
        Me.txtdata.TabIndex = 12
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(130, 116)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(100, 20)
        Me.txthora.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 327)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 44
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
        Me.txtcodConsulta.Location = New System.Drawing.Point(130, 20)
        Me.txtcodConsulta.Name = "txtcodConsulta"
        Me.txtcodConsulta.Size = New System.Drawing.Size(65, 20)
        Me.txtcodConsulta.TabIndex = 7
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(270, 250)
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
        Me.btsalvar.Location = New System.Drawing.Point(150, 250)
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
        Me.btnovo.Location = New System.Drawing.Point(395, 250)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 103
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'ComboTipoConsulta
        '
        Me.ComboTipoConsulta.FormattingEnabled = True
        Me.ComboTipoConsulta.Location = New System.Drawing.Point(130, 220)
        Me.ComboTipoConsulta.Name = "ComboTipoConsulta"
        Me.ComboTipoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipoConsulta.TabIndex = 104
        '
        'FormConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 491)
        Me.Controls.Add(Me.ComboTipoConsulta)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.txtdata)
        Me.Controls.Add(Me.ComboMedicoAuxiliar)
        Me.Controls.Add(Me.ComboMedico)
        Me.Controls.Add(Me.txtagendado)
        Me.Controls.Add(Me.txtcodConsulta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConsulta"
        Me.Text = "SysVet - Cadastro de Consultas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtagendado As System.Windows.Forms.TextBox
    Friend WithEvents ComboMedico As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMedicoAuxiliar As System.Windows.Forms.ComboBox
    Friend WithEvents txtdata As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txthora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodConsulta As System.Windows.Forms.TextBox
    Friend WithEvents ComboTipoConsulta As System.Windows.Forms.ComboBox
End Class
