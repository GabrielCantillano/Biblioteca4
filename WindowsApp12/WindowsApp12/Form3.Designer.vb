<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NOMBRE_DEL_LIBROLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim Nº_de_pagLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.Administracion_BDDataSet = New WindowsApp12.Administracion_BDDataSet()
        Me.AdministracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministracionTableAdapter = New WindowsApp12.Administracion_BDDataSetTableAdapters.AdministracionTableAdapter()
        Me.TableAdapterManager = New WindowsApp12.Administracion_BDDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Español_BDDataSet = New WindowsApp12.Español_BDDataSet()
        Me.Base_de_datos_españolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_datos_españolTableAdapter = New WindowsApp12.Español_BDDataSetTableAdapters.base_de_datos_españolTableAdapter()
        Me.TableAdapterManager1 = New WindowsApp12.Español_BDDataSetTableAdapters.TableAdapterManager()
        Me.Base_de_datos_españolDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_DEL_LIBROTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Nº_de_pagTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        NOMBRE_DEL_LIBROLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Nº_de_pagLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.Administracion_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Español_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_datos_españolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_datos_españolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Administracion_BDDataSet
        '
        Me.Administracion_BDDataSet.DataSetName = "Administracion_BDDataSet"
        Me.Administracion_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdministracionBindingSource
        '
        Me.AdministracionBindingSource.DataMember = "Administracion"
        Me.AdministracionBindingSource.DataSource = Me.Administracion_BDDataSet
        '
        'AdministracionTableAdapter
        '
        Me.AdministracionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministracionTableAdapter = Me.AdministracionTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp12.Administracion_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 37)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 37)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(173, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 37)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.base_de_datos_españolTableAdapter = Me.Base_de_datos_españolTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApp12.Español_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Base_de_datos_españolDataGridView
        '
        Me.Base_de_datos_españolDataGridView.AutoGenerateColumns = False
        Me.Base_de_datos_españolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Base_de_datos_españolDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Base_de_datos_españolDataGridView.DataSource = Me.Base_de_datos_españolBindingSource
        Me.Base_de_datos_españolDataGridView.Location = New System.Drawing.Point(290, 28)
        Me.Base_de_datos_españolDataGridView.Name = "Base_de_datos_españolDataGridView"
        Me.Base_de_datos_españolDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.Base_de_datos_españolDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE DEL LIBRO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE DEL LIBRO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nº de pag"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nº de pag"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(31, 52)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 18
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(153, 49)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 19
        '
        'NOMBRE_DEL_LIBROLabel
        '
        NOMBRE_DEL_LIBROLabel.AutoSize = True
        NOMBRE_DEL_LIBROLabel.Location = New System.Drawing.Point(31, 78)
        NOMBRE_DEL_LIBROLabel.Name = "NOMBRE_DEL_LIBROLabel"
        NOMBRE_DEL_LIBROLabel.Size = New System.Drawing.Size(116, 13)
        NOMBRE_DEL_LIBROLabel.TabIndex = 20
        NOMBRE_DEL_LIBROLabel.Text = "NOMBRE DEL LIBRO:"
        '
        'NOMBRE_DEL_LIBROTextBox
        '
        Me.NOMBRE_DEL_LIBROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "NOMBRE DEL LIBRO", True))
        Me.NOMBRE_DEL_LIBROTextBox.Location = New System.Drawing.Point(153, 75)
        Me.NOMBRE_DEL_LIBROTextBox.Name = "NOMBRE_DEL_LIBROTextBox"
        Me.NOMBRE_DEL_LIBROTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_DEL_LIBROTextBox.TabIndex = 21
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(31, 104)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(32, 13)
        AreaLabel.TabIndex = 22
        AreaLabel.Text = "Area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(153, 101)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 23
        '
        'Nº_de_pagLabel
        '
        Nº_de_pagLabel.AutoSize = True
        Nº_de_pagLabel.Location = New System.Drawing.Point(31, 130)
        Nº_de_pagLabel.Name = "Nº_de_pagLabel"
        Nº_de_pagLabel.Size = New System.Drawing.Size(58, 13)
        Nº_de_pagLabel.TabIndex = 24
        Nº_de_pagLabel.Text = "Nº de pag:"
        '
        'Nº_de_pagTextBox
        '
        Me.Nº_de_pagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Nº de pag", True))
        Me.Nº_de_pagTextBox.Location = New System.Drawing.Point(153, 127)
        Me.Nº_de_pagTextBox.Name = "Nº_de_pagTextBox"
        Me.Nº_de_pagTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nº_de_pagTextBox.TabIndex = 25
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(31, 156)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 26
        CodigoLabel.Text = "Codigo:"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(153, 153)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 27
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(31, 182)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 28
        AutorLabel.Text = "Autor:"
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(153, 179)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AutorTextBox.TabIndex = 29
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(31, 208)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 30
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Base_de_datos_españolBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(153, 205)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 31
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NOMBRE_DEL_LIBROLabel)
        Me.Controls.Add(Me.NOMBRE_DEL_LIBROTextBox)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Nº_de_pagLabel)
        Me.Controls.Add(Me.Nº_de_pagTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.AutorTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(Me.Base_de_datos_españolDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Administracion_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Español_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_datos_españolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_datos_españolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Administracion_BDDataSet As Administracion_BDDataSet
    Friend WithEvents AdministracionBindingSource As BindingSource
    Friend WithEvents AdministracionTableAdapter As Administracion_BDDataSetTableAdapters.AdministracionTableAdapter
    Friend WithEvents TableAdapterManager As Administracion_BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Español_BDDataSet As Español_BDDataSet
    Friend WithEvents Base_de_datos_españolBindingSource As BindingSource
    Friend WithEvents Base_de_datos_españolTableAdapter As Español_BDDataSetTableAdapters.base_de_datos_españolTableAdapter
    Friend WithEvents TableAdapterManager1 As Español_BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Base_de_datos_españolDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NOMBRE_DEL_LIBROTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents Nº_de_pagTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents AutorTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
End Class
