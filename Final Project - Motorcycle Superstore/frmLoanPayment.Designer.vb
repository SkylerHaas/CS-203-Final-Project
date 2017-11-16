<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPricinple = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblDateDue = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAPR = New System.Windows.Forms.Label()
        Me.cboLoanNumber = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan Number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount Due: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APR: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Principle - "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Interest - "
        '
        'lblPricinple
        '
        Me.lblPricinple.AutoSize = True
        Me.lblPricinple.Location = New System.Drawing.Point(68, 14)
        Me.lblPricinple.Name = "lblPricinple"
        Me.lblPricinple.Size = New System.Drawing.Size(34, 13)
        Me.lblPricinple.TabIndex = 6
        Me.lblPricinple.Text = "$0.00"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(68, 36)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(34, 13)
        Me.lblInterest.TabIndex = 7
        Me.lblInterest.Text = "$0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Outstanding Balance: "
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(132, 76)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(34, 13)
        Me.lblBalance.TabIndex = 9
        Me.lblBalance.Text = "$0.00"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Location = New System.Drawing.Point(132, 98)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(34, 13)
        Me.lblAmountDue.TabIndex = 11
        Me.lblAmountDue.Text = "$0.00"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(132, 171)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPayment.TabIndex = 12
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(78, 212)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(103, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm Payment"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblDateDue
        '
        Me.lblDateDue.AutoSize = True
        Me.lblDateDue.Location = New System.Drawing.Point(132, 32)
        Me.lblDateDue.Name = "lblDateDue"
        Me.lblDateDue.Size = New System.Drawing.Size(41, 13)
        Me.lblDateDue.TabIndex = 16
        Me.lblDateDue.Text = "1/1/17"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Payment Due By: "
        '
        'lblAPR
        '
        Me.lblAPR.AutoSize = True
        Me.lblAPR.Location = New System.Drawing.Point(132, 54)
        Me.lblAPR.Name = "lblAPR"
        Me.lblAPR.Size = New System.Drawing.Size(36, 13)
        Me.lblAPR.TabIndex = 17
        Me.lblAPR.Text = "4.99%"
        '
        'cboLoanNumber
        '
        Me.cboLoanNumber.FormattingEnabled = True
        Me.cboLoanNumber.Location = New System.Drawing.Point(132, 6)
        Me.cboLoanNumber.Name = "cboLoanNumber"
        Me.cboLoanNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboLoanNumber.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPricinple)
        Me.GroupBox1.Controls.Add(Me.lblInterest)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 58)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboLoanNumber)
        Me.Controls.Add(Me.lblAPR)
        Me.Controls.Add(Me.lblDateDue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoanPayment"
        Me.Text = "Enter Loan Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPricinple As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDateDue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAPR As Label
    Friend WithEvents cboLoanNumber As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
