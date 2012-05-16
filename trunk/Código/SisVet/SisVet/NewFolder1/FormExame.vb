Public Class FormExame

    Private Sub FormExame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Sisvet.ClassBanco


        DataGridView1.DataSource = obj.executasql("Select * from exame")
        DataGridView1.Refresh()
        Carregacombo()

    End Sub
    Public Sub Carregacombo()
        Dim obj As New Sisvet.ClassBanco

        ComboLaboratorio.DisplayMember = "nome_laboratorio"
        ComboLaboratorio.ValueMember = "cod_laboratorio_pk"
        ComboLaboratorio.DataSource = obj.retornaDataTable("Select *from laboratorios")


    End Sub

    Private Sub btsalvar_Click(sender As System.Object, e As System.EventArgs) Handles btsalvar.Click

    End Sub

    Private Sub btnovo_Click(sender As System.Object, e As System.EventArgs) Handles btnovo.Click

    End Sub
End Class