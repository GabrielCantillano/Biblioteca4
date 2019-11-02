Public Class Form1
    Private Sub Base_de_datos_españolBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Base_de_datos_españolBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Base_de_datos_españolBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Español_BDDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Español_BDDataSet.base_de_datos_español' Puede moverla o quitarla según sea necesario.
        Me.Base_de_datos_españolTableAdapter.Fill(Me.Español_BDDataSet.base_de_datos_español)

    End Sub
End Class
