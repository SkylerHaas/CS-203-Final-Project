Public Class frmSellInventory
    Private Sub frmSellInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblYear.Text = frmBrowseInventory.dgvInventory.SelectedCells(1).ToString
        lblMake.Text = frmBrowseInventory.dgvInventory.SelectedCells(2).ToString
        lblModel.Text = frmBrowseInventory.dgvInventory.SelectedCells(3).ToString
        Dim price As Decimal = 0
        Decimal.TryParse(frmBrowseInventory.dgvInventory.SelectedCells(9).ToString, price)
        lblPrice.Text = price.ToString("c")
    End Sub

    Private Sub rdoLoan_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLoan.CheckedChanged
        If rdoLoan.Checked Then
            grpLoanDetails.Enabled = True
        Else
            grpLoanDetails.Enabled = False
        End If
    End Sub
End Class