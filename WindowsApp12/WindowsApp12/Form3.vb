Public Class Form3
    Private Sub AdministracionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.AdministracionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Administracion_BDDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Administracion_BDDataSet.Administracion' Puede moverla o quitarla según sea necesario.
        Me.AdministracionTableAdapter.Fill(Me.Administracion_BDDataSet.Administracion)

    End Sub
End Class