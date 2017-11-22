Public Class frmBrowseInventory

    Private inventory As Inventory = New Inventory

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSellInventory.ShowDialog()
    End Sub

    Private Sub frmBrowseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Inventory' table. You can move, or remove it, as needed.
        dgvInventory.DataSource = inventory.GetCurrentInventory()
    End Sub
End Class