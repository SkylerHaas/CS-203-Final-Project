Public Class frmViewLoans

    Private loans As Loans = New Loans

    Private Sub btnEnterPayment_Click(sender As Object, e As EventArgs) Handles btnEnterPayment.Click
        frmLoanPayment.ShowDialog()
    End Sub

    Private Sub frmViewLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorcycleShopDataSet.Loans' table. You can move, or remove it, as needed.
        Me.LoansTableAdapter.Fill(Me.MotorcycleShopDataSet.Loans)
        If frmOpeningScreen.firstLoad Then
            dgvLoans.DataSource = Nothing
            dgvLoans.DataSource = loans.GetPaymentsDue
        End If
    End Sub
End Class