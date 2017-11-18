Public Class Inventory

    Private adapter As New MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

    Public Function Insert(ByVal mc As Motorcycle) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(mc.Year, mc.Make, mc.Model, mc.BodyStyle, mc.Milage, mc.Condition, mc.EngineSize, mc.EngineCylinders, mc.Price, CType(Today, String), CType(Today, String))
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

End Class
