Public Class frmBrowseInventory
    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSellInventory.ShowDialog()
    End Sub

    Private Sub frmBrowseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.MotorcycleShopDataSet.Inventory)

    End Sub
End Class