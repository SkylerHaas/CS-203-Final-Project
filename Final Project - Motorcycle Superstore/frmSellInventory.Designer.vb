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
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblAPR = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.grpLoanDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoLoan
        '
        Me.rdoLoan.AutoSize = True
        Me.rdoLoan.Location = New System.Drawing.Point(270, 10)
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
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(49, 18)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(71, 21)
        Me.cboTerm.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Term: "
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(78, 107)
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
        Me.lblMake.Location = New System.Drawing.Point(78, 75)
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
        Me.lblYear.Location = New System.Drawing.Point(78, 41)
        Me.lblYear.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(150, 22)
        Me.lblYear.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Model: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Make: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 41)
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
        Me.lblPrice.Location = New System.Drawing.Point(78, 139)
        Me.lblPrice.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 22)
        Me.lblPrice.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 139)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ID: "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(78, 10)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(150, 20)
        Me.txtID.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Birthday: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Last Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "First Name: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(74, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "-----Customer Info-----"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(116, 212)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 20)
        Me.txtFirstName.TabIndex = 27
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(116, 244)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 20)
        Me.txtLastName.TabIndex = 28
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(116, 276)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(150, 20)
        Me.txtBirthday.TabIndex = 29
        '
        'frmSellInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 350)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label9)
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
    Friend WithEvents Label9 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtBirthday As TextBox
End Class
