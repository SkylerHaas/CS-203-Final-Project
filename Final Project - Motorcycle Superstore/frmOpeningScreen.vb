Public Class frmOpeningScreen

    Private inventory As Inventory

    Private Sub frmOpeningScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventory.UpdatePrices
    End Sub

    Private Sub mnuPayment_Click(sender As Object, e As EventArgs) Handles mnuPayment.Click
        frmLoanPayment.ShowDialog()
    End Sub

    Private Sub mnuViewLoans_Click(sender As Object, e As EventArgs) Handles mnuViewLoans.Click
        frmViewLoans.ShowDialog()
    End Sub

    Private Sub mnuBrowse_Click(sender As Object, e As EventArgs) Handles mnuBrowse.Click
        frmBrowseInventory.ShowDialog()
    End Sub

    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        frmAddInventory.ShowDialog()
    End Sub

    Private Sub mnuSale_Click(sender As Object, e As EventArgs) Handles mnuSale.Click
        frmSellInventory.ShowDialog()
    End Sub
End Class
