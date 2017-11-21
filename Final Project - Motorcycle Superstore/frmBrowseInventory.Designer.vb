<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowseInventory))
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnViewAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboBodyStyle = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboMake = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSell = New System.Windows.Forms.ToolStripButton()
        Me.MotorcycleShopDataSet = New WindowsApplication1.MotorcycleShopDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.InventoryTableAdapter()
        Me.InventoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyStyleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineCylindersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLastPriceAdjustedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIdDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.BodyStyleDataGridViewTextBoxColumn, Me.MilageDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn, Me.EngineSizeDataGridViewTextBoxColumn, Me.EngineCylindersDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn, Me.DateLastPriceAdjustedDataGridViewTextBoxColumn})
        Me.dgvInventory.DataSource = Me.InventoryBindingSource
        Me.dgvInventory.Location = New System.Drawing.Point(0, 41)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.Size = New System.Drawing.Size(994, 220)
        Me.dgvInventory.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnViewAll, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboBodyStyle, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.cboMake, Me.ToolStripSeparator3, Me.btnSell})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(994, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnViewAll
        '
        Me.btnViewAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewAll.Image = CType(resources.GetObject("btnViewAll.Image"), System.Drawing.Image)
        Me.btnViewAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(53, 22)
        Me.btnViewAll.Text = "View All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "Body Style:"
        '
        'cboBodyStyle
        '
        Me.cboBodyStyle.Name = "cboBodyStyle"
        Me.cboBodyStyle.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel2.Text = "Make: "
        '
        'cboMake
        '
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnSell
        '
        Me.btnSell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSell.Image = CType(resources.GetObject("btnSell.Image"), System.Drawing.Image)
        Me.btnSell.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(29, 22)
        Me.btnSell.Text = "Sell"
        '
        'MotorcycleShopDataSet
        '
        Me.MotorcycleShopDataSet.DataSetName = "MotorcycleShopDataSet"
        Me.MotorcycleShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'InventoryIdDataGridViewTextBoxColumn
        '
        Me.InventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.Name = "InventoryIdDataGridViewTextBoxColumn"
        Me.InventoryIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryIdDataGridViewTextBoxColumn.Width = 85
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.Width = 54
        '
        'MakeDataGridViewTextBoxColumn
        '
        Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
        Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
        Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
        Me.MakeDataGridViewTextBoxColumn.Width = 59
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.Width = 61
        '
        'BodyStyleDataGridViewTextBoxColumn
        '
        Me.BodyStyleDataGridViewTextBoxColumn.DataPropertyName = "BodyStyle"
        Me.BodyStyleDataGridViewTextBoxColumn.HeaderText = "BodyStyle"
        Me.BodyStyleDataGridViewTextBoxColumn.Name = "BodyStyleDataGridViewTextBoxColumn"
        Me.BodyStyleDataGridViewTextBoxColumn.Width = 79
        '
        'MilageDataGridViewTextBoxColumn
        '
        Me.MilageDataGridViewTextBoxColumn.DataPropertyName = "Milage"
        Me.MilageDataGridViewTextBoxColumn.HeaderText = "Milage"
        Me.MilageDataGridViewTextBoxColumn.Name = "MilageDataGridViewTextBoxColumn"
        Me.MilageDataGridViewTextBoxColumn.Width = 63
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        Me.ConditionDataGridViewTextBoxColumn.Width = 76
        '
        'EngineSizeDataGridViewTextBoxColumn
        '
        Me.EngineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize"
        Me.EngineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize"
        Me.EngineSizeDataGridViewTextBoxColumn.Name = "EngineSizeDataGridViewTextBoxColumn"
        Me.EngineSizeDataGridViewTextBoxColumn.Width = 85
        '
        'EngineCylindersDataGridViewTextBoxColumn
        '
        Me.EngineCylindersDataGridViewTextBoxColumn.DataPropertyName = "EngineCylinders"
        Me.EngineCylindersDataGridViewTextBoxColumn.HeaderText = "EngineCylinders"
        Me.EngineCylindersDataGridViewTextBoxColumn.Name = "EngineCylindersDataGridViewTextBoxColumn"
        Me.EngineCylindersDataGridViewTextBoxColumn.Width = 107
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 56
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded"
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.Width = 86
        '
        'DateLastPriceAdjustedDataGridViewTextBoxColumn
        '
        Me.DateLastPriceAdjustedDataGridViewTextBoxColumn.DataPropertyName = "DateLastPriceAdjusted"
        Me.DateLastPriceAdjustedDataGridViewTextBoxColumn.HeaderText = "DateLastPriceAdjusted"
        Me.DateLastPriceAdjustedDataGridViewTextBoxColumn.Name = "DateLastPriceAdjustedDataGridViewTextBoxColumn"
        Me.DateLastPriceAdjustedDataGridViewTextBoxColumn.Width = 140
        '
        'frmBrowseInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 261)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvInventory)
        Me.Name = "frmBrowseInventory"
        Me.Text = "Browse Inventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnViewAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboBodyStyle As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cboMake As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnSell As ToolStripButton
    Friend WithEvents MotorcycleShopDataSet As MotorcycleShopDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodyStyleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EngineSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EngineCylindersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateLastPriceAdjustedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
