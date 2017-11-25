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
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.MotorcycleShopDataSet = New WindowsApplication1.MotorcycleShopDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.InventoryTableAdapter()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.cboBodyStyle = New System.Windows.Forms.ComboBox()
        Me.BodyStylesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.ManufacturersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BodyStylesTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.BodyStylesTableAdapter()
        Me.ManufacturersTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.ManufacturersTableAdapter()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodyStylesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManufacturersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(0, 41)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(994, 220)
        Me.dgvInventory.TabIndex = 0
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
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(12, 12)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(75, 21)
        Me.btnViewAll.TabIndex = 1
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'btnSell
        '
        Me.btnSell.Location = New System.Drawing.Point(456, 12)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(75, 21)
        Me.btnSell.TabIndex = 4
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'cboBodyStyle
        '
        Me.cboBodyStyle.DataSource = Me.BodyStylesBindingSource
        Me.cboBodyStyle.DisplayMember = "BodyStyle"
        Me.cboBodyStyle.FormattingEnabled = True
        Me.cboBodyStyle.Location = New System.Drawing.Point(159, 12)
        Me.cboBodyStyle.Name = "cboBodyStyle"
        Me.cboBodyStyle.Size = New System.Drawing.Size(121, 21)
        Me.cboBodyStyle.TabIndex = 2
        Me.cboBodyStyle.ValueMember = "BodyStyle"
        '
        'BodyStylesBindingSource
        '
        Me.BodyStylesBindingSource.DataMember = "BodyStyles"
        Me.BodyStylesBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'cboMake
        '
        Me.cboMake.DataSource = Me.ManufacturersBindingSource
        Me.cboMake.DisplayMember = "Make"
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Location = New System.Drawing.Point(329, 12)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(121, 21)
        Me.cboMake.TabIndex = 3
        Me.cboMake.ValueMember = "Make"
        '
        'ManufacturersBindingSource
        '
        Me.ManufacturersBindingSource.DataMember = "Manufacturers"
        Me.ManufacturersBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Body Style:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Make:"
        '
        'BodyStylesTableAdapter
        '
        Me.BodyStylesTableAdapter.ClearBeforeFill = True
        '
        'ManufacturersTableAdapter
        '
        Me.ManufacturersTableAdapter.ClearBeforeFill = True
        '
        'frmBrowseInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.cboBodyStyle)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.dgvInventory)
        Me.Name = "frmBrowseInventory"
        Me.Text = "Browse Inventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodyStylesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManufacturersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents MotorcycleShopDataSet As MotorcycleShopDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents cboBodyStyle As ComboBox
    Friend WithEvents cboMake As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BodyStylesBindingSource As BindingSource
    Friend WithEvents BodyStylesTableAdapter As MotorcycleShopDataSetTableAdapters.BodyStylesTableAdapter
    Friend WithEvents ManufacturersBindingSource As BindingSource
    Friend WithEvents ManufacturersTableAdapter As MotorcycleShopDataSetTableAdapters.ManufacturersTableAdapter
End Class
