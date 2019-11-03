Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Español_BDDataSet.base_de_datos_español' Puede moverla o quitarla según sea necesario.
        Me.Base_de_datos_españolTableAdapter.Fill(Me.Español_BDDataSet.base_de_datos_español)

    End Sub
End Class