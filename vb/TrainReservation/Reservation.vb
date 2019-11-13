Public Class Reservation
    Public Property TrainId As String
    Public Property BookingId As String
    Public Property Seats As List(Of Seat)

    Public Sub New(ByVal trainId As String, ByVal bookingId As String, ByVal seats As List(Of Seat))
        TrainId = trainId
        BookingId = bookingId
        Seats = seats
    End Sub
End Class

