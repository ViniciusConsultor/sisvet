Public Class FormPrincipal

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

    Private Sub AuxiliarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AuxiliarToolStripMenuItem1.Click
        FormAuxiliar.MdiParent = Me
        FormAuxiliar.Show()

    End Sub

    Private Sub PacienteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PacienteToolStripMenuItem1.Click
        FormPaciente.MdiParent = Me
        FormPaciente.Show()

    End Sub
End Class
