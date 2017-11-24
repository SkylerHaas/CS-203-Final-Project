Public Class frmBrowseInventory

    Private inventory As Inventory = New Inventory

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSellInventory.ShowDialog()
    End Sub

    Private Sub frmBrowseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Inventory' table. You can move, or remove it, as needed.
        dgvInventory.DataSource = inventory.GetCurrentInventory()
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        dgvInventory.DataSource = Nothing
        dgvInventory.DataSource = inventory.GetCurrentInventory()
    End Sub

    Private Sub cboBodyStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBodyStyle.SelectedIndexChanged
        If cboBodyStyle.SelectedIndex <> -1 Then
            If cboMake.SelectedIndex <> -1 Then
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyleAndMake(cboMake.SelectedText, cboBodyStyle.SelectedText)
            Else
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyle(cboBodyStyle.SelectedText)
            End If
        End If
    End Sub

    Private Sub cboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMake.SelectedIndexChanged
        If cboMake.SelectedIndex <> -1 Then
            If cboBodyStyle.SelectedIndex <> -1 Then
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyleAndMake(cboMake.SelectedText, cboBodyStyle.SelectedText)
            Else
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByMake(cboMake.SelectedText)
            End If
        End If
    End Sub
End Class