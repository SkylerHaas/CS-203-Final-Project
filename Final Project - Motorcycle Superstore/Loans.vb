Public Class Loans

    Private adapter As MotorcycleShopDataSetTableAdapters.LoansTableAdapter = New MotorcycleShopDataSetTableAdapters.LoansTableAdapter

    Public Function Insert(ByVal custId As Integer, ByVal inventoryId As Integer, ByVal status As String, ByVal nextPaymentDueDate As Date, ByVal payment As Decimal, ByVal apr As Decimal, ByVal remainingLoanAmountDue As Decimal) As Boolean
        adapter.Insert(custId, inventoryId, status, nextPaymentDueDate, payment, apr, remainingLoanAmountDue)
        Return False
    End Function
    Public Function GetPaymentsDue() As DataTable
        Return adapter.GetPaymentsDue()
    End Function
End Class
