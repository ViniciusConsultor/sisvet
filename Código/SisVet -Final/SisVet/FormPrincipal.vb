﻿Public Class FormPrincipal

    Private Sub ClienteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        FormCliente.MdiParent = Me
        FormCliente.Show()

    End Sub

    Private Sub MedicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MedicoToolStripMenuItem.Click
        FormMedico.MdiParent = Me
        FormMedico.Show()

    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        End

    End Sub

    Private Sub AuxiliarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        FormContasApagar.MdiParent = Me
        FormContasApagar.Show()

    End Sub

    Private Sub PacienteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PacienteToolStripMenuItem1.Click
        FormPaciente.MdiParent = Me
        FormPaciente.Show()

    End Sub

    Private Sub LaboratórioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaboratórioToolStripMenuItem.Click
        FormLaboratorio.MdiParent = Me
        FormLaboratorio.Show()

    End Sub

    Private Sub MedicamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MedicamentoToolStripMenuItem.Click
        FormMedicamento.MdiParent = Me
        FormMedicamento.Show()

    End Sub

    Private Sub MarcarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MarcarToolStripMenuItem.Click
        FormTratamento.MdiParent = Me
        FormTratamento.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        FormConsulta.MdiParent = Me
        FormConsulta.Show()

    End Sub

    Private Sub ExameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormExameLaboratorial.MdiParent = Me
        FormExameLaboratorial.Show()


    End Sub

    Private Sub CirurgiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormCirurgiaInternacao.MdiParent = Me
        FormCirurgiaInternacao.Show()


    End Sub

    Private Sub TipoConsultaToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles TipoConsultaToolStripMenuItem.Click
        FormTipoConsulta.MdiParent = Me
        FormTipoConsulta.Show()
    End Sub


    Private Sub AuxiliarToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles AuxiliarToolStripMenuItem1.Click
        FormContasApagar.MdiParent = Me
        FormContasApagar.Show()
    End Sub

    Private Sub PagamentoToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MedicaçãoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormMedicacao.MdiParent = Me
        FormMedicacao.Show()

    End Sub

    Private Sub TipoExameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoExameToolStripMenuItem.Click
        FormExame.MdiParent = Me
        FormExame.Show()


    End Sub

    Private Sub TipoCirurgiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoCirurgiaToolStripMenuItem.Click
        FormCirurgia.MdiParent = Me
        FormCirurgia.Show()

    End Sub
End Class
