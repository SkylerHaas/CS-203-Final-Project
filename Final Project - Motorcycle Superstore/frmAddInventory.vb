Public Class frmAddInventory
    Private inventory As Inventory
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim year As Integer
        Dim make As String
        Dim model As String
        Dim milage As Integer
        Dim condition As String
        Dim bodyStyle As String
        Dim engineSize As Integer
        Dim engineCylinders As Integer
        Dim price As Decimal
        Dim mc As Motorcycle

        'Check inputs and store them in variables
        If (Not Integer.TryParse(txtYear.Text, year) Or year < 0) Then
            errorProvider.SetError(txtYear, "Year must be an integer greater than 0")
            Return
        End If
        If (cboMake.SelectedIndex = -1) Then
            errorProvider.SetError(cboMake, "Must select a Make")
            Return
        End If
        make = cboMake.SelectedText
        If (txtModel.Text = "") Then
            errorProvider.SetError(txtModel, "Must enter a Model")
            Return
        End If
        model = txtModel.Text
        If (Not Integer.TryParse(txtMilage.Text, milage) Or milage < 0) Then
            errorProvider.SetError(txtMilage, "Milage must be an integer greater than 0")
            Return
        End If
        If (cboCondition.SelectedIndex = -1) Then
            errorProvider.SetError(cboCondition, "Must select a Condition")
            Return
        End If
        condition = cboCondition.SelectedText
        If (cboBodyStyle.SelectedIndex = -1) Then
            errorProvider.SetError(cboBodyStyle, "Must select a Body Style")
            Return
        End If
        bodyStyle = cboBodyStyle.SelectedText
        If (Not Integer.TryParse(txtEngineSize.Text, engineSize) Or engineSize < 0) Then
            errorProvider.SetError(txtEngineSize, "Engine Size must be an integer greater than 0")
            Return
        End If
        If (cboEngineCylinders.SelectedIndex = -1) Then
            errorProvider.SetError(cboEngineCylinders, "Must select a Cylinder count")
            Return
        End If
        engineCylinders = Integer.Parse(cboEngineCylinders.SelectedText)
        If (Not Decimal.TryParse(txtPrice.Text, price) Or price < 0) Then
            errorProvider.SetError(txtMilage, "Price must be a decimal greater than 0")
            Return
        End If
        'create new motocycle using variables
        mc = New Motorcycle(year, make, model, bodyStyle, milage, condition, engineSize, engineCylinders, price)

        inventory.Insert(mc)
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
    End Sub
End Class