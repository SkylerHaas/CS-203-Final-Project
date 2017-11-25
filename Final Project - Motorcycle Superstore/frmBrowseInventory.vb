Public Class frmBrowseInventory

    Private inventory As Inventory = New Inventory

    Private Sub frmBrowseInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Manufacturers' table. You can move, or remove it, as needed.
        Me.ManufacturersTableAdapter.Fill(Me.MotorcycleShopDataSet.Manufacturers)
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.BodyStyles' table. You can move, or remove it, as needed.
        Me.BodyStylesTableAdapter.Fill(Me.MotorcycleShopDataSet.BodyStyles)
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Manufacturers' table. You can move, or remove it, as needed.
        dgvInventory.DataSource = inventory.GetCurrentInventory()
        cboMake.SelectedText = ""
        cboBodyStyle.SelectedText = ""
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        cboMake.SelectedIndex = -1
        cboBodyStyle.SelectedIndex = -1
        dgvInventory.DataSource = Nothing
        dgvInventory.DataSource = inventory.GetCurrentInventory()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSellInventory.ShowDialog()
    End Sub

    Private Sub cboBodyStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBodyStyle.SelectedIndexChanged
        If cboBodyStyle.SelectedIndex <> -1 Then
            If cboMake.SelectedIndex <> -1 Then
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyleAndMake(cboBodyStyle.SelectedValue.ToString, cboMake.SelectedValue.ToString)
            Else
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyle(cboBodyStyle.SelectedValue.ToString)
            End If
        End If
    End Sub

    Private Sub cboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMake.SelectedIndexChanged
        If cboMake.SelectedIndex <> -1 Then
            If cboBodyStyle.SelectedIndex <> -1 Then
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByBodyStyleAndMake(cboBodyStyle.SelectedValue.ToString, cboMake.SelectedValue.ToString)
            Else
                dgvInventory.DataSource = Nothing
                dgvInventory.DataSource = inventory.GetCurrentInventoryByMake(cboMake.SelectedValue.ToString)
            End If
        End If
    End Sub
End Class