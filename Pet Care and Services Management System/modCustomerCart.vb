Public Class CartItem
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Category As String
    Public Property UnitPrice As Decimal
    Public Property Quantity As Integer
    Public Property ProductImage As Image

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return UnitPrice * Quantity
        End Get
    End Property
End Class

Module modCustomerCart
    Public CustomerCart As New Dictionary(Of Integer, CartItem)
End Module