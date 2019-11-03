<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Español_BDDataSet = New WindowsApp12.Español_BDDataSet()
        Me.Base_de_datos_españolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_datos_españolTableAdapter = New WindowsApp12.Español_BDDataSetTableAdapters.base_de_datos_españolTableAdapter()
        Me.TableAdapterManager = New WindowsApp12.Español_BDDataSetTableAdapters.TableAdapterManager()
        CType(Me.Español_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_datos_españolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Español_BDDataSet
        '
        Me.Español_BDDataSet.DataSetName = "Español_BDDataSet"
        Me.Español_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Base_de_datos_españolBindingSource
        '
        Me.Base_de_datos_españolBindingSource.DataMember = "base de datos español"
        Me.Base_de_datos_españolBindingSource.DataSource = Me.Español_BDDataSet
        '
        'Base_de_datos_españolTableAdapter
        '
        Me.Base_de_datos_españolTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.base_de_datos_españolTableAdapter = Me.Base_de_datos_españolTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp12.Español_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Español_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_datos_españolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Español_BDDataSet As Español_BDDataSet
    Friend WithEvents Base_de_datos_españolBindingSource As BindingSource
    Friend WithEvents Base_de_datos_españolTableAdapter As Español_BDDataSetTableAdapters.base_de_datos_españolTableAdapter
    Friend WithEvents TableAdapterManager As Español_BDDataSetTableAdapters.TableAdapterManager
End Class
