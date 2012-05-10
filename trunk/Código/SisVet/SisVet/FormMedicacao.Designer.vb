<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedicacao
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
        Me.ComboResponsavel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtquantidade = New System.Windows.Forms.TextBox()
        Me.Comboremedio = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboResponsavel
        '
        Me.ComboResponsavel.FormattingEnabled = True
        Me.ComboResponsavel.Location = New System.Drawing.Point(152, 141)
        Me.ComboResponsavel.Name = "ComboResponsavel"
        Me.ComboResponsavel.Size = New System.Drawing.Size(241, 21)
        Me.ComboResponsavel.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Responsável:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Quantidade Aplicada:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 394)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 109
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(152, 32)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Remédio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Código:"
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(303, 293)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 111
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(183, 293)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 110
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(428, 293)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 112
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(152, 177)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Valor:"
        '
        'txtquantidade
        '
        Me.txtquantidade.Location = New System.Drawing.Point(152, 103)
        Me.txtquantidade.Name = "txtquantidade"
        Me.txtquantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtquantidade.TabIndex = 119
        '
        'Comboremedio
        '
        Me.Comboremedio.FormattingEnabled = True
        Me.Comboremedio.Location = New System.Drawing.Point(152, 70)
        Me.Comboremedio.Name = "Comboremedio"
        Me.Comboremedio.Size = New System.Drawing.Size(241, 21)
        Me.Comboremedio.TabIndex = 120
        '
        'FormMedicacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 576)
        Me.Controls.Add(Me.Comboremedio)
        Me.Controls.Add(Me.txtquantidade)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboResponsavel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormMedicacao"
        Me.Text = "SisVet - Controle de Medicacao"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboResponsavel As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtquantidade As System.Windows.Forms.TextBox
    Friend WithEvents Comboremedio As System.Windows.Forms.ComboBox
End Class
