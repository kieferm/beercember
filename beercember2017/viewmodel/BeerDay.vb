﻿Public Class BeerDay
    Public ReadOnly Property CalendarDay As String
        Get
            Return CalendarDate.ToString("MMMM d")
        End Get
    End Property

    Public Property CalendarDate As Date
    Public Property Beer As String = ""
    Public Property Href As String = ""
    Public Property Alcohol As String = ""

    Public Sub New(day As Date, beer As String, abv As String, link As String)
        CalendarDate = day
        Me.Beer = beer
        Alcohol = abv
        Href = link
    End Sub

End Class