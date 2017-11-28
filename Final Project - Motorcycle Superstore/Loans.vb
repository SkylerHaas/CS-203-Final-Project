Public Class Loans

    Private adapter As New MotorcycleShopDataSetTableAdapters.LoansTableAdapter

    Public Function Insert(ByVal custId As Integer, ByVal inventoryId As Integer, ByVal status As String, ByVal nextPaymentDueDate As Date, ByVal payment As Decimal, ByVal apr As Decimal, ByVal remainingLoanAmountDue As Decimal) As Boolean
        Try
            adapter.Insert(custId, inventoryId, status, nextPaymentDueDate, payment, apr, remainingLoanAmountDue)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function GetPaymentsDue() As DataTable
        Return adapter.GetPaymentsDue()
    End Function

End Class
