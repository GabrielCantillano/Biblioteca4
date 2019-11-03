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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label1.Text = "Cargando el sistema al" & ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()
        End If


    End Sub
End Class
