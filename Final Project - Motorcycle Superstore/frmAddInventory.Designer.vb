<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMilage = New System.Windows.Forms.TextBox()
        Me.txtEngineSize = New System.Windows.Forms.TextBox()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.cboBodyStyle = New System.Windows.Forms.ComboBox()
        Me.BodyStylesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotorcycleShopDataSet = New WindowsApplication1.MotorcycleShopDataSet()
        Me.cboEngineCylinders = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.ManufacturersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.InventoryTableAdapter()
        Me.ManufacturersTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.ManufacturersTableAdapter()
        Me.BodyStylesTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.BodyStylesTableAdapter()
        Me.CylindersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CylindersTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.CylindersTableAdapter()
        Me.ConditionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConditionsTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.ConditionsTableAdapter()
        CType(Me.BodyStylesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManufacturersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CylindersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Make: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Milage: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Condition: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Body Style: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Engine Size: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cylinders: "
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(100, 31)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(100, 77)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 10
        '
        'txtMilage
        '
        Me.txtMilage.Location = New System.Drawing.Point(100, 102)
        Me.txtMilage.Name = "txtMilage"
        Me.txtMilage.Size = New System.Drawing.Size(100, 20)
        Me.txtMilage.TabIndex = 11
        '
        'txtEngineSize
        '
        Me.txtEngineSize.Location = New System.Drawing.Point(100, 172)
        Me.txtEngineSize.Name = "txtEngineSize"
        Me.txtEngineSize.Size = New System.Drawing.Size(100, 20)
        Me.txtEngineSize.TabIndex = 14
        '
        'cboCondition
        '
        Me.cboCondition.DataSource = Me.ConditionsBindingSource
        Me.cboCondition.DisplayMember = "Condition"
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Location = New System.Drawing.Point(100, 126)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(100, 21)
        Me.cboCondition.TabIndex = 15
        Me.cboCondition.ValueMember = "Condition"
        '
        'cboBodyStyle
        '
        Me.cboBodyStyle.DataSource = Me.BodyStylesBindingSource
        Me.cboBodyStyle.DisplayMember = "BodyStyle"
        Me.cboBodyStyle.FormattingEnabled = True
        Me.cboBodyStyle.Location = New System.Drawing.Point(100, 149)
        Me.cboBodyStyle.Name = "cboBodyStyle"
        Me.cboBodyStyle.Size = New System.Drawing.Size(100, 21)
        Me.cboBodyStyle.TabIndex = 16
        Me.cboBodyStyle.ValueMember = "BodyStyle"
        '
        'BodyStylesBindingSource
        '
        Me.BodyStylesBindingSource.DataMember = "BodyStyles"
        Me.BodyStylesBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'MotorcycleShopDataSet
        '
        Me.MotorcycleShopDataSet.DataSetName = "MotorcycleShopDataSet"
        Me.MotorcycleShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboEngineCylinders
        '
        Me.cboEngineCylinders.DataSource = Me.CylindersBindingSource
        Me.cboEngineCylinders.DisplayMember = "Cylinders"
        Me.cboEngineCylinders.FormattingEnabled = True
        Me.cboEngineCylinders.Location = New System.Drawing.Point(100, 195)
        Me.cboEngineCylinders.Name = "cboEngineCylinders"
        Me.cboEngineCylinders.Size = New System.Drawing.Size(100, 21)
        Me.cboEngineCylinders.TabIndex = 17
        Me.cboEngineCylinders.ValueMember = "Cylinders"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(58, 266)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add to Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboMake
        '
        Me.cboMake.DataSource = Me.ManufacturersBindingSource
        Me.cboMake.DisplayMember = "Make"
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Location = New System.Drawing.Point(100, 54)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(100, 21)
        Me.cboMake.TabIndex = 19
        Me.cboMake.ValueMember = "Make"
        '
        'ManufacturersBindingSource
        '
        Me.ManufacturersBindingSource.DataMember = "Manufacturers"
        Me.ManufacturersBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Price: "
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(100, 220)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 21
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
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
        'ManufacturersTableAdapter
        '
        Me.ManufacturersTableAdapter.ClearBeforeFill = True
        '
        'BodyStylesTableAdapter
        '
        Me.BodyStylesTableAdapter.ClearBeforeFill = True
        '
        'CylindersBindingSource
        '
        Me.CylindersBindingSource.DataMember = "Cylinders"
        Me.CylindersBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'CylindersTableAdapter
        '
        Me.CylindersTableAdapter.ClearBeforeFill = True
        '
        'ConditionsBindingSource
        '
        Me.ConditionsBindingSource.DataMember = "Conditions"
        Me.ConditionsBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'ConditionsTableAdapter
        '
        Me.ConditionsTableAdapter.ClearBeforeFill = True
        '
        'frmAddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 314)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboEngineCylinders)
        Me.Controls.Add(Me.cboBodyStyle)
        Me.Controls.Add(Me.cboCondition)
        Me.Controls.Add(Me.txtEngineSize)
        Me.Controls.Add(Me.txtMilage)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddInventory"
        Me.Text = "frmAddInventory"
        CType(Me.BodyStylesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManufacturersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CylindersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMilage As TextBox
    Friend WithEvents txtEngineSize As TextBox
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents cboBodyStyle As ComboBox
    Friend WithEvents cboEngineCylinders As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboMake As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents MotorcycleShopDataSet As MotorcycleShopDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents ManufacturersBindingSource As BindingSource
    Friend WithEvents ManufacturersTableAdapter As MotorcycleShopDataSetTableAdapters.ManufacturersTableAdapter
    Friend WithEvents BodyStylesBindingSource As BindingSource
    Friend WithEvents BodyStylesTableAdapter As MotorcycleShopDataSetTableAdapters.BodyStylesTableAdapter
    Friend WithEvents CylindersBindingSource As BindingSource
    Friend WithEvents CylindersTableAdapter As MotorcycleShopDataSetTableAdapters.CylindersTableAdapter
    Friend WithEvents ConditionsBindingSource As BindingSource
    Friend WithEvents ConditionsTableAdapter As MotorcycleShopDataSetTableAdapters.ConditionsTableAdapter
End Class
