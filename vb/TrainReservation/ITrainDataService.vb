Imports System.Collections.Generic

Public Interface ITrainDataService

    '{"seats": {	"1A": 	{"booking_reference": "",
    '        "seat_number": "1",
    '        "coach": "A"},
    '    "2A": 	{"booking_reference": "",
    '        "seat_number": "2",
    '        "coach": "A"}}}
    Function GetTrainInformation(ByVal trainId As String) As Object
End Interface
