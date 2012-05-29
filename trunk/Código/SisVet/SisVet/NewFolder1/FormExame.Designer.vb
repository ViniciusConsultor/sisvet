<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExame
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
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboLaboratorio = New System.Windows.Forms.ComboBox()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.btbusca = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(134, 65)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(269, 20)
        Me.txtdescricao.TabIndex = 1
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(134, 31)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 0
        Me.txtcodigo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Laboratório:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Descrição:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Código:"
        '
        'ComboLaboratorio
        '
        Me.ComboLaboratorio.FormattingEnabled = True
        Me.ComboLaboratorio.Location = New System.Drawing.Point(134, 97)
        Me.ComboLaboratorio.Name = "ComboLaboratorio"
        Me.ComboLaboratorio.Size = New System.Drawing.Size(269, 21)
        Me.ComboLaboratorio.TabIndex = 2
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(274, 138)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 4
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(154, 138)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 3
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(399, 138)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 5
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
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
        Me.GroupBox10.Location = New System.Drawing.Point(74, 226)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(467, 40)
        Me.GroupBox10.TabIndex = 84
        Me.GroupBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Busca Por Nome:"
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
        'FormExame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 431)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ComboLaboratorio)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormExame"
        Me.Text = "SisVet - Cadastro de Exame"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtdescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboLaboratorio As System.Windows.Forms.ComboBox
    Friend WithEvents btbusca As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
