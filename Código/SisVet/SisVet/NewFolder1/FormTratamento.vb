Public Class FormTratamento

    Private Sub FormTratamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco


        '  DataGridView1.DataSource = obj.lista
        DataGridView1.Refresh()
        Carregacombo()
    End Sub

    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco


        comboMedico.DisplayMember = "nome_medico_veterinario"
        comboMedico.ValueMember = "codigo_medico_vet_pk"
        comboMedico.DataSource = obj.retornaDataTable("Select *from medico_veterinario")


        comboPaciente.DisplayMember = "nome_paciente"
        ComboPaciente.ValueMember = "cod_paciente"
        comboPaciente.DataSource = obj.retornaDataTable("Select *from paciente")


    End Sub

    Private Sub btbusca_Click(sender As System.Object, e As System.EventArgs) Handles btbusca.Click

    End Sub

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

    End Sub
End Class