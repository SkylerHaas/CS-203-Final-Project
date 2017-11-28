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

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub UpdateSaleFormMotorcycle()
        lblYear.Text
        lblMake.Text
        lblModel.Text
        lblPrice.Text = 
    End Sub
End Class