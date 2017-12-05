Public Class BeerData
    Public Property Beers As New List(Of BeerDay)
    Public Property DataTimestamp As Date
    Public Sub New()
        DataTimestamp = Date.Now()
    End Sub
End Class
