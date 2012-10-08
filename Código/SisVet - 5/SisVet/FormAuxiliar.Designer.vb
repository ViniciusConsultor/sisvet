<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuxiliar
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
        Me.txtcodAux = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcpfAux = New System.Windows.Forms.TextBox()
        Me.txtrgAux = New System.Windows.Forms.TextBox()
        Me.txtnomeAux = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btexcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.btnovo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodAux
        '
        Me.txtcodAux.Location = New System.Drawing.Point(133, 26)
        Me.txtcodAux.Name = "txtcodAux"
        Me.txtcodAux.Size = New System.Drawing.Size(97, 20)
        Me.txtcodAux.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Código:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'txtcpfAux
        '
        Me.txtcpfAux.Location = New System.Drawing.Point(133, 117)
        Me.txtcpfAux.Name = "txtcpfAux"
        Me.txtcpfAux.Size = New System.Drawing.Size(128, 20)
        Me.txtcpfAux.TabIndex = 3
        '
        'txtrgAux
        '
        Me.txtrgAux.Location = New System.Drawing.Point(133, 87)
        Me.txtrgAux.Name = "txtrgAux"
        Me.txtrgAux.Size = New System.Drawing.Size(128, 20)
        Me.txtrgAux.TabIndex = 2
        '
        'txtnomeAux
        '
        Me.txtnomeAux.Location = New System.Drawing.Point(133, 56)
        Me.txtnomeAux.Name = "txtnomeAux"
        Me.txtnomeAux.Size = New System.Drawing.Size(293, 20)
        Me.txtnomeAux.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "RG:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nome:"
        '
        'btexcluir
        '
        Me.btexcluir.Image = Global.SisVet.My.Resources.Resources.Button_Delete_icon32
        Me.btexcluir.Location = New System.Drawing.Point(272, 164)
        Me.btexcluir.Name = "btexcluir"
        Me.btexcluir.Size = New System.Drawing.Size(75, 66)
        Me.btexcluir.TabIndex = 5
        Me.btexcluir.Text = "Excluir"
        Me.btexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btexcluir.UseVisualStyleBackColor = True
        '
        'btsalvar
        '
        Me.btsalvar.Image = Global.SisVet.My.Resources.Resources.informatica_3632_disquete13
        Me.btsalvar.Location = New System.Drawing.Point(152, 164)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(75, 66)
        Me.btsalvar.TabIndex = 4
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsalvar.UseVisualStyleBackColor = True
        '
        'btnovo
        '
        Me.btnovo.Image = Global.SisVet.My.Resources.Resources.Button_Add_icon32
        Me.btnovo.Location = New System.Drawing.Point(397, 164)
        Me.btnovo.Name = "btnovo"
        Me.btnovo.Size = New System.Drawing.Size(75, 66)
        Me.btnovo.TabIndex = 6
        Me.btnovo.Text = "Novo"
        Me.btnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnovo.UseVisualStyleBackColor = True
        '
        'FormAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 406)
        Me.Controls.Add(Me.btexcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnovo)
        Me.Controls.Add(Me.txtcodAux)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcpfAux)
        Me.Controls.Add(Me.txtrgAux)
        Me.Controls.Add(Me.txtnomeAux)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAuxiliar"
        Me.Text = "SisVet - Cadastro de Auxiliar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcodAux As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcpfAux As System.Windows.Forms.TextBox
    Friend WithEvents txtrgAux As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeAux As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btexcluir As System.Windows.Forms.Button
    Friend WithEvents btsalvar As System.Windows.Forms.Button
    Friend WithEvents btnovo As System.Windows.Forms.Button
End Class
