<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Chapter16_2.Database1DataSet()
        Me.TableTableAdapter = New Chapter16_2.Database1DataSetTableAdapters.TableTableAdapter()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.學號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.國文DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.英文DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.數學DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.總分DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.平均DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.學號DataGridViewTextBoxColumn, Me.姓名DataGridViewTextBoxColumn, Me.國文DataGridViewTextBoxColumn, Me.英文DataGridViewTextBoxColumn, Me.數學DataGridViewTextBoxColumn, Me.總分DataGridViewTextBoxColumn, Me.平均DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(786, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        '學號DataGridViewTextBoxColumn
        '
        Me.學號DataGridViewTextBoxColumn.DataPropertyName = "學號"
        Me.學號DataGridViewTextBoxColumn.HeaderText = "學號"
        Me.學號DataGridViewTextBoxColumn.Name = "學號DataGridViewTextBoxColumn"
        '
        '姓名DataGridViewTextBoxColumn
        '
        Me.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名"
        Me.姓名DataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn"
        '
        '國文DataGridViewTextBoxColumn
        '
        Me.國文DataGridViewTextBoxColumn.DataPropertyName = "國文"
        Me.國文DataGridViewTextBoxColumn.HeaderText = "國文"
        Me.國文DataGridViewTextBoxColumn.Name = "國文DataGridViewTextBoxColumn"
        '
        '英文DataGridViewTextBoxColumn
        '
        Me.英文DataGridViewTextBoxColumn.DataPropertyName = "英文"
        Me.英文DataGridViewTextBoxColumn.HeaderText = "英文"
        Me.英文DataGridViewTextBoxColumn.Name = "英文DataGridViewTextBoxColumn"
        '
        '數學DataGridViewTextBoxColumn
        '
        Me.數學DataGridViewTextBoxColumn.DataPropertyName = "數學"
        Me.數學DataGridViewTextBoxColumn.HeaderText = "數學"
        Me.數學DataGridViewTextBoxColumn.Name = "數學DataGridViewTextBoxColumn"
        '
        '總分DataGridViewTextBoxColumn
        '
        Me.總分DataGridViewTextBoxColumn.DataPropertyName = "總分"
        Me.總分DataGridViewTextBoxColumn.HeaderText = "總分"
        Me.總分DataGridViewTextBoxColumn.Name = "總分DataGridViewTextBoxColumn"
        Me.總分DataGridViewTextBoxColumn.ReadOnly = True
        '
        '平均DataGridViewTextBoxColumn
        '
        Me.平均DataGridViewTextBoxColumn.DataPropertyName = "平均"
        Me.平均DataGridViewTextBoxColumn.HeaderText = "平均"
        Me.平均DataGridViewTextBoxColumn.Name = "平均DataGridViewTextBoxColumn"
        Me.平均DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As Database1DataSetTableAdapters.TableTableAdapter
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents 學號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 姓名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 國文DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 英文DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 數學DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 總分DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 平均DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
