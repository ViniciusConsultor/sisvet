<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExameLaboratoriais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExameLaboratoriais))
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        Me.btbusca = New System.Windows.Forms.Button()
        Me.ComboTratamento = New System.Windows.Forms.ComboBox()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboExame = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtresponsavel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Controls.Add(Me.txtbusca)
        Me.GroupBox10.Controls.Add(Me.btbusca)
        Me.GroupBox10.Location = New System.Drawing.Point(183, 300)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(467, 40)
        Me.GroupBox10.TabIndex = 90
        Me.GroupBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Busca Por Nome:"
        '
        'txtbusca
        '
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusca.Location = New System.Drawing.Point(176, 13)
        Me.txtbusca.MaxLength = 7
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(168, 22)
        Me.txtbusca.TabIndex = 3
        '
        'btbusca
        '
        Me.btbusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbusca.Location = New System.Drawing.Point(361, 12)
        Me.btbusca.Name = "btbusca"
        Me.btbusca.Size = New System.Drawing.Size(95, 23)
        Me.btbusca.TabIndex = 0
        Me.btbusca.Text = "Buscar"
        Me.btbusca.UseVisualStyleBackColor = True
        '
        'ComboTratamento
        '
        Me.ComboTratamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTratamento.FormattingEnabled = True
        Me.ComboTratamento.Location = New System.Drawing.Point(138, 73)
        Me.ComboTratamento.Name = "ComboTratamento"
        Me.ComboTratamento.Size = New System.Drawing.Size(180, 24)
        Me.ComboTratamento.TabIndex = 86
        '
        'btexcluir
        '
        Me.btexcluir.BackgroundImage = CType(resources.GetObject("btexcluir.BackgroundImage"), System.Drawing.Image)
        Me.btexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(385, 215)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 88
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.BackgroundImage = CType(resources.GetObject("btsalvar.BackgroundImage"), System.Drawing.Image)
        Me.btsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(265, 215)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 87
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.BackgroundImage = CType(resources.GetObject("btnovo.BackgroundImage"), System.Drawing.Image)
        Me.btnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(510, 215)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 89
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 356)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(810, 150)
        Me.DataGridView1.TabIndex = 91
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(138, 36)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtcodigo.TabIndex = 84
        Me.txtcodigo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Tratamento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Código:"
        '
        'ComboExame
        '
        Me.ComboExame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboExame.FormattingEnabled = True
        Me.ComboExame.Location = New System.Drawing.Point(138, 111)
        Me.ComboExame.Name = "ComboExame"
        Me.ComboExame.Size = New System.Drawing.Size(180, 24)
        Me.ComboExame.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Exame:"
        '
        'txtdescricao
        '
        Me.txtdescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescricao.Location = New System.Drawing.Point(550, 74)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(236, 22)
        Me.txtdescricao.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(446, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Descrição:"
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.Location = New System.Drawing.Point(550, 110)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(110, 22)
        Me.txtvalor.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Valor:"
        '
        'txtresponsavel
        '
        Me.txtresponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresponsavel.Location = New System.Drawing.Point(550, 37)
        Me.txtresponsavel.Name = "txtresponsavel"
        Me.txtresponsavel.Size = New System.Drawing.Size(236, 22)
        Me.txtresponsavel.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Responsalvel:"
        '
        'FormExameLaboratoriais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 512)
        Me.Controls.Add(Me.txtresponsavel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboExame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ComboTratamento)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormExameLaboratoriais"
        Me.Text = "Exames Laboratoriais"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
    Friend WithEvents btbusca As System.Windows.Forms.Button
    Friend WithEvents ComboTratamento As System.Windows.Forms.ComboBox
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboExame As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtresponsavel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
