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
        Dim Id_administracionLabel As System.Windows.Forms.Label
        Dim Nombre_del_libroLabel As System.Windows.Forms.Label
        Dim Numero_del_paginasLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CodigtoLabel As System.Windows.Forms.Label
        Dim Autor_del_libroLabel As System.Windows.Forms.Label
        Me.Administracion_BDDataSet = New WindowsApp12.Administracion_BDDataSet()
        Me.AdministracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministracionTableAdapter = New WindowsApp12.Administracion_BDDataSetTableAdapters.AdministracionTableAdapter()
        Me.TableAdapterManager = New WindowsApp12.Administracion_BDDataSetTableAdapters.TableAdapterManager()
        Me.AdministracionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_administracionTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_del_libroTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_del_paginasTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigtoTextBox = New System.Windows.Forms.TextBox()
        Me.Autor_del_libroTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Id_administracionLabel = New System.Windows.Forms.Label()
        Nombre_del_libroLabel = New System.Windows.Forms.Label()
        Numero_del_paginasLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CodigtoLabel = New System.Windows.Forms.Label()
        Autor_del_libroLabel = New System.Windows.Forms.Label()
        CType(Me.Administracion_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministracionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'AdministracionDataGridView
        '
        Me.AdministracionDataGridView.AutoGenerateColumns = False
        Me.AdministracionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdministracionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AdministracionDataGridView.DataSource = Me.AdministracionBindingSource
        Me.AdministracionDataGridView.Location = New System.Drawing.Point(322, 23)
        Me.AdministracionDataGridView.Name = "AdministracionDataGridView"
        Me.AdministracionDataGridView.Size = New System.Drawing.Size(743, 319)
        Me.AdministracionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id administracion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id administracion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre del libro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre del libro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Numero del paginas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Numero del paginas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Codigto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Codigto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Autor del libro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Autor del libro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_administracionLabel
        '
        Id_administracionLabel.AutoSize = True
        Id_administracionLabel.Location = New System.Drawing.Point(31, 45)
        Id_administracionLabel.Name = "Id_administracionLabel"
        Id_administracionLabel.Size = New System.Drawing.Size(89, 13)
        Id_administracionLabel.TabIndex = 1
        Id_administracionLabel.Text = "Id administracion:"
        '
        'Id_administracionTextBox
        '
        Me.Id_administracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Id administracion", True))
        Me.Id_administracionTextBox.Location = New System.Drawing.Point(141, 42)
        Me.Id_administracionTextBox.Name = "Id_administracionTextBox"
        Me.Id_administracionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_administracionTextBox.TabIndex = 2
        '
        'Nombre_del_libroLabel
        '
        Nombre_del_libroLabel.AutoSize = True
        Nombre_del_libroLabel.Location = New System.Drawing.Point(31, 71)
        Nombre_del_libroLabel.Name = "Nombre_del_libroLabel"
        Nombre_del_libroLabel.Size = New System.Drawing.Size(86, 13)
        Nombre_del_libroLabel.TabIndex = 3
        Nombre_del_libroLabel.Text = "Nombre del libro:"
        '
        'Nombre_del_libroTextBox
        '
        Me.Nombre_del_libroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Nombre del libro", True))
        Me.Nombre_del_libroTextBox.Location = New System.Drawing.Point(141, 68)
        Me.Nombre_del_libroTextBox.Name = "Nombre_del_libroTextBox"
        Me.Nombre_del_libroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_del_libroTextBox.TabIndex = 4
        '
        'Numero_del_paginasLabel
        '
        Numero_del_paginasLabel.AutoSize = True
        Numero_del_paginasLabel.Location = New System.Drawing.Point(31, 97)
        Numero_del_paginasLabel.Name = "Numero_del_paginasLabel"
        Numero_del_paginasLabel.Size = New System.Drawing.Size(104, 13)
        Numero_del_paginasLabel.TabIndex = 5
        Numero_del_paginasLabel.Text = "Numero del paginas:"
        '
        'Numero_del_paginasTextBox
        '
        Me.Numero_del_paginasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Numero del paginas", True))
        Me.Numero_del_paginasTextBox.Location = New System.Drawing.Point(141, 94)
        Me.Numero_del_paginasTextBox.Name = "Numero_del_paginasTextBox"
        Me.Numero_del_paginasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_del_paginasTextBox.TabIndex = 6
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(31, 123)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(32, 13)
        AreaLabel.TabIndex = 7
        AreaLabel.Text = "Area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(141, 120)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 8
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(31, 149)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 9
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(141, 146)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 10
        '
        'CodigtoLabel
        '
        CodigtoLabel.AutoSize = True
        CodigtoLabel.Location = New System.Drawing.Point(31, 175)
        CodigtoLabel.Name = "CodigtoLabel"
        CodigtoLabel.Size = New System.Drawing.Size(46, 13)
        CodigtoLabel.TabIndex = 11
        CodigtoLabel.Text = "Codigto:"
        '
        'CodigtoTextBox
        '
        Me.CodigtoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Codigto", True))
        Me.CodigtoTextBox.Location = New System.Drawing.Point(141, 172)
        Me.CodigtoTextBox.Name = "CodigtoTextBox"
        Me.CodigtoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigtoTextBox.TabIndex = 12
        '
        'Autor_del_libroLabel
        '
        Autor_del_libroLabel.AutoSize = True
        Autor_del_libroLabel.Location = New System.Drawing.Point(31, 201)
        Autor_del_libroLabel.Name = "Autor_del_libroLabel"
        Autor_del_libroLabel.Size = New System.Drawing.Size(74, 13)
        Autor_del_libroLabel.TabIndex = 13
        Autor_del_libroLabel.Text = "Autor del libro:"
        '
        'Autor_del_libroTextBox
        '
        Me.Autor_del_libroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministracionBindingSource, "Autor del libro", True))
        Me.Autor_del_libroTextBox.Location = New System.Drawing.Point(141, 198)
        Me.Autor_del_libroTextBox.Name = "Autor_del_libroTextBox"
        Me.Autor_del_libroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Autor_del_libroTextBox.TabIndex = 14
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_administracionLabel)
        Me.Controls.Add(Me.Id_administracionTextBox)
        Me.Controls.Add(Nombre_del_libroLabel)
        Me.Controls.Add(Me.Nombre_del_libroTextBox)
        Me.Controls.Add(Numero_del_paginasLabel)
        Me.Controls.Add(Me.Numero_del_paginasTextBox)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CodigtoLabel)
        Me.Controls.Add(Me.CodigtoTextBox)
        Me.Controls.Add(Autor_del_libroLabel)
        Me.Controls.Add(Me.Autor_del_libroTextBox)
        Me.Controls.Add(Me.AdministracionDataGridView)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Administracion_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministracionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Administracion_BDDataSet As Administracion_BDDataSet
    Friend WithEvents AdministracionBindingSource As BindingSource
    Friend WithEvents AdministracionTableAdapter As Administracion_BDDataSetTableAdapters.AdministracionTableAdapter
    Friend WithEvents TableAdapterManager As Administracion_BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdministracionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Id_administracionTextBox As TextBox
    Friend WithEvents Nombre_del_libroTextBox As TextBox
    Friend WithEvents Numero_del_paginasTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CodigtoTextBox As TextBox
    Friend WithEvents Autor_del_libroTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
