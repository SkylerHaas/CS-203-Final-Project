﻿Public Class Inventory

    Private adapter As New MotorcycleShopDataSetTableAdapters.InventoryTableAdapter
    Private Const DISCOUNT_NEW_PERIOD As Integer = 6    '6 months is the period of time a new bike can sit before getting discounted
    Private Const DISCOUNT_USED_PERIOD As Integer = 1   '1 month is the period of time a used bike can sit before getting discounted
    Private Const DISCOUNT_NEW_FACTOR As Decimal = 0.8D   'after 6 months of sitting, new inventory will be reduced by 20%
    Private Const DISCOUNT_USED_FACTOR As Decimal = 0.9D  'after 1 months of sitting, used inventory will be reduced by 10%

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

    Public Function Insert(ByVal mc As Motorcycle) As Boolean
        Try
            adapter.Insert(mc.Year, mc.Make, mc.Model, mc.BodyStyle, mc.Milage, mc.Condition, mc.EngineSize, mc.EngineCylinders, mc.Price, Today, Today)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function UpdatePrices() As Boolean
        Dim answer As Boolean = False
        Dim rows As Integer = 0
        rows = adapter.UpdatePrices(DISCOUNT_NEW_FACTOR, "New", DISCOUNT_NEW_PERIOD) + adapter.UpdatePrices(DISCOUNT_USED_FACTOR, "Used", DISCOUNT_USED_PERIOD)
        If (rows > 0) Then
            answer = True
        End If
        Return answer
    End Function

    Public Function GetCurrentInventory() As DataTable
        Return adapter.GetCurrentInventory()
    End Function

    Public Function GetCurrentInventoryByMake(ByVal make As String) As DataTable
        Return adapter.GetCurrentInventoryByMake(make)
    End Function

    Public Function GetCurrentInventoryByBodyStyle(ByVal bodyStyle As String) As DataTable
        Return adapter.GetCurrentInventoryByBodyStyle(bodyStyle)
    End Function

    Public Function GetCurrentInventoryByBodyStyleAndMake(ByVal bodyStyle As String, ByVal make As String) As DataTable
        Return adapter.GetCurrentInventoryByBodyStyleAndMake(bodyStyle, make)
    End Function

End Class
