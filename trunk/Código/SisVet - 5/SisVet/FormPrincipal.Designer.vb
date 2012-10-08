<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoExameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoCirurgiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MédicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem1, Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem1, Me.ContasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem1
        '
        Me.ArquivoToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ArquivoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1})
        Me.ArquivoToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArquivoToolStripMenuItem1.Image = CType(resources.GetObject("ArquivoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ArquivoToolStripMenuItem1.Name = "ArquivoToolStripMenuItem1"
        Me.ArquivoToolStripMenuItem1.Size = New System.Drawing.Size(80, 36)
        Me.ArquivoToolStripMenuItem1.Text = "Home"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = CType(resources.GetObject("SairToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(107, 26)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.MedicoToolStripMenuItem, Me.PacienteToolStripMenuItem1, Me.LaboratórioToolStripMenuItem, Me.MedicamentoToolStripMenuItem, Me.TipoConsultaToolStripMenuItem, Me.TipoExameToolStripMenuItem, Me.TipoCirurgiaToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Image = CType(resources.GetObject("CadastroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(96, 36)
        Me.CadastroToolStripMenuItem.Text = "Registro"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Image = Global.SisVet.My.Resources.Resources.aesthetica_5022_users
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(175, 26)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5558_Head_physician_icon
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.MedicoToolStripMenuItem.Text = "Medico"
        '
        'PacienteToolStripMenuItem1
        '
        Me.PacienteToolStripMenuItem1.Image = Global.SisVet.My.Resources.Resources.cattle
        Me.PacienteToolStripMenuItem1.Name = "PacienteToolStripMenuItem1"
        Me.PacienteToolStripMenuItem1.Size = New System.Drawing.Size(175, 26)
        Me.PacienteToolStripMenuItem1.Text = "Paciente"
        '
        'LaboratórioToolStripMenuItem
        '
        Me.LaboratórioToolStripMenuItem.Image = CType(resources.GetObject("LaboratórioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaboratórioToolStripMenuItem.Name = "LaboratórioToolStripMenuItem"
        Me.LaboratórioToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.LaboratórioToolStripMenuItem.Text = "Laboratório"
        '
        'MedicamentoToolStripMenuItem
        '
        Me.MedicamentoToolStripMenuItem.Image = CType(resources.GetObject("MedicamentoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MedicamentoToolStripMenuItem.Name = "MedicamentoToolStripMenuItem"
        Me.MedicamentoToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.MedicamentoToolStripMenuItem.Text = "Medicamento"
        '
        'TipoConsultaToolStripMenuItem
        '
        Me.TipoConsultaToolStripMenuItem.Image = CType(resources.GetObject("TipoConsultaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoConsultaToolStripMenuItem.Name = "TipoConsultaToolStripMenuItem"
        Me.TipoConsultaToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.TipoConsultaToolStripMenuItem.Text = "Tipo consulta"
        '
        'TipoExameToolStripMenuItem
        '
        Me.TipoExameToolStripMenuItem.Name = "TipoExameToolStripMenuItem"
        Me.TipoExameToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.TipoExameToolStripMenuItem.Text = "Tipo exame"
        '
        'TipoCirurgiaToolStripMenuItem
        '
        Me.TipoCirurgiaToolStripMenuItem.Name = "TipoCirurgiaToolStripMenuItem"
        Me.TipoCirurgiaToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.TipoCirurgiaToolStripMenuItem.Text = "Tipo cirurgia"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.ConsultaToolStripMenuItem1.Image = CType(resources.GetObject("ConsultaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(128, 36)
        Me.ConsultaToolStripMenuItem1.Text = "Atendimento"
        '
        'MarcarToolStripMenuItem
        '
        Me.MarcarToolStripMenuItem.Image = CType(resources.GetObject("MarcarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MarcarToolStripMenuItem.Name = "MarcarToolStripMenuItem"
        Me.MarcarToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.MarcarToolStripMenuItem.Text = "Tratamento"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5549_Medical_invoice_information_icon
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.ConsultarToolStripMenuItem.Text = "Consulta"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuxiliarToolStripMenuItem1, Me.PagamentoToolStripMenuItem})
        Me.ContasToolStripMenuItem.Image = CType(resources.GetObject("ContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(86, 36)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'AuxiliarToolStripMenuItem1
        '
        Me.AuxiliarToolStripMenuItem1.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5549_Medical_invoice_information_icon
        Me.AuxiliarToolStripMenuItem1.Name = "AuxiliarToolStripMenuItem1"
        Me.AuxiliarToolStripMenuItem1.Size = New System.Drawing.Size(184, 26)
        Me.AuxiliarToolStripMenuItem1.Text = "Contas a pagar"
        '
        'PagamentoToolStripMenuItem
        '
        Me.PagamentoToolStripMenuItem.Image = CType(resources.GetObject("PagamentoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PagamentoToolStripMenuItem.Name = "PagamentoToolStripMenuItem"
        Me.PagamentoToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.PagamentoToolStripMenuItem.Text = "Pagamento"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(89, 25)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'MédicoToolStripMenuItem
        '
        Me.MédicoToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5558_Head_physician_icon
        Me.MédicoToolStripMenuItem.Name = "MédicoToolStripMenuItem"
        Me.MédicoToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.MédicoToolStripMenuItem.Text = "Médico"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.aesthetica_5022_users
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'AuxiliarToolStripMenuItem
        '
        Me.AuxiliarToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5552_surgeon_icon
        Me.AuxiliarToolStripMenuItem.Name = "AuxiliarToolStripMenuItem"
        Me.AuxiliarToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AuxiliarToolStripMenuItem.Text = "Auxiliar"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Image = Global.SisVet.My.Resources.Resources.Medicina_e_Saude_5549_Medical_invoice_information_icon
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel1.Text = "Sis Vet"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 512)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.Text = "SisVet -Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MédicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuxiliarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArquivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaboratórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuxiliarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TipoExameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCirurgiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
