Public Class Loans

    Private adapter As MotorcycleShopDataSetTableAdapters.LoansTableAdapter

    Public Function GetPaymentsDue() As DataTable
        Return adapter.GetPaymentsDue()
    End Function
End Class
