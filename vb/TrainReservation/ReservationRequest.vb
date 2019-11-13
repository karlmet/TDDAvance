Public Class ReservationRequest
    Public Property TrainId As String
    Public Property SeatCount As Integer

    Public Sub New(ByVal trainId As String, ByVal seatCount As Integer)
        TrainId = trainId
        SeatCount = seatCount
    End Sub
End Class