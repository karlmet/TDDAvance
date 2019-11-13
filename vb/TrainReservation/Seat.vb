Public Class Seat
    Public Property Coach As String
    Public Property SeatNumber As Integer

    Public Sub New(ByVal coach As String, ByVal seatNumber As Integer)
        Coach = coach
        SeatNumber = seatNumber
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim other As Seat = TryCast(obj, Seat)
        Return Coach = other.Coach AndAlso SeatNumber = other.SeatNumber
    End Function
End Class
