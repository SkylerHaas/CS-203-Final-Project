Public Class frmAddInventory
    Private year As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim year As Integer
        Dim make As String
        Dim model As String
        Dim milage As Integer
        Dim condition As String
        Dim bodyStyle As String
        Dim engineSize As Integer
        Dim engineCylinders As Integer

        If (Not Integer.TryParse(txtYear.Text, year)) Then

        End If

    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
    End Sub
End Class