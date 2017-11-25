Public Class frmSellInventory
    Private Sub frmSellInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblYear.Text = frmBrowseInventory.dgvInventory.SelectedCells.ToString
    End Sub
End Class