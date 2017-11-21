<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpeningScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpeningScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoans = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewLoans = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventory, Me.mnuLoans})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuInventory
        '
        Me.mnuInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrowse, Me.mnuAdd, Me.mnuSale})
        Me.mnuInventory.Name = "mnuInventory"
        Me.mnuInventory.Size = New System.Drawing.Size(69, 20)
        Me.mnuInventory.Text = "&Inventory"
        '
        'mnuBrowse
        '
        Me.mnuBrowse.Name = "mnuBrowse"
        Me.mnuBrowse.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrowse.Text = "&Browse"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(152, 22)
        Me.mnuAdd.Text = "&Add"
        '
        'mnuSale
        '
        Me.mnuSale.Name = "mnuSale"
        Me.mnuSale.Size = New System.Drawing.Size(152, 22)
        Me.mnuSale.Text = "Make &Sale"
        '
        'mnuLoans
        '
        Me.mnuLoans.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPayment, Me.mnuViewLoans})
        Me.mnuLoans.Name = "mnuLoans"
        Me.mnuLoans.Size = New System.Drawing.Size(50, 20)
        Me.mnuLoans.Text = "&Loans"
        '
        'mnuPayment
        '
        Me.mnuPayment.Name = "mnuPayment"
        Me.mnuPayment.Size = New System.Drawing.Size(151, 22)
        Me.mnuPayment.Text = "Enter &Payment"
        '
        'mnuViewLoans
        '
        Me.mnuViewLoans.Name = "mnuViewLoans"
        Me.mnuViewLoans.Size = New System.Drawing.Size(151, 22)
        Me.mnuViewLoans.Text = "&View Loans"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(65, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Haas's Hosses"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmOpeningScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 221)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOpeningScreen"
        Me.Text = "Haas's Hosses Motorcycle Emporium"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuInventory As ToolStripMenuItem
    Friend WithEvents mnuBrowse As ToolStripMenuItem
    Friend WithEvents mnuSale As ToolStripMenuItem
    Friend WithEvents mnuLoans As ToolStripMenuItem
    Friend WithEvents mnuPayment As ToolStripMenuItem
    Friend WithEvents mnuViewLoans As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
