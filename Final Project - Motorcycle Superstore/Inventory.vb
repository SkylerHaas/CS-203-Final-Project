Public Class Inventory

    Private adapter As New MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Private Const DISCOUNT_NEW_PERIOD As Integer = 6    '6 months is the period of time a new bike can sit before getting discounted
    Private Const DISCOUNT_USED_PERIOD As Integer = 1   '1 month is the period of time a used bike can sit before getting discounted
    Private Const DISCOUNT_NEW_FACTOR As Decimal = 0.8D   'after 6 months of sitting, new inventory will be reduced by 20%
    Private Const DISCOUNT_USED_FACTOR As Decimal = 0.9D  'after 1 months of sitting, used inventory will be reduced by 10%
    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

    Public Function Insert(ByVal mc As Motorcycle) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(mc.Year, mc.Make, mc.Model, mc.BodyStyle, mc.Milage, mc.Condition, mc.EngineSize, mc.EngineCylinders, mc.Price, Today, Today)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function UpdatePrices() As Boolean
        Dim answer As Boolean = False
        Dim rows As Integer = 0
        rows = rows + adapter.UpdatePrices(DISCOUNT_NEW_FACTOR, "New", DISCOUNT_NEW_PERIOD) + adapter.UpdatePrices(DISCOUNT_USED_FACTOR, "Used", DISCOUNT_USED_PERIOD)
        If (rows > 0) Then
            answer = True
        End If
        Return answer
    End Function

End Class
