<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewLoans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewLoans))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnViewAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnViewOutstanding = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnViewPaid = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEnterPayment = New System.Windows.Forms.ToolStripButton()
        Me.dgvLoans = New System.Windows.Forms.DataGridView()
        Me.MotorcycleShopDataSet = New WindowsApplication1.MotorcycleShopDataSet()
        Me.LoansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoansTableAdapter = New WindowsApplication1.MotorcycleShopDataSetTableAdapters.LoansTableAdapter()
        Me.LoanIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextPaymentDueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AprDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvLoans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnViewAll, Me.ToolStripSeparator1, Me.btnViewOutstanding, Me.ToolStripSeparator2, Me.btnViewPaid, Me.ToolStripSeparator3, Me.btnEnterPayment})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(846, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'btnViewOutstanding
        '
        Me.btnViewOutstanding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewOutstanding.Image = CType(resources.GetObject("btnViewOutstanding.Image"), System.Drawing.Image)
        Me.btnViewOutstanding.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewOutstanding.Name = "btnViewOutstanding"
        Me.btnViewOutstanding.Size = New System.Drawing.Size(105, 22)
        Me.btnViewOutstanding.Text = "View Outstanding"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnViewPaid
        '
        Me.btnViewPaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewPaid.Image = CType(resources.GetObject("btnViewPaid.Image"), System.Drawing.Image)
        Me.btnViewPaid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewPaid.Name = "btnViewPaid"
        Me.btnViewPaid.Size = New System.Drawing.Size(82, 22)
        Me.btnViewPaid.Text = "View Paid Off"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEnterPayment
        '
        Me.btnEnterPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEnterPayment.Image = CType(resources.GetObject("btnEnterPayment.Image"), System.Drawing.Image)
        Me.btnEnterPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnterPayment.Name = "btnEnterPayment"
        Me.btnEnterPayment.Size = New System.Drawing.Size(88, 22)
        Me.btnEnterPayment.Text = "Enter Payment"
        '
        'dgvLoans
        '
        Me.dgvLoans.AllowUserToAddRows = False
        Me.dgvLoans.AllowUserToDeleteRows = False
        Me.dgvLoans.AutoGenerateColumns = False
        Me.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoanIdDataGridViewTextBoxColumn, Me.CustIdDataGridViewTextBoxColumn, Me.InventoryIdDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.NextPaymentDueDateDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.AprDataGridViewTextBoxColumn, Me.AmountDueDataGridViewTextBoxColumn})
        Me.dgvLoans.DataSource = Me.LoansBindingSource
        Me.dgvLoans.Location = New System.Drawing.Point(0, 38)
        Me.dgvLoans.Name = "dgvLoans"
        Me.dgvLoans.ReadOnly = True
        Me.dgvLoans.Size = New System.Drawing.Size(846, 223)
        Me.dgvLoans.TabIndex = 1
        '
        'MotorcycleShopDataSet
        '
        Me.MotorcycleShopDataSet.DataSetName = "MotorcycleShopDataSet"
        Me.MotorcycleShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoansBindingSource
        '
        Me.LoansBindingSource.DataMember = "Loans"
        Me.LoansBindingSource.DataSource = Me.MotorcycleShopDataSet
        '
        'LoansTableAdapter
        '
        Me.LoansTableAdapter.ClearBeforeFill = True
        '
        'LoanIdDataGridViewTextBoxColumn
        '
        Me.LoanIdDataGridViewTextBoxColumn.DataPropertyName = "LoanId"
        Me.LoanIdDataGridViewTextBoxColumn.HeaderText = "LoanId"
        Me.LoanIdDataGridViewTextBoxColumn.Name = "LoanIdDataGridViewTextBoxColumn"
        Me.LoanIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustIdDataGridViewTextBoxColumn
        '
        Me.CustIdDataGridViewTextBoxColumn.DataPropertyName = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.HeaderText = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.Name = "CustIdDataGridViewTextBoxColumn"
        Me.CustIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryIdDataGridViewTextBoxColumn
        '
        Me.InventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.Name = "InventoryIdDataGridViewTextBoxColumn"
        Me.InventoryIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NextPaymentDueDateDataGridViewTextBoxColumn
        '
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.DataPropertyName = "NextPaymentDueDate"
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.HeaderText = "NextPaymentDueDate"
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.Name = "NextPaymentDueDateDataGridViewTextBoxColumn"
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        Me.PaymentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AprDataGridViewTextBoxColumn
        '
        Me.AprDataGridViewTextBoxColumn.DataPropertyName = "Apr"
        Me.AprDataGridViewTextBoxColumn.HeaderText = "Apr"
        Me.AprDataGridViewTextBoxColumn.Name = "AprDataGridViewTextBoxColumn"
        Me.AprDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDueDataGridViewTextBoxColumn
        '
        Me.AmountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue"
        Me.AmountDueDataGridViewTextBoxColumn.HeaderText = "AmountDue"
        Me.AmountDueDataGridViewTextBoxColumn.Name = "AmountDueDataGridViewTextBoxColumn"
        Me.AmountDueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmViewLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 261)
        Me.Controls.Add(Me.dgvLoans)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmViewLoans"
        Me.Text = "View Loans"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvLoans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorcycleShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnViewAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnViewOutstanding As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnViewPaid As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnEnterPayment As ToolStripButton
    Friend WithEvents dgvLoans As DataGridView
    Friend WithEvents MotorcycleShopDataSet As MotorcycleShopDataSet
    Friend WithEvents LoansBindingSource As BindingSource
    Friend WithEvents LoansTableAdapter As MotorcycleShopDataSetTableAdapters.LoansTableAdapter
    Friend WithEvents LoanIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NextPaymentDueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AprDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
