Public Class BeerDay
    Public ReadOnly Property CalendarDay As String
        Get
            Return CalendarDate.ToString("MMM d")
        End Get
    End Property

    Public Property CalendarDate As Date
    Public Property Brewery As String = ""
    Public Property Beer As String = ""
    Public Property Href As String = ""
    Public Property Alcohol As String = ""
    Public Property Ibu As String = ""

    Public Sub New(brewery As String, beer As String, abv As String, ibu As String, link As String)
        Me.Brewery = brewery
        Me.Beer = beer
        Me.Ibu = ibu
        Alcohol = abv
        Href = link
    End Sub

End Class
