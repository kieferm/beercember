Public Class BeerData
    Public Property Beers As New List(Of BeerDay)
    Public Property DataTimestamp As String

    Public Sub New()
        DataTimestamp = Date.Now().AddHours(-5).ToString()
    End Sub

End Class
