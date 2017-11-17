<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellInventory
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
        Me.rdoLoan = New System.Windows.Forms.RadioButton()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.grpLoanDetails = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAPR = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.grpLoanDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoLoan
        '
        Me.rdoLoan.AutoSize = True
        Me.rdoLoan.Location = New System.Drawing.Point(270, 12)
        Me.rdoLoan.Name = "rdoLoan"
        Me.rdoLoan.Size = New System.Drawing.Size(81, 17)
        Me.rdoLoan.TabIndex = 0
        Me.rdoLoan.Text = "Buy on Lien"
        Me.rdoLoan.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Checked = True
        Me.rdoCash.Location = New System.Drawing.Point(270, 141)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(92, 17)
        Me.rdoCash.TabIndex = 1
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "Buy with Cash"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'grpLoanDetails
        '
        Me.grpLoanDetails.Controls.Add(Me.cboTerm)
        Me.grpLoanDetails.Controls.Add(Me.lblPayment)
        Me.grpLoanDetails.Controls.Add(Me.lblAPR)
        Me.grpLoanDetails.Controls.Add(Me.Label3)
        Me.grpLoanDetails.Controls.Add(Me.Label2)
        Me.grpLoanDetails.Controls.Add(Me.Label1)
        Me.grpLoanDetails.Enabled = False
        Me.grpLoanDetails.Location = New System.Drawing.Point(288, 35)
        Me.grpLoanDetails.Name = "grpLoanDetails"
        Me.grpLoanDetails.Size = New System.Drawing.Size(200, 100)
        Me.grpLoanDetails.TabIndex = 2
        Me.grpLoanDetails.TabStop = False
        Me.grpLoanDetails.Text = "Loan Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Term: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APR: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAPR
        '
        Me.lblAPR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAPR.AutoSize = True
        Me.lblAPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAPR.Location = New System.Drawing.Point(70, 47)
        Me.lblAPR.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblAPR.Name = "lblAPR"
        Me.lblAPR.Size = New System.Drawing.Size(50, 18)
        Me.lblAPR.TabIndex = 3
        Me.lblAPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayment
        '
        Me.lblPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayment.Location = New System.Drawing.Point(70, 72)
        Me.lblPayment.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(50, 18)
        Me.lblPayment.TabIndex = 4
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(49, 18)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(71, 21)
        Me.cboTerm.TabIndex = 5
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(79, 88)
        Me.lblModel.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(150, 22)
        Me.lblModel.TabIndex = 14
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(79, 56)
        Me.lblMake.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(150, 22)
        Me.lblMake.TabIndex = 13
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(79, 22)
        Me.lblYear.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(150, 22)
        Me.lblYear.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Model: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Make: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Year: "
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(79, 120)
        Me.lblPrice.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 22)
        Me.lblPrice.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Price: "
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(513, 72)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(118, 29)
        Me.btnSell.TabIndex = 17
        Me.btnSell.Text = "Confirm Sale"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'frmSellInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 169)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpLoanDetails)
        Me.Controls.Add(Me.rdoCash)
        Me.Controls.Add(Me.rdoLoan)
        Me.Name = "frmSellInventory"
        Me.Text = "Sell Inventory"
        Me.grpLoanDetails.ResumeLayout(False)
        Me.grpLoanDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoLoan As RadioButton
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents grpLoanDetails As GroupBox
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblAPR As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSell As Button
End Class
